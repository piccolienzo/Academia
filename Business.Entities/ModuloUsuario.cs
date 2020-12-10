using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class ModuloUsuario: BusinessEntity
    {
        private int idusuario, idmodulo;
        private bool permitealta, permitebaja, permitemodificacion, permiteconsulta;

        public int IdUsuario { get { return idusuario; } set { idusuario = value; } }
        public int IdModulo { get { return idmodulo; } set { idmodulo = value; } }
        public bool PermiteAlta { get { return permitealta; } set { permitealta = value; } }       
        public bool PermiteBaja { get { return permitebaja; } set { permitebaja = value; } }
        public bool PermiteModificacion { get { return permitemodificacion; } set { permitemodificacion = value; } }
        public bool PermiteConsulta { get { return permiteconsulta; } set { permiteconsulta = value; } }


    }
}
