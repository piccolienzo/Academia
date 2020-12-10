using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial  class ApplicationForm : Form
    {

        public enum ModoForm
        {
            Alta, Baja, Modificacion, Consulta

        }

        public ModoForm Modo { get; set; }

        public ApplicationForm()
        {
            InitializeComponent();
        }

        public virtual void MapearDeDatos() { }
        public virtual void MapearADatos() { }
        public virtual void GuardarCambios() { }
        public virtual bool Validar() { return false; }
        public void Notificar(string titulo, string mensaje, MessageBoxButtons
        botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
        public void Notificar(string mensaje, MessageBoxButtons botones,
        MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }
        public bool Continuar(string accion,string tipo)
        {
            if (MessageBox.Show($"¿Desea continuar y {accion.ToLower()} {tipo.ToLower()}?", $"{accion} {tipo}", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
        System.Windows.Forms.DialogResult.No)
            {
                return false;
            }
            else
            {
                return true;
            }


        }
    }
}
