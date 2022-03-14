using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;
using System.Configuration;

namespace DiseasePredictionApp
{
    public partial class AdminLogin1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Page.User.Identity.IsAuthenticated)
            {
                FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, false);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FormsAuthentication.Authenticate(TextBox1.Text, TextBox2.Text))
            { FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, false); }
            else { Response.Write("<script>alert('Wrong Credentials')</script>"); }
        }
    }
}