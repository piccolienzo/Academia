using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Materia : BusinessEntity
    {
        private int hssemanales, hstotales, idplan;
        private string descripcion;

        public int HsSemanales { get { return hssemanales; } set { hssemanales = value; } }
        public int HsTotales { get { return hstotales; } set { hstotales = value; } }
        public int IdPlan { get { return idplan; } set { idplan = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }




    }
}