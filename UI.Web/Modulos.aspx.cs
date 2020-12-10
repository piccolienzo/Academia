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
    public partial class Modulos : System.Web.UI.Page
    {
        private ModuloLogic moduloLogic;
        private ModuloLogic ModuloLogic
        {
            get
            {
                if (moduloLogic == null)
                {
                    moduloLogic = new ModuloLogic();
                }
                return moduloLogic;
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
        private Modulo Entity { get; set; }
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
            LinkButton lnk = (LinkButton)Master.FindControl("LinkModulos");
            lnk.CssClass = "nav-link active";
        }
        private void LoadGrid()
        {
            GridViewModulo.DataBind();
        }
        private void MapearDeEntidad(int id, string text)
        {
            this.ClearForm();
            this.Entity = ModuloLogic.GetOne(id);

            TextBoxID.Text = Entity.ID.ToString();
            TextBoxDesc.Text = Entity.Descripcion;
            TextBoxEjecuta.Text = Entity.Ejecuta;

        }
        private void ClearForm()
        {
            TextBoxID.Text = string.Empty;
            TextBoxDesc.Text = string.Empty;
        }

        private void MapearAEntidad(Modulo mod)
        {

            mod.Descripcion = TextBoxDesc.Text;
            mod.Ejecuta = TextBoxEjecuta.Text;

        }
        private void Eliminar(int id)
        {
            this.ModuloLogic.Delete(id);
        }
        private void Guardar(Modulo mod)
        {
            this.ModuloLogic.Save(mod);
        }
        private void EnableForm(bool truefalse)
        {
            TextBoxID.Enabled = truefalse;
            TextBoxDesc.Enabled = truefalse;
        }



        protected void GridViewModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rowIndex = (int)this.GridViewModulo.SelectedIndex;
            GridViewRow row = this.GridViewModulo.Rows[rowIndex];
            this.SelectedID = Convert.ToInt32(((Label)row.FindControl("LabelId")).Text);
        }

        protected void BotonNuevo_Click(object sender, EventArgs e)
        {
            ClearForm();
            GridViewModulo.SelectedIndex = -1;
            GridViewModulo.Enabled = false;
            PanelAcciones.Visible = true;
            PanelABM.Visible = true;
            FormMode = FormModes.Alta;
            EnableForm(true);
        }

        protected void BotonEditar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                GridViewModulo.Enabled = true;
                PanelAcciones.Visible = true;
                PanelBotonesGrilla.Visible = true;
                EnableForm(true);
                PanelABM.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.MapearDeEntidad(SelectedID, FormMode.ToString());
            }
        }

        protected void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.FormMode = FormModes.Baja;
                this.MapearDeEntidad(SelectedID, this.FormMode.ToString());
                GridViewModulo.Enabled = false;
                PanelAcciones.Visible = true;
                PanelBotonesGrilla.Visible = true;
                PanelABM.Visible = true;
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
                    this.Entity = new Modulo();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.MapearAEntidad(this.Entity);
                    this.Guardar(this.Entity);
                    LoadGrid();
                    break;
                case FormModes.Alta:
                    this.Entity = new Modulo();
                    this.MapearAEntidad(this.Entity);
                    this.Guardar(this.Entity);
                    LoadGrid();
                    break;
            }

            GridViewModulo.SelectedIndex = -1;
            GridViewModulo.Enabled = true;
            PanelBotonesGrilla.Visible = true;
            PanelABM.Visible = false;
            PanelAcciones.Visible = false;
        }

        protected void BotonCancelar_Click(object sender, EventArgs e)
        {
            PanelBotonesGrilla.Visible = true;
            PanelAcciones.Visible = false;
            GridViewModulo.Enabled = true;
            PanelABM.Visible = false;
        }
    }
}
