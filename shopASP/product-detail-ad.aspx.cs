using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopASP
{
    public partial class product_detail_ad : System.Web.UI.Page
    {
        DataUtils dataUtils = new DataUtils();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["product_id"] != null)
                {
                    hienthi(int.Parse(Request.QueryString["product_id"]));
                    product_id.Value = Request.QueryString["product_id"];
                }
                dsMau.DataSource = dataUtils.GetColors();
                dsMau.DataTextField = "color_name";
                dsMau.DataValueField = "color_id";
                DataBind();
            }
        }
        protected void hienthi(int product_id)
        {
            GridView1.DataSource = dataUtils.danhSachDienThoaiTheoMa(product_id);
            DataBind();
        }
        protected void delete_click(object sender, CommandEventArgs e1)
        {
            if (e1.CommandName == "delete")
            {
                int productDetailId = Convert.ToInt16(e1.CommandArgument);
                dataUtils.xoaProductDetail(productDetailId);
                hienthi(productDetailId);
            }
        }
        protected void edit_click(object sender, CommandEventArgs e1)
        {
            if (e1.CommandName == "edit")
            {
                int productDetailId = Convert.ToInt16(e1.CommandArgument);
                product_detail_hienthi product_detail_hienthi = dataUtils.layProductDetail(productDetailId);
                Session["product_detail_hienthi"] = product_detail_hienthi;
                Response.Redirect("editProductDetail.aspx");
            }
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            product_detail product_Detail = new product_detail();
            product_Detail.color_id = int.Parse(dsMau.SelectedValue);
            product_Detail.quantity = int.Parse(soluong.Text);
            product_Detail.product_id = int.Parse(product_id.Value);
            dataUtils.themChiTietDienThoai(product_Detail);
            hienthi(product_Detail.product_id);
        }
    }
}