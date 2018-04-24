using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Connection
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
               
                SqlCommand cmd = new SqlCommand("Select *from employeeTB", connection);
                connection.Open();
                
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }
        }

        protected void Btn_Submit_Click(object sender, EventArgs e)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_employeeTB", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", TextName.Text.Trim());
                cmd.Parameters.AddWithValue("@email", TextEmail.Text.Trim());
                connection.Open();
                int i = cmd.ExecuteNonQuery();
                if(i==1)
                {
                    TextName.Text = "";
                    TextEmail.Text = "";
                    lblmesssage.Text = "Record is saved";

                }
                else
                {

                }

            }
           
        }
    }
}