using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Comision : BusinessEntity
    {
        private int añoespecialidad, idplan;
        private string descripcion;


        public int AñoEspecialidad { get { return añoespecialidad; } set { añoespecialidad = value; } }
        public int IdPlan { get { return idplan; } set { idplan = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }


    }

    


}