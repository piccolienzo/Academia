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
    public partial class AlumnosInscripcionesDesktop : ApplicationForm
    {
        public Business.Entities.AlumnoInscripcion InscripcionActual { get; set; }

        public AlumnosInscripcionesDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }
        public AlumnosInscripcionesDesktop(int id,ModoForm modo) : this()
        {
            this.Modo = modo;
            AlumnoInscripcion inscripcion = new AlumnoInscripcionLogic().GetOne(id);
            InscripcionActual = inscripcion;
            MapearDeDatos();
        }

        public AlumnosInscripcionesDesktop()
        {
            InitializeComponent();
        }

        public new void MapearDeDatos()
        {
            //combos
            CursoLogic cl = new CursoLogic();
            ComboComision.DataSource = cl.GetAll();
            ComboComision.DisplayMember = "id";
            ComboComision.ValueMember = "id";

            List<Business.Entities.Persona> ul = new PersonaLogic().GetAll();

            ComboAlumno.DataSource = (from p in ul
                                     where p.TipoPersona == Business.Entities.Persona.TiposPersonas.Alumno
                                     select p).ToList();
            ComboAlumno.DisplayMember = "legajo";
            ComboAlumno.ValueMember = "id";

            //fin combos 

            if (this.Modo != ModoForm.Alta)
            {
                TextBoxId.Text = InscripcionActual.ID.ToString();
                TextBoxIdAlumno.Text = InscripcionActual.IdAlumno.ToString();
                ComboAlumno.SelectedValue = InscripcionActual.IdAlumno; 

                TextBoxIdComision.Text = InscripcionActual.IdCurso.ToString();
                ComboComision.SelectedValue = InscripcionActual.IdCurso;

                TextBoxNota.Text = InscripcionActual.Nota.ToString();
                TextBoxCondicion.Text = InscripcionActual.Condicion;

            }
            else {
                TextBoxIdAlumno.Text =

                TextBoxIdComision.Text = string.Empty;
            }
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
                    InscripcionActual = new AlumnoInscripcion();
                    InscripcionActual.IdAlumno = Convert.ToInt32(TextBoxIdAlumno.Text);
                    InscripcionActual.IdCurso = Convert.ToInt32(TextBoxIdComision.Text);
                    InscripcionActual.Nota = Convert.ToInt32(TextBoxNota.Text);
                    InscripcionActual.Condicion = TextBoxCondicion.Text;

                    InscripcionActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Baja:
                    InscripcionActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Modificacion:
                    InscripcionActual = new AlumnoInscripcion();
                    InscripcionActual.IdAlumno = Convert.ToInt32(TextBoxIdAlumno.Text);
                    InscripcionActual.IdCurso = Convert.ToInt32(TextBoxIdComision.Text);
                    InscripcionActual.Nota = Convert.ToInt32(TextBoxNota.Text);
                    InscripcionActual.Condicion = TextBoxCondicion.Text;
                    InscripcionActual.ID = Convert.ToInt32(TextBoxId.Text);
                    InscripcionActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Consulta:
                    InscripcionActual.State = BusinessEntity.States.Unmodified;
                    break;
                default:
                    break;
            }

        }

        public new void GuardarCambios()
        {
            this.MapearADatos();
            AlumnoInscripcionLogic ail = new AlumnoInscripcionLogic();
            ail.Save(this.InscripcionActual);
            this.Close();
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

        #region Validaciones
        private void AlumnosInscripcionesDesktop_Load(object sender, EventArgs e)
        {
            this.Text = this.Modo.ToString();
            MapearDeDatos();
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

        private void ComboComision_SelectedValueChanged(object sender, EventArgs e)
        {
            TextBoxIdComision.Text = ComboComision.SelectedValue.ToString();
        }

        private void ComboAlumno_SelectedValueChanged(object sender, EventArgs e)
        {
            TextBoxIdAlumno.Text = ComboAlumno.SelectedValue.ToString();
        }

        private void TextBoxNota_Validating(object sender, CancelEventArgs e)
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

        private void TextBoxNota_Validated(object sender, EventArgs e)
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

        private void TextBoxDescripcion_Validated(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            errorProvider1.SetError(t, "");
        }

        private void TextBoxAlumno_Validating(object sender, CancelEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(t, "Debe seleccionar un alumno");
            }
        }

        private void TextBoxAlumno_Validated(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            errorProvider1.SetError(t, "");
        }

        private void TextBoxComision_Validating(object sender, CancelEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(t, "Debe seleccionar una comision");
            }
        }

        private void TextBoxComision_Validated(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            errorProvider1.SetError(t, "");
        }

# endregion
    }
}
