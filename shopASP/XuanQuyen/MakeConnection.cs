using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MakeConnection
/// </summary>
public class MakeConnection
{
    public static string createCondition(Product_Detail similar)
    {
        string conds = "";
        if (similar != null)
        {
            int id = similar.product_id;
            if (id > 0)
            {
                conds += " product.product_id = " + id;
            }

            string product_name = similar.product_name;
            if (product_name != null && product_name != "")
            {
                if (conds != "")
                {
                    conds += " AND ";
                }
                conds += " (product.product_name like '%" + product_name + "%') ";

            }
            int pc_id = similar.category_id;
            if (pc_id > 0)
            {
                if (conds != "")
                {
                    conds += " AND ";
                }
                conds += " product.category_id = " + pc_id;

            }
            //string price = similar.price;
            //if (price != null&& price!="" )
            //{
            //    if (conds != "")
            //    {
            //        conds += " AND ";
            //    }
            //    conds += " product.price = " + price;

            //}
            int color_id = similar.color_id;
            if (color_id > 0)
            {
                if (conds != "")
                {
                    conds += " AND ";
                }
                conds += " product_detail.color_id = " + color_id;
            }

        }
        Console.Write(conds);
        return conds;
    }
}