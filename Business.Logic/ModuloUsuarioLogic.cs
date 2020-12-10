using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{

    public class ModuloUsuarioLogic : BusinessLogic 
    {
        public ModuloUsuarioAdapter ModuloUsuarioData;

        public ModuloUsuarioLogic()
        {
            ModuloUsuarioData = new ModuloUsuarioAdapter();
        }

        public ModuloUsuario GetOne(int id)
        {
            return ModuloUsuarioData.GetOne(id);
        }
        public List<ModuloUsuario> GetAll()
        {
            return ModuloUsuarioData.GetAll();
        }


        public void Save(ModuloUsuario modulousuario)
        {
            ModuloUsuarioData.Save(modulousuario);
        }

        public void Delete(int id)
        {
            ModuloUsuarioData.Delete(id);
        }

    }
}