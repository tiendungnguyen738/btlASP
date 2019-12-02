using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopASP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ItemInserting(object sender, FormViewInsertEventArgs e)
        {
            FileUpload f = (FileUpload)formview1.FindControl("FileUpload1");
            String path = Server.MapPath("~/Web/images/");
            f.PostedFile.SaveAs(path + f.FileName);
            //set parameter to image column
            SqlDataSource2.InsertParameters["image"].DefaultValue = f.FileName;

        }
    }
}