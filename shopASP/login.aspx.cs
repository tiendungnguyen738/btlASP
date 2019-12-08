using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopASP
{
    public partial class login : System.Web.UI.Page
    {
        DataUtils data = new DataUtils();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            int a = data.checkLogin(username, password);

            if (a == 1)
            {
                Session["name"] = txtusername.Text;
                Session["allow"] = true;
                Response.Redirect("/category-ad.aspx");
            }
            else if (a == 2)
            {
                Session["name"] = txtusername.Text;
                User u = Session["loginUser"] as User;
                u = data.getUser(username, password);
                
                Session["fullname"] = u.full_name;
                Session["address"] = u.address;
                Session["email"] = u.email;
                Session["phone"] = u.phone;
                Response.Redirect("/HomeXQ/index.aspx");
            }
            else
            {
                errg.Text = "Đăng nhập không thành công";
            }
        }
    }
}