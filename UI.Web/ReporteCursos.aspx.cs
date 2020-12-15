﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class ReporteCursos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string asd = DateTime.Now.ToString("dd-MM-yyyy-HHmm");
            ReportViewer1.LocalReport.DisplayName = $"ReporteCursos{asd}";
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Reportes.aspx");
        }
    }
}