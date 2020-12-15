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
    public partial class PersonasDesktop : ApplicationForm
    {
        public Business.Entities.Persona PersonaActual { get; set; }
        public PersonasDesktop()
        {
            InitializeComponent();
        }

        public PersonasDesktop(int id, ModoForm modo) : this()
        {
            this.Modo = modo;
            Business.Entities.Persona persona = new PersonaLogic().GetOne(id);
            this.PersonaActual = persona;
            this.MapearDeDatos();


        }
        public PersonasDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }


        public new void MapearDeDatos()
        {
            this.textBoxID.Text = this.PersonaActual.ID.ToString();
            this.textBoxNombre.Text = this.PersonaActual.Nombre;
            this.textBoxApellido.Text = this.PersonaActual.Apellido;
            this.textBoxDireccion.Text = this.PersonaActual.Direccion;
            this.textBoxEmail.Text = this.PersonaActual.Email;
            this.textBoxTelefono.Text = this.PersonaActual.Telefono;
            this.textBoxLegajo.Text = Convert.ToString(this.PersonaActual.Legajo);
            this.dateTimePicker1.Value = this.PersonaActual.FechaNacimiento;
            this.textBoxIdPlan.Text = Convert.ToString(this.PersonaActual.IdPlan);
          



            if (this.Modo == ModoForm.Baja)
            {

                this.botonGuardar.Text = "Eliminar";
                textBoxApellido.Enabled = false;
                textBoxDireccion.Enabled = false;
                textBoxEmail.Enabled = false;
                textBoxIdPlan.Enabled = false;
                textBoxLegajo.Enabled = false;
                textBoxNombre.Enabled = false;
                textBoxTelefono.Enabled = false;
                comboBoxPlanes.Enabled = false;
                comboBoxTipoPersona.Enabled = false;
                dateTimePicker1.Enabled = false;
            }
            else if (this.Modo == ModoForm.Alta || this.Modo == ModoForm.Modificacion)
            {

                this.botonGuardar.Text = "Guardar";
            }
            else
            {
                this.botonGuardar.Text = "Aceptar";
            }
        }

        public new void MapearADatos()
        {
            if (this.Modo == ModoForm.Alta)
            {
                Persona persona = new Persona();
                PersonaActual = persona;

                
                this.PersonaActual.Nombre = this.textBoxNombre.Text;
                this.PersonaActual.Apellido = this.textBoxApellido.Text;
                this.PersonaActual.Direccion = this.textBoxDireccion.Text;
                this.PersonaActual.Email = this.textBoxEmail.Text;
                this.PersonaActual.Telefono = this.textBoxTelefono.Text;
                this.PersonaActual.Legajo = Int32.Parse(this.textBoxLegajo.Text);
                this.PersonaActual.FechaNacimiento = this.dateTimePicker1.Value.Date;
                this.PersonaActual.IdPlan = Convert.ToInt32(this.textBoxIdPlan.Text);
                this.PersonaActual.TipoPersona = (Persona.TiposPersonas)(int)comboBoxTipoPersona.SelectedValue;




            }
            else if (this.Modo == ModoForm.Modificacion)
            {

                this.PersonaActual.Nombre = this.textBoxNombre.Text;
                this.PersonaActual.Apellido = this.textBoxApellido.Text;
                this.PersonaActual.Direccion = this.textBoxDireccion.Text;
                this.PersonaActual.Email = this.textBoxEmail.Text;
                this.PersonaActual.Telefono = this.textBoxTelefono.Text;
                this.PersonaActual.Legajo = Int32.Parse(this.textBoxLegajo.Text);
                this.PersonaActual.FechaNacimiento = this.dateTimePicker1.Value.Date;
                this.PersonaActual.IdPlan = Convert.ToInt32(this.textBoxIdPlan.Text);
                this.PersonaActual.TipoPersona = (Persona.TiposPersonas)(int)comboBoxTipoPersona.SelectedValue;

            }

            switch (this.Modo)
            {
                case ModoForm.Alta:
                    {
                        this.PersonaActual.State = BusinessEntity.States.New;
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        this.PersonaActual.State = BusinessEntity.States.Modified;
                        break;
                    }
                case ModoForm.Baja:
                    {
                        this.PersonaActual.State = BusinessEntity.States.Deleted;
                        break;
                    }
                case ModoForm.Consulta:
                    {
                        this.PersonaActual.State = BusinessEntity.States.Unmodified;
                        break;
                    }

            }


        }
        public new void GuardarCambios()
        {
            this.MapearADatos();
            PersonaLogic personaLogic = new PersonaLogic();
            personaLogic.Save(this.PersonaActual);


        }

        private void ComboBoxPlanes_SelectedValueChanged(object sender, EventArgs e)
        {
            this.textBoxIdPlan.Text = (string)this.comboBoxPlanes.SelectedValue.ToString();
        }



        private void PersonasDesktop_Load(object sender, EventArgs e)
        {
            
            PlanLogic planLogic = new PlanLogic();       

            this.comboBoxPlanes.DataSource = planLogic.GetAll();
            this.comboBoxPlanes.DisplayMember = "descripcion";
            this.comboBoxPlanes.ValueMember = "id";



            this.comboBoxTipoPersona.DataSource = Util.Personas.GetTipoPersonas();
            this.comboBoxTipoPersona.DisplayMember = "Nombre";
            this.comboBoxTipoPersona.ValueMember = "Numero";




        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                this.GuardarCambios();
                this.Close();
            }
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private new bool Validar()
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (this.Continuar(this.botonGuardar.Text, "Persona"))
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

        private void TextBoxTelefono_Validating(object sender, CancelEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(t, "No debe estar en blanco");
            }
            if (int.TryParse(t.Text, out int i) == false)
            {
                e.Cancel = true;
                errorProvider1.SetError(t, "Debe ser un numero ");
            }
        }

        private void TextBoxTelefono_Validated(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            errorProvider1.SetError(t, "");
        }

        private void TextBoxLegajo_Validating(object sender, CancelEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(t, "No debe estar en blanco");
            }
            if (int.TryParse(t.Text, out int i) == false)
            {
                e.Cancel = true;
                errorProvider1.SetError(t, "Debe ser un numero ");
            }
        }

        private void TextBoxLegajo_Validated(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            errorProvider1.SetError(t, "");
        }

        private void TextBoxNombre_Validating(object sender, CancelEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(t, "No debe estar en blanco");
            }
 
        }

        private void TextBoxNombre_Validated(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            errorProvider1.SetError(t, "");
        }

        private void TextBoxApellido_Validating(object sender, CancelEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(t, "No debe estar en blanco");
            }

        }

        private void TextBoxApellido_Validated(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            errorProvider1.SetError(t, "");
        }

        private void TextBoxDireccion_Validating(object sender, CancelEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(t, "No debe estar en blanco");
            }

        }

        private void TextBoxDireccion_Validated(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            errorProvider1.SetError(t, "");
        }

        private void TextBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(t, "No debe estar en blanco");
            }

        }

        private void TextBoxEmail_Validated(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            errorProvider1.SetError(t, "");
        }
    }
}
