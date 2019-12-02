using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopASP
{
    public partial class color_ad : System.Web.UI.Page
    {
        DataUtils data = new DataUtils();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                hienthi();
        }
        protected void hienthi()
        {
            GridView1.DataSource = data.GetColors();
            DataBind();
        }
        protected void delete_click(object sender, CommandEventArgs e1)
        {
            if (e1.CommandName == "delete")
            {
                int colorId = Convert.ToInt16(e1.CommandArgument);
                data.xoaColor(colorId);
                hienthi();
            }
        }
        protected void edit_click(object sender, CommandEventArgs e2)
        {
            if (e2.CommandName == "edit")
            {
                int colorId = Convert.ToInt16(e2.CommandArgument);
                color color = data.layColor(colorId);
                Session["color"] = color;
                Response.Redirect("editColor.aspx");
            }
        }

        protected void btnThemMau_Click(object sender, EventArgs e)
        {
            color color = new color();
            color.color_name = tenmau.Text;
            data.themColor(color);
            hienthi();
            tenmau.Text = "";
        }
    }
}