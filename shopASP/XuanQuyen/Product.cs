using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for product
/// </summary>
public class Product
{
    public int product_id { get; set; }
    public int category_id { get; set; }
    public string product_name { get; set; }
	 public string  descriptions { get; set; }
    public int  price { get; set; }
    public string image { get; set; }
    public Product()
	{
	}
    public Product(int id1 ,int id2, string name, string descriptions,int price, string image)
    {
        this.product_id = id1;
        this.category_id = id2;
        this.product_name = name;
		this.descriptions = descriptions;
        this.price = price;
        this.image = image;
    }
}