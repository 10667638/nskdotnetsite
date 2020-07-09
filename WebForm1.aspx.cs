using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.EnterpriseServices;
using System.Windows.Forms;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }
         public string constring = "Data Source=DotNet;Initial Catalog=sai;Persist Security Info=True;User ID=sa;Password=pass@word1";
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            if(con.State==System.Data.ConnectionState.Open)
            {
                string query = "insert into register(username,password,fn,ln,mobile) values('" + TextBox1.Text.ToString() + "','" + TextBox2.Text.ToString() +"','"+TextBox3.Text.ToString()+"','" +TextBox4.Text.ToString()+"','" +TextBox5.Text.ToString() +  "')";
                SqlCommand cmd = new SqlCommand(query,con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration sucessfull");

                


                con.Close();    

            }


        }
    }
}