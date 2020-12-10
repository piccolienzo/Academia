using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class DocenteCurso: BusinessEntity
    {
        public enum TiposCargos
        {
            Teoria,
            Practica,
            Auxiliar,
            Practicante
        }

        private int idcurso, iddocente;
        private TiposCargos cargo;

        public int IdCurso { get { return idcurso; } set { idcurso = value; } }
        public int IdDocente { get { return iddocente; } set { iddocente = value; } }
        public TiposCargos Cargo { get { return cargo; } set { cargo = value; } }



    }
}