using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class PersonaLogic : BusinessLogic
    {
        public PersonaAdapter PersonaData;

        public PersonaLogic()
        {
            PersonaData = new PersonaAdapter();
        }

        public Personas GetOne(int id)
        {
            return PersonaData.GetOne(id);
        }
        public List<Personas> GetAll()
        {
            return PersonaData.GetAll();
        }


        public void Save(Personas persona)
        {
            PersonaData.Save(persona);
        }

        public void Delete(int id)
        {
            PersonaData.Delete(id);
        }

    }
}
