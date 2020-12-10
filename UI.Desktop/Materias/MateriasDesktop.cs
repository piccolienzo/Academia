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
    public partial class MateriasDesktop : ApplicationForm
    {

        public Business.Entities.Materia MateriaActual { get; set; }
        public MateriasDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public MateriasDesktop(int id, ModoForm modo) : this()
        {
            this.Modo = modo;
            Business.Entities.Materia materia = new MateriaLogic().GetOne(id);
            this.MateriaActual = materia;
            

        }
        public MateriasDesktop()
        {
            InitializeComponent();
        }

        private void MateriasDesktop_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2_netDataSetBuscarPlanesMateria.planes' Puede moverla o quitarla según sea necesario.

            this.Text = Modo.ToString();
            this.MapearDeDatos();


        }

        private void BotonAgregarIdPlan_Click(object sender, EventArgs e)
        {
            this.TextBoxIdPlan.Text = (string)this.ComboBoxPlanes.SelectedValue.ToString();
        }

        public new void MapearDeDatos()
        {
            //Carga combo 
            PlanLogic planLogic = new PlanLogic();
            this.ComboBoxPlanes.DataSource = planLogic.GetAll();
            this.ComboBoxPlanes.DisplayMember = "descripcion";
            this.ComboBoxPlanes.ValueMember = "id";
            //seteo campos
            if (this.Modo != ModoForm.Alta){
                this.TextBoxId.Text = this.MateriaActual.ID.ToString();
                this.TextBoxDescripcion.Text = this.MateriaActual.Descripcion;
                this.ComboBoxPlanes.SelectedValue = this.MateriaActual.IdPlan;
                this.TextBoxHsSemanales.Text = this.MateriaActual.HsSemanales.ToString();
                this.TextBoxHsTotales.Text = this.MateriaActual.HsTotales.ToString();
            }
            //Seteo de textos en boton     
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
                    {
                        
                        MateriaActual = new Materia();

                        this.MateriaActual.Descripcion = this.TextBoxDescripcion.Text;
                        this.MateriaActual.IdPlan = Convert.ToInt32(this.TextBoxIdPlan.Text);
                        this.MateriaActual.HsTotales = Convert.ToInt32(this.TextBoxHsTotales.Text);
                        this.MateriaActual.HsSemanales = Convert.ToInt32(this.TextBoxHsSemanales.Text);
                        this.MateriaActual.State = BusinessEntity.States.New;
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        this.TextBoxIdPlan.Enabled = false;
                        this.MateriaActual.Descripcion = this.TextBoxDescripcion.Text;
                        this.MateriaActual.IdPlan = Convert.ToInt32(this.TextBoxIdPlan.Text);
                        this.MateriaActual.HsTotales = Convert.ToInt32(this.TextBoxHsTotales.Text);
                        this.MateriaActual.HsSemanales = Convert.ToInt32(this.TextBoxHsSemanales.Text);
                        this.MateriaActual.State = BusinessEntity.States.Modified;
                        break;
                    }
                case ModoForm.Baja:
                    {
                        this.MateriaActual.State = BusinessEntity.States.Deleted;
                        break;
                    }
                case ModoForm.Consulta:
                    {
                        this.MateriaActual.State = BusinessEntity.States.Unmodified;
                        break;
                    }

            }


        }
        public new void GuardarCambios()
        {
            this.MapearADatos();
            MateriaLogic materiaLogic = new MateriaLogic();
            materiaLogic.Save(this.MateriaActual);


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

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBoxPlanes_SelectedValueChanged(object sender, EventArgs e)
        {
           this.TextBoxIdPlan.Text = this.ComboBoxPlanes.SelectedValue.ToString();
        }
    }
}
