using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Util
{
    public class Usuarios
    {
        public static List<UsuariosNomAP> GetUsuariosNomAp()
        {
            Business.Logic.UsuarioLogic blusr = new Business.Logic.UsuarioLogic();
            List<Usuario> lista = blusr.GetAll();
            
            List<UsuariosNomAP> users = (from Usuario usr in lista
                        select new UsuariosNomAP 
                        { ID = usr.ID, NombreApellido = usr.Nombre + " " + usr.Apellido })
                        .ToList();
            return users;
        }

    }

    public class UsuariosNomAP  
    {
        public string NombreApellido { get; set; }
        public int ID { get; set; }

    }
}
