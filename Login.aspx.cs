using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;
using System.Linq.Expressions;

namespace WebApplication2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string constring = "Data Source=DotNet;Initial Catalog=sai;Persist Security Info=True;User ID=sa;Password=pass@word1";

        protected void Button1_Click(object sender, EventArgs e)
        {
            string constr = WebConfigurationManager.ConnectionStrings["saiConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                SqlCommand cmd=new SqlCommand("select count(*) from register where username = '" + TextBox1.Text + "' and password = '" + TextBox2.Text + "'  ",con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cmd.ExecuteNonQuery();
                if(dt.Rows[0][0].ToString()=="1")
                {
                   // Response.Write("<script>alert('login sucessfull')</script>");
                    //xperiment starts here 
                    Response.Redirect("/Aboutus.aspx");
                }
                else
                {
                    Response.Write("<script>alert('INVALID LOGIN')</script>");
                }
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}