using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPattern23Example.Pattern.Creational.Singleton.Impletment
{
    /// <summary>
    /// 建立一個類別 - 前臺負載平衡的伺服器
    /// ※Volitile 是核心，設為靜態
    ///   方法 的Static LoadBalanceServer() 是端口，是用來作為Load Balance Server內外存取的唯一管道 (單例)
    /// </summary>
    public class LoadBalanceServer
    {
        #region 欄位Field

        /// <summary>
        /// 最大Server 數量為3
        /// </summary>
        private const int Server_Count = 3;

        /// <summary>
        /// 當前Server 清單
        /// </summary>
        private List<LobbyServer> serverList = new List<LobbyServer>();

        /// <summary>
        /// volatile:不進行最佳化編譯 ※用於多執行緒進行存取時使用，且不需要特定宣告Lock
        /// </summary>
        private static volatile LoadBalanceServer lbs;

        /// <summary>
        /// Lock物件
        /// </summary>
        private static object syncLock = new object();


        #endregion

        #region 方法 Method

        /// <summary>
        /// 提供給外部呼叫時，將內的LoadBalanceServer 提供給外部檢視
        /// </summary>
        private LoadBalanceServer()
        {
            for (int i = 0; i < Server_Count; i++)
            {
                serverList.Add(new LobbyServer("LobbyServer" + i));
            }
        }

        /// <summary>
        /// 外部呼叫-取得負載平衡Server主機-初始化該機器
        /// </summary>
        /// <returns></returns>
        public static LoadBalanceServer GetLoadBalanceServer()
        {
            if (lbs == null)
            {
                lock (syncLock)
                {
                    if (lbs == null)
                    {
                        Thread.Sleep(100);
                        lbs = new LoadBalanceServer();
                    }
                }
            }
            return lbs;
        }

        /// <summary>
        /// 取得負載平衡主機底下的子伺服器資料
        /// </summary>
        /// <returns></returns>
        public LobbyServer GetLobbyServer()
        {
            LobbyServer ls = serverList[0];

            //平衡塞入-列舉所有Server 找出
            for (int i = 0; i < Server_Count; i++)
            {
                //有第0台Server開始，如果1、2 Server小於前一台的總數，就設為優先將資料存入的主機
                if (serverList[i].PlayerList.Count < ls.PlayerList.Count)
                {
                    ls = serverList[i];
                }
            }
            return ls;
        }

        /// <summary>
        /// 顯示資料狀態 - 所有Server + Server底下的連線玩家
        /// </summary>
        public void ShowServerInfo()
        {
            foreach (LobbyServer ls in serverList)
            {
                Console.WriteLine("===============" + ls.ServerName + "===================");
                foreach (string player in ls.PlayerList)
                {
                    Console.WriteLine(player);
                }
            }
        }



        #endregion

    }
}
