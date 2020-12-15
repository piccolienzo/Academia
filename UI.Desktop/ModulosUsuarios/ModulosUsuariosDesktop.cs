using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class ModulosUsuariosDesktop : ApplicationForm
    {
        public Business.Entities.ModuloUsuario ModuloActual { get; set; }

        #region constructores
        public ModulosUsuariosDesktop(ModoForm modo):this()
        {
            this.Modo = modo;
        }

        public ModulosUsuariosDesktop(int id,ModoForm modo):this()
        {
            this.Modo = modo;
            ModuloUsuario moduloUsuarioLogic = new ModuloUsuarioLogic().GetOne(id);
            this.ModuloActual = moduloUsuarioLogic;
        }

        public ModulosUsuariosDesktop()
        {
            InitializeComponent();
        }
        #endregion

        public new void MapearDeDatos()
        {
            //COmbos
            UsuarioLogic ul = new UsuarioLogic();
            ComboIDUsuario.DataSource = ul.GetAll();
            ComboIDUsuario.DisplayMember = "nombre"+"apellido"+"email";
            ComboIDUsuario.ValueMember = "id";

            ModuloLogic ml = new ModuloLogic();
            ComboIDModulo.DataSource = ml.GetAll();
            ComboIDModulo.DisplayMember = "descripcion";
            ComboIDModulo.ValueMember = "id";


            if (this.Modo != ModoForm.Alta)
            {
                this.TextBoxID.Text = this.ModuloActual.ID.ToString();
                this.ComboIDModulo.SelectedValue = this.ModuloActual.IdModulo;
                this.ComboIDUsuario.SelectedValue = this.ModuloActual.IdUsuario;
                this.CheckAlta.Checked = this.ModuloActual.PermiteAlta;
                this.CheckBaja.Checked = this.ModuloActual.PermiteBaja;
                this.CheckConsulta.Checked = this.ModuloActual.PermiteConsulta;
                this.CheckModificacion.Checked = this.ModuloActual.PermiteModificacion;
                
            }

            if (this.Modo == ModoForm.Baja)
            {
                this.BotonAceptar.Text = "Eliminar";
                ComboIDModulo.Enabled = false;
                ComboIDUsuario.Enabled = false;
            }
            else if (this.Modo == ModoForm.Alta || this.Modo == ModoForm.Modificacion)
            {
                this.BotonAceptar.Text = "Guardar";
            }
            else
            {
                this.BotonAceptar.Text = "Aceptar";
            }
        }
        public new void MapearADatos()
        {
            switch (this.Modo)
            {
                case ModoForm.Alta:
                    this.ModuloActual = new ModuloUsuario();                    
                    this.ModuloActual.IdModulo = Convert.ToInt32(this.TextBoxIDModulo.Text);
                    this.ModuloActual.IdUsuario = Convert.ToInt32(this.TextBoxIDUsuario.Text);
                    this.ModuloActual.PermiteAlta = this.CheckAlta.Checked;
                    this.ModuloActual.PermiteBaja = this.CheckBaja.Checked;
                    this.ModuloActual.PermiteConsulta = this.CheckConsulta.Checked;
                    this.ModuloActual.PermiteModificacion = this.CheckModificacion.Checked;
                    this.ModuloActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    this.ModuloActual = new ModuloUsuario();
                    this.ModuloActual.ID = Convert.ToInt32(this.TextBoxID.Text);
                    this.ModuloActual.IdModulo = Convert.ToInt32(this.TextBoxIDModulo.Text);
                    this.ModuloActual.IdUsuario = Convert.ToInt32(this.TextBoxIDUsuario.Text);
                    this.ModuloActual.PermiteAlta = this.CheckAlta.Checked;
                    this.ModuloActual.PermiteBaja = this.CheckBaja.Checked;
                    this.ModuloActual.PermiteConsulta = this.CheckConsulta.Checked;
                    this.ModuloActual.PermiteModificacion = this.CheckModificacion.Checked;
                    this.ModuloActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Baja:
                    this.ModuloActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Consulta:
                    this.ModuloActual.State = BusinessEntity.States.Unmodified;
                    break;
            }
        }
        public new void GuardarCambios()
        {
            this.MapearADatos();
            ModuloUsuarioLogic mul = new ModuloUsuarioLogic();
            mul.Save(this.ModuloActual);
            this.Close();
        }
        private new bool Validar()
        {
            if (this.Continuar(this.BotonAceptar.Text, "Modulos usuario"))
            {
                Notificar("Atención", "Cambios guardados", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                return true;
            }
            else
            {
                return false;

            }
        }

        #region botones
        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                this.GuardarCambios();
            }
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region validaciones
        // no se requieren   
        #endregion

        #region eventos
        private void ComboIDUsuario_SelectedValueChanged(object sender, EventArgs e)
        {
            this.TextBoxIDUsuario.Text = ComboIDUsuario.SelectedValue.ToString();
        }

        private void ComboIDModulo_SelectedValueChanged(object sender, EventArgs e)
        {
            this.TextBoxIDModulo.Text = ComboIDModulo.SelectedValue.ToString();
        }

        private void ModulosUsuariosDesktop_Load(object sender, EventArgs e)
        {
            this.Text = this.Modo.ToString();
            this.MapearDeDatos();
        }
        #endregion
    }
}
