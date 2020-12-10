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
    public partial class Planes : System.Web.UI.Page
    {
        private PlanLogic planLogic;
        private PlanLogic PlanLogic {
            get
            {
                if (planLogic == null)
                {
                    planLogic = new PlanLogic();
                }
                return planLogic;
            }

        }
        public enum FormModes
        {
            Alta,
            Baja,
            Modificacion
        }
        public FormModes FormMode
        {
            get { return (FormModes)this.ViewState["FormMode"]; }
            set { this.ViewState["FormMode"] = value; }
        }
        private Plan Entity { get; set; }
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
                this.PanelAccionesFormulario.Visible = false;
                LoadGrid();
            }
            LinkButton lnk = (LinkButton)Master.FindControl("LinkPlanes");
            lnk.CssClass = "nav-link active";


        }
        private void LoadGrid()
        {
            GridViewPlanes.DataBind();
        }


        private void MapearDeEntidad(int id,string lbltext)
        {
            this.ClearForm();
            this.Entity = PlanLogic.GetOne(id);

            TextBoxID.Text = Entity.ID.ToString() ;
            TextBoxDescripcion.Text = Entity.Descripcion;
            DropDownEsp.SelectedValue = Entity.IdEspecialidad.ToString();
            TextBoxIdEspecialidad.Text = DropDownEsp.SelectedValue;
            
        }
       
        private void MapearAEntidad(Plan plan)
        {           
            plan.Descripcion = TextBoxDescripcion.Text;
            plan.IdEspecialidad = Convert.ToInt32(TextBoxIdEspecialidad.Text);          
        }

        private void Eliminar(int idDel)
        {
            PlanLogic.Delete(idDel);
        }
        private void Guardar(Plan plan)
        {
            PlanLogic.Save(plan);
        }


        private void EnableForm(bool truefalse)
        {
            TextBoxDescripcion.Enabled = truefalse;
            //this.TextBoxID.Enabled = truefalse;
            TextBoxIdEspecialidad.Enabled = truefalse;
            DropDownEsp.Enabled = truefalse;
        }

        private void ClearForm()
        {
            TextBoxID.Text = string.Empty;
            TextBoxDescripcion.Text = string.Empty;
            DropDownEsp.SelectedIndex = -1;
            TextBoxIdEspecialidad.Text = string.Empty;

        }


        #region Botones
        protected void BotonAceptar_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Baja:
                    this.Eliminar(this.SelectedID);
                    LoadGrid();
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Plan();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.MapearAEntidad(this.Entity);
                    this.Guardar(this.Entity);
                    LoadGrid();
                    break;
                case FormModes.Alta:
                    this.Entity = new Plan();
                    this.MapearAEntidad(this.Entity);
                    this.Guardar(this.Entity);
                    LoadGrid();
                    break;

            }
            GridViewPlanes.SelectedIndex = -1;
            GridViewPlanes.Enabled = true;
            PanelBotonesGrilla.Visible = true;
            PanelABM.Visible = false;
        }

        

        protected void BotonNuevo_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            this.GridViewPlanes.SelectedIndex = -1;
            this.GridViewPlanes.Enabled = false;
            this.PanelAccionesFormulario.Visible = true;
            this.PanelBotonesGrilla.Visible = false;
            this.PanelABM.Visible = true;
            this.FormMode = FormModes.Alta;
            this.EnableForm(true);
        }

        protected void BotonEditar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                GridViewPlanes.Enabled = false;
                PanelAccionesFormulario.Visible = true;
                PanelBotonesGrilla.Visible = false;
                PanelABM.Visible = true;
                this.EnableForm(true);
                this.FormMode = FormModes.Modificacion;
                this.MapearDeEntidad(this.SelectedID, this.FormMode.ToString());
            }
        }

        protected void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.FormMode = FormModes.Baja;
                this.MapearDeEntidad(this.SelectedID, this.FormMode.ToString());
                GridViewPlanes.Enabled = false;
                PanelAccionesFormulario.Visible = true;
                PanelBotonesGrilla.Visible = true;
                PanelABM.Visible = true;
                this.EnableForm(false);
            }
        }
        protected void BotonCancelar_Click(object sender, EventArgs e)
        {
            
            PanelBotonesGrilla.Visible = true;
            PanelAccionesFormulario.Visible = false;
            GridViewPlanes.Enabled = true;
            PanelABM.Visible = false;
            ClearForm();

        }

        #endregion

        protected void GridViewPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rowIndex = (int)this.GridViewPlanes.SelectedIndex;
            GridViewRow row = this.GridViewPlanes.Rows[rowIndex];
            this.SelectedID = Convert.ToInt32(((Label)row.FindControl("LabelId")).Text);
        }

        protected void DropDownEsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            { TextBoxIdEspecialidad.Text = DropDownEsp.SelectedValue.ToString(); }
        }
    }
}