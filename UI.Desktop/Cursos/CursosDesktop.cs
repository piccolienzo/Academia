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
    public partial class CursosDesktop : ApplicationForm
    {
        public Business.Entities.Curso CursoActual { get; set; }
        
        public CursosDesktop(ModoForm modo):this()
        {
            this.Modo = modo;
        }

        public CursosDesktop(int id,ModoForm modo) : this()
        {
            this.Modo = modo;
            CursoActual = new CursoLogic().GetOne(id);
        }

        public CursosDesktop()
        {
            InitializeComponent();
        }

        public new void MapearDeDatos()
        {
            //Combo Materia
            MateriaLogic mat = new MateriaLogic();
            this.ComboIDMateria.DataSource = mat.GetAll();
            this.ComboIDMateria.DisplayMember = "descripcion";
            this.ComboIDMateria.ValueMember = "id";
            //Combo Comision
            ComisionLogic com = new ComisionLogic();
            this.ComboIDCom.DataSource = com.GetAll();
            this.ComboIDCom.DisplayMember = "descripcion";
            this.ComboIDCom.ValueMember = "id";

            //Seteo de campos
            if (this.Modo != ModoForm.Alta)
            {
                this.TextBoxIDCurso.Text = CursoActual.ID.ToString();
                this.TextBoxAnioCal.Text = CursoActual.AñoCalendario.ToString();
                this.TextBoxCupo.Text = CursoActual.Cupo.ToString();
                
                this.ComboIDCom.SelectedValue = this.CursoActual.IdComision;
                this.ComboIDMateria.SelectedValue = this.CursoActual.IdMateria;

            }



            //texto boton
            switch (this.Modo)
            {
                case ModoForm.Baja:
                    this.BotonAceptar.Text = "Eliminar"; break;
                case ModoForm.Alta:
                    this.BotonAceptar.Text = "Guardar"; break;
                case ModoForm.Modificacion:
                    this.BotonAceptar.Text = "Guardar"; break;
                case ModoForm.Consulta:
                    this.BotonAceptar.Text = "Aceptar"; break;
            }



        }
        public new void MapearADatos()
        {
            switch (this.Modo)
            {
                case ModoForm.Alta:
                    this.CursoActual = new Curso
                    {
                        AñoCalendario = Convert.ToInt32(this.TextBoxAnioCal.Text),
                        Cupo = Convert.ToInt32(this.TextBoxCupo.Text),
                        
                        IdComision = Convert.ToInt32(this.TextBoxIDComision.Text),
                        IdMateria = Convert.ToInt32(this.TextBoxIDMateria.Text),
                        State = BusinessEntity.States.New
                    };

                    
                    break;
                case ModoForm.Modificacion:

                    this.CursoActual = new Curso
                    {
                        ID = Convert.ToInt32(this.TextBoxIDCurso.Text),
                        AñoCalendario = Convert.ToInt32(this.TextBoxAnioCal.Text),
                        Cupo = Convert.ToInt32(this.TextBoxCupo.Text),
                        
                        IdComision = Convert.ToInt32(this.TextBoxIDComision.Text),
                        IdMateria = Convert.ToInt32(this.TextBoxIDMateria.Text),
                        State = BusinessEntity.States.Modified
                    };

                    break;
                case ModoForm.Baja:
                    this.CursoActual.State = BusinessEntity.States.Deleted;

                    break;
                case ModoForm.Consulta:
                    this.CursoActual.State = BusinessEntity.States.Unmodified;
                    break;
            }
        }
        public new void GuardarCambios()
        {
            this.MapearADatos();
            CursoLogic com = new CursoLogic();
            com.Save(this.CursoActual);
            this.Close();
        }


        #region Botones

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

        #region Validaciones

        private new bool Validar()
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (this.Continuar(this.BotonAceptar.Text, "Curso"))
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

       

        private void TextBoxAnioCal_Validated(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            errorProvider1.SetError(t, "");
        }

        private void TextBoxAnioCal_Validating(object sender, CancelEventArgs e)
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

        private void TextBoxCupo_Validating(object sender, CancelEventArgs e)
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

        private void TextBoxCupo_Validated(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            errorProvider1.SetError(t, "");
        }

        private void TextBoxDesc_Validating(object sender, CancelEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(t, "No debe estar en blanco");
            }
        }

        private void TextBoxDesc_Validated(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            errorProvider1.SetError(t, "");
        }
        #endregion

        private void ComboIDMateria_SelectedValueChanged(object sender, EventArgs e)
        {
            this.TextBoxIDMateria.Text = ComboIDMateria.SelectedValue.ToString();
        }

        private void ComboIDCom_SelectedValueChanged(object sender, EventArgs e)
        {
            this.TextBoxIDComision.Text = ComboIDCom.SelectedValue.ToString();
        }

        private void CursosDesktop_Load(object sender, EventArgs e)
        {
            this.Text = this.Modo.ToString();
            this.MapearDeDatos();
        }
    }
}
 //