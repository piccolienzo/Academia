using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Usuario"] != null){
                this.UsuarioOpciones.Text = ((Usuario)Session["Usuario"]).NombreUsuario;
            }
            
        }

        protected void HomeLinkNav_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Home.aspx");
        }

        protected void BotonLogOut_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Page.Response.Redirect("~/Login.aspx");
        }
      

        protected void LinkUsuarios_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Usuarios.aspx");
        }

        protected void BotonInscripCursado_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/InscripcionCursado.aspx");
        }

        protected void LinkPlanes_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Planes.aspx");
        }

        protected void LinkEspecialidades_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Especialidades.aspx");
        }

        protected void LinkModulos_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Modulos.aspx");
        }

        protected void LinkComisiones_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Comisiones.aspx");
        }

        protected void LinkMaterias_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Materias.aspx");
        }

        protected void LinkCursos_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Cursos.aspx");
        }

        protected void LinkDocentesCursos_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/DocentesCursos.aspx");
        }

        protected void LinkModulosUsuarios_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/ModulosUsuarios.aspx");
        }

        protected void LinkPersonas_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Personas.aspx");
        }

        protected void LinkNav_Click(object sender, EventArgs e)
        {

        }

        protected void LinkReportes_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Reportes.aspx");
        }

        //public void UnactiveAll()

    }
}