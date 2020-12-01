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
    public partial class TeacherIntroPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButTeacher_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "Insert into [dbo].[Teacher] (Tname,Temail,TCourse,TQualification) values (@Tname,@Temail,@TCourse,@TQualification)";
            SqlCommand sqlcomm = new SqlCommand(sqlquery,
                                                sqlconn);
            sqlconn.Open();
            sqlcomm.Parameters.AddWithValue("@Tname", TxtTeacherName.Text);
            sqlcomm.Parameters.AddWithValue("@Temail", TxtEmail.Text);
            sqlcomm.Parameters.AddWithValue("@TCourse", DDLCourse.SelectedItem.Text);
            sqlcomm.Parameters.AddWithValue("@TQualification", TxtQualification.Text);
            sqlcomm.ExecuteNonQuery();
            LabMsg.Text = "The Teacher " + TxtTeacherName.Text + "Is saved Successfully...!";
            TxtTeacherName.Text = "";
            TxtEmail.Text = "";
            TxtQualification.Text = "";
            sqlconn.Close();
        }
    }
}