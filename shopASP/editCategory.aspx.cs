using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopASP
{
    public partial class editCategory : System.Web.UI.Page
    {
        DataUtils data = new DataUtils();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                category category = (category)Session["category"];
                categoryId.Text = category.category_id.ToString();
                categoryName.Text = category.category_name;
                image.ImageUrl = "~/Web/images/"+category.image;
            }
        }

        protected void edit_Click(object sender, EventArgs e)
        {
            FileUpload f = (FileUpload)Table1.FindControl("FileUpload1");
            String path = Server.MapPath("~/Web/images/");
            f.PostedFile.SaveAs(path + f.FileName);

            category danhmuc = new category();
            danhmuc.category_id = int.Parse(categoryId.Text);
            danhmuc.category_name = categoryName.Text;
            danhmuc.image = f.FileName;
            data.suaCategory(danhmuc);


        }
    }
}