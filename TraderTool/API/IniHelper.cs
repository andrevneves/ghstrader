using System;
using System.Collections.Generic;
using System.Text;

namespace API
{
    public class IniHelper
    {
        // 声明INI文件的写操作函数 WritePrivateProfileString()
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        // 声明INI文件的读操作函数 GetPrivateProfileString()
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, System.Text.StringBuilder retVal, int size, string filePath);


        private string sPath = null;
        public IniHelper(string path)
        {
            this.sPath = path;
        }

        public void WriteValue(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, sPath);
        }

        public string ReadValue(string section, string key)
        {
            System.Text.StringBuilder temp = new System.Text.StringBuilder(512);

            GetPrivateProfileString(section, key, "", temp, 512, sPath);

            return temp.ToString();
        }
    }
}