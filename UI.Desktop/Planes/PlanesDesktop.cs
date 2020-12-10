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
    public partial class PlanesDesktop : ApplicationForm
    {

        public Business.Entities.Plan PlanActual { get; set; }

        public PlanesDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public PlanesDesktop(int id, ModoForm modo) : this()
        {
            this.Modo = modo;
            Plan plan = new PlanLogic().GetOne(id);
            this.PlanActual = plan;
            this.MapearDeDatos();
        }
        public PlanesDesktop()
        {
            InitializeComponent();
        }

        public new void MapearDeDatos()
        {
            this.TextBoxId.Text = this.PlanActual.ID.ToString();
            this.TextBoxIdEspecialidad.Text = this.PlanActual.IdEspecialidad.ToString();
            this.TextBoxDescripcion.Text = this.PlanActual.Descripcion;

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
                Plan plan = new Plan();
                PlanActual = plan;

                this.PlanActual.Descripcion = this.TextBoxDescripcion.Text;
                this.PlanActual.IdEspecialidad = Convert.ToInt32(this.TextBoxIdEspecialidad.Text);



            }
            else if (this.Modo == ModoForm.Modificacion)
            {
                this.TextBoxIdEspecialidad.Enabled = false;
                this.PlanActual.Descripcion = this.TextBoxDescripcion.Text;

            }

            switch (this.Modo)
            {
                case ModoForm.Alta:
                    {
                        this.PlanActual.State = BusinessEntity.States.New;
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        this.PlanActual.State = BusinessEntity.States.Modified;
                        break;
                    }
                case ModoForm.Baja:
                    {
                        this.PlanActual.State = BusinessEntity.States.Deleted;
                        break;
                    }
                case ModoForm.Consulta:
                    {
                        this.PlanActual.State = BusinessEntity.States.Unmodified;
                        break;
                    }

            }


        }
        public new void GuardarCambios()
        {
            this.MapearADatos();
            PlanLogic planLogic = new PlanLogic();
            planLogic.Save(this.PlanActual);


        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {


                MessageBox.Show("Todo ok ");
                this.GuardarCambios();
                this.Close();

            }
            else
            {
                // this.Notificar("Existen errores", );
                MessageBox.Show("Todo mal :/ ");



            }
            this.Validar();
        }

        private void PlanesDesktop_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2_netDataSetEspecialidades.especialidades' Puede moverla o quitarla según sea necesario.
            EspecialidadLogic especialidadLogic = new EspecialidadLogic();
            //Lista de planes


            this.ComboBoxEspecialidades.DataSource = especialidadLogic.GetAll();
            this.ComboBoxEspecialidades.DisplayMember = "descripcion";
            this.ComboBoxEspecialidades.ValueMember = "id";


        }

        private void BotonAgregarIdEspecialidad_Click(object sender, EventArgs e)
        {

            
            this.TextBoxIdEspecialidad.Text = (string)this.ComboBoxEspecialidades.SelectedValue.ToString();
        }

        private void ComboBoxEspecialidades_SelectedValueChanged(object sender, EventArgs e)
        {
            this.TextBoxIdEspecialidad.Text = (string)this.ComboBoxEspecialidades.SelectedValue.ToString();
        }
    }
}
