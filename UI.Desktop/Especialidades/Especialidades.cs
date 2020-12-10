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
    public partial class Especialidades : ApplicationForm
    {

        
        public Especialidades()
        {
            InitializeComponent();
            this.TextBoxId.Text = "0";
            this.DataGridViewEspecialidades.AutoGenerateColumns = false;

        }


        public void Listar()
        {
            EspecialidadLogic especialidad = new EspecialidadLogic();
            this.DataGridViewEspecialidades.DataSource = especialidad.GetAll();
        }

       

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void Limpiar()
        {
            this.TextBoxId.Text = "0";
            this.TextBoxDescripcion.Text = "";
        }

        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {

            if (this.DataGridViewEspecialidades.SelectedRows is null)
            { }
            else
            {
                int id = ((Business.Entities.Especialidad)this.DataGridViewEspecialidades.SelectedRows[0].DataBoundItem).ID;

                Modo = ModoForm.Baja;
                Especialidad esp = new EspecialidadLogic().GetOne(id);
               
                esp.State = BusinessEntity.States.Deleted;

                EspecialidadLogic espDel = new EspecialidadLogic();
                espDel.Save(esp);


            }
            this.Listar();

        }

        private void BotonEditar_Click(object sender, EventArgs e)
        {
            if (this.DataGridViewEspecialidades.SelectedRows is null)
            { }
            else
            {
                int id = ((Business.Entities.Especialidad)this.DataGridViewEspecialidades.SelectedRows[0].DataBoundItem).ID;
                
                Modo = ModoForm.Modificacion;
                Especialidad esp = new EspecialidadLogic().GetOne(id);
                this.TextBoxId.Text = (esp.ID).ToString();
                this.TextBoxDescripcion.Text = esp.Descripcion;
                


            }
            this.Listar();


        }



        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                int id = int.Parse(this.TextBoxId.Text);
                if (id == 0)
                {
                    Modo = ModoForm.Alta;
                    Especialidad esp = new Especialidad();

                    esp.Descripcion = this.TextBoxDescripcion.Text;
                    esp.State = BusinessEntity.States.New;

                    EspecialidadLogic espsave = new EspecialidadLogic();
                    espsave.Save(esp);

                }
                else
                {
                    Modo = ModoForm.Modificacion;
                    Especialidad esp = new Especialidad();
                    esp.ID = Convert.ToInt32(this.TextBoxId.Text);
                    esp.Descripcion = this.TextBoxDescripcion.Text;
                    esp.State = BusinessEntity.States.Modified;
                    EspecialidadLogic espsave = new EspecialidadLogic();
                    espsave.Save(esp);
                }
                Limpiar();
                Listar();
            }

        }

        private new bool Validar()
        {
            if (string.IsNullOrWhiteSpace(this.TextBoxDescripcion.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void Especialidades_Load(object sender, EventArgs e)
        {
            Listar();
        }

        
       
           
        
    }
}
