using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data.Common;
using System.Security;
using System.Security.Permissions;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.Sql;

namespace DesignPattern23Example.Pattern.Creational.AbstractFactory.Inpletment.DBConnection
{
    public class AbstractFactoryExample
    {
      

    }

    /// <summary>
    /// 建立DB連線的抽象工廠
    /// </summary>
    public abstract class DbProviderFactory
    {
        protected DbProviderFactory()
        {

        }
        public virtual DbCommand CreateCommand()
        {
            return null;
        }
        public virtual DbCommandBuilder CreateCommandBuilder()
        {
            return null;
        }
        public virtual DbConnection CreateConnection()
        {
            return null;
        }
        public virtual DbConnectionStringBuilder CreateConnectionStringBuilder()
        {
            return null;
        }
        public virtual DbDataAdapter CreateDataAdapter()
        {
            return null;
        }
        public virtual DbDataSourceEnumerator CreateDataSourceEnumerator()
        {
            return null;
        }
        public virtual DbParameter CreateParameter()
        {
            return null;
        }
        public virtual CodeAccessPermission CreatePermission(PermissionState state)
        {
            return null;
        }

        #region Properties

        /// <summary>
        /// 取得當前Db 連線狀態
        /// </summary>
        public virtual bool CanCreateDataSourceEnumerator
        {
            get
            {
                return false;
            }
        }

        #endregion

    }

    public sealed class OleDbFactory : DbProviderFactory
    {
        #region Field (私有的、不讓外界輕易使用)
        public static readonly OleDbFactory Instance = new OleDbFactory();

        #endregion


        #region Method

        private OleDbFactory()
        {
        }

        public override DbCommand CreateCommand()
        {
            return new OleDbCommand();//執行Inline SQL (Sp or SQL 陳述句)
        }

        public override DbCommandBuilder CreateCommandBuilder()
        {
            return new OleDbCommandBuilder();
        }


        public override DbConnection CreateConnection()
        {
            return new OleDbConnection();
        }

        public override DbConnectionStringBuilder CreateConnectionStringBuilder()
        {
            return null;
        }

        public override DbDataAdapter CreateDataAdapter()
        {
            return new OleDbDataAdapter();
        }

        public override DbParameter CreateParameter()
        {
            return new OleDbParameter();
        }

        public override CodeAccessPermission CreatePermission(PermissionState state)
        {
            return new OleDbPermission(state);
        }
        #endregion
    }

    public sealed class SqlClientFactory : DbProviderFactory, IServiceProvider
    {
        #region Field

        // Fields
        public static readonly SqlClientFactory Instance = new SqlClientFactory();

        #endregion

        #region Method

        /// <summary>
        /// 建構式
        /// </summary>
        private SqlClientFactory()
        {
        }

        public override DbCommand CreateCommand()
        {
            return new SqlCommand();
        }

        public override DbCommandBuilder CreateCommandBuilder()
        {
            return new SqlCommandBuilder();
        }

        public override DbConnection CreateConnection()
        {
            return new SqlConnection();
        }

        public override DbConnectionStringBuilder CreateConnectionStringBuilder()
        {
            return new SqlConnectionStringBuilder();
        }

        public override DbDataAdapter CreateDataAdapter()
        {
            return new SqlDataAdapter();
        }

        public override DbDataSourceEnumerator CreateDataSourceEnumerator()
        {
            return SqlDataSourceEnumerator.Instance;
        }

        public override DbParameter CreateParameter()
        {
            return new SqlParameter();
        }

        public override CodeAccessPermission CreatePermission(PermissionState state)
        {
            return new SqlClientPermission(state);
        }

        object IServiceProvider.GetService(Type serviceType)
        {
            object obj2 = null;
            //if (serviceType == GreenMethods.SystemDataCommonDbProviderServices_Type)
            //{
            //    obj2 = GreenMethods.SystemDataSqlClientSqlProviderServices_Instance();
            //}
            return obj2;
        }

        #endregion

        public override bool CanCreateDataSourceEnumerator
        {
            get
            {
                return true;
            }
        }
    }
}
