using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopASP
{
    public partial class editProductDetail : System.Web.UI.Page
    {
        DataUtils DataUtils = new DataUtils();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                product_detail_hienthi product_Detail_Hienthi = (product_detail_hienthi)Session["product_detail_hienthi"];
                product_name.Text = product_Detail_Hienthi.product_name;
                soluong.Value = product_Detail_Hienthi.quantity.ToString();
                product_detail_id.Value = product_Detail_Hienthi.product_detail_id.ToString();
                dsmau.DataSource = DataUtils.GetColors();
                dsmau.DataValueField = "color_id";
                dsmau.DataTextField = "color_name";
                dsmau.DataBind();
                dsmau.SelectedValue = product_Detail_Hienthi.color_id.ToString();
                quayvetrangchitiet.PostBackUrl = "~/product-detail-ad.aspx?product_id="+product_Detail_Hienthi.product_id;
            }
        }

        protected void edit_Click(object sender, EventArgs e)
        {
            product_detail_hienthi product_Detail_Hienthi = new product_detail_hienthi();
            product_Detail_Hienthi.color_id = int.Parse(dsmau.SelectedValue);
            product_Detail_Hienthi.quantity = int.Parse(soluong.Value);
            product_Detail_Hienthi.product_detail_id = int.Parse(product_detail_id.Value);
            DataUtils.suaSoLuongVaMau(product_Detail_Hienthi);
        }
    }
}