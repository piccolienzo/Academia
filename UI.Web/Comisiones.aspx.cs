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
    public partial class Comisiones : System.Web.UI.Page
    {
        private ComisionLogic comisionLogic;
        private ComisionLogic ComisionLogic
        {
            get
            {
                if (comisionLogic == null)
                {
                    comisionLogic = new ComisionLogic();
                }
                return comisionLogic;
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
        private Comision Entity { get; set; }
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
            LinkButton lnk = (LinkButton)Master.FindControl("LinkComisiones");
            lnk.CssClass = "nav-link active";
        }
        private void LoadGrid()
        {
            GridViewComisiones.DataBind();
        }
        private void MapearDeEntidad(int id, string text)
        {
            this.ClearForm();
            this.Entity = ComisionLogic.GetOne(id);

            TextBoxID.Text = Entity.ID.ToString();
            TextBoxDesc.Text = Entity.Descripcion;
            TextBoxAesp.Text = Entity.AñoEspecialidad.ToString();
            DropDownListPlan.SelectedValue = Entity.IdPlan.ToString();
            TextBoxIdPlan.Text = DropDownListPlan.SelectedValue;


        }
        private void ClearForm()
        {
            TextBoxID.Text = string.Empty;
            TextBoxDesc.Text = string.Empty;
            TextBoxAesp.Text = string.Empty;
            DropDownListPlan.SelectedIndex = -1;
            TextBoxIdPlan.Text = string.Empty;
        }

        private void MapearAEntidad(Comision com)
        {

            com.Descripcion = TextBoxDesc.Text;
            com.AñoEspecialidad = Convert.ToInt32(TextBoxAesp.Text);
            com.IdPlan = Convert.ToInt32(TextBoxIdPlan.Text);

        }
        private void Eliminar(int id)
        {
            this.ComisionLogic.Delete(id);
        }
        private void Guardar(Comision com)
        {
            this.ComisionLogic.Save(com);
        }
        private void EnableForm(bool truefalse)
        {
            TextBoxID.Enabled = truefalse;
            TextBoxDesc.Enabled = truefalse;
            TextBoxAesp.Enabled = truefalse;
            DropDownListPlan.Enabled = truefalse;
            TextBoxIdPlan.Enabled = truefalse;
        }



        protected void GridViewComisiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rowIndex = (int)this.GridViewComisiones.SelectedIndex;
            GridViewRow row = this.GridViewComisiones.Rows[rowIndex];
            this.SelectedID = Convert.ToInt32(((Label)row.FindControl("LabelId")).Text);
        }

        protected void BotonNuevo_Click(object sender, EventArgs e)
        {
            ClearForm();
            GridViewComisiones.SelectedIndex = -1;
            GridViewComisiones.Enabled = false;
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
                GridViewComisiones.Enabled = true;
                PanelAcciones.Visible = true;
                PanelBotonesGrilla.Visible = true;
                EnableForm(true);
                PanelABM.Visible = true;
                this.FormMode = FormModes.Modificacion;
                LabelModo.Text = FormMode.ToString();
                this.MapearDeEntidad(SelectedID, FormMode.ToString());
            }
        }

        protected void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.FormMode = FormModes.Baja;
                this.MapearDeEntidad(SelectedID, this.FormMode.ToString());
                GridViewComisiones.Enabled = false;
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
                    this.Entity = new Comision();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.MapearAEntidad(this.Entity);
                    this.Guardar(this.Entity);
                    LoadGrid();
                    break;
                case FormModes.Alta:
                    this.Entity = new Comision();
                    this.MapearAEntidad(this.Entity);
                    this.Guardar(this.Entity);
                    LoadGrid();
                    break;
            }

            GridViewComisiones.SelectedIndex = -1;
            GridViewComisiones.Enabled = true;
            PanelBotonesGrilla.Visible = true;
            PanelABM.Visible = false;
            PanelAcciones.Visible = false;

        }

        protected void BotonCancelar_Click(object sender, EventArgs e)
        {
            PanelBotonesGrilla.Visible = true;
            PanelAcciones.Visible = false;
            GridViewComisiones.Enabled = true;
            PanelABM.Visible = false;
        }

        protected void DropDownListPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (Page.IsPostBack)
                { TextBoxIdPlan.Text = DropDownListPlan.SelectedValue.ToString(); }
            }
        }
    }
}