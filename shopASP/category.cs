using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shopASP
{
    public class category
    {
        public int category_id { get; set; }
        public string category_name { get; set; }
        public string  image { get; set; }
        public category()
        {

        }
        public category(string category_name,string image)
        {
            this.category_name = category_name;
            this.image = image;
        }
    }
}