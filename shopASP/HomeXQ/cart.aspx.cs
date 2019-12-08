using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home_cart : System.Web.UI.Page
{
    Product_detailBus data = new Product_detailBus();
    protected void Page_Load(object sender, EventArgs e)
    {
       
        
    }
   
    protected void hienthi()
    {
       if(Session["giohang"] == null)
       {
       }else{
           List<Product_Detail> ds = Session["giohang"] as List<Product_Detail>;
            string tmp = "";
            tmp += "<div class='cart_title'>Giỏ hàng</div>";
            tmp += "<div class='cart_items'>";
            Product_Detail pd = new Product_Detail();
            
            double total = 0;
            for (int i = 0; i < ds.Count; i++)
            {
                pd = ds[i];
                Product_Detail pd2 = data.getProduct_detailByID(pd.product_detail_id);
                Color_BUS color = new Color_BUS();
                Color c = color.GetColor(pd.product_detail_id);
                tmp += "<ul class='cart_list'>";
                tmp += "<li class='cart_item clearfix'>";
                tmp += "<div class='cart_item_image'><img style='width:115px;height:115px;' src='images/"+pd.image+"' alt=''></div>";
                tmp += "<div class='cart_item_info d-flex flex-md-row flex-column justify-content-between'>";
                tmp += "<div class='cart_item_name cart_info_col'>";
                tmp += "<div class='cart_item_title'>Tên sản phẩm</div>";
                tmp += "<div class='cart_item_text'>" + pd.product_name + "</div>";
                tmp += "</div>";
                tmp += "<div class='cart_item_color cart_info_col'>";
                tmp += "<div class='cart_item_title'>Màu sắc</div>";
                tmp += "<div class='cart_item_text'>" + c.color+"</div>";
                tmp += "</div>";
                tmp += "<div class='cart_item_quantity cart_info_col'>";
                tmp += "<div class='cart_item_title'>Số lượng</div>";
                tmp += "<!-- Product Quantity -->";
                
                tmp += "<div style=\"width:100px;margin-top:25px;\" class='product_quantity clearfix'>";

                tmp += "<input id='quantity_input' class='abcdAlert' name='quantity_input' type='text' max='" + pd2.quantity + "' pattern='[0-9]*' value='" + pd.quantity + "'>";
                tmp += "<div class='quantity_buttons'>";
                tmp += "<div id='quantity_inc_button' class='quantity_inc quantity_control abcdcheck'><i class='fas fa-chevron-up abcdcheck'></i></div>";
                tmp += "<div id='quantity_dec_button' class='quantity_dec quantity_control'><i class='fas fa-chevron-down'></i></div>";
                tmp += "</div>";
                tmp += "</div>";
                
                tmp += "</div>";
                tmp += "<div class='cart_item_price cart_info_col' style=\"margin-right:100px; width:50px;\">";
                tmp += "<div class='cart_item_title'>Giá</div>";
                tmp += "<div class='cart_item_text'>" + pd.price.ToString("#,##0").Replace(',', '.') + "</div>";
                tmp += "</div>";
                tmp += "<div class='cart_item_price cart_info_col' style=\"margin-right:50px; width:50px;\">";
                tmp += "<div class='cart_item_title'>Edit</div>";
                tmp += "<div class='cart_item_text'><a class=\"editcart\" href='/HomeXQ/XLeditCart.aspx?id=" + pd.product_detail_id + "&quantity=" + pd.quantity + "'  tabindex='0'><img src='/HomeXQ/images/Apps-system-software-update-icon (1).png' alt=''></a></div>";
                tmp += "</div>";
                tmp += "<div class='cart_item_total cart_info_col'  style=\"\">";
                tmp += "<div class='cart_item_title'>Delete</div>";
                tmp += "<div class='cart_item_text'><a onclick=\"return confirm('Bạn có chắc muốn bỏ sản phẩm này khỏi giỏ hàng?');\" href='/HomeXQ/XLdelCart.aspx?id=" + pd.product_detail_id + "' tabindex='0'><img src='/HomeXQ/images/Button-Close-icon (1).png' alt=''></a></div>";
                tmp += "<input class='quantitymax' id='checkquan' name=\"checkquan\" type=\"Text\" value='" + pd2.quantity + "' hidden=\"\">";            
                tmp += "</div>";
                tmp += "</div>";
                tmp += "</li>";
                tmp += "</ul>";
                
                total = total + (pd.quantity * pd.price);
                Session["total"] = total.ToString();
            }
            tmp += "</div>";

            tmp += "<!-- Order Total -->";
            tmp += "<div class='order_total'>";
            tmp += "<div class='order_total_content text-md-right'>";
            tmp += "<div class='order_total_title'>Tổng hóa đơn:</div>";
            tmp += "<div class='order_total_amount'>" + total.ToString("#,##0").Replace(',', '.') + "</div>";
            tmp += "</div>";

            
            tmp += "</div>";
            tmp += "";
            tmp += "<div class='cart_buttons'>";
            tmp += "<a class='button cart_button_checkout' href='/HomeXQ/product.aspx' style='margin-right:30px;'>Mua tiep</a>";
            tmp += "<a class='button cart_button_checkout hide' href='#checkout' style='margin-right:30px;'>Đặt hàng</a>";
            //tmp += "<button type='button' class='button cart_button_checkout'>Add to Cart</button>";
            tmp += "</div>";
            Response.Write(tmp);
        }
    }
        
}