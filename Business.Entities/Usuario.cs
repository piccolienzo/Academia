using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Usuario : BusinessEntity
    {
        private string nombreusuario, clave, nombre, apellido, email;
        private bool habilitado;

        public string NombreUsuario {get { return nombreusuario; } set {nombreusuario = value; }}
        public string Clave { get { return clave; } set { clave = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public string Email { get { return email; } set { email = value; } }
        public bool Habilitado { get { return habilitado; } set { habilitado = value; } }
        public int Id_Persona { get; set; }
    }
}
