using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Attendancemanagementsystemforstudents
{
    public partial class AMSFS : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Adminname"] != null)
            {
                LabUserLogin.Text = Session["Adminname"].ToString();
            }
            else
            {
                Response.Redirect("LoginPage.aspx");
            }
        }

        protected void LnkCourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("CourseIntroPage.aspx");
        }

        protected void LnkTeacher_Click(object sender, EventArgs e)
        {
            Response.Redirect("TeacherIntroPage.aspx");
        }

        protected void LnkStudent_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentIntroPage.aspx");
        }

        protected void LnkLogout_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Session.Abandon();
            Response.Redirect("LoginPage.aspx");
        }
    }
}