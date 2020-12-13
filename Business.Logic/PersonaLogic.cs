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

        public Persona GetOne(int id)
        {
            return PersonaData.GetOne(id);
        }
        public List<Persona> GetAll()
        {
            return PersonaData.GetAll();
        }


        public void Save(Persona persona)
        {
            PersonaData.Save(persona);
        }

        public void Delete(int id)
        {
            PersonaData.Delete(id);
        }

    }
}
