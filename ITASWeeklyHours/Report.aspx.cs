﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExecuteSSISPackage;
namespace ITASWeeklyHours
{
    public partial class Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LinkButtonGenerateReport_Click(object sender, EventArgs e)
        {
            RunSSISPackage runSSISPackage = new RunSSISPackage();
            runSSISPackage.ExecuteSSISPackage();
        }
    }
}