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
    public partial class Notas : System.Web.UI.Page
    {
        protected int IDDocente { get; set; }
        protected int SelectedID { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                Page.Response.Redirect("~/Login.aspx");
            }
            LinkButton lnk = (LinkButton)Master.FindControl("LinkInscripCursado");
            lnk.CssClass = "nav-link active";

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
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rowIndex = (int)this.GridView1.SelectedIndex;
            GridViewRow row = this.GridView1.Rows[rowIndex];

            MapearAlumno( Convert.ToInt32(((Label)row.FindControl("LabelId")).Text) );
        }

        protected void MapearAlumno(int id)
        {
            SelectedID = id;
            AlumnoInscripcion alumnoInscripcion = new AlumnoInscripcionLogic().GetOne(id);

            TextBoxCondicion.Text = alumnoInscripcion.Condicion;
            TextBoxNota.Text = alumnoInscripcion.Nota.ToString();
            PanelRegistro.Visible = true;
        }

        protected void BotonAceptar_Click(object sender, EventArgs e)
        {
            AlumnoInscripcion alumnoInscripcion = new AlumnoInscripcionLogic().GetOne(SelectedID);

            alumnoInscripcion.Nota = Convert.ToInt32(TextBoxNota.Text);
            alumnoInscripcion.Condicion = TextBoxCondicion.Text;
            alumnoInscripcion.State = BusinessEntity.States.Modified;
            Guardar(alumnoInscripcion);

            PanelRegistro.Visible = false;
            TextBoxCondicion.Text =
            TextBoxNota.Text = string.Empty;

            GridView1.DataBind();
        }

        protected void Guardar(AlumnoInscripcion alumnoInscripcion)
        {
            AlumnoInscripcionLogic ail = new AlumnoInscripcionLogic();
            ail.Save(alumnoInscripcion);
        }

        protected void BotonCancelar_Click(object sender, EventArgs e)
        {
            PanelRegistro.Visible = false;
            TextBoxCondicion.Text = 
            TextBoxNota.Text = string.Empty;
            GridView1.DataBind();
        }
    }
}