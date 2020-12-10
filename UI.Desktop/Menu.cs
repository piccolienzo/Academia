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

namespace UI.Desktop
{
    public partial class Menu : Form
    {
        private Usuario _usrEntity;
        private bool _alta, _baja, _modificacion, _consulta;

        private void BotonMenu_Click(object sender, EventArgs e)
        {
            SubPanelMenuView(this.SubPanelMenu);
        }

        private void SubPanelMenuView(Panel subpanel)
        {
            if(subpanel.Visible == false)
            {
                subpanel.Visible = true;
            }
            else
            {
                subpanel.Visible = false;
            }
        }

        

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelChildForms.Controls.Add(childForm);
            PanelChildForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void BotonCursos_Click(object sender, EventArgs e)
        {
            OpenChildForm( new Cursos());
        }


        private void BotonAlumnosInscripciones_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AlumnosInscripciones());
        }

        private void BotonComisiones_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Comisiones());
        }

        private void BotonDocenteCurso_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DocentesCursos());
        }

        private void BotonEspecialidades_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Especialidades());
        }

        private void Botonmaterias_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Materias());
        }

        private void BotonModulos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Modulos() );
        }

        private void BotonModulosUsuarios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ModulosUsuarios());
        }

        private void BotonPersonas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Personas());
        }

        private void BotonPlanes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Planes());
        }

        private void BotonUsuarios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Usuarios());
        }

        private void Alumno()
        {

        }

        private void BotonClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BotonLogOut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void Profesor()
        {

        }

        private void Administrativo()
        {

        }
        public Menu(Usuario usr)
        {          
            InitializeComponent();
            _usrEntity = usr;
            this.SubPanelMenu.Visible = false;
             
        }

    }
}
