using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using yiwoSDK;
using System.Threading;
using System.Net;
using System.Linq;
using System.Web.Script.Serialization;
using Model;
using System.IO;
using API;

namespace QQRobot
{
    public partial class Main : Form
    {
        CookieContainer cookie = new CookieContainer();
        BTCModel btc = new BTCModel();
        OrderModel order = new OrderModel();

        string openQQ = null;

        public Main()
        {
            InitializeComponent();
        }

        //跨线程访问
        void GetMessage(string argQQ, int argRetCode, List<string> argPoll_List, List<object> argMsg_List, string argMsgString)
        {
            try
            {
                Invoke(new CWebQQ.DMsg(ReceiveMessage), new object[] { argQQ, argRetCode, argPoll_List, argMsg_List, argMsgString });
            }
            catch
            {
            }
        }

        private void ReceiveMessage(string argQQ, int argRetCode, List<string> argPoll_List, List<object> argMsg_List, string argMsgString)
        {
            if (argPoll_List[0] == "kick_message")
            {
                MessageBox.Show("您的账号在另一地点登录，您已被迫下线。");
                QQAPI.cWebQQ.Quit();
                return;
            }

            if (argRetCode == 102
                || argRetCode == 116)
                return;
            else if (argRetCode != 0)
            {
                MessageBox.Show("您的账号已经掉线，错误代码（" + argRetCode + ")");
                QQAPI.cWebQQ.Quit();
                return;
            }

            if (argPoll_List[0] == "group_message")//如果是群消息
            {
                GroupMsgData msgObject = (GroupMsgData)argMsg_List[0];

                if (msgObject.OnlyText.ToUpper().StartsWith("@G"))
                {
                    QQAPI.cWebQQ.SendMsgToGroup(msgObject.from_uin, msgObject.group_code, GetMessage(msgObject.OnlyText.ToUpper().Split(' ')[1].Replace("_", " ")));
                }
                else if (msgObject.OnlyText.ToUpper().StartsWith("@O"))
                {
                    QQAPI.cWebQQ.SendMsgToGroup(msgObject.from_uin, msgObject.group_code, GetOrderMessage(msgObject.OnlyText.ToUpper().Split(' ')[1]));
                }
                else if (msgObject.OnlyText.ToUpper().StartsWith("@C"))
                {
                    QQAPI.cWebQQ.SendMsgToGroup(msgObject.from_uin, msgObject.group_code, GetHelperMessage());
                }
                else if (msgObject.OnlyText.ToUpper().StartsWith("@T"))
                {
                    QQAPI.cWebQQ.SendMsgToGroup(msgObject.from_uin, msgObject.group_code, new Random().Next(100000, 10000000).ToString());
                }
            }
            else if (argPoll_List[0] == "message")
            {
                FriendMsgData msgObject = (FriendMsgData)argMsg_List[0];
            }
        }

        private void GetBTC()
        {
            while (true)
            {
                try
                {
                    btc = GHS.GetBTC();
                    Thread.CurrentThread.Join(1500);
                }
                catch
                {

                }
            }
        }

        private void CheckState()
        {
            while (true)
            {
                try
                {
                    if (QQAPI.cWebQQ.GetOnlineStatus() == "离线")
                        QQAPI.cWebQQ.SetNewStatus("Q我吧");
                }
                catch
                {

                }
            }
        }

        private void GetOrder()
        {
            while (true)
            {
                try
                {
                    order = GHS.GetOrder();

                    Thread.CurrentThread.Join(1500);
                }
                catch
                {

                }
            }
        }

        private string GetHelperMessage()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(@"可用命令有:\\n@G       获取最近的交易信息\\n@O       获取GHS订单信息\\n@O 20  获取大于数字的GHS订单信息");
            return sb.ToString();
        }

        private string GetOrderMessage(string argStr)
        {
            int number = 0;
            int.TryParse(argStr, out number);

            if (number < 0)
                number = 0;

            if (order.asks == null || order.bids == null)
                return "暂无数据";

            List<Dictionary<string, decimal>> sellOrder = new List<Dictionary<string, decimal>>();

            decimal totalAmount = 0m;

            foreach (List<decimal> decList in order.asks)
            {
                totalAmount += decList[1];

                if (decList[1] > number)
                {
                    Dictionary<string, decimal> dic = new Dictionary<string, decimal>();
                    dic.Add("Price", decList[0]);
                    dic.Add("Amount", decList[1]);
                    dic.Add("TotalAmount", totalAmount);

                    sellOrder.Add(dic);
                }
            }

            totalAmount = 0m;

            List<Dictionary<string, decimal>> buyOrder = new List<Dictionary<string, decimal>>();

            foreach (List<decimal> decList in order.bids)
            {
                totalAmount += decList[1];

                if (decList[1] > number)
                {
                    Dictionary<string, decimal> dic = new Dictionary<string, decimal>();
                    dic.Add("Price", decList[0]);
                    dic.Add("Amount", decList[1]);
                    dic.Add("TotalAmount", totalAmount);

                    buyOrder.Add(dic);
                }
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(@"卖出订单:\\n{0}\\n{1}\\n{2}\\n{3}\\n{4}\\n买入订单:\\n{5}\\n{6}\\n{7}\\n{8}\\n{9}",
                (sellOrder.Count() > 0 ? sellOrder[0]["Price"].ToString("f8") + "-" + sellOrder[0]["Amount"].ToString("f8") + "-" + sellOrder[0]["TotalAmount"].ToString("f8") : "0 - 0 - 0"),
                (sellOrder.Count() > 1 ? sellOrder[1]["Price"].ToString("f8") + "-" + sellOrder[1]["Amount"].ToString("f8") + "-" + sellOrder[1]["TotalAmount"].ToString("f8") : "0 - 0 - 0"),
                (sellOrder.Count() > 2 ? sellOrder[2]["Price"].ToString("f8") + "-" + sellOrder[2]["Amount"].ToString("f8") + "-" + sellOrder[2]["TotalAmount"].ToString("f8") : "0 - 0 - 0"),
                (sellOrder.Count() > 3 ? sellOrder[3]["Price"].ToString("f8") + "-" + sellOrder[3]["Amount"].ToString("f8") + "-" + sellOrder[3]["TotalAmount"].ToString("f8") : "0 - 0 - 0"),
                (sellOrder.Count() > 4 ? sellOrder[4]["Price"].ToString("f8") + "-" + sellOrder[4]["Amount"].ToString("f8") + "-" + sellOrder[4]["TotalAmount"].ToString("f8") : "0 - 0 - 0"),
                (buyOrder.Count() > 0 ? buyOrder[0]["Price"].ToString("f8") + "-" + buyOrder[0]["Amount"].ToString("f8") + "-" + buyOrder[0]["TotalAmount"].ToString("f8") : "0 - 0 - 0"),
                (buyOrder.Count() > 1 ? buyOrder[1]["Price"].ToString("f8") + "-" + buyOrder[1]["Amount"].ToString("f8") + "-" + buyOrder[1]["TotalAmount"].ToString("f8") : "0 - 0 - 0"),
                (buyOrder.Count() > 2 ? buyOrder[2]["Price"].ToString("f8") + "-" + buyOrder[2]["Amount"].ToString("f8") + "-" + buyOrder[2]["TotalAmount"].ToString("f8") : "0 - 0 - 0"),
                (buyOrder.Count() > 3 ? buyOrder[3]["Price"].ToString("f8") + "-" + buyOrder[3]["Amount"].ToString("f8") + "-" + buyOrder[3]["TotalAmount"].ToString("f8") : "0 - 0 - 0"),
                (buyOrder.Count() > 4 ? buyOrder[4]["Price"].ToString("f8") + "-" + buyOrder[4]["Amount"].ToString("f8") + "-" + buyOrder[4]["TotalAmount"].ToString("f8") : "0 - 0 - 0"));

            return sb.ToString();
        }

        private string GetMessage(string argStr)
        {
            return string.Format(@"交易价格 - {0}\\n最低价格 - {3}\\n最高价格 - {4}\\n卖总GHS - {1}\\n买总BTC - {2}",
                btc.Last.ToString("f8"),
                order.asks != null ? order.asks.Sum(p => p[1]).ToString("f8") : "0",
                order.bids != null ? order.bids.Sum(p => (p[1] * p[0])).ToString("f8") : "0",
                btc.Low.ToString("f8"),
                btc.High.ToString("f8")
                );
        }

        Thread BTCThread;
        Thread OrderThread;
        Thread StateThread;

        private void Main_Load(object sender, EventArgs e)
        {
            this.Hide();

            BTCThread = new Thread(new ThreadStart(GetBTC));
            BTCThread.Start();

            OrderThread = new Thread(new ThreadStart(GetOrder));
            OrderThread.Start();

            StateThread = new Thread(new ThreadStart(CheckState));
            StateThread.Start();

            QQAPI.cWebQQ.RevMsg += new CWebQQ.DMsg(GetMessage);
        }

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BTCThread != null)
                BTCThread.Abort();
            BTCThread = null;


            if (OrderThread != null)
                OrderThread.Abort();
            OrderThread = null;

            if (StateThread != null)
                StateThread.Abort();
            StateThread = null;

            QQAPI.cWebQQ.Quit();

            notifyIcon1.Dispose();
            this.Close();
            this.Dispose();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (BTCThread != null)
                BTCThread.Abort();
            BTCThread = null;


            if (OrderThread != null)
                OrderThread.Abort();
            OrderThread = null;

            QQAPI.cWebQQ.Quit();
        }
    }
}