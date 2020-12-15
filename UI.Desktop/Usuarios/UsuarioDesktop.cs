using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class UsuarioDesktop : ApplicationForm 
    {

        public Business.Entities.Usuario UsuarioActual { get; set; }


        public UsuarioDesktop(ModoForm modo):this() {
            this.Modo = modo;
        }

        public UsuarioDesktop(int id, ModoForm modo) : this()
        {
            this.Modo = modo;
            Usuario usuario = new UsuarioLogic().GetOne(id);
            this.UsuarioActual = usuario;
            this.MapearDeDatos();
        }
        public UsuarioDesktop()
        {
          InitializeComponent();
        }

        public new void MapearDeDatos() {
            this.TextBoxID.Text = this.UsuarioActual.ID.ToString();
            this.CheckBoxHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.TextBoxEmail.Text = this.UsuarioActual.Email;
            this.TextBoxNombre.Text = this.UsuarioActual.Nombre;
            this.TextBoxApellido.Text = this.UsuarioActual.Apellido;
            this.TextBoxUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.TextBoxClave.Text = this.UsuarioActual.Clave;
            this.TextBoxConfirmarClave.Text = this.UsuarioActual.Clave;

            if(this.Modo == ModoForm.Baja){

                this.BotonAceptar.Text = "Eliminar";
                this.TextBoxClave.Enabled = false;
                TextBoxApellido.Enabled = false;
                TextBoxConfirmarClave.Enabled = false;
                TextBoxEmail.Enabled = false;
                TextBoxNombre.Enabled = false;
                TextBoxUsuario.Enabled = false;
            } else if (this.Modo == ModoForm.Consulta)
            {

                this.BotonAceptar.Text = "Aceptar";
            }
            else
            {
                this.BotonAceptar.Text = "Guardar";
            }


        }
        public new void MapearADatos() {
        if (this.Modo == ModoForm.Alta)
            {
                Usuario usuario = new Usuario();
                UsuarioActual = usuario;

                this.UsuarioActual.Habilitado = this.CheckBoxHabilitado.Checked;
                this.UsuarioActual.Email = this.TextBoxEmail.Text;
                this.UsuarioActual.Nombre = this.TextBoxNombre.Text;
                this.UsuarioActual.Apellido = this.TextBoxApellido.Text;
                this.UsuarioActual.NombreUsuario = this.TextBoxUsuario.Text;
                this.UsuarioActual.Clave = this.TextBoxClave.Text;
                   

            }
        else if (this.Modo == ModoForm.Modificacion)
            {
                this.UsuarioActual.ID = int.Parse( this.TextBoxID.Text);
                this.UsuarioActual.Habilitado = this.CheckBoxHabilitado.Checked;
                this.UsuarioActual.Email = this.TextBoxEmail.Text;
                this.UsuarioActual.Nombre = this.TextBoxNombre.Text;
                this.UsuarioActual.Apellido = this.TextBoxApellido.Text;
                this.UsuarioActual.NombreUsuario = this.TextBoxUsuario.Text;
                this.UsuarioActual.Clave = this.TextBoxClave.Text;
            }
        
        switch (this.Modo)
            {
                case ModoForm.Alta:
                {
                        this.UsuarioActual.State = BusinessEntity.States.New;
                        break;
                }
                case ModoForm.Modificacion:
                    {
                        this.UsuarioActual.State = BusinessEntity.States.Modified;
                        break;
                    }
                case ModoForm.Baja:
                    {
                        this.UsuarioActual.State = BusinessEntity.States.Deleted;
                        break;
                    }
                case ModoForm.Consulta:
                    {
                        this.UsuarioActual.State = BusinessEntity.States.Unmodified;
                        break;
                    }

            }
        
        
        }
        public new void GuardarCambios() {
            this.MapearADatos();
            UsuarioLogic usuarioLogic = new UsuarioLogic();
            usuarioLogic.Save(this.UsuarioActual);


        
        }
        private new bool Validar()
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (this.Continuar(this.BotonAceptar.Text, "Inscripcion alumno"))
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
            else
            {
                Notificar("Error", "Existen errores, porfavor verificar el formulario", MessageBoxButtons.OK
                , MessageBoxIcon.Error);
                return false;
            }
        }



        private void TextBoxNombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.TextBoxNombre.Text))
            {
                e.Cancel = true;
                //this.TextBoxNombre.Focus();
                ErrorProviderApp.SetError(this.TextBoxNombre, "No deberia estar en blanco");
            }
            else
            {
                e.Cancel = false;
                ErrorProviderApp.SetError(this.TextBoxNombre, "");
            }
        }

        private void TextBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(this.TextBoxEmail.Text))
                {
                    e.Cancel = true;
                    //this.TextBoxEmail.Focus();
                    ErrorProviderApp.SetError(this.TextBoxEmail, "No deberia estar en blanco");
                }
                else
                {
                    e.Cancel = false;
                    ErrorProviderApp.SetError(this.TextBoxEmail, "");
                }
            }
        }

        private void TextBoxApellido_Validating(object sender, CancelEventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(this.TextBoxApellido.Text))
                {
                    e.Cancel = true;
                    //this.TextBoxApellido.Focus();
                    ErrorProviderApp.SetError(this.TextBoxApellido, "No deberia estar en blanco");
                }
                else
                {
                    e.Cancel = false;
                    ErrorProviderApp.SetError(this.TextBoxApellido, "");
                }
            }
        }

        private void TextBoxUsuario_Validating(object sender, CancelEventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(this.TextBoxUsuario.Text))
                {
                    e.Cancel = true;
                    
                    ErrorProviderApp.SetError(this.TextBoxUsuario, "No deberia estar en blanco");
                }
                else
                {
                    e.Cancel = false;
                    ErrorProviderApp.SetError(this.TextBoxUsuario, "");
                }
            }
        }

        private void TextBoxClave_Validating(object sender, CancelEventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(this.TextBoxClave.Text))
                {
                    e.Cancel = true;

                    ErrorProviderApp.SetError(this.TextBoxClave, "No deberia estar en blanco");
                }
               

                else
                {
                    e.Cancel = false;
                    ErrorProviderApp.SetError(this.TextBoxClave, "");
                    this.TextBoxConfirmarClave.Enabled = true;
                    

                }
            }
        }

        private void TextBoxConfirmarClave_Validating(object sender, CancelEventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(this.TextBoxConfirmarClave.Text))
                {
                    e.Cancel = true;
                    
                    ErrorProviderApp.SetError(this.TextBoxConfirmarClave, "No deberia estar en blanco");
                }
                else if (TextBoxClave.Text != this.TextBoxConfirmarClave.Text)
                {
                    e.Cancel = true;
                    //this.TextBoxConfirmarClave.Focus();
                    ErrorProviderApp.SetError(this.TextBoxConfirmarClave, "La clave no coincide");
                }

                else
                {
                    e.Cancel = false;
                    ErrorProviderApp.SetError(this.TextBoxConfirmarClave, "");
                }
            }
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {

            if (this.Validar())
            {
                this.GuardarCambios();
                this.Close();
            }
            else
            {

            }


        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
