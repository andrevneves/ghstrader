using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Model;
using System.Web.Script.Serialization;
using System.Security.Cryptography;

namespace API
{
    public class GHS
    {
        public static string secret = string.Empty;
        public static string api_key = string.Empty;
        public static string name = string.Empty;
        public static long nonce = 0;

        static CookieContainer cookie = new CookieContainer();

        public static bool GetSignature(ref string argSignature, ref string argNonce)
        {
            if (string.IsNullOrEmpty(secret)
                     || string.IsNullOrEmpty(api_key)
                     || string.IsNullOrEmpty(name))
                throw new Exception("请先设置账号信息");

            if (nonce == 0)
                nonce = DateTime.Now.Ticks;
            else
                nonce++;

            argNonce = nonce.ToString();

            HMACSHA256 hmac = new HMACSHA256(Encoding.Default.GetBytes(secret));
            hmac.ComputeHash(Encoding.Default.GetBytes(argNonce + name + api_key));
            byte[] key = hmac.Hash;
            StringBuilder sb = new StringBuilder(key.Length * 2);
            foreach (byte b in key)
            {
                sb.AppendFormat("{0:X2}", b);
            }

            argSignature = sb.ToString().ToUpper();

            return true;
        }

        public static bool CancelOrder(string argId)
        {
            HttpHelper httpHelper = new HttpHelper();

            string signature = string.Empty;

            string nonce = string.Empty;

            if (!GetSignature(ref signature, ref nonce))
                return false;

            string str = httpHelper.doPost(@"https://cex.io/api/cancel_order/", "key=" + api_key + "&signature=" + signature + "&nonce=" + nonce + "&id=" + argId, ref cookie);

            if (string.IsNullOrEmpty(str))
                throw new Exception("访问超时");

            if (str.ToUpper().IndexOf("ERROR") > -1)
                return false;

            bool isBool = false;

            if (bool.TryParse(str, out isBool))
                return true;
            else
                return false;
        }

        public static List<Dictionary<string, string>> OpenOrder()
        {
            HttpHelper httpHelper = new HttpHelper();

            string signature = string.Empty;

            string nonce = string.Empty;

            if (!GetSignature(ref signature, ref nonce))
                return null;

            string str = httpHelper.doPost(@"https://cex.io/api/open_orders/GHS/BTC", "key=" + api_key + "&signature=" + signature + "&nonce=" + nonce, ref cookie);

            if (string.IsNullOrEmpty(str))
                throw new Exception("访问超时");

            if (str.ToUpper().IndexOf("ERROR") > -1)
                return null;

            JavaScriptSerializer jscvt = new JavaScriptSerializer();
            return jscvt.Deserialize<List<Dictionary<string, string>>>(str);
        }

        public static BalanceModel GetBalance()
        {
            HttpHelper httpHelper = new HttpHelper();

            string signature = string.Empty;
            string nonce = string.Empty;

            if (!GetSignature(ref signature, ref nonce))
                return null;

            string str = httpHelper.doPost(@"https://cex.io/api/balance/", "key=" + api_key + "&signature=" + signature + "&nonce=" + nonce, ref cookie);

            if (string.IsNullOrEmpty(str))
                throw new Exception("访问超时");

            if (str.ToUpper().IndexOf("ERROR") > -1)
                return null;

            JavaScriptSerializer jscvt = new JavaScriptSerializer();
            return jscvt.Deserialize<BalanceModel>(str);
        }

        public static bool BuyOrSellBTC(string argType, decimal argAmount, decimal argPrice)
        {
            HttpHelper httpHelper = new HttpHelper();

            string signature = string.Empty;

            string nonce = string.Empty;

            if (!GetSignature(ref signature, ref nonce))
                return false;

            string str = httpHelper.doPost(@"https://cex.io/api/place_order/GHS/BTC", "key=" + api_key + "&signature=" + signature + "&nonce=" + nonce + "&type=" + argType + "&amount=" + argAmount.ToString("f8") + "&price=" + argPrice.ToString("f8"), ref cookie);

            if (string.IsNullOrEmpty(str))
                throw new Exception("访问超时");

            if (str.ToUpper().IndexOf("ERROR") > -1)
                return false;

            if (str.ToUpper().IndexOf("ID") > -1)
                return true;
            else
                return false;
        }

        public static OrderModel GetOrder()
        {
            HttpHelper httpHelper = new HttpHelper();
            string str = httpHelper.doGet(@"https://cex.io/api/order_book/GHS/BTC", ref cookie);

            if (string.IsNullOrEmpty(str))
                throw new Exception("访问超时");

            if (str.ToUpper().IndexOf("ERROR") > -1)
                return null;

            JavaScriptSerializer jscvt = new JavaScriptSerializer();
            OrderModel order = jscvt.Deserialize<OrderModel>(str);

            return order;
        }

        public static BTCModel GetBTC()
        {
            HttpHelper httpHelper = new HttpHelper();
            string str = httpHelper.doGet(@"https://cex.io/api/ticker/GHS/BTC", ref cookie);

            if (string.IsNullOrEmpty(str))
                throw new Exception("访问超时");

            if (str.ToUpper().IndexOf("ERROR") > -1)
                return null;

            JavaScriptSerializer jscvt = new JavaScriptSerializer();
            return jscvt.Deserialize<BTCModel>(str);
        }
    }
}
