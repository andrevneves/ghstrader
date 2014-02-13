using System;
using System.Collections.Generic;
using System.Text;
namespace Model
{
    public class OrderModel
    {
        public string timestamp
        {
            get;
            set;
        }

        public List<List<decimal>> bids
        {
            get;
            set;
        }

        public List<List<decimal>> asks
        {
            get;
            set;
        }
    }
}
