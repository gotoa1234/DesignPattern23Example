using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace DesignPattern23Example.Pattern.Creational.Singleton.Impletment
{
    /// <summary>
    /// 單例模式 - 範例
    /// 原理：任何呼叫者都只會指向同一筆Single Thread 
    /// </summary>
    public class SingletonExample
    {
        public SingletonExample()
        {
            //建立Server
            LoadBalanceServer lbs = LoadBalanceServer.GetLoadBalanceServer();

            //參數傳遞的委派
            ParameterizedThreadStart ts = new ParameterizedThreadStart(EnterPlayer);

            //建立20個Thread 模擬20個不同來源，並且加入20個遊戲玩家
            for (int i = 0; i < 20; i++)
            {
                Thread t = new Thread(ts);
                t.Start("player " + i);

            }
            ///印出當前3台Server的狀況
            LoadBalanceServer.GetLoadBalanceServer().ShowServerInfo();
        }

        /// <summary>
        /// 增加玩家進入Server
        /// </summary>
        /// <param name="playerName"></param>
        static void EnterPlayer(object playerName)
        {
            //載入Server
            LoadBalanceServer lbs = LoadBalanceServer.GetLoadBalanceServer();
            lbs.GetLobbyServer().EnterPlayer(playerName.ToString());


        }
    }



   
}
