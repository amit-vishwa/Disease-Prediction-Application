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
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ddl1, ddl2, ddl3, ddl4, ddl5, ddl6, ddl7;
            ddl1 = DropDownList1.SelectedItem.Text;
            ddl2 = DropDownList2.SelectedItem.Text;
            ddl3 = DropDownList3.SelectedItem.Text;
            ddl4 = DropDownList4.SelectedItem.Text;
            ddl5 = DropDownList5.SelectedItem.Text;
            ddl6 = DropDownList6.SelectedItem.Text;
            ddl7 = DropDownList7.SelectedItem.Text;
            try
            {
                if (ddl7 != "Symptom1" && ddl6 != "Symptom2" && ddl5 != "Symptom3" && ddl4 != "Symptom4"
                    && ddl3 != "Symptom5" && ddl2 != "Symptom6" && ddl1 != "Symptom7")
                {
                    if ((ddl1 != ddl2 && ddl1 != ddl3 && ddl1 != ddl4 && ddl1 != ddl5 && ddl1 != ddl6 && ddl1 != ddl7) &&
                        (ddl2 != ddl3 && ddl2 != ddl4 && ddl2 != ddl5 && ddl2 != ddl6 && ddl2 != ddl7) &&
                        (ddl3 != ddl4 && ddl3 != ddl5 && ddl3 != ddl6 && ddl3 != ddl7) &&
                        (ddl4 != ddl5 && ddl4 != ddl6 && ddl4 != ddl7) &&
                        (ddl5 != ddl6 && ddl5 != ddl7) && (ddl6 != ddl7))
                    {
                        string str = "Select Disease from Diseases where (Symptom1 = '" + ddl7 + "' OR Symptom2 = '" + ddl7
                            + "' OR Symptom3 = '" + ddl7 + "' OR Symptom4 = '" + ddl7 + "' OR Symptom5 = '" + ddl7
                            + "' OR Symptom6 = '" + ddl7 + "' OR Symptom7 = '" + ddl7 + "') AND (Symptom1 = '" + ddl6
                            + "' OR Symptom2 = '" + ddl6 + "' OR Symptom3 = '" + ddl6 + "' OR Symptom4 = '" + ddl6
                            + "' OR Symptom5 = '" + ddl6 + "' OR Symptom6 = '" + ddl6 + "' OR Symptom7 = '" + ddl6
                            + "') AND (Symptom1 = '" + ddl5 + "' OR Symptom2 = '" + ddl5 + "' OR Symptom3 = '" + ddl5
                            + "' OR Symptom4 = '" + ddl5 + "' OR Symptom5 = '" + ddl5 + "' OR Symptom6 = '" + ddl5
                            + "' OR Symptom7 = '" + ddl5 + "') AND (Symptom1='" + ddl4 + "' OR Symptom2 = '" + ddl4
                            + "' OR Symptom3 = '" + ddl4 + "' OR Symptom4 = '" + ddl4 + "' OR Symptom5 = '" + ddl4 + "' OR Symptom6 = '"
                            + ddl4 + "' OR Symptom7 = '" + ddl4 + "') AND (Symptom1='" + ddl3 + "' OR Symptom2 = '" + ddl3
                            + "' OR Symptom3 = '" + ddl3 + "' OR Symptom4 = '" + ddl3 + "' OR Symptom5 = '" + ddl3 + "' OR Symptom6 = '"
                            + ddl3 + "' OR Symptom7 = '" + ddl3 + "') AND (Symptom1='" + ddl2 + "' OR Symptom2 = '" + ddl2
                            + "' OR Symptom3 = '" + ddl2 + "' OR Symptom4 = '" + ddl2 + "' OR Symptom5 = '" + ddl2 + "' OR Symptom6 = '"
                            + ddl2 + "' OR Symptom7 = '" + ddl2 + "') AND (Symptom1='" + ddl1 + "' OR Symptom2 = '" + ddl1
                            + "' OR Symptom3 = '" + ddl1 + "' OR Symptom4 = '" + ddl1 + "' OR Symptom5 = '" + ddl1 + "' OR Symptom6 = '" 
                            + ddl1 + "' OR Symptom7 = '" + ddl1 + "')";
                        
                        string disease = "";
                        try
                        {
                            SqlConnection sc = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
                            sc.Open();
                            SqlCommand cmd = new SqlCommand(str, sc);                            
                            disease = cmd.ExecuteScalar().ToString();
                            sc.Close();
                            HttpCookie cookie = new HttpCookie("PreviousPage");
                            cookie.Value = disease;
                            Response.Cookies.Add(cookie);
                            Response.Redirect("DiseaseDetails.aspx");
                        }
                        catch (Exception ex)
                        {
                            HttpCookie cookie = new HttpCookie("PreviousPage");
                            cookie.Value = disease;
                            Response.Cookies.Add(cookie);
                            Response.Redirect("DiseaseDetails.aspx");
                        }
                    }
                    else { Response.Write("<script>alert('Please select unique symptoms only!!!')</script>"); }
                }
                else { Response.Write("<script>alert('Please select valid symptoms from dropdown list!!!')</script>"); }
            }
            catch (Exception ex) { Response.Write("<script>alert(ex.Message)</script>"); }
        }
    }
}