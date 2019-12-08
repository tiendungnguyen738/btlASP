using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home_product : System.Web.UI.Page
{
    ProductBUS data = new ProductBUS();
    protected void Page_Load(object sender, EventArgs e)
    {
        //List<Product> ds = data.getListProduct();
        //Response.Write(ds.Count);

    }
    protected void hienthi()
    {
        //doi tuong truy van
        Product_Detail similar = new Product_Detail();
        int orderby = 1;
        int color = 0;
        //int category_id = Int32.Parse(Request.QueryString["category_id"]);
        if (Request.QueryString["category_id"] != null)
        {
            similar.category_id = Int32.Parse(Request.QueryString["category_id"]);
        }
        if (Request.QueryString["color_id"] != null && Request.QueryString["color"] != null)
        {
            similar.color_id = Int32.Parse(Request.QueryString["color_id"]);
            color = 1;
        }
        if (Request.Form["product_name"] != null && Request.Form["product_name"] != "")
        {
            similar.product_name = Request.Form["product_name"];
            //Response.Write(Request.Form["product_name"].ToString());
        }
        if (Request.QueryString["orderby"] != null)
        {
            orderby = Int32.Parse(Request.QueryString["orderby"]);
        }
        List<Product> ds = data.getListProduct(similar, orderby,color);
        for(int i=0;i<ds.Count();i++)
        {
            Product p = new Product();
            p = ds[i];
            string tmp = "";
            tmp +="<div class='product_item is_new'>";
            tmp +="<div class='product_border'></div>";
            tmp += "<div class='product_image d-flex flex-column align-items-center justify-content-center'><img style='width=115px;height:115px;' src='/Web/images/" + p.image+"' alt=''></div>";
            tmp +="<div class='product_content'>";
            tmp += "<div class='product_price'>" + p.price.ToString("#,##0").Replace(',', '.') + "</div>";
            tmp += "<div class='product_name'><div><a href='/HomeXQ/product_detail.aspx?product_id="+p.product_id + "&category_id="+p.category_id+"' tabindex='0'>" + p.product_name + "</a></div></div>";
            tmp +="</div>";
            tmp +="<div class='product_fav'><i class='fas fa-heart'></i></div>";
            tmp +="<ul class='product_marks'>";
            //tmp +="<li class='product_mark product_discount'>-25%</li>";
            tmp +="<li class='product_mark product_new'>new</li>";
            tmp +="</ul>";
            tmp +="</div>";
            Response.Write(tmp);

        }
      

    }
}