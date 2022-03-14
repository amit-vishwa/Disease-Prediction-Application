using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DiseasePredictionApp
{
    public partial class AdminDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.User.Identity.IsAuthenticated)
            {
                FormsAuthentication.RedirectToLoginPage();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "" 
                && TextBox5.Text != "")
            {
                try
                {
                    SqlConnection sc = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
                    sc.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Diseases(Disease,Symptom1,Symptom2,Symptom3,Symptom4,Symptom5,Symptom6,Symptom7) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "')", sc);
                    cmd.ExecuteNonQuery();
                    sc.Close();
                    Response.Redirect("AdminDetails.aspx");
                    TextBox1.Text = TextBox2.Text = TextBox3.Text = TextBox4.Text = TextBox5.Text = TextBox6.Text = TextBox7.Text = TextBox8.Text = "";
                }
                catch (Exception ex) { Response.Write("<script>alert('Insertion Failed!!!')</script>"); }
            }
            else { Response.Write("<script>alert('Disease and Symptoms Fields cannot be Empty')</script>"); }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox9.Text != "" && TextBox10.Text != "" && TextBox11.Text != "")
            {
                try
                {
                    SqlConnection sc = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
                    sc.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Doctors(DName,DPhone,DAddress) values('" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "')", sc);
                    cmd.ExecuteNonQuery();
                    sc.Close();
                    Response.Redirect("AdminDetails.aspx");
                    TextBox9.Text = TextBox10.Text = TextBox11.Text = "";
                }
                catch (Exception ex) { Response.Write("<script>alert('Insertion Failed!!!')</script>"); }
            }
            else { Response.Write("<script>alert('Doctor Name, Doctor Contact, Doctor Address Fields cannot be Empty')</script>"); }
        }
    }
}