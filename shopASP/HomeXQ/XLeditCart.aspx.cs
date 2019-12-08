using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home_XLeditCart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int product_detail_id = int.Parse(Request.QueryString["id"]);
        int quantity = Int32.Parse(Request.QueryString["quantity"]);
        if (Session["giohang"] != null)
        {

            if (product_detail_id != null)
            {
                List<Product_Detail> shopppingCart = Session["giohang"] as List<Product_Detail>;
                Product_Detail cardItem = shopppingCart.Single(p => p.product_detail_id == product_detail_id);

                //shopppingCart.Remove(cardItem);
                if (cardItem != null)
                {
                    cardItem.quantity = quantity;
                    Response.Write("hello" + product_detail_id);
                }
              
                //if (Request.QueryString["qua"] == "plus")
                //{
                //    cardItem.quantity++;
                //}
                Response.Redirect("cart.aspx");
               
            }
            //Response.Write("hello 111" + product_detail_id);
        }
        else
        {

            Response.Write("hello" + product_detail_id);
        }
       // int sl = Int32.Parse(Request["quantity_input"]);
       // Response.Write("hello" + sl);
    }
}