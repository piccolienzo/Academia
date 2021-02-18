using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
using Business.Entities;
using System.Web.UI.HtmlControls;

namespace UI.Web
{
    public partial class Usuarios : System.Web.UI.Page
    {
        private UsuarioLogic usuarioLogic;
        private UsuarioLogic UsuarioLogicUsuarios
        {
            get
            {
                if (usuarioLogic == null)
                {
                    usuarioLogic = new UsuarioLogic();
                }
                return usuarioLogic;
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

        private Usuario Entity { get; set; }

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
                this.PanelABM.Visible = false;
                this.PanelAccionesFormulario.Visible = false;
            LoadGrid();

            }
            //HtmlGenericControl li = (HtmlGenericControl)Master?.FindControl("link11");
            //li.Visible = false;
            
            LinkButton lnk = (LinkButton)Master.FindControl("LinkUsuarios");
            lnk.CssClass = "nav-link active";
            

        }

        private void LoadGrid()
        {
            
            this.GridViewUsuarios.DataBind();
        }

        private void MapearDeUsuario(int id, string labelText)
        {
            
            this.ClearForm();
            this.Entity = UsuarioLogicUsuarios.GetOne(id);

            this.TextBoxNombre.Text = this.Entity.Nombre;
            this.TextBoxApellido.Text = this.Entity.Apellido;
            this.TextBoxEmail.Text = this.Entity.Email;
            this.CheckBoxHabilitado.Checked = this.Entity.Habilitado;
            this.TextBoxNombreUsuario.Text = this.Entity.NombreUsuario;
            if (this.FormMode == FormModes.Baja) 
            { 
                this.TextBoxClave.Text = this.Entity.Clave;
                this.TextBoxConfirmarClave.Text = (string)this.Entity.Clave; 
            }
            TextBoxIDPersona.Text = Entity.Id_Persona.ToString();
            DropDownIDPersona.SelectedValue = Entity.Id_Persona.ToString();

        }
        private void MapearAUsuarioEntity(Usuario usuario)
        {
            usuario.Nombre = this.TextBoxNombre.Text;
            usuario.Apellido = this.TextBoxApellido.Text;
            usuario.Email = this.TextBoxEmail.Text;
            usuario.NombreUsuario = this.TextBoxNombreUsuario.Text;
            usuario.Clave = this.TextBoxClave.Text;
            usuario.Habilitado = this.CheckBoxHabilitado.Checked;
            usuario.Id_Persona = Convert.ToInt32(TextBoxIDPersona.Text);

        }

        private void GuardarUsuario(Usuario usuario)
        {
            
            this.UsuarioLogicUsuarios.Save(usuario);
        }

        private void EliminarUsuario (int idUsuarioDel)
        {
            this.UsuarioLogicUsuarios.Delete(idUsuarioDel);
        }

        protected void GridViewUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

            int rowIndex = (int)this.GridViewUsuarios.SelectedIndex;
            GridViewRow row = this.GridViewUsuarios.Rows[rowIndex];
            int id = Convert.ToInt32(((Label)row.FindControl("LabelId")).Text);
            this.SelectedID = id;
           
        }

        private void EnableForm(bool truefalse)
        {
            this.TextBoxNombre.Enabled = truefalse;
            this.TextBoxApellido.Enabled = truefalse;
            this.TextBoxEmail.Enabled = truefalse;
            this.TextBoxNombreUsuario.Enabled = truefalse;
            this.TextBoxClave.Enabled = truefalse;
            this.TextBoxConfirmarClave.Enabled = truefalse;
            TextBoxIDPersona.Enabled = truefalse;
        }

        private void ClearForm()
        {
            this.TextBoxNombre.Text = string.Empty;
            this.TextBoxApellido.Text = string.Empty;
            this.TextBoxEmail.Text = string.Empty;
            this.CheckBoxHabilitado.Checked = false;
            this.TextBoxNombreUsuario.Text = string.Empty;
            this.TextBoxClave.Text = string.Empty;
            this.TextBoxConfirmarClave.Text = string.Empty;
            TextBoxIDPersona.Text = string.Empty;
        }
        
        #region Button Actions

        protected void ButtonNuevo_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            this.GridViewUsuarios.SelectedIndex = -1;
            this.GridViewUsuarios.Enabled = false;
            this.PanelAccionesFormulario.Visible = true ;
            this.PanelBotonesGrilla.Visible = false;
            this.PanelABM.Visible = true;
            this.FormMode = FormModes.Alta;
            LabelModo.Text = FormMode.ToString();
            this.EnableForm(true);

        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.FormMode = FormModes.Baja;
                this.MapearDeUsuario(this.SelectedID, this.FormMode.ToString());
               
                this.GridViewUsuarios.Enabled = false;
                this.PanelAccionesFormulario.Visible = true;
                this.PanelBotonesGrilla.Visible = false;
                this.PanelABM.Visible = true;
                LabelModo.Text = FormMode.ToString();
                this.EnableForm(false);
                
            }
        }

        protected void ButtonEditar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.GridViewUsuarios.Enabled = false;
                this.PanelAccionesFormulario.Visible = true;
                this.PanelBotonesGrilla.Visible = false;
                this.EnableForm(true);
                this.PanelABM.Visible = true;
                this.FormMode = FormModes.Modificacion;

                LabelModo.Text = FormMode.ToString();
                this.MapearDeUsuario(this.SelectedID, this.FormMode.ToString());
            }
        }

        protected void ButtonAceptar_Click(object sender, EventArgs e)
        {
            
            switch (this.FormMode)
            {
                case FormModes.Baja:

                    
                    this.EliminarUsuario(this.SelectedID);
                    this.LoadGrid();
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Usuario();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.MapearAUsuarioEntity(this.Entity);
                    this.GuardarUsuario(this.Entity);
                    this.LoadGrid();
                    break;
                case FormModes.Alta:
                    this.Entity = new Usuario();
                    this.MapearAUsuarioEntity(this.Entity);
                    this.GuardarUsuario(this.Entity);
                    this.LoadGrid();


                    break;
                    

            }
            this.GridViewUsuarios.SelectedIndex = -1;
            this.GridViewUsuarios.Enabled = true;
            this.PanelBotonesGrilla.Visible = true;
            this.PanelABM.Visible = false; //CAMBIAR A FALSE;
            PanelAccionesFormulario.Visible = false;
            



            
        }
        
        protected void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.PanelBotonesGrilla.Visible = true;
            this.PanelAccionesFormulario.Visible = false;
            this.GridViewUsuarios.Enabled = true;
        }

        #endregion

        protected void DropDownIDPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Page.IsPostBack)
                TextBoxIDPersona.Text = DropDownIDPersona.SelectedValue;
        }
    }
}