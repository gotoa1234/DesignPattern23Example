using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23Example.Pattern.Creational.Singleton.Impletment
{
    /// <summary>
    /// 後臺子伺服器
    /// </summary>
    public class LobbyServer
    {

        #region 欄位 Field
        /// <summary>
        /// 紀錄玩家資料
        /// </summary>
        private List<string> playerList = new List<string>();

        /// <summary>
        /// ServerName
        /// </summary>
        private string serverName;
        #endregion

        #region 屬性 Property

        /// <summary>
        /// 回傳本Server底下的玩家個人資料 
        /// </summary>
        public List<string> PlayerList
        {
            get { return playerList; }
        }

        /// <summary>
        /// 取得實體Server Name
        /// </summary>
        public string ServerName
        {
            get { return serverName; }
        }

        #endregion

        #region 方法 Method

        #region 建構式 Construct

        /// <summary>
        /// 建構式
        /// </summary>
        /// <param name="serverName"></param>
        public LobbyServer(string serverName)
        {
            this.serverName = serverName;
        }
        #endregion

        /// <summary>
        /// 輸入玩家(登入)
        /// </summary>
        /// <param name="playerName"></param>
        public void EnterPlayer(string playerName)
        {
            this.playerList.Add(playerName);
        }

        #endregion




    }
}
