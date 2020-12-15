using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class Reportes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BotonNotas_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/ReporteNotas.aspx");
        }

        protected void BotonCursos_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/ReporteCursos.aspx");
        }

        protected void BotonPlanes_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/ReportePlanes.aspx");
        }
    }
}