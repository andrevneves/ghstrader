using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;


public class HttpHelper
{
    public Stream GetStream(string url, ref CookieContainer cookies)
    {
        Stream strm = null;
        try
        {
            WebRequest req = WebRequest.Create(url);
            req.Timeout = 10000;
            HttpWebRequest httpreg = (HttpWebRequest)req;
            httpreg.CookieContainer = cookies;
            httpreg.Method = "GET";
            httpreg.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; .NET CLR 2.0.50727; CIBA)";
            WebResponse resp = httpreg.GetResponse();
            strm = resp.GetResponseStream();
        }
        catch (Exception ex)
        {
            return null;
        }
        return strm;
    }

    public string doGet(string url, ref CookieContainer cookies)
    {
        string result = null;
        try
        {
            WebRequest req = WebRequest.Create(url);
            req.Timeout = 10000;
            HttpWebRequest httpreg = (HttpWebRequest)req;
            httpreg.CookieContainer = cookies;
            httpreg.Method = "GET";
            httpreg.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; .NET CLR 2.0.50727; CIBA)";
            WebResponse resp = httpreg.GetResponse();
            StreamReader reader = new StreamReader(resp.GetResponseStream(), Encoding.GetEncoding(936));
            result = reader.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
        return result;
    }


    public Stream PostStream(string action, string data, ref CookieContainer cookies)
    {
        Stream strm = null;
        try
        {
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            WebRequest req = WebRequest.Create(action);
            req.Timeout = 10000;
            HttpWebRequest httpreq = (HttpWebRequest)req;
            httpreq.Method = "POST";
            httpreq.ContentType = "application/x-www-form-urlencoded";
            httpreq.Accept = "application/x-shockwave-flash, image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/vnd.ms-excel, application/vnd.ms-powerpoint, application/msword, application/x-silverlight, */*";
            httpreq.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; .NET CLR 2.0.50727; CIBA)";
            httpreq.ContentLength = bytes.Length;
            httpreq.CookieContainer = cookies;
            strm = httpreq.GetRequestStream();
        }
        catch (Exception ex)
        {
            return null;
        }
        return strm;
    }


    public string doPost(string action, string data, ref CookieContainer cookies)
    {
        string result = null;
        try
        {
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            WebRequest req = WebRequest.Create(action);
            req.Timeout = 10000;
            HttpWebRequest httpreq = (HttpWebRequest)req;
            httpreq.Method = "POST";
            httpreq.ContentType = "application/x-www-form-urlencoded";
            httpreq.Accept = "application/x-shockwave-flash, image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/vnd.ms-excel, application/vnd.ms-powerpoint, application/msword, application/x-silverlight, */*";
            httpreq.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; .NET CLR 2.0.50727; CIBA)";
            httpreq.ContentLength = bytes.Length;
            httpreq.CookieContainer = cookies;
            Stream strm = httpreq.GetRequestStream();
            strm.Write(bytes, 0, bytes.Length);
            strm.Close();
            WebResponse resq = httpreq.GetResponse();
            StreamReader reader = new StreamReader(resq.GetResponseStream(), Encoding.GetEncoding(936));
            result = reader.ReadToEnd();

        }
        catch (Exception ex)
        {
            return "";
        }
        return result;
    }
}