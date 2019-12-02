using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopASP
{
    public partial class editProduct : System.Web.UI.Page
    {
        DataUtils data = new DataUtils();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                product product = (product)Session["product"];
                productId.Text = product.product_id.ToString();
                tendienthoai.Text = product.product_name;
                giadienthoai.Text = product.price.ToString();
                dsHangDienThoai.DataSource = data.dscategories();
                dsHangDienThoai.DataTextField = "category_name";
                dsHangDienThoai.DataValueField = "category_id";
                DataBind();
                dsHangDienThoai.SelectedValue = product.category_id.ToString();
                mota.Text = product.descriptions;
            }
        }

        protected void edit_Click(object sender, EventArgs e)
        {
            FileUpload f = (FileUpload)Table1.FindControl("FileUpload1");
            String path = Server.MapPath("~/Web/images/");
            f.PostedFile.SaveAs(path + f.FileName);

            product product = new product();
            product.product_id = int.Parse(productId.Text);
            product.product_name = tendienthoai.Text;
            product.price = int.Parse(giadienthoai.Text);
            product.descriptions = mota.Text;
            product.category_id = int.Parse(dsHangDienThoai.SelectedValue);
            product.image = f.FileName;
            data.suaProduct(product);
        }
    }
}