using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home_XLaddCart : System.Web.UI.Page
{
    Product_detailBus data = new Product_detailBus();
    ProductBUS product = new ProductBUS();
    protected void Page_Load(object sender, EventArgs e)
    {
        //Lấy id
        //int comd = Int32.Parse(Request.Form["command111"]); 
        // int id = Int32.Parse(Request.Form["quantity_input"]);
        int quantity = Int32.Parse(Request["quantity_input"]);
        int product_id = Int32.Parse(Request["product_id"]);
        int color_id = Int32.Parse(Request["color_id"]);
        //lay san pham theo id
        Product item = new Product();
        Product_Detail pdd = data.getCart(product_id, color_id);
        //item = product.getProduct(product_id);
        //Lay chi tiet san pham
        Product_Detail detail = new Product_Detail();
        detail.product_detail_id = pdd.product_detail_id;
        detail.product_id = pdd.product_id;
        detail.product_name = pdd.product_name;
        detail.image = pdd.image;
        detail.price = pdd.price;
        detail.color_id = color_id;
        

        //tao danh sach gio hang
        List<Product_Detail> ds = (List<Product_Detail>)Session["giohang"];

        if (ds == null)
        {
            ds = new List<Product_Detail>();
           
        }

        else   //int c = li.i
        {
            //  Product_Detail x = new Product_Detail();
            //   x.product_id = 10;

            //  ds.Remove(x);

            if (ds.Any(prod => prod.product_id == detail.product_id && prod.color_id == detail.color_id))
            {
                //Response.Write("<br/>Ban da mua " + ds.Count + " nay roi <br/>");
                for (int i = 0; i < ds.Count; i++)
                {
                    Product_Detail prd = ds[i];
                    prd.quantity = prd.quantity + quantity;

                }

            }
            else
            {
                detail.quantity = quantity;
                ds.Add(detail);
            }
           
        }


        Session["giohang"] = ds;
        Response.Redirect("Cart.aspx");
    }
}