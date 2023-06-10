using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITASWeeklyHours
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LinkButtonReport_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("Report.aspx");
        }
        protected void LinkButtonLogIn_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("Report.aspx");
        }
        protected void LinkButtonSignUp_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("Report.aspx");
        }
    }
}