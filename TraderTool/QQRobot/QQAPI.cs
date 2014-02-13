using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Security.Cryptography;
using System.Web.Script.Serialization;
using yiwoSDK;

namespace QQRobot
{
    public static class QQAPI
    {
        public static string MD5(string argPassword, int md5Len = 32)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5CryptoServiceProvider.Create();
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(argPassword);
            bytes = md5.ComputeHash(bytes);

            System.Text.StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in bytes)
            {
                stringBuilder.Append(item.ToString("x").PadLeft(2, '0'));
            }

            string strMd5 = "";

            if (md5Len == 32)
                strMd5 = stringBuilder.ToString().ToUpper();
            else
                strMd5 = stringBuilder.ToString().ToUpper().Substring(8, md5Len);

            return strMd5;
        }

        public static CHttpWeb cHttpWeb = new CHttpWeb();//网络类
        public static CWebQQ cWebQQ = new CWebQQ();//webqq类
        public static CEncode cEncode = new CEncode();//编码类
    }
}
