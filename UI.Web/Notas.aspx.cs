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
        protected int SelectedIDCurso { get; set; }
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
                LabelDocente.Text = persona.Apellido + " " + persona.Nombre;
                PanelNotas.Visible = false;

            }





            LinkButton lnk = (LinkButton)Master.FindControl("LinkInscripCursado");
            lnk.CssClass = "nav-link active";
        }

        



        protected void BotonGuardarNotas_Click(object sender, EventArgs e)
        {
            if(Page.IsPostBack)
            {
                List<Util.ListaParaNotas> list = new List<Util.ListaParaNotas>();

                foreach (GridViewRow row in GridView1.Rows)
                {
                    int id = Convert.ToInt32(((Label)row.FindControl("LabelId")).Text);
                    int nota = Convert.ToInt32(((TextBox)row.FindControl("TextBoxNotaGV")).Text);
                    string condicion = ((TextBox)row.FindControl("TextBoxCondicionGV")).Text;
                    Util.ListaParaNotas li = new Util.ListaParaNotas
                    {
                        IDInscripcion = id,
                        Nota = nota,
                        Condicion = condicion

                    };
                    list.Add(li);


                }

                AlumnoInscripcionLogic logic = new AlumnoInscripcionLogic();

                foreach (Util.ListaParaNotas l in list)
                {
                    AlumnoInscripcion aluins = logic.GetOne(l.IDInscripcion);
                    aluins.Nota = l.Nota;
                    aluins.Condicion = l.Condicion;
                    aluins.State = BusinessEntity.States.Modified;
                    logic.Save(aluins);
                }
                SelectedIDCurso = 0;
                GridView1.DataBind();

                PanelNotas.Visible = false;
                PanelSeleccion.Enabled = true;
            }
        }



            //Buscar
        protected void Unnamed2_Click(object sender, EventArgs e) 
        {
            if(SelectedIDCurso == 0 || SelectedIDCurso == null)
            {
                if(DropDownList1.Items.Count > 0)
                {
                    SelectedIDCurso = Convert.ToInt32(DropDownList1.SelectedValue);
                    Session["idcurso"] = SelectedIDCurso;

                    PanelNotas.Visible = true;
                    PanelSeleccion.Enabled = false;
                    GridView1.DataBind();

                }
            }
            else
            {
                PanelNotas.Visible = true;
                PanelSeleccion.Enabled = false;
                GridView1.DataBind();


            }
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIDCurso = Convert.ToInt32(DropDownList1.SelectedValue);
            Session["idcurso"] = SelectedIDCurso;
            
        }

        protected void BotonCancelar_Click(object sender, EventArgs e)
        {
            PanelNotas.Visible = false;
            PanelSeleccion.Enabled = true;
            Page.Response.Redirect("~/Notas.aspx");
        }
    }
}