using Business.Entities;
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

namespace UI.Desktop
{
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
            DataGridViewCursos.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            CursoLogic comisionLogic = new CursoLogic();
            this.DataGridViewCursos.DataSource = comisionLogic.GetAll();

        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            this.Listar(); 
        }

        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            if (this.DataGridViewCursos.SelectedRows is null)
            {

            }
            else
            {
                int id = ((Curso)this.DataGridViewCursos.SelectedRows[0].DataBoundItem).ID;
                CursosDesktop cursosDesktop = new CursosDesktop(id,ApplicationForm.ModoForm.Modificacion);
                cursosDesktop.ShowDialog(); 
            }
            Listar();
        }

        private void BotonBorrar_Click(object sender, EventArgs e)
        {
            if (this.DataGridViewCursos.SelectedRows is null)
            {

            }
            else
            {
                int id = ((Comision)this.DataGridViewCursos.SelectedRows[0].DataBoundItem).ID;
                CursosDesktop cursosDesktop = new CursosDesktop(id, ApplicationForm.ModoForm.Baja);
                cursosDesktop.ShowDialog();
            }
            Listar();
        }

        private void BotonNuevo_Click(object sender, EventArgs e)
        {
            CursosDesktop cursosDesktop = new CursosDesktop(ApplicationForm.ModoForm.Alta);
            cursosDesktop.ShowDialog();
            this.Listar();
        } 


        
    }
}
