using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiseasePredictionApp
{
    public partial class DiseaseDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["PreviousPage"] != null)
                Label1.Text = Request.Cookies["PreviousPage"].Value;
                
            if (Label1.Text == "")
                Label1.Text = "Unable to predict a disease!! Please contact a Doctor from below table for more details";
        }
    }
}