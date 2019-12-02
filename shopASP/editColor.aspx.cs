using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopASP
{
    public partial class editColor : System.Web.UI.Page
    {
        DataUtils data = new DataUtils();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                color color = (color)Session["color"];
                colorId.Text = color.color_id.ToString();
                colorName.Text = color.color_name;
            }
        }

        protected void edit_Click(object sender, EventArgs e)
        {
            color color = new color();
            color.color_id = int.Parse(colorId.Text);
            color.color_name = colorName.Text;
            data.suaColor(color);
        }
    }
}