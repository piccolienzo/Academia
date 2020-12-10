using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;
using System;  

namespace UI.Web
{
    public partial class Materias : System.Web.UI.Page
    {
        private MateriaLogic materiaLogic;

        public MateriaLogic MateriaLogic
        {
            get
            {
                if (materiaLogic == null)
                {
                    materiaLogic = new MateriaLogic();

                }
                return materiaLogic;
            }
        }
        public enum FormModes
        {
            Alta,Baja,Modificacion
        }
        public FormModes FormMode
        {
            get { return (FormModes)this.ViewState["FormMode"]; }
            set { this.ViewState["FormMode"] = value; }
        }
        private Materia Entity { get; set; }
        private int SelectedID
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
        private bool IsEntitySelected
        {
            get
            {
                return (this.SelectedID != 0);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                PanelABM.Visible = false;
                PanelAcciones.Visible = false;

                LoadGrid();
            }
            LinkButton lnk = (LinkButton)Master.FindControl("LinkMaterias");
            lnk.CssClass = "nav-link active";
        }

        protected void LoadGrid()
        {
            GridViewMaterias.DataBind();
        }

        protected void MapearDeEntidad(int id)
        {
            ClearForm();
            Entity = MateriaLogic.GetOne(id);

            TextBoxID.Text = Entity.ID.ToString();
            TextBoxDescripcion.Text = Entity.Descripcion;
            TextBoxHsSemanales.Text = Entity.HsSemanales.ToString();
            TextBoxHsTotales.Text = Entity.HsTotales.ToString();
            TextBoxIdPlan.Text = Entity.IdPlan.ToString();
            DropDownListIdPlan.SelectedValue = Entity.IdPlan.ToString();

        }
        protected void MapearAEntidad(Materia materia)
        {
            materia.Descripcion = TextBoxDescripcion.Text;
            materia.HsSemanales = Convert.ToInt32(TextBoxHsSemanales.Text);
            materia.HsTotales = Convert.ToInt32(TextBoxHsTotales.Text);
            materia.IdPlan = Convert.ToInt32(TextBoxIdPlan.Text);
             
        }
        protected void ClearForm()
        {
            TextBoxID.Text=TextBoxDescripcion.Text = TextBoxIdPlan.Text = string.Empty;          
            TextBoxHsSemanales.Text = TextBoxHsTotales.Text = string.Empty;
        }

        protected void EnableForm(bool truefalse)
        {
            TextBoxID.Enabled = 
            TextBoxDescripcion.Enabled = 
            TextBoxHsSemanales.Enabled =
            TextBoxHsTotales.Enabled = 
            TextBoxIdPlan.Enabled = 
            DropDownListIdPlan.Enabled = truefalse;
        }

        
        
        protected void Guardar(Materia materia, BusinessEntity.States estado, int? id)
        {
            if(id != null)
                materia.ID = (int)id;

            materia.State = estado;
            MateriaLogic.Save(materia);
        }

        protected void DropDownListIdPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                TextBoxIdPlan.Text = DropDownListIdPlan.SelectedValue.ToString();
            }
        }



        protected void BotonNuevo_Click(object sender, EventArgs e)
        {
            ClearForm();
            GridViewMaterias.SelectedIndex = -1;
            GridViewMaterias.Enabled = false;
            PanelAcciones.Visible = true;
            PanelBotonesGrilla.Visible = false;
            PanelABM.Visible = true;
            FormMode = FormModes.Alta;
            EnableForm(true);
        }

        protected void BotonEditar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                GridViewMaterias.Enabled = false;
                PanelAcciones.Visible = true;
                PanelBotonesGrilla.Visible = false;
                PanelABM.Visible = true;
                EnableForm(true);
                FormMode = FormModes.Modificacion;
                MapearDeEntidad(this.SelectedID);
            }
        }

        protected void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                FormMode = FormModes.Baja;
                MapearDeEntidad(this.SelectedID);
                GridViewMaterias.Enabled = false;
                PanelAcciones.Visible = true;
                PanelBotonesGrilla.Visible = true;
                PanelABM.Visible = true;
                this.EnableForm(false);
            }
        }

        protected void BotonAceptar_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Baja:                    
                    this.Entity = new Materia();                                       
                    this.Guardar(this.Entity, BusinessEntity.States.Deleted, SelectedID);
                    LoadGrid();
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Materia();                    
                    this.MapearAEntidad(this.Entity);
                    this.Guardar(this.Entity, BusinessEntity.States.Modified, SelectedID);
                    LoadGrid();
                    break;
                case FormModes.Alta:
                    this.Entity = new Materia();
                    this.MapearAEntidad(this.Entity);
                    this.Guardar(this.Entity, BusinessEntity.States.Modified, null);
                    LoadGrid();
                    break;

            }
            GridViewMaterias.SelectedIndex = -1;
            GridViewMaterias.Enabled = true;
            PanelBotonesGrilla.Visible = true;
            PanelABM.Visible = false;
        }
    

        protected void BotonCancelar_Click(object sender, EventArgs e)
        {
            PanelBotonesGrilla.Visible = true;
            PanelAcciones.Visible = false;
            GridViewMaterias.Enabled = true;
            PanelABM.Visible = false;
            ClearForm();
        }

        protected void GridViewMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rowIndex = (int)this.GridViewMaterias.SelectedIndex;
            GridViewRow row = this.GridViewMaterias.Rows[rowIndex];
            this.SelectedID = Convert.ToInt32(((Label)row.FindControl("LabelId")).Text);
        }
    }
}