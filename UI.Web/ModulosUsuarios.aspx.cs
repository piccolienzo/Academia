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
    public partial class ModulosUsuarios : System.Web.UI.Page
    {
        private ModuloUsuarioLogic muLogic;

        protected ModuloUsuario Entity { get; set; }
        protected ModuloUsuarioLogic MULogic
        {
            get 
            { 
                if(muLogic == null)
                {
                    muLogic = new ModuloUsuarioLogic();
                }
                
                return muLogic;
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
            LinkButton lnk = (LinkButton)Master.FindControl("LinkModulosUsuarios");
            lnk.CssClass = "nav-link active";
        }
        protected void LoadGrid()
        {
            GridViewMU.DataBind();
        }
        protected void ClearForm()
        {
            TextBoxId.Text =
            TextBoxIdModulo.Text =
            TextBoxIdUsuario.Text = string.Empty;

            CheckBoxAlta.Checked = CheckBoxBaja.Checked =
            CheckBoxConsulta.Checked = CheckBoxModificacion.Checked = false; 
        }
        protected void MapearDeEntidad(int id)
        {
            ClearForm();
            Entity = MULogic.GetOne(id);

            TextBoxId.Text = Entity.ID.ToString();
            TextBoxIdModulo.Text = Entity.IdModulo.ToString();
            TextBoxIdUsuario.Text = Entity.IdUsuario.ToString();

            CheckBoxAlta.Checked = Entity.PermiteAlta;
            CheckBoxBaja.Checked = Entity.PermiteBaja;
            CheckBoxConsulta.Checked = Entity.PermiteConsulta;
            CheckBoxModificacion.Checked = Entity.PermiteModificacion;

        }

        protected void MapearAEntidad(ModuloUsuario MU)
        {
            //MU.ID = Convert.ToInt32(TextBoxId.Text);
            MU.IdModulo = Convert.ToInt32(TextBoxIdModulo.Text);
            MU.IdUsuario = Convert.ToInt32(TextBoxIdUsuario.Text);
            MU.PermiteAlta = CheckBoxAlta.Checked;
            MU.PermiteBaja = CheckBoxBaja.Checked;
            MU.PermiteModificacion = CheckBoxModificacion.Checked;
            MU.PermiteConsulta = CheckBoxConsulta.Checked;
        }
        protected void Guardar(ModuloUsuario MU,BusinessEntity.States estado, int? id)
        {
            if(id != null)
            {
                MU.ID = (int)id;
            }
            MU.State = estado;
            MULogic.Save(MU);
        }

        protected void BotonNuevo_Click(object sender, EventArgs e)
        {
            ClearForm();
            GridViewMU.SelectedIndex = -1;
            GridViewMU.Enabled = false;
            PanelAcciones.Visible = true;
            PanelBotonesGrilla.Visible = false;
            PanelABM.Visible = true;
            FormMode = FormModes.Alta;

            LabelModo.Text = FormMode.ToString();
        }

        protected void BotonEditar_Click(object sender, EventArgs e)
        {
            if (IsEntitySelected)
            {
                GridViewMU.Enabled = false;
                PanelAcciones.Visible = true;
                PanelBotonesGrilla.Visible = false;
                PanelABM.Visible = true;
                FormMode = FormModes.Modificacion;
                MapearDeEntidad(this.SelectedID);

                LabelModo.Text = FormMode.ToString();
            }
        }

        protected void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                FormMode = FormModes.Baja;
                MapearDeEntidad(this.SelectedID);
                GridViewMU.Enabled = false;
                PanelAcciones.Visible = true;
                PanelBotonesGrilla.Visible = true;
                PanelABM.Visible = true;

                LabelModo.Text = FormMode.ToString();

            }
        }

        protected void BotonAceptar_Click(object sender, EventArgs e)
        {
            switch (FormMode)
            {
                case FormModes.Alta:
                    Entity = new ModuloUsuario();
                    MapearAEntidad(Entity);
                    Guardar(Entity, BusinessEntity.States.New, null);
                    LoadGrid();
                    break;
                case FormModes.Baja:
                    Entity = new ModuloUsuario();
                    Guardar(Entity, BusinessEntity.States.Deleted, SelectedID);
                    LoadGrid();
                    break;
                case FormModes.Modificacion:
                    Entity = new ModuloUsuario();
                    MapearAEntidad(Entity);
                    Guardar(Entity, BusinessEntity.States.Modified, SelectedID);
                    LoadGrid();
                    break;
                default:
                    break;
            }
            GridViewMU.SelectedIndex = -1;
            GridViewMU.Enabled = true;
            PanelBotonesGrilla.Visible = true;
            PanelABM.Visible = false;
            PanelAcciones.Visible = false;
            ClearForm();
        }

        protected void BotonCancelar_Click(object sender, EventArgs e)
        {
            PanelBotonesGrilla.Visible = true;
            PanelAcciones.Visible = false;
            GridViewMU.Enabled = true;
            PanelABM.Visible = false;
            
            ClearForm();
        }

        protected void DropDownListIdUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                TextBoxIdUsuario.Text = DropDownListIdUsuario.SelectedValue;
            }
        }

        protected void DropDownListIdModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                TextBoxIdModulo.Text = DropDownListIdModulo.SelectedValue;
            }
        }

        protected void GridViewMU_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rowIndex = (int)this.GridViewMU.SelectedIndex;
            GridViewRow row = this.GridViewMU.Rows[rowIndex];
            this.SelectedID = Convert.ToInt32(((Label)row.FindControl("LabelId")).Text);
        }
    }
}