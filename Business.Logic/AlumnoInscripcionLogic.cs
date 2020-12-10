using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{

    public class AlumnoInscripcionLogic : BusinessLogic
    {
        public AlumnoInscripcionAdapter AlumnoInscripcionData;

        public AlumnoInscripcionLogic()
        {
            AlumnoInscripcionData = new AlumnoInscripcionAdapter();
        }

        public AlumnoInscripcion GetOne(int id)
        {
            return AlumnoInscripcionData.GetOne(id);
        }
        public List<AlumnoInscripcion> GetAll()
        {
            return AlumnoInscripcionData.GetAll();
        }


        public void Save(AlumnoInscripcion alumnoInscripcion)
        {
            AlumnoInscripcionData.Save(alumnoInscripcion);
        }

        public void Delete(int id)
        {
            AlumnoInscripcionData.Delete(id);
        }
    }
}