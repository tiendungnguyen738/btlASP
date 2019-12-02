using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopASP
{
    public partial class category_ad : System.Web.UI.Page
    {
        DataUtils data = new DataUtils();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            hienthi();
        }
       private void hienthi()
        {
            GridView1.DataSource = data.dscategories();
            DataBind();
        }
        protected void Delete_Click(object sender,CommandEventArgs e1)
        {
            if(e1.CommandName== "delete")
            {
                int categoryId = Convert.ToInt16(e1.CommandArgument);
                data.xoaCategory(categoryId);
                hienthi();
            }
        }
        protected void Edit_Click(object sender,CommandEventArgs e1)
        {
            if(e1.CommandName== "Edit")
            {
                int categoryId = Convert.ToInt16(e1.CommandArgument);
                category category = data.layCategory(categoryId);
                Session["category"] = category;
                Response.Redirect("editCategory.aspx");
            }
        }
    }

}