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
    public partial class AlumnosInscripciones : Form
    {
        public AlumnosInscripciones()
        {
            InitializeComponent();
            this.DataGridViewInscripciones.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            AlumnoInscripcionLogic alumnoInscripcionLogic = new AlumnoInscripcionLogic();
            this.DataGridViewInscripciones.DataSource = alumnoInscripcionLogic.GetAll();
        }

        private void AlumnosInscripciones_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void BotonBorrar_Click(object sender, EventArgs e)
        {
            if (this.DataGridViewInscripciones.SelectedRows is null)
            { }
            else
            {
                int id = ((AlumnoInscripcion)this.DataGridViewInscripciones.SelectedRows[0].DataBoundItem).ID;
                AlumnosInscripcionesDesktop usuarioDesktop = new AlumnosInscripcionesDesktop(id, ApplicationForm.ModoForm.Baja);
                usuarioDesktop.ShowDialog();
            }
            this.Listar();
        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            if (this.DataGridViewInscripciones.SelectedRows is null)
            { }
            else
            {
                int id = ((Business.Entities.AlumnoInscripcion)this.DataGridViewInscripciones.SelectedRows[0].DataBoundItem).ID;
                AlumnosInscripcionesDesktop usuarioDesktop = new AlumnosInscripcionesDesktop(id, ApplicationForm.ModoForm.Modificacion);
                usuarioDesktop.ShowDialog();
            }
            this.Listar();
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            AlumnosInscripcionesDesktop aid = new AlumnosInscripcionesDesktop(ApplicationForm.ModoForm.Alta);
            aid.ShowDialog();
            Listar();
        }
        
    }
}
