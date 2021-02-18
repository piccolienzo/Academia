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
    public partial class Especialidades : System.Web.UI.Page
    {
        private EspecialidadLogic especialidadLogic;
        private EspecialidadLogic EspecialidadLogic
        {
            get
            {
                if (especialidadLogic == null)
                {
                    especialidadLogic = new EspecialidadLogic();
                }
                return especialidadLogic;
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
        private Especialidad Entity { get; set; }
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
            LinkButton lnk = (LinkButton)Master.FindControl("LinkEspecialidades");
            lnk.CssClass = "nav-link active";
        }
        private void LoadGrid()
        {
            GridViewEspecialidades.DataBind();
        }
        private void MapearDeEntidad(int id, string text)
        {
            this.ClearForm();
            this.Entity = EspecialidadLogic.GetOne(id);

            TextBoxID.Text = Entity.ID.ToString();
            TextBoxDesc.Text = Entity.Descripcion;

        }
        private void ClearForm()
        {
            TextBoxID.Text = string.Empty;
            TextBoxDesc.Text = string.Empty;
        }
        
        private void MapearAEntidad(Especialidad esp)
        {
            
                esp.Descripcion = TextBoxDesc.Text;              
            
        }
        private void Eliminar(int id)
        {
            EspecialidadLogic.Delete(id);
        }
        private void Guardar(Especialidad esp)
        {
            EspecialidadLogic.Save(esp);
        }
        private void EnableForm(bool truefalse)
        {
            TextBoxID.Enabled = truefalse;
            TextBoxDesc.Enabled = truefalse;
        }



        protected void GridViewEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rowIndex = (int)this.GridViewEspecialidades.SelectedIndex;
            GridViewRow row = this.GridViewEspecialidades.Rows[rowIndex];
            this.SelectedID = Convert.ToInt32(((Label)row.FindControl("LabelId")).Text);
        }

        protected void BotonNuevo_Click(object sender, EventArgs e)
        {
            ClearForm();
            GridViewEspecialidades.SelectedIndex = -1;
            GridViewEspecialidades.Enabled = false;
            PanelAcciones.Visible = true;
            PanelABM.Visible = true;
            FormMode = FormModes.Alta;
            LabelModo.Text = FormMode.ToString();
            EnableForm(true);
        }

        protected void BotonEditar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                GridViewEspecialidades.Enabled = true;
                PanelAcciones.Visible = true;
                PanelBotonesGrilla.Visible = true;
                EnableForm(true);
                PanelABM.Visible = true;
                this.FormMode = FormModes.Modificacion;
                LabelModo.Text = FormMode.ToString();
                this.MapearDeEntidad(SelectedID,FormMode.ToString());
            }
        }

        protected void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.FormMode = FormModes.Baja;
                this.MapearDeEntidad(SelectedID,this.FormMode.ToString());
                GridViewEspecialidades.Enabled = false;
                PanelAcciones.Visible = true;
                PanelBotonesGrilla.Visible = true;
                PanelABM.Visible = true;
                LabelModo.Text = FormMode.ToString();
                EnableForm(true);
            }
        }

        protected void BotonAceptar_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Baja:
                    this.Eliminar(this.SelectedID);
                    LoadGrid();
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Especialidad();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.MapearAEntidad(this.Entity);
                    this.Guardar(this.Entity);
                    LoadGrid();
                    break;
                case FormModes.Alta:
                    this.Entity = new Especialidad();
                    this.MapearAEntidad(this.Entity);
                    this.Guardar(this.Entity);
                    LoadGrid();
                    break;
            }

            GridViewEspecialidades.SelectedIndex = -1;
            GridViewEspecialidades.Enabled = true;
            PanelBotonesGrilla.Visible = true;
            PanelABM.Visible = false;
            PanelAcciones.Visible = false;
        }

        protected void BotonCancelar_Click(object sender, EventArgs e)
        {
            PanelBotonesGrilla.Visible = true;
            PanelAcciones.Visible = false;
            GridViewEspecialidades.Enabled = true;
            PanelABM.Visible = false;
        }
    }
}