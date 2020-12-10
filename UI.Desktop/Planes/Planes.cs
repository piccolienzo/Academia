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
    public partial class Planes : Form
    {
        public Planes()
        {
            InitializeComponent();
            this.DataGridViewPlanes.AutoGenerateColumns = false;
        }
        public void Listar()
        {
            PlanLogic planesLogic = new PlanLogic();
            this.DataGridViewPlanes.DataSource = planesLogic.GetAll();
        }

        private void Planes_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void BotonEditar_Click(object sender, EventArgs e)
        {
            if (this.DataGridViewPlanes.SelectedRows is null)
            { }
            else
            {
                int id = ((Business.Entities.Plan)this.DataGridViewPlanes.SelectedRows[0].DataBoundItem).ID;
                PlanesDesktop planesDesktop = new PlanesDesktop(id, PlanesDesktop.ModoForm.Modificacion);
                planesDesktop.ShowDialog();
            }
            this.Listar();
        }

        private void BotonBorrar_Click(object sender, EventArgs e)
        {
            if (this.DataGridViewPlanes.SelectedRows is null)
            { }
            else
            {
                int id = ((Business.Entities.Plan)this.DataGridViewPlanes.SelectedRows[0].DataBoundItem).ID;
                PlanesDesktop planesDesktop = new PlanesDesktop(id, PlanesDesktop.ModoForm.Baja);
                planesDesktop.ShowDialog();
            }
            this.Listar();
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            PlanesDesktop planesDesktop = new PlanesDesktop(PlanesDesktop.ModoForm.Alta);
            planesDesktop.ShowDialog();
            this.Listar();
        }

        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
