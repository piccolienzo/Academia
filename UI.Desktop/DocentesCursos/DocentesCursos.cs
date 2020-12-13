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

namespace UI.Desktop
{
    public partial class DocentesCursos : Form
    {

        public DocentesCursos()
        {
            InitializeComponent();
            this.DataGridViewDocentesCursos.AutoGenerateColumns = false;
        }
        public void Listar()
        {
            DocenteCursoLogic docenteCursoLogic = new DocenteCursoLogic();
            this.DataGridViewDocentesCursos.DataSource = docenteCursoLogic.GetAll();
        }

        private void DocentesCursos_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void BotonEditar_Click(object sender, EventArgs e)
        {
            if (this.DataGridViewDocentesCursos.SelectedRows is null)
            { }
            else
            {
                int id = ((Business.Entities.DocenteCurso)this.DataGridViewDocentesCursos.SelectedRows[0].DataBoundItem).ID;
                DocentesCursosDesktop docentesCursosDesktop = new DocentesCursosDesktop(id, DocentesCursosDesktop.ModoForm.Modificacion);
                docentesCursosDesktop.ShowDialog();
            }
            this.Listar();
        }

        private void BotonBorrar_Click(object sender, EventArgs e)
        {
            if (this.DataGridViewDocentesCursos.SelectedRows is null)
            { }
            else
            {
                
                int id = ((Business.Entities.DocenteCurso)this.DataGridViewDocentesCursos.SelectedRows[0].DataBoundItem).ID;
                DocentesCursosDesktop docentesCursosDesktop = new DocentesCursosDesktop(id, DocentesCursosDesktop.ModoForm.Baja);
                docentesCursosDesktop.ShowDialog();
            }
            this.Listar();
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            DocentesCursosDesktop docentesCursosDesktop = new DocentesCursosDesktop(DocentesCursosDesktop.ModoForm.Alta);
            docentesCursosDesktop.ShowDialog();
            this.Listar();
        }

        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
