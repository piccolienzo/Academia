using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Util
{
    public class Personas
    {
        public static List<TiposPersonas> GetTipoPersonas()
        {
            List<TiposPersonas> tp = new List<TiposPersonas>();
            int[] valores = (int[])Enum.GetValues(typeof(Business.Entities.Personas.TiposPersonas));
            string[] tipos = Enum.GetNames(typeof(Business.Entities.Personas.TiposPersonas));
            for (int x=0;x<tipos.Length;x++)
            {
                TiposPersonas tp2 = new TiposPersonas
                {
                    Numero = valores[x],
                    Nombre = tipos[x]

                };
                tp.Add(tp2);
            }
            return tp;



        }
        public class TiposPersonas
        {
            public int Numero { get; set; }
            public string Nombre { get; set; }
        }

    }
}
