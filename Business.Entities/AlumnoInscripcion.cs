using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class AlumnoInscripcion : BusinessEntity
    {
        private int idalumno, idcurso, nota;
        private string condicion;

        public int IdAlumno { get { return idalumno; } set { idalumno = value; } }
        public int IdCurso { get { return idcurso; } set { idcurso = value; } }
        public int Nota { get { return nota; } set { nota = value; } }
        public string Condicion { get { return condicion; } set { condicion = value; } }
        
    }
}