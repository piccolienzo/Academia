using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
using Business.Entities;
using System.Globalization;

namespace UI.Web
{
    public partial class Personas : System.Web.UI.Page
    {
        public Business.Entities.Personas Entity { get; set; }
        private PersonaLogic personaLogic;
        protected PersonaLogic PersonaLogic
        {
            get
            {
                if (personaLogic == null)
                {
                    personaLogic = new PersonaLogic();
                }
                return personaLogic;
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
            
            LinkButton lnk = (LinkButton)Master.FindControl("LinkPersonas");
            lnk.CssClass = "nav-link active";
        }
        protected void LoadGrid()
        {
            GridViewPersonas.DataBind();
        }

        protected void MapearDeEntidad(int id)
        {
            ClearForm();
            Entity = PersonaLogic.GetOne(id);

            TextBoxId.Text = Entity.ID.ToString();
            TextBoxApellido.Text = Entity.Apellido;
            TextBoxNombre.Text = Entity.Nombre;
            TextBoxFechaNacimiento.Text = ((DateTime)Entity.FechaNacimiento).ToShortDateString();


            TextBoxEmail.Text = Entity.Email;
            TextBoxDireccion.Text = Entity.Direccion;
            TextBoxTelefono.Text = Entity.Telefono;
            DropDownTipoPersona.SelectedValue = ((int)Entity.TipoPersona).ToString();
            //VER TIPO PERSONA
            DropDownIdPlan.SelectedValue = Entity.IdPlan.ToString();
            TextBoxIdPlan.Text = Entity.IdPlan.ToString();
            TextBoxLegajo.Text = Entity.Legajo.ToString();
        }

        protected void MapearAEntidad(Business.Entities.Personas persona)
        {
            persona.Apellido = TextBoxApellido.Text;
            persona.Direccion = TextBoxDireccion.Text;
            persona.Email = TextBoxEmail.Text;

            DateTime d = Convert.ToDateTime(TextBoxFechaNacimiento.Text);
            //Convert.ToDateTime(TextBoxFechaNac.Text);
            persona.FechaNacimiento = d;
            persona.IdPlan = Convert.ToInt32(TextBoxIdPlan.Text);
            persona.Legajo = Convert.ToInt32(TextBoxLegajo.Text);
            persona.Nombre = TextBoxNombre.Text;
            persona.Telefono = TextBoxTelefono.Text;
            persona.TipoPersona = (Business.Entities.Personas.TiposPersonas)
                Enum.Parse(typeof(Business.Entities.Personas.TiposPersonas), 
                DropDownTipoPersona.SelectedValue, true);
            

            
        }

        protected void ClearForm()
        {
            TextBoxId.Text =
            TextBoxApellido.Text =
            TextBoxNombre.Text =
            TextBoxFechaNacimiento.Text =
            TextBoxEmail.Text =
            TextBoxDireccion.Text =
            TextBoxTelefono.Text =
            TextBoxIdPlan.Text =
            TextBoxLegajo.Text = string.Empty;

            DropDownTipoPersona.SelectedIndex =
            //VER TIPO PERSONA
            DropDownIdPlan.SelectedIndex = -1;
        }

        protected void Guardar(Business.Entities.Personas persona, BusinessEntity.States estado, int? id)
        {
            if (id != null)
            {
                persona.ID = (int)id;
            }
            persona.State = estado;
            PersonaLogic.Save(persona);

        }

        protected void BotonAceptar_Click(object sender, EventArgs e)
        {
            switch (FormMode)
            {
                case FormModes.Alta:
                    Entity = new Business.Entities.Personas();
                    MapearAEntidad(Entity);
                    Guardar(Entity, BusinessEntity.States.New, null);
                    LoadGrid();
                    break;
                case FormModes.Baja:
                    Entity = new Business.Entities.Personas();
                    Guardar(Entity, BusinessEntity.States.Deleted, SelectedID);
                    LoadGrid();
                    break;
                case FormModes.Modificacion:
                    Entity = new Business.Entities.Personas();
                    MapearAEntidad(Entity);
                    Guardar(Entity, BusinessEntity.States.Modified, SelectedID);
                    LoadGrid();
                    break;
                default:
                    break;
            }
            GridViewPersonas.SelectedIndex = -1;
            GridViewPersonas.Enabled = true;
            PanelBotonesGrilla.Visible = true;
            PanelABM.Visible = false;
            PanelAcciones.Visible = false;
        }

        protected void BotonCancelar_Click(object sender, EventArgs e)
        {
            PanelBotonesGrilla.Visible = true;
            PanelAcciones.Visible = false;
            GridViewPersonas.Enabled = true;
            PanelABM.Visible = false;
            PanelAcciones.Visible = false;
            ClearForm();
        }

        protected void BotonNuevo_Click(object sender, EventArgs e)
        {
            ClearForm();
            GridViewPersonas.SelectedIndex = -1;
            GridViewPersonas.Enabled = false;
            PanelAcciones.Visible = true;
            PanelBotonesGrilla.Visible = false;
            PanelABM.Visible = true;
            FormMode = FormModes.Alta;
        }

        protected void BotonEditar_Click(object sender, EventArgs e)
        {
            if (IsEntitySelected)
            {
                GridViewPersonas.Enabled = false;
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
                GridViewPersonas.Enabled = false;
                PanelAcciones.Visible = true;
                PanelBotonesGrilla.Visible = true;
                PanelABM.Visible = true;

            }
        }

        protected void GridViewPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rowIndex = (int)this.GridViewPersonas.SelectedIndex;
            GridViewRow row = this.GridViewPersonas.Rows[rowIndex];
            this.SelectedID = Convert.ToInt32(((Label)row.FindControl("LabelId")).Text);
        }

        protected void DropDownIdPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                TextBoxIdPlan.Text = DropDownIdPlan.SelectedValue.ToString();
            }
        }

        protected void DropDownTipoPersona_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}