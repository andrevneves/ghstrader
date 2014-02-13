using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class BalanceModel
    {
        public string timestamp
        {
            get;
            set;
        }

        public Dictionary<string, string> BTC
        {
            get;
            set;
        }

        public Dictionary<string, string> GHS
        {
            get;
            set;
        }

        public Dictionary<string, string> NMC
        {
            get;
            set;
        }

        public Dictionary<string, string> IXC
        {
            get;
            set;
        }

        public Dictionary<string, string> DVC
        {
            get;
            set;
        }
    }
}