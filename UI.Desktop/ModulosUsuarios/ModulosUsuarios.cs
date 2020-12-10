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
    public partial class ModulosUsuarios : Form
    {
        public ModulosUsuarios()
        {
            InitializeComponent();
            DataGridViewMU.AutoGenerateColumns = false;

        }

        private void Listar()
        {
            this.DataGridViewMU.DataSource = new ModuloUsuarioLogic().GetAll();
        }
        private void ModulosUsuarios_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
        private void BotonModificar_Click(object sender, EventArgs e)
        {
            if (this.DataGridViewMU.SelectedRows is null)
            {

            }
            else
            {
                int id = ((ModuloUsuario)this.DataGridViewMU.SelectedRows[0].DataBoundItem).ID;
                ModulosUsuariosDesktop mud = new ModulosUsuariosDesktop(id,ApplicationForm.ModoForm.Modificacion);
                mud.ShowDialog();
                
            }

            this.Listar();
        }

        private void BotonBorrar_Click(object sender, EventArgs e)
        {
            if (this.DataGridViewMU.SelectedRows is null)
            {

            }
            else
            {
                int id = ((ModuloUsuario)this.DataGridViewMU.SelectedRows[0].DataBoundItem).ID;
                ModulosUsuariosDesktop mud = new ModulosUsuariosDesktop(id,ApplicationForm.ModoForm.Baja);
                mud.ShowDialog();
                
            }

            this.Listar();
        }

        private void BotonNuevo_Click(object sender, EventArgs e)
        {
            ModulosUsuariosDesktop mud = new ModulosUsuariosDesktop(ApplicationForm.ModoForm.Alta);
            mud.ShowDialog(); 
            this.Listar();

        }

        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

       
    }
}
