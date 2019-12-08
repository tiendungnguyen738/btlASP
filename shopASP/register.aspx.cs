using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopASP
{
    public partial class register : System.Web.UI.Page
    {
        DataUtils data = new DataUtils();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();
                user.full_name = txtFullname.Text;
                user.address = txtAddress.Text;
                user.sex = int.Parse(txtSex.Text);
                user.idccard = txtCardId.Text;
                user.role_id = 2;
                user.email = txtEmail.Text;
                user.username = txtUsername.Text;
                user.password = txtPassword.Text;

                data.insertAccount(user);
                errg.Text = "Dang ky thanh cong";
            }
            catch (Exception e1)
            {
                errg.Text = "Dang ky khong thanh cong";
            }
        }
    }
}