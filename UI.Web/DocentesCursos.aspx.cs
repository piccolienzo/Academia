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
    public partial class DocentesCursos : System.Web.UI.Page
    {
        public Business.Entities.DocenteCurso Entity { get; set; }
        private DocenteCursoLogic docenteCursoLogic;
        protected DocenteCursoLogic DocenteCursoLogic
        {
            get
            {
                if (docenteCursoLogic == null)
                {
                    docenteCursoLogic = new DocenteCursoLogic();
                }
                return docenteCursoLogic;
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

            LinkButton lnk = (LinkButton)Master.FindControl("LinkDocentesCursos");
            lnk.CssClass = "nav-link active";
        }
        protected void LoadGrid()
        {
            GridViewDocentesCursos.DataBind();
        }

        protected void ClearForm()
        {
            TextBoxCurso.Text =
            TextBoxCargo.Text =
            TextBoxDocente.Text = string.Empty;
            DropDownListCursos.SelectedIndex =
            DropDownListCargos.SelectedIndex =
            DropDownListDocentes.SelectedIndex = -1;
        }

        protected void MapearDeEntidad(int id)
        {
            ClearForm();
            Entity = DocenteCursoLogic.GetOne(id);

            TextBoxCurso.Text = Entity.IdCurso.ToString();
            DropDownListCursos.SelectedValue = Entity.IdCurso.ToString();
            TextBoxCargo.Text = ((int)Entity.Cargo).ToString();
            DropDownListCargos.SelectedValue = ((int)Entity.Cargo).ToString();
            TextBoxDocente.Text = Entity.IdDocente.ToString();
            DropDownListDocentes.SelectedValue = Entity.IdDocente.ToString();

        }

        protected void MapearAEntidad(Business.Entities.DocenteCurso docc)
        {
            docc.IdCurso = Convert.ToInt32(DropDownListCursos.SelectedValue);
            docc.IdDocente = Convert.ToInt32(DropDownListDocentes.SelectedValue);
            docc.Cargo = (DocenteCurso.TiposCargos)Convert.ToInt32(DropDownListCargos.SelectedValue);

        }

        protected void Guardar(DocenteCurso docc, BusinessEntity.States estado, int? id)
        {
            if (id != null)
            {
                docc.ID = (int)id;
            }
            docc.State = estado;
            DocenteCursoLogic.Save(docc);
        }

        protected void DropDownListCargos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                TextBoxCargo.Text = DropDownListCursos.SelectedValue;
            }
        }

        protected void DropDownListDocentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                TextBoxDocente.Text = DropDownListDocentes.SelectedValue;
            }
        }

        protected void DropDownListCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                TextBoxCurso.Text = DropDownListCursos.SelectedValue;
            }
        }

        protected void BotonNuevo_Click(object sender, EventArgs e)
        {
            ClearForm();
            GridViewDocentesCursos.SelectedIndex = -1;
            GridViewDocentesCursos.Enabled = false;
            PanelAcciones.Visible = true;
            PanelBotonesGrilla.Visible = false;
            PanelABM.Visible = true;
            FormMode = FormModes.Alta;
        }

        protected void BotonEditar_Click(object sender, EventArgs e)
        {
            if (IsEntitySelected)
            {
                GridViewDocentesCursos.Enabled = false;
                PanelAcciones.Visible = true;
                PanelBotonesGrilla.Visible = false;
                PanelABM.Visible = true;
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
                GridViewDocentesCursos.Enabled = false;
                PanelAcciones.Visible = true;
                PanelBotonesGrilla.Visible = true;
                PanelABM.Visible = true;

            }
        }

        protected void BotonCancelar_Click(object sender, EventArgs e)
        {
            PanelBotonesGrilla.Visible = true;
            PanelAcciones.Visible = false;
            GridViewDocentesCursos.Enabled = true;
            PanelABM.Visible = false;
            PanelAcciones.Visible = false;
            ClearForm();
        }

        protected void BotonAceptar_Click(object sender, EventArgs e)
        {
            switch (FormMode)
            {
                case FormModes.Alta:
                    Entity = new Business.Entities.DocenteCurso();
                    MapearAEntidad(Entity);
                    Guardar(Entity, BusinessEntity.States.New, null);
                    LoadGrid();
                    break;
                case FormModes.Baja:
                    Entity = new Business.Entities.DocenteCurso();
                    Guardar(Entity, BusinessEntity.States.Deleted, SelectedID);
                    LoadGrid();
                    break;
                case FormModes.Modificacion:
                    Entity = new Business.Entities.DocenteCurso();
                    MapearAEntidad(Entity);
                    Guardar(Entity, BusinessEntity.States.Modified, SelectedID);
                    LoadGrid();
                    break;
                default:
                    break;
            }
            GridViewDocentesCursos.SelectedIndex = -1;
            GridViewDocentesCursos.Enabled = true;
            PanelBotonesGrilla.Visible = true;
            PanelABM.Visible = false;
            PanelAcciones.Visible = false;
        }

        protected void GridViewDocentesCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rowIndex = (int)this.GridViewDocentesCursos.SelectedIndex;
            GridViewRow row = this.GridViewDocentesCursos.Rows[rowIndex];
            this.SelectedID = Convert.ToInt32(((Label)row.FindControl("LabelId")).Text);
        }
    }
}