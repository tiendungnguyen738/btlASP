using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shopASP
{
    public class product
    {
        public int product_id { get; set; }
        public int category_id { get; set; }
        public string product_name { get; set; }
        public int price { get; set; }
        public string descriptions { get; set; }
        public string image { get; set; }
   
    }
}