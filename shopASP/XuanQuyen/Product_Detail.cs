using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for product_detail
/// </summary>
public class Product_Detail:Product
{
    public int product_detail_id { get; set; }
    public int product_id { get; set; }
    public int size_id { get; set; }
    public int color_id { get; set; }
    public int quantity { get; set; }

	public Product_Detail()
	{
	}
    public Product_Detail(int product_detail,int product_id,int size_id,int color_id,int quantity)
    {
        this.product_detail_id = product_detail_id;
        this.product_id = product_id;
        this.size_id = size_id;
        this.color_id = color_id;
        this.quantity = quantity;
    }
    public override bool Equals(object obj)
    {
        Product_Detail p = (Product_Detail)obj;

        return p.product_detail_id == product_detail_id;
    }
}