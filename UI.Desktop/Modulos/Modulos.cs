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
    public partial class Modulos : Form
    {
        public Modulos()
        {
            InitializeComponent();
            DataGridViewModulos.AutoGenerateColumns = false;
        }
        public void Listar()
        {
            ModuloLogic moduloLogic = new ModuloLogic();
            this.DataGridViewModulos.DataSource = moduloLogic.GetAll();
        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            if (DataGridViewModulos.SelectedRows is null){ }
            else
            {
                int id = ((Modulo)this.DataGridViewModulos.SelectedRows[0].DataBoundItem).ID;
                ModulosDesktop a = new ModulosDesktop(id, ModulosDesktop.ModoForm.Modificacion);
                a.ShowDialog();
            }
            this.Listar();
        }

        private void BotonBorrar_Click(object sender, EventArgs e)
        {
            if (DataGridViewModulos.SelectedRows is null) { }
            else
            {
                int id = ((Modulo)this.DataGridViewModulos.SelectedRows[0].DataBoundItem).ID;
                ModulosDesktop a = new ModulosDesktop(id, ModulosDesktop.ModoForm.Baja);
                a.ShowDialog();

            }
            this.Listar();
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            ModulosDesktop a = new ModulosDesktop(ModulosDesktop.ModoForm.Alta);
            a.ShowDialog();
            this.Listar();
        }

        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void Modulos_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
