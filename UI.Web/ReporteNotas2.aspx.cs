﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace UI.Web
{
    public partial class ReporteNotas2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string asd = DateTime.Now.ToString("dd-MM-yyyy-HHmm");
            ReportViewer1.LocalReport.DisplayName = $"ReporteNotas{asd}";
            
        }
    }
}