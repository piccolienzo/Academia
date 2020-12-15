using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class InscripcionCursado : System.Web.UI.Page
    {

        protected int IdPersona { get; set; }
        private AlumnoInscripcionLogic alumInscripLogic;

        public AlumnoInscripcionLogic AlumnoInscripcionLogic
        {
            get { 
                if(alumInscripLogic == null)
                {
                    alumInscripLogic = new AlumnoInscripcionLogic();
                }
                return alumInscripLogic; }
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                Page.Response.Redirect("~/Login.aspx");
            }

            if (!Page.IsPostBack)
            {
                PanelErrorCupos.Visible = false;
                GridViewInscripciones.DataBind();

            }
            LinkButton lnk = (LinkButton)Master.FindControl("LinkInscripCursado");
            lnk.CssClass = "nav-link active";

            Usuario usuario = (Usuario)Session["Usuario"];
            Business.Entities.Persona persona = new PersonaLogic().GetOne((int)usuario.Id_Persona);

            if ((int)persona.TipoPersona != ((int)Business.Entities.Persona.TiposPersonas.Alumno))
            {
                Page.Response.Redirect("~/Home.aspx");
            }
            else
            {
                IdPersona = persona.ID;
                TextBoxIdPersona.Text = persona.ID.ToString();
                //IdPersona = Convert.ToInt32(TextBoxIdPersona.Text);
                Session["id"] = persona.ID;
            }
        }


        protected void BotonAceptar_Click(object sender, EventArgs e)
        {
            int idCurso = Convert.ToInt32(DropDownListMaterias.SelectedValue);
           
            CursoLogic cl = new CursoLogic();

            if (cl.GetOne(idCurso).Cupo < 1)
            {
                Inscribir(idCurso,IdPersona,"Inscripto");
                ActualizarCupos(idCurso);
            }
            else
            {
                PanelErrorCupos.Visible = true;
                PanelInscripcion.Visible = false;
            }
            GridViewInscripciones.DataBind();


        }

        protected void ActualizarCupos(int idCurso)
        {
            CursoLogic cursoupdate = new CursoLogic();
            Curso curso = cursoupdate.GetOne(idCurso);

            curso.Cupo-=1;
            curso.State = BusinessEntity.States.Modified;
            cursoupdate.Save(curso);

        }

        protected void Inscribir(int idCurso,int idAlumno,string estado)
        {
            AlumnoInscripcion alumnoInscripcion = new AlumnoInscripcion
            {
                IdAlumno = idAlumno,
                IdCurso = idCurso,
                Condicion = estado,
                Nota = default
           };
            AlumnoInscripcionLogic.Save(alumnoInscripcion);
        }

        protected void BotonReload_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/InscripcionCursado.aspx");
        }

        protected void GridViewInscripciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rowIndex = (int)this.GridViewInscripciones.SelectedIndex;
            GridViewRow row = this.GridViewInscripciones.Rows[rowIndex];
            int id = Convert.ToInt32(((Label)row.FindControl("LabelId")).Text);
            AlumnoInscripcionLogic.Delete(id);
            GridViewInscripciones.DataBind();

        }
    }

       

}