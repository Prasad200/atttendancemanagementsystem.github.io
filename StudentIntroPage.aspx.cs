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
    public partial class StudentIntroPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButStudent_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "Insert into [dbo].[Student] (FirstName,LastName,Pname) values (@FirstName,@LastName,@Pname)";
            SqlCommand sqlcomm = new SqlCommand(sqlquery,
                                                sqlconn);
            sqlconn.Open();
            sqlcomm.Parameters.AddWithValue("@FirstName", TxtFirstName.Text);
            sqlcomm.Parameters.AddWithValue("@LastName", TxtLastName.Text);
            sqlcomm.Parameters.AddWithValue("@Pname", TxtPname.Text);
            sqlcomm.ExecuteNonQuery();
            LabMsg.Text = "The Student " + TxtFirstName.Text + "Is saved Successfully...!";
            TxtFirstName.Text = "";
            TxtLastName.Text = "";
            TxtPname.Text = "";
            sqlconn.Close();
        }
    }
}