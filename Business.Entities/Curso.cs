using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Business.Entities
{
    public class Curso: BusinessEntity
    {
        private int añocalendario, idmateria, idcomision, cupo;
        

        public int AñoCalendario { get { return añocalendario; } set { añocalendario = value; } }
        public int IdMateria { get { return idmateria; } set { idmateria = value; } }
        public int IdComision { get { return idcomision; } set { idcomision = value; } }
        public int Cupo { get { return cupo; } set { cupo = value; } }

    }
}