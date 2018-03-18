using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data.Common;
using System.Security;
using System.Security.Permissions;

namespace DesignPattern23Example.Pattern.Creational.AbstractFactory.Inpletment.DBConnection
{
    public class AbstractFactoryExample
    {


    }

    public abstract class DbProviderFactory
    {
        protected DbProviderFactory()
        {

        }

        public virtual DbCommand CreateCommand()
        {
            return null;
        }

        public virtual DbCommandBuilder CreaterCommandBuilder()
        {
            return null;
        }
        public virtual DbConnectionStringBuilder CreateConnectionStringBuilder()
        {
            return null;
        }

        public virtual DbDatDbDataAdapter CreateDataAdapter()
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
        
        /// <summary>
        /// Properties
        /// </summary>
        public virtual bool CanCreateDatCanCreateDataSourceEnumerator
        {
            get
            {
                return false;
            }
        }
    }

    public sealed class OleDbFactory : DbProviderFactory
    {

    }

}
