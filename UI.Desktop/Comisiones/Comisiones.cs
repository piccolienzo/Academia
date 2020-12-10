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
    public partial class Comisiones : Form
    {
        public Comisiones()
        {
            InitializeComponent();
            DataGridViewComisiones.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            ComisionLogic comisionLogic = new ComisionLogic();
            this.DataGridViewComisiones.DataSource = comisionLogic.GetAll();
        }

        private void Comisiones_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            ComisionesDesktop comisionesDesktop = new ComisionesDesktop(ComisionesDesktop.ModoForm.Alta);
            comisionesDesktop.ShowDialog();
            this.Listar();
            
        }


        private void BotonActualizar_Click(object sender, EventArgs e)
        {           
            Listar();
        }
        

        private void BotonBorrar_Click(object sender, EventArgs e)
        {
            if (this.DataGridViewComisiones.SelectedRows is null)
            {   }
            else
            {
                int id = ((Comision)this.DataGridViewComisiones.SelectedRows[0].DataBoundItem).ID;
                ComisionesDesktop comisionesDesktop = new ComisionesDesktop(id, ComisionesDesktop.ModoForm.Baja);
                comisionesDesktop.ShowDialog();
            }
            this.Listar();
        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            if (this.DataGridViewComisiones.SelectedRows is null)
            { }            
            else
            {
                int id = ((Comision)this.DataGridViewComisiones.SelectedRows[0].DataBoundItem).ID;
                ComisionesDesktop comisionesDesktop = new ComisionesDesktop(id, ComisionesDesktop.ModoForm.Modificacion);
                comisionesDesktop.ShowDialog();
            }

            Listar();
        }
    }
}
