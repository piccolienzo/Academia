using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;


namespace Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {

        public UsuarioAdapter UsuarioData;

        public UsuarioLogic()
        {
            UsuarioData = new UsuarioAdapter();
        }

        public Usuario GetOne(int id)
        {
            return UsuarioData.GetOne(id);
        }

        public Usuario GetOneByUsername(string username)
        {
            return UsuarioData.GetOneByUsername(username);
        }
        public static Usuario UsrAutentication(string username)
        {
            Usuario u = new UsuarioAdapter().GetOneByUsername(username);
            return u;
        }

        public static bool PassForUsrAutentication(string username,string pass)
        {
            Usuario u = new UsuarioAdapter().GetOneByUsername(username);
            if(pass == u.Clave)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public List<Usuario> GetAll()
        {           
            return UsuarioData.GetAll();
        }
        

        public void Save(Usuario user)
        {
            UsuarioData.Save(user);
        }

        public void Delete(int id)
        {
            UsuarioData.Delete(id);
        }

    }
}
