using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Plan : BusinessEntity
    {
        private int idespecialidad;
        private string descripcion;

        public int IdEspecialidad  { get { return idespecialidad ; } set { idespecialidad = value; } }

        public string Descripcion  { get { return descripcion; } set {  descripcion = value; } }

    }
}