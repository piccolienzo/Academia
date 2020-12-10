using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;

namespace UI.Web
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LinkButton lnk = (LinkButton)Master.FindControl("HomeLinkNav");
            lnk.CssClass = "navbar-brand active";
        }

        protected void LblUserBienvenida_Load(object sender, EventArgs e)
        {
            
            if (Session["Usuario"] != null)
            {
                string te = ((Usuario)Session["Usuario"]).NombreUsuario;
                ((Label)sender).Text = te;
                Page.Response.Write(te);
            }
           
        }
    }
}