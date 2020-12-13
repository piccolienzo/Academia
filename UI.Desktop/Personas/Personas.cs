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
    public partial class Personas : Form
    {
        public Personas()
        {
            InitializeComponent();
            this.DataGridViewPersonas.AutoGenerateColumns = false;
        }
        
        public void Listar()
        {
            PersonaLogic personaLogic = new PersonaLogic();
            this.DataGridViewPersonas.DataSource = personaLogic.GetAll();
        }

        private void Personas_Load(object sender, EventArgs e)
        {
            Listar();
        }

        

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            if (this.DataGridViewPersonas.SelectedRows is null)
            { }
            else
            {
                int id = ((Business.Entities.Persona)this.DataGridViewPersonas.SelectedRows[0].DataBoundItem).ID;
                PersonasDesktop personasDesktop = new PersonasDesktop(id, PersonasDesktop.ModoForm.Modificacion);
                personasDesktop.ShowDialog();
            }
            this.Listar();
        }

        private void BotonBorrar_Click(object sender, EventArgs e)
        {
            if (this.DataGridViewPersonas.SelectedRows is null)
            { }
            else
            {
                int id = ((Persona)this.DataGridViewPersonas.SelectedRows[0].DataBoundItem).ID;
                PersonasDesktop personasDesktop = new PersonasDesktop(id, PersonasDesktop.ModoForm.Baja);
                personasDesktop.ShowDialog();
            }
            this.Listar();
        }



        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            PersonasDesktop personasDesktop = new PersonasDesktop(PersonasDesktop.ModoForm.Alta);
            personasDesktop.ShowDialog();
            this.Listar();
        }
    }
}
