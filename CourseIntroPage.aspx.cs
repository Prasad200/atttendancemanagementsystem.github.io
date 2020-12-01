using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Attendancemanagementsystemforstudents
{
    public partial class CourseIntroPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButCourse_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "Insert into [dbo].[courses] (cname,time,credits) values (@cname,@time,@credits)";
            SqlCommand sqlcomm = new SqlCommand(sqlquery,
                                                sqlconn);
            sqlconn.Open();
            sqlcomm.Parameters.AddWithValue("@cname", TxtCourseName.Text);
            sqlcomm.Parameters.AddWithValue("@time", TxtTime.Text);
            sqlcomm.Parameters.AddWithValue("@credits", TxtCredits.Text);
            sqlcomm.ExecuteNonQuery();
            LabMsg.Text = "The Course " + TxtCourseName.Text + "Is saved Successfully...!";
            TxtCourseName.Text = "";
            TxtTime.Text = "";
            TxtCredits.Text = "";
            sqlconn.Close();
        }
    }
}