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
using Util;

namespace UI.Desktop
{
    public partial class DocentesCursosDesktop : ApplicationForm
    {
        public Business.Entities.DocenteCurso DocenteCursoActual { get; set; }

        public DocentesCursosDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public DocentesCursosDesktop(int id, ModoForm modo) : this()
        {
            this.Modo = modo;
            DocenteCurso docenteCurso = new DocenteCursoLogic().GetOne(id);
            this.DocenteCursoActual = docenteCurso;
            this.MapearDeDatos();
        }
        public DocentesCursosDesktop()
        {
            InitializeComponent();
        }
        
        public new void MapearDeDatos()
        {
            this.textBoxIdDictado.Text = this.DocenteCursoActual.ID.ToString();
            this.textBoxIdCurso.Text = this.DocenteCursoActual.IdCurso.ToString();
            this.textBoxIdDocente.Text = this.DocenteCursoActual.IdDocente.ToString();
            this.textBoxCargo.Text = this.DocenteCursoActual.Cargo.ToString();
            


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
            if (this.Modo == ModoForm.Alta)
            {
                DocenteCurso docenteCurso = new DocenteCurso();
                DocenteCursoActual = docenteCurso;

                
                this.DocenteCursoActual.IdCurso = Convert.ToInt32(this.textBoxIdCurso.Text);
                this.DocenteCursoActual.IdDocente = Convert.ToInt32(this.textBoxIdDocente.Text);
                this.DocenteCursoActual.Cargo = (DocenteCurso.TiposCargos)(int)comboBoxCargo.SelectedValue;

                



            }
            else if (this.Modo == ModoForm.Modificacion)
            {
                this.DocenteCursoActual.IdCurso = Convert.ToInt32(this.textBoxIdCurso.Text);
                this.DocenteCursoActual.IdDocente = Convert.ToInt32(this.textBoxIdDocente.Text);
                this.DocenteCursoActual.Cargo = (DocenteCurso.TiposCargos)(int)comboBoxCargo.SelectedValue;

            }

            switch (this.Modo)
            {
                case ModoForm.Alta:
                    {
                        this.DocenteCursoActual.State = BusinessEntity.States.New;
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        this.DocenteCursoActual.State = BusinessEntity.States.Modified;
                        break;
                    }
                case ModoForm.Baja:
                    {
                        this.DocenteCursoActual.State = BusinessEntity.States.Deleted;
                        break;
                    }
                case ModoForm.Consulta:
                    {
                        this.DocenteCursoActual.State = BusinessEntity.States.Unmodified;
                        break;
                    }

            }


        }
        public new void GuardarCambios()
        {
            this.MapearADatos();
            DocenteCursoLogic docenteCursoLogic = new DocenteCursoLogic();
            docenteCursoLogic.Save(this.DocenteCursoActual);


        }


        private void DocentesCursos_Load(object sender, EventArgs e)
        {
            CursoLogic cursoLogic = new CursoLogic();

            this.comboBoxIdCurso.DataSource = cursoLogic.GetAll();
            this.comboBoxCargo.DisplayMember = "id";
            this.comboBoxIdCurso.ValueMember = "id";

            this.comboBoxIdDocente.DataSource = Util.Personas.GetDocentes();
            this.comboBoxIdDocente.DisplayMember = "Apellido";
            this.comboBoxIdDocente.ValueMember = "ID";

            this.comboBoxCargo.DataSource = Util.Personas.GetTipoCargos();
            this.comboBoxCargo.DisplayMember = "Nombre";
            this.comboBoxCargo.ValueMember = "Numero";

        }


        private void ComboBoxIdCurso_SelectedValueChanged(object sender, EventArgs e)
        {
            this.textBoxIdCurso.Text = (string)this.comboBoxIdCurso.SelectedValue.ToString();
        }

        private void ComboBoxIdDocente_SelectedValueChanged(object sender, EventArgs e)
        {
            this.textBoxIdDocente.Text = (string)this.comboBoxIdDocente.SelectedValue.ToString();
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
    }
}
