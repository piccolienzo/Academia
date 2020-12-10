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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            this.DataGridViewUsuarios.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            UsuarioLogic usuarioLogic = new UsuarioLogic();
            this.DataGridViewUsuarios.DataSource = usuarioLogic.GetAll();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripButtonNuevo_Click(object sender, EventArgs e)
        {
            UsuarioDesktop usuarioDesktop = new UsuarioDesktop(UsuarioDesktop.ModoForm.Alta);
            usuarioDesktop.ShowDialog();
            this.Listar();


        }

        private void ToolStripButtonEditar_Click(object sender, EventArgs e)
        {
            if (this.DataGridViewUsuarios.SelectedRows is null)
            { }
            else { 
                int id = ((Business.Entities.Usuario)this.DataGridViewUsuarios.SelectedRows[0].DataBoundItem).ID;
                UsuarioDesktop usuarioDesktop = new UsuarioDesktop(id, UsuarioDesktop.ModoForm.Modificacion);
                usuarioDesktop.ShowDialog();
            }
            this.Listar();
        }

        private void ToolStripButtonBorrar_Click(object sender, EventArgs e)
        {
            if (this.DataGridViewUsuarios.SelectedRows is null)
            { }
            else
            {
                int id = ((Business.Entities.Usuario)this.DataGridViewUsuarios.SelectedRows[0].DataBoundItem).ID;
                UsuarioDesktop usuarioDesktop = new UsuarioDesktop(id, UsuarioDesktop.ModoForm.Baja);
                usuarioDesktop.ShowDialog();
            }
            this.Listar();
        }

       
    }
}
