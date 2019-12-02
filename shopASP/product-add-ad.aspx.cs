using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopASP
{
    public partial class product_add_ad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ItemInserting(object sender, FormViewInsertEventArgs e)
        {
            FileUpload f = (FileUpload)FormView1.FindControl("FileUpload1");
            String path = Server.MapPath("~/Web/images/");
            f.PostedFile.SaveAs(path + f.FileName);
            SqlDataSource1.InsertParameters["image"].DefaultValue = f.FileName;
        }
    }
}