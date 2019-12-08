using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home_XLdelCart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int product_detail_id = int.Parse(Request.QueryString["id"]);
        if (Session["giohang"] != null)
        {

            if (product_detail_id >0)
            {
                List<Product_Detail> shopppingCart = Session["giohang"] as List<Product_Detail>;
                Product_Detail cardItem = shopppingCart.Single(p => p.product_detail_id == product_detail_id);

                shopppingCart.Remove(cardItem);
                Response.Redirect("cart.aspx");
            }
            Response.Redirect("cart.aspx");
        }
        else
        {

            Response.Write("hello" + product_detail_id);
        }


    }
}