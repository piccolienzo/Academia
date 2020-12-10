using Business.Entities;
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
    public partial class Materias : Form
    {
        public Materias()
        {
            InitializeComponent();
            this.DataGridViewMaterias.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            MateriaLogic materiaLogic = new MateriaLogic();
            this.DataGridViewMaterias.DataSource = materiaLogic.GetAll();
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            Listar();

        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            if (this.DataGridViewMaterias.SelectedRows is null)
            { }
            else
            {
                int id = ((Business.Entities.Materia)this.DataGridViewMaterias.SelectedRows[0].DataBoundItem).ID;
                MateriasDesktop materiasDesktop = new MateriasDesktop(id, MateriasDesktop.ModoForm.Modificacion);
                materiasDesktop.ShowDialog();
            }
            this.Listar();
        }

        private void BotonBorrar_Click(object sender, EventArgs e)
        {
            if (this.DataGridViewMaterias.SelectedRows is null)
            { }
            else
            {
                int id = ((Materia)this.DataGridViewMaterias.SelectedRows[0].DataBoundItem).ID;
                MateriasDesktop materiasDesktop = new MateriasDesktop(id, MateriasDesktop.ModoForm.Baja);
                materiasDesktop.ShowDialog();
            }
            this.Listar();
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            MateriasDesktop materiasDesktop = new MateriasDesktop(MateriasDesktop.ModoForm.Alta);
            materiasDesktop.ShowDialog();
            this.Listar();
        }

        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
