using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Order_detail
/// </summary>
public class Order_detail
{
    public int orders_id { get; set; }
    public string product_detail_id { get; set; }
    public int quantity { get; set; }
    public string price { get; set; }
    
	public Order_detail()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public Order_detail(int orders_id, string product_detail_id, int quantity, string price)
    {
        this.orders_id = orders_id;
        this.product_detail_id = product_detail_id;
        this.quantity = quantity;
        this.price = price;
    }
}