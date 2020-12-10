﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    
    public class ModuloLogic : BusinessLogic ////TERMINAR
    {
        public ModuloAdapter ModuloData;

        public ModuloLogic()
        {
            ModuloData = new ModuloAdapter();
        }

        public Modulo GetOne(int id)
        {
            return ModuloData.GetOne(id);
        }
        public List<Modulo> GetAll()
        {
            return ModuloData.GetAll();
        }


        public void Save(Modulo modulo)
        {
            ModuloData.Save(modulo);
        }

        public void Delete(int id)
        {
            ModuloData.Delete(id);
        }
   
    } 
}
