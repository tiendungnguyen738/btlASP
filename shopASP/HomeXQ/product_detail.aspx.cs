using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home_product_detail : System.Web.UI.Page
{
    Product_detailBus data = new Product_detailBus();
    ProductBUS data2 = new ProductBUS();
    Color_BUS data1 = new Color_BUS();
    protected void Page_Load(object sender, EventArgs e)
    {
       // Session["name11"] = "anh quyen";
    }
    protected void hienthi()
    {
        int id = Int32.Parse(Request.QueryString["product_id"]);
        Product pd = data.getProduct_detail(id);
        List<Color> colors = data1.getListColor(id);
        string tmp = "";
        if (pd != null && colors != null)
        {
            tmp += "<div class='row'>";
            tmp += "";
            tmp += "<!-- Images -->";
            tmp += "<div class='col-lg-2 order-lg-1 order-2'>";
            tmp += "<ul class='image_list'>";
            tmp += "<li data-image='images/" + pd.image + "'><img src='/Web/images/" + pd.image + "' alt=''></li>";
            tmp += "<li data-image='images/" + pd.image + "'><img src='/Web/images/" + pd.image + "' alt=''></li>";
            tmp += "<li data-image='images/" + pd.image + "'><img src='/Web/images/" + pd.image + "' alt=''></li>";
            tmp += "</ul>";
            tmp += "</div>";
            tmp += "";
            tmp += "<!-- Selected Image -->";
            tmp += "<div class='col-lg-5 order-lg-2 order-1'>";
            tmp += "<div class='image_selected'><img src='/Web/images/" + pd.image + "' alt=''></div>";
            tmp += "</div>";
            tmp += "";
            tmp += "<!-- Description -->";
            tmp += "<div class='col-lg-5 order-3'>";
            tmp += "<div class='product_description'>";
            tmp += "<div class='product_category'></div>";
            tmp += "<div class='product_name'>" + pd.product_name + "</div>";
            tmp += "<div class='rating_r rating_r_4 product_rating'><i></i><i></i><i></i><i></i><i></i></div>";
            tmp += "<div class='product_text'><p>"+pd.descriptions+"</p></div>";
            tmp += "<div class='order_info d-flex flex-row'>";
            //tmp += "<input id='command' name=\"command111\" type=\"Text\" value='0' hidden=\"\">";

            tmp += "<form id=\"form12\" runat=\"server\">";
            tmp += "<div>";
            tmp += "<div class='clearfix' style='z-index: 1000;'>";

            tmp += "<!-- Product Quantity -->";
            tmp += "<input id='product_id' name=\"product_id\" type=\"Text\" value=" + pd.product_id + " hidden=\"\">";

            tmp += "<div class='product_quantity clearfix' >";
            tmp += "<span>Quantity: </span>";
            tmp += "<input id='quantity_input' name='quantity_input' type='text' pattern='[0-9]*' value='1'>";
            tmp += "<div class='quantity_buttons'>";
            tmp += "<div id='quantity_inc_button' class='quantity_inc quantity_control'><i class='fas fa-chevron-up'></i></div>";
            tmp += "<div id='quantity_dec_button' class='quantity_dec quantity_control'><i class='fas fa-chevron-down'></i></div>";
            tmp += "</div>";
            tmp += "</div>";
            tmp += "";
            tmp += "<!-- Product Color -->";
            tmp += "<ul class='product_color'>";
            tmp += "<li>";
            tmp += "<span>Color: </span>";
            tmp += "<div class='color_mark_container'>";
            tmp += "<select style='width: 40px;height: 40px;margin-right: -50px;' name='color_id'>";
            for (int i = 0; i < colors.Count(); i++)
            {
                Color c = colors[i];
                tmp += "<option value=\"" + c.color_id + "\">";
                tmp += "<li><div class='color_mark' style='background: #999999;'>" + c.color + "</div></li>";
                tmp += "</option>";

            }
            tmp += "</select>";
            tmp += "</div>";
            tmp += "</li>";
            tmp += "</ul>";

            tmp += "</div>";
            tmp += "";
            tmp += "<div class='product_price'>" + pd.price.ToString("#,##0").Replace(',', '.') + " đ</div>";
            tmp += "<div class='button_container'>";
            //tmp += "<asp:Button ID=\"mua\" class='button cart_button' runat='server' Text=\"Add to Cart\" PostBackUrl=\"~/Home/Dathang.aspx\"/>";
            //tmp += "<button type='button' class='button cart_button'>Add to Cart</button>";
            //tmp += "<input type='submit' class='button cart_button' name='ctl00$noidung$mua' value='Mua' onclick='javascript:WebForm_DoPostBackWithOptions(new WebForm_PostBackOptions(&quot;ctl00$noidung$mua&quot;, &quot;&quot;, false, &quot;&quot;, &quot;cart.aspx&quot;, false, false))' id='noidung_mua' />";
            tmp += "<input type=\"submit\" class='button cart_button' name=\"ctl00$noidung$mua\" value=\"Mua\" onclick=\"javascript:WebForm_DoPostBackWithOptions(new WebForm_PostBackOptions(&quot;ctl00$noidung$mua&quot;, &quot;&quot;, false, &quot;&quot;, &quot;XLaddCart.aspx&quot;, false, false))\" id=\"noidung_mua\" />";
            tmp += "<div class='product_fav'><i class='fas fa-heart'></i></div>";
            tmp += "</div>";
            tmp += "</div>";
            tmp += "</form>";
            tmp += "</div>";
            tmp += "</div>";
            tmp += "</div>";
            tmp += "";
            tmp += "</div>";

            Response.Write(tmp);
        }
        else {
            Response.Write("San pham chu co chi tiet");
        }
        
    }
    protected void hienthiTT()
    { 
        //khai bao doi tuong 
        Product_Detail similar = new Product_Detail();
        if (Request.QueryString["category_id"] != null)
        {
            similar.category_id = Int32.Parse(Request.QueryString["category_id"]);
        }
        List<Product> List = data2.getListProduct(similar,1,0);
        string tmp = "";
        for (int i = 0; i < List.Count; i++)
        {
            Product p = List[i];
            tmp += "<div class=\"owl-item\">";
            tmp += "<div class=\"viewed_item is_new d-flex flex-column align-items-center justify-content-center text-center\">";
            tmp += "<div class=\"viewed_image\"><img src=\"/Web/images/" + p.image+"\" alt=\"\"></div>";
            tmp += "<div class=\"viewed_content text-center\">";
            tmp += "<div class=\"viewed_price\">" + p.price.ToString("#,##0").Replace(',', '.') + "</div>";
            tmp += "<div class=\"viewed_name\"><a href=\"/HomeXQ/product_detail.aspx?product_id="+p.product_id+"\">"+p.product_name+"</a></div>";
            tmp += "</div>";
            tmp += "<ul class=\"item_marks\">";
            //tmp += "<li class=\"item_mark item_discount\">-25%</li>";
            tmp += "<li class=\"item_mark item_new\">new</li>";
            tmp += "</ul>";
            tmp += "</div>";
            tmp += "</div>";
            Response.Write(tmp);

        }
    }
}