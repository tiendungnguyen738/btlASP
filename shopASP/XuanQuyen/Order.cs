using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Order
/// </summary>
public class Order
{
    public int orders_id { get; set; }
    public string customer_name { get; set; }
    public string phone { get; set; }
    public string address { get; set; }
    public bool orders_status { get; set; }
    public string orders_date { get; set; }
    public string note { get; set; }
    
	
	public Order()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public Order(int order_id, string customer_name, string phone, string address, bool orders_status, string orders_date, string note)
    {
        this.orders_id = orders_id;
        this.customer_name = customer_name;
        this.phone = phone;
        this.address = address;
        this.orders_status = orders_status;
        this.orders_date = orders_date;
        this.note = note;
    }
}