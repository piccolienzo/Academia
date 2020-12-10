using Business.Logic;
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

namespace UI.Desktop
{
    public partial class ComisionesDesktop : ApplicationForm
    {
        public Business.Entities.Comision ComisionActual { get; set; }
        #region constructores
        public ComisionesDesktop(ModoForm modo):this()
        {
            
            this.Modo = modo;
        }
        public ComisionesDesktop(int id, ModoForm modo) : this()
        {
            
            this.Modo = modo;
            Comision comision = new ComisionLogic().GetOne(id);
            ComisionActual = comision;
            
        }

        public ComisionesDesktop()
        {
            InitializeComponent();
        }
        #endregion

        public new void MapearDeDatos()
        {
            //Carga combo
            PlanLogic planLogic = new PlanLogic();
            this.ComboBoxPlanes.DataSource = planLogic.GetAll();
            this.ComboBoxPlanes.DisplayMember = "descripcion";
            this.ComboBoxPlanes.ValueMember = "id";

            //Seteo campos form
            if (this.Modo != ModoForm.Alta)
            {
                this.TextBoxID.Text = this.ComisionActual.ID.ToString();
                this.TextBoxDescripcion.Text = this.ComisionActual.Descripcion;
                this.TextBoxAñoEsp.Text = this.ComisionActual.AñoEspecialidad.ToString();
                this.ComboBoxPlanes.SelectedValue = this.ComisionActual.IdPlan;
            }
            
            //seteo de texto boton
            if (this.Modo == ModoForm.Baja)
            {
                this.BotonAceptar.Text = "Eliminar";
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
                    
                    this.ComisionActual = new Comision();
                    
                    this.ComisionActual.IdPlan = Convert.ToInt32(this.TextBoxIdPlan.Text);
                    this.ComisionActual.Descripcion = this.TextBoxDescripcion.Text;
                    this.ComisionActual.AñoEspecialidad = Convert.ToInt32(this.TextBoxAñoEsp.Text);
                    this.ComisionActual.State = BusinessEntity.States.New;

                    break;
                case ModoForm.Modificacion:
                    
                    this.ComisionActual.IdPlan = Convert.ToInt32(this.TextBoxIdPlan.Text);
                    this.ComisionActual.Descripcion = this.TextBoxDescripcion.Text;
                    this.ComisionActual.AñoEspecialidad = Convert.ToInt32(this.TextBoxAñoEsp.Text);
                    this.ComisionActual.State = BusinessEntity.States.Modified;

                    break;
                case ModoForm.Baja:
                    this.ComisionActual.State = BusinessEntity.States.Deleted;

                    break;
                case ModoForm.Consulta:
                    this.ComisionActual.State = BusinessEntity.States.Unmodified;
                    break;
            }

        }

        public new void GuardarCambios()
        {
            this.MapearADatos();
            ComisionLogic comLogic = new ComisionLogic();
            comLogic.Save(this.ComisionActual);
            this.Close();
        }
        private void ComboBoxPlanes_SelectedValueChanged(object sender, EventArgs e)
        {
            this.TextBoxIdPlan.Text = ComboBoxPlanes.SelectedValue.ToString();
        }
        
        private void ComisionesDesktop_Load(object sender, EventArgs e)
        {

            this.Text = this.Modo.ToString();
            this.MapearDeDatos();
        }


        #region Botones
        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            
           if (this.Validar())
            {
                this.GuardarCambios();
            }
        }
        #endregion
       
        #region Validaciones
        private new bool Validar()
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (this.Continuar(this.BotonAceptar.Text,"Comisión"))
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
        private void TextBoxDescripcion_Validating(object sender, CancelEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(t, "No debe estar en blanco");
            }
        }

        private void TextBoxAñoEsp_Validating(object sender, CancelEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(t, "No debe estar en blanco");
            }
            if (int.TryParse(t.Text,out int i)==false)
            {
                e.Cancel = true;
                errorProvider1.SetError(t, "Debe ser un numero ");
            }
        }

        private void TextBoxDescripcion_Validated(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            errorProvider1.SetError(t, "");
        }

        private void TextBoxAñoEsp_Validated(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            errorProvider1.SetError(t, "");
        }
        #endregion
    }
}
