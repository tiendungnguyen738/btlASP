using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home_index : System.Web.UI.Page
{
    ProductBUS data = new ProductBUS();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void hienthi()
    {
        Product_Detail similar = new Product_Detail();
         List<Product> ds = data.getListProduct(similar, 4,0);
        for(int i=0;i<ds.Count();i++)
        {
            Product p = new Product();
            p = ds[i];
            string tmp = "";

            tmp +="<div class=\"featured_slider_item\">";
            tmp +="<div class=\"border_active\"></div>";
            tmp +="<div class=\"product_item discount d-flex flex-column align-items-center justify-content-center text-center\">";
            tmp += "<div class=\"product_image d-flex flex-column align-items-center justify-content-center\"><img style='width:115px;height:115px;' src=\"/Web/images/"+p.image+"\" alt=\"\" /></div>";
            tmp +="<div class=\"product_content\">";
            tmp += "<div class=\"product_price discount\"><span>" + p.price.ToString("#,##0").Replace(',', '.') + " đ</span></div>";
            tmp +="<div class=\"product_name\"><div><a href=\"product.html\">"+p.product_name+"...</a></div></div>";
            tmp +="<div class=\"product_extras\">";
            tmp +="<div class=\"product_color\">";
            tmp +="<input type=\"radio\" checked name=\"product_color\" style=\"background:#b19c83\">";
            tmp +="<input type=\"radio\" name=\"product_color\" style=\"background:#000000\">";
            tmp +="<input type=\"radio\" name=\"product_color\" style=\"background:#999999\">";
            tmp +="</div>";
            tmp += "<button class=\"product_cart_button\"><a href='/HomeXQ/product_detail.aspx?product_id=" + p.product_id + "&category_id=" + p.category_id + "' tabindex='0'>Xem chi tiết</a></button>";
            tmp +="</div>";
            tmp +="</div>";
            tmp +="<div class=\"product_fav\"><i class=\"fas fa-heart\"></i></div>";
            tmp +="<ul class=\"product_marks\">";
            //tmp +="<li class=\"product_mark product_discount\">-25%</li>";
            tmp +="<li class=\"product_mark product_new\">new</li>";
            tmp +="</ul>";
            tmp +="</div>";
            tmp +="</div>";
            tmp +="";

            Response.Write(tmp);

        }
        
    }
    protected void hienthi2()
    {
        Product_Detail similar = new Product_Detail();
        List<Product> ds = data.getListProduct(similar, 4,0);
        for (int i = 0; i < ds.Count(); i++)
        {
            Product p = new Product();
            p = ds[i];
            string tmp = "";

            tmp += "<div class=\"featured_slider_item\">";
            tmp += "<div class=\"border_active\"></div>";
            tmp += "<div class=\"product_item discount d-flex flex-column align-items-center justify-content-center text-center\">";
            tmp += "<div class=\"product_image d-flex flex-column align-items-center justify-content-center\"><img style='width:115px;height:115px;' src=\"/Web/images/" + p.image + "\" alt=\"\" /></div>";
            tmp += "<div class=\"product_content\">";
            tmp += "<div class=\"product_price discount\">$225<span>$300</span></div>";
            tmp += "<div class=\"product_name\"><div><a href=\"product.html\">"+p.product_name+"...</a></div></div>";
            tmp += "<div class=\"product_extras\">";
            tmp += "<div class=\"product_color\">";
            tmp += "<input type=\"radio\" checked name=\"product_color\" style=\"background:#b19c83\">";
            tmp += "<input type=\"radio\" name=\"product_color\" style=\"background:#000000\">";
            tmp += "<input type=\"radio\" name=\"product_color\" style=\"background:#999999\">";
            tmp += "</div>";
            tmp += "<button class=\"product_cart_button\"><a href='/HomeXQ/product_detail.aspx?product_id=" + p.product_id + "&category_id=" + p.category_id + "' tabindex='0'>Xem chi tiết</a></button>";
            tmp += "</div>";
            tmp += "</div>";
            tmp += "<div class=\"product_fav\"><i class=\"fas fa-heart\"></i></div>";
            tmp += "<ul class=\"product_marks\">";
            tmp += "<li class=\"product_mark product_discount\">-25%</li>";
            tmp += "<li class=\"product_mark product_new\">new</li>";
            tmp += "</ul>";
            tmp += "</div>";
            tmp += "</div>";

            Response.Write(tmp);

        }

    }
    protected void hienthi3()
    {
        Product_Detail similar = new Product_Detail();
        List<Product> ds = data.getListProduct(similar, 4,0);
        for (int i = 0; i < ds.Count(); i++)
        {
            Product p = new Product();
            p = ds[i];
            string tmp = "";

           tmp +="<div class=\"arrivals_slider_item\">";
            tmp +="<div class=\"border_active\"></div>";
            tmp +="<div class=\"product_item is_new d-flex flex-column align-items-center justify-content-center text-center\">";
            tmp += "<div class=\"product_image d-flex flex-column align-items-center justify-content-center\"><img style='width:115px;height:115px;' src=\"/Web/images/" + p.image + "\" alt=\"\" /></div>";
            tmp +="<div class=\"product_content\">";
            tmp +="<div class=\"product_price\">$225</div>";
            tmp +="<div class=\"product_name\"><div><a href=\"product.html\">"+p.product_name+"</a></div></div>";
            tmp +="<div class=\"product_extras\">";
            tmp +="<div class=\"product_color\">";
            tmp +="<input type=\"radio\" checked name=\"product_color\" style=\"background:#b19c83\">";
            tmp +="<input type=\"radio\" name=\"product_color\" style=\"background:#000000\">";
            tmp +="<input type=\"radio\" name=\"product_color\" style=\"background:#999999\">";
            tmp +="</div>";
            tmp += "<button class=\"product_cart_button\"><a href='/HomeXQ/product_detail.aspx?product_id=" + p.product_id + "&category_id=" + p.category_id + "' tabindex='0'>Xem chi tiết</a></button>";
            tmp +="</div>";
            tmp +="</div>";
            tmp +="<div class=\"product_fav\"><i class=\"fas fa-heart\"></i></div>";
            tmp +="<ul class=\"product_marks\">";
            tmp +="<li class=\"product_mark product_discount\">-25%</li>";
            tmp +="<li class=\"product_mark product_new\">new</li>";
            tmp +="</ul>";
            tmp +="</div>";
            tmp +="</div>";

            Response.Write(tmp);

        }

    }
}