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
    public partial class Login : Form
    {
        private bool _foundUsername = false;
        private bool _foundPassword= false;
        private string _username;
        private string _password;
        private Usuario UsuarioLogin;
        
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                this.CreateUser();
                UI.Desktop.Menu menu = new Menu(UsuarioLogin);
                this.Hide();
                DialogResult r = menu.ShowDialog();
                
                if (r == DialogResult.OK)
                {
                    this.ClearAll();
                    this.Show();

                }
                else if (r == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                

            }
        }

        private void ClearAll()
        {
            _username = string.Empty;
            _password = string.Empty;
            TxtPassword.Text = string.Empty;
        }

        private bool Validar()
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                
                return true;
            }
            else
            {
                return false;
            }
        }


        private void TxtUser_Validating(object sender, CancelEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(t.Text) == true || string.IsNullOrEmpty(t.Text) == true)
            {
                e.Cancel = true;
                errorProvider1.SetError(t, "No debe estar en blanco");
                _foundUsername = false;
            }

            if (string.IsNullOrWhiteSpace(this.TxtPassword.Text) == false || string.IsNullOrEmpty(this.TxtPassword.Text) == false)
            {
                if (UsuarioLogic.UsrAutentication(t.Text).NombreUsuario == null)
                {               
                    e.Cancel = true;
                    errorProvider1.SetError(t, "Usuario Inválido");
                    _foundUsername = false;
                }
            }
            


        }

        private void TxtUser_Validated(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            errorProvider1.SetError(t, "");
            _username = t.Text;
            _foundUsername = true;
            
        }

        private void TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(t, "No debe estar en blanco");
                
            }
            if (_foundUsername)
            {
                if (UsuarioLogic.PassForUsrAutentication(_username,t.Text)==false)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(t, "Usuario y contraseña no coinciden");

                }                
            }
            
            
            


        }

        private void TxtPassword_Validated(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            _password = t.Text;
            errorProvider1.SetError(t, "");

        }
        private void CreateUser()
        {
            Usuario usr = new UsuarioLogic().GetOneByUsername(_username);
            this.UsuarioLogin = usr;
        }
    }
}
