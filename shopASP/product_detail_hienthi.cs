using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shopASP
{
    public class product_detail_hienthi
    {
        public string product_name { get; set; }
      //  public int price { get; set; }
        public string color_name { get; set; }
        public int quantity { get; set; }
        public string image { get; set; }

        public int color_id { get; set; }

        public int product_detail_id { get; set; }
        public int product_id { get; set; }

    }
}