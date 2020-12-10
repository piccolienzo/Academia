using Business.Logic;
using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();

        }




        protected void ButtonIngresarLogin_Click(object sender, EventArgs e)
        {
            //Buscar Usuario por username // quitar mayusculas
            this.BuscarUsuario(this.TextBoxUsuarioLogin.Text, this.TextBoxClaveLogin.Text);

            if (this.BuscarUsuario(this.TextBoxUsuarioLogin.Text, this.TextBoxClaveLogin.Text))
            {
                Page.Response.Redirect("~/Home.aspx");
            }
            else
            {
                Page.Response.Write("Credenciales incorrectas");
            }
        }

        private bool BuscarUsuario(string username, string password)
        {
            Business.Entities.Usuario userLogin;
            UsuarioLogic usuarioLogicLogin = new UsuarioLogic();
            userLogin = usuarioLogicLogin.GetOneByUsername(username);

            if (userLogin.Nombre != null)
            {
                if (userLogin.NombreUsuario == username && userLogin.Clave == password)
                {
                    Session["Usuario"] = userLogin;
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }

        }
    }
}