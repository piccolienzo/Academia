using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace Util
{
    public class Personas
    {
        public static List<TiposPersonas> GetTipoPersonas()
        {
            List<TiposPersonas> tp = new List<TiposPersonas>();
            int[] valores = (int[])Enum.GetValues(typeof(Business.Entities.Persona.TiposPersonas));
            string[] tipos = Enum.GetNames(typeof(Business.Entities.Persona.TiposPersonas));
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

        public static List<TiposCargos> GetTipoCargos()
        {
            List<TiposCargos> tc = new List<TiposCargos>();
            int[] numeros = (int[])Enum.GetValues(typeof(Business.Entities.DocenteCurso.TiposCargos));
            string[] nombres = Enum.GetNames(typeof(Business.Entities.DocenteCurso.TiposCargos));
            for (int x = 0; x < numeros.Length; x++)
            {
                TiposCargos tc2 = new TiposCargos
                {
                    Numero = numeros[x],
                    Nombre = nombres[x]
                };
                tc.Add(tc2);
            }
            return tc;
        }



        public static List<Business.Entities.Persona> GetDocentes()
        {
            List<Business.Entities.Persona> personas = new Business.Logic.PersonaLogic().GetAll();


            List<Business.Entities.Persona> docentes = (from docente in personas
                                                         where docente.TipoPersona == Business.Entities.Persona.TiposPersonas.Docente
                                                         select docente
                                                         ).ToList();
            return docentes;
        }

        public static List<Business.Entities.Persona> GetAlumnos()
        {
            List<Business.Entities.Persona> personas = new Business.Logic.PersonaLogic().GetAll();


            List<Business.Entities.Persona> alumno = (from docente in personas
                                                        where docente.TipoPersona == Business.Entities.Persona.TiposPersonas.Alumno
                                                        select docente
                                                         ).ToList();
            return alumno;
        }

        public class TiposPersonas
        {
            public int Numero { get; set; }
            public string Nombre { get; set; }
        }
        public class TiposCargos
        {
            public int Numero { get; set; }
            public string Nombre { get; set; }
        }

    }
}
