using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopASP
{
    public partial class product_ad : System.Web.UI.Page
    {
        DataUtils data = new DataUtils();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                hienthi();
            }
            
        }
        private void hienthi()
        {
            GridView1.DataSource = data.laydsdt();
            DataBind();
        }
        protected void Delete_Click(object sender, CommandEventArgs e1)
        {
            if (e1.CommandName == "delete")
            {
                int productId = Convert.ToInt16(e1.CommandArgument);
                data.xoaDienThoai(productId);
                hienthi();
            }
        }
        protected void Edit_Click(object sender, CommandEventArgs e1)
        {
            if (e1.CommandName == "Edit")
            {
                int productId = Convert.ToInt16(e1.CommandArgument);
                product product = data.layProduct(productId);
                Session["product"] = product;
                Response.Redirect("editProduct.aspx");
            }
        }

        protected void btnTim_Click(object sender, EventArgs e)
        {
            List<thong_tin_dienthoai> lists = data.getListProductSearch(tensanpham.Text);
            if(lists.Count != 0)
            {
                thongbao.Text = "Có "+lists.Count+" Sản Phẩm: '"+tensanpham.Text+"' Được Tìm Thấy.";
                GridView1.DataSource = lists;
                DataBind();
            }
            if(lists.Count == 0)
            {
                thongbao.Text = "Không Có Sản Phẩm Nào Có Tên: '"+tensanpham.Text+"'";
                GridView1.DataSource = null;
                DataBind();
            }
        }
    }
}