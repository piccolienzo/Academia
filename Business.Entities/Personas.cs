using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Personas : BusinessEntity
    {
        public enum TiposPersonas
        {
            Alumno=1,
            Docente,
            Personal,
            Admin
        }
        
        private string apellido, direccion, email, nombre, telefono;
        private DateTime fechanacimiento;
        private int legajo, idplan;
        private TiposPersonas tipopersona;

        public int IdPlan { get { return idplan; } set { idplan = value; } }
        public int Legajo { get { return legajo; } set { legajo = value; } }

        public string Apellido { get { return apellido; } set { apellido = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        public TiposPersonas TipoPersona { get { return tipopersona; } set { tipopersona = value; } }
        public DateTime FechaNacimiento { get { return fechanacimiento; } set { fechanacimiento = value; } }




    }
}