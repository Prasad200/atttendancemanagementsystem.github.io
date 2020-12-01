using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Attendancemanagementsystemforstudents
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButLogin_Click(object sender, EventArgs e)
        {
            if (TxtAdminId.Text == "Vtu12796" && TxtPwdAdmin.Text == "12796")
            {
                Session["Adminname"] = "Welcome " + TxtAdminId.Text;
                Response.Redirect("AdminPage.aspx");
            }
            else
            {
                Labmsg.Text = "Failed Login Details...";
            }
        }
    }
}