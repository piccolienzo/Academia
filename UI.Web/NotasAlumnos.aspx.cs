using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class NotasAlumnos : System.Web.UI.Page
    {
        protected int IDDocente { get; set; }
       
        protected void Page_Load(object sender, EventArgs e)
        {


            if (Session["Usuario"] == null)
            {
                Page.Response.Redirect("~/Login.aspx");
            }

            Usuario usuario = (Usuario)Session["Usuario"];
            Business.Entities.Persona persona = new PersonaLogic().GetOne((int)usuario.Id_Persona);

            if ((int)persona.TipoPersona != ((int)Business.Entities.Persona.TiposPersonas.Docente))
            {
                Page.Response.Redirect("~/Home.aspx");
            }
            else
            {
                IDDocente = persona.ID;
                Session["id"] = persona.ID;
            }
            if (!Page.IsPostBack)
            {
                GridViewNotas.DataBind();

            }
            LinkButton lnk = (LinkButton)Master.FindControl("LinkInscripCursado");
            lnk.CssClass = "nav-link active";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}