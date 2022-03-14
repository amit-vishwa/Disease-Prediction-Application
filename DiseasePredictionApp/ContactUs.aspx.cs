using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DiseasePredictionApp
{
    public partial class ContactUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "")
                {
                    SqlConnection sc = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
                    sc.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Visitors values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')", sc);
                    cmd.ExecuteNonQuery();
                    sc.Close();
                    Response.Write("<script>alert('Message Delivered')</script>");
                    TextBox1.Text = TextBox2.Text = TextBox3.Text = "";
                }
                else { Response.Write("<script>alert('Fields cannot be empty!!!')</script>"); }
            }
            catch (Exception ex) { Response.Write("<script>alert('Improper inputs entered!!!')</script>"); }
        }
    }
}