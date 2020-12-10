using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
using Business.Entities;



namespace UI.Web
{
    public partial class Cursos : System.Web.UI.Page
    {
        private CursoLogic cursosLogic;
        protected Curso Entity { get; set; }
        protected CursoLogic CursoLogic
        {
            get 
            { 
                if (cursosLogic == null)
                {
                    cursosLogic = new CursoLogic();
                }
                return cursosLogic; 
            }
            
        }
        
        protected int SelectedID
        {
            get
            {
                if (this.ViewState["SelectedID"] != null)
                {
                    return (int)this.ViewState["SelectedID"];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                this.ViewState["SelectedID"] = value;
            }
        }
        protected bool IsEntitySelected
        {
            get
            {
                return (this.SelectedID != 0);
            }
        }
      
        protected enum FormModes
        {
            Alta, Baja, Modificacion
        }
        protected FormModes FormMode
        {
            get { return (FormModes)this.ViewState["FormMode"]; }
            set { this.ViewState["FormMode"] = value; }
        }
        
        


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                PanelABM.Visible = false;
                PanelAcciones.Visible = false;
                LoadGrid();
            }
            LinkButton lnk = (LinkButton)Master.FindControl("LinkCursos");
            lnk.CssClass = "nav-link active";
        }

        protected void LoadGrid()
        {
            GridViewCursos.DataBind();
        }

        protected void MapearDeEntidad(int id)
        {
            ClearForm();
            Entity = CursoLogic.GetOne(id);

            TextBoxId.Text = Entity.ID.ToString();
            
            TextBoxAnio.Text = Entity.AñoCalendario.ToString();
            TextBoxCupo.Text = Entity.Cupo.ToString();

            TextBoxIdCom.Text = Entity.IdComision.ToString();
            TextBoxIdMateria.Text = Entity.IdMateria.ToString();

            DropDownIdComision.SelectedValue = Entity.IdComision.ToString();
            DropDownIdMateria.SelectedValue = Entity.IdMateria.ToString();

        }

        protected void MapearAEntidad(Curso curso)
        {
            
            curso.IdComision = Convert.ToInt32(TextBoxIdCom.Text);
            curso.IdMateria = Convert.ToInt32(TextBoxIdMateria.Text);
            curso.AñoCalendario = Convert.ToInt32(TextBoxAnio.Text);
            curso.Cupo = Convert.ToInt32(TextBoxCupo.Text);
        }



        protected void ClearForm()
        {
            TextBoxId.Text =
            
            TextBoxAnio.Text =
            TextBoxCupo.Text =
            TextBoxIdCom.Text =
            TextBoxIdMateria.Text = string.Empty;

            DropDownIdComision.SelectedIndex =
            DropDownIdMateria.SelectedIndex = -1;
        }

        protected void Guardar(Curso curso,BusinessEntity.States estado, int? id)
        {
            if (id != null)
            {
                curso.ID = (int)id;
            }
            curso.State = estado;
            CursoLogic.Save(curso);
        }


        protected void BotonCancelar_Click(object sender, EventArgs e)
        {
            PanelBotonesGrilla.Visible = true;
            PanelAcciones.Visible = false;
            GridViewCursos.Enabled = true;
            PanelABM.Visible = false;
            ClearForm();
        }

        protected void BotonAceptar_Click(object sender, EventArgs e)
        {
            switch (FormMode)
            {
                case FormModes.Alta:
                    Entity = new Curso();
                    MapearAEntidad(Entity);
                    Guardar(Entity, BusinessEntity.States.New, null);
                    LoadGrid();
                    break;
                case FormModes.Baja:
                    Entity = new Curso();
                    Guardar(Entity, BusinessEntity.States.Deleted, SelectedID);
                    LoadGrid();
                    break;
                case FormModes.Modificacion:
                    Entity = new Curso();
                    MapearAEntidad(Entity);
                    Guardar(Entity, BusinessEntity.States.Modified, SelectedID);
                    LoadGrid();
                    break;
                default:
                    break;
            }
            GridViewCursos.SelectedIndex = -1;
            GridViewCursos.Enabled = true;
            PanelBotonesGrilla.Visible = true;
            PanelABM.Visible = false;
            PanelAcciones.Visible = false;
        }

        protected void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                FormMode = FormModes.Baja;
                MapearDeEntidad(this.SelectedID);
                GridViewCursos.Enabled = false;
                PanelAcciones.Visible = true;
                PanelBotonesGrilla.Visible = true;
                PanelABM.Visible = true;
                
            }
        }

        protected void BotonEditar_Click(object sender, EventArgs e)
        {
            if (IsEntitySelected)
            {
                GridViewCursos.Enabled = false;
                PanelAcciones.Visible = true;
                PanelBotonesGrilla.Visible = false;
                PanelABM.Visible = true;
                FormMode = FormModes.Modificacion;
                MapearDeEntidad(this.SelectedID);
            }
        }

        protected void BotonNuevo_Click(object sender, EventArgs e)
        {
            ClearForm();
            GridViewCursos.SelectedIndex = -1;
            GridViewCursos.Enabled = false;
            PanelAcciones.Visible = true;
            PanelBotonesGrilla.Visible = false;
            PanelABM.Visible = true;
            FormMode = FormModes.Alta;

        }

        protected void DropDownIdComision_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                TextBoxIdCom.Text = DropDownIdComision.SelectedValue.ToString();
            }
        }

        protected void DropDownIdMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                TextBoxIdMateria.Text = DropDownIdMateria.SelectedValue.ToString();
            }
        }

        protected void GridViewCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rowIndex = (int)this.GridViewCursos.SelectedIndex;
            GridViewRow row = this.GridViewCursos.Rows[rowIndex];
            this.SelectedID = Convert.ToInt32(((Label)row.FindControl("LabelId")).Text);
        }
    }
}

