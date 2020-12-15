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
    public partial class ModulosDesktop : ApplicationForm
    {
        public Modulo ModuloActual { get; set; }
        public ModulosDesktop()
        {
            InitializeComponent();
            
        }
        public ModulosDesktop(ModoForm modo):this()
        {
            this.Modo = modo;
        }
        public ModulosDesktop(int ID,ModoForm modo):this()
        {
            this.Modo = modo;
            this.ModuloActual = new ModuloLogic().GetOne(ID);
            
        }

        private void ModulosDesktop_Load(object sender, EventArgs e)
        {
            this.Text = this.Modo.ToString();
            this.MapearDeDatos();
        }
        private new void MapearADatos()
        {
            switch (this.Modo)
            {
                case ModoForm.Alta:
                    this.ModuloActual = new Modulo();
                    this.ModuloActual.Descripcion = this.TextBoxDescripcion.Text;
                    this.ModuloActual.Ejecuta = this.TextBoxEjecuta.Text;
                    this.ModuloActual.State = BusinessEntity.States.New;
                    break;

                case ModoForm.Modificacion:
                    this.ModuloActual.Descripcion = this.TextBoxDescripcion.Text;
                    this.ModuloActual.Ejecuta = this.TextBoxEjecuta.Text;
                    
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
        private new void MapearDeDatos()
        {
            if (this.Modo != ModoForm.Alta)
            {
                this.TextBoxDescripcion.Text = this.ModuloActual.Descripcion;
                this.TextBoxID.Text = this.ModuloActual.ID.ToString();
                this.TextBoxEjecuta.Text = this.ModuloActual.Ejecuta;
            }

            //seteo de texto boton
            if (this.Modo == ModoForm.Baja)
            {
                this.BotonAceptar.Text = "Eliminar";
                TextBoxDescripcion.Enabled = false;
                TextBoxEjecuta.Enabled = false;
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
        private new void GuardarCambios()
        {
            this.MapearADatos();
            ModuloLogic comisionLogic = new ModuloLogic();
            comisionLogic.Save(this.ModuloActual);
            this.Close();
        }
        private new bool Validar()
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (this.Continuar(this.BotonAceptar.Text, "Módulo"))
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
        #region Validaciones
        private void TextBoxDescripcion_Validated(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            errorProvider1.SetError(t, "");
        }

        private void TextBoxDescripcion_Validating(object sender, CancelEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(t, "No debe estar en blanco");
            }
        }
        #endregion

    }
}
