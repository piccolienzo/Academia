using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Logic;
using Business.Entities;

namespace Util
{
    public  class InscripcionesCursado
    {
        public static List<Curso> CursosParaMateria(int idMateria)
        {
            CursoLogic cursoLogic = new CursoLogic();
            List<Curso> lista = cursoLogic.GetAll();

            List<Curso> cursos = (from Curso x in lista
                                 where x.IdMateria == idMateria
                                 select x).ToList();
            return cursos;

        } //no usado

        public static List<CursoMateriaComsion> CursosMateriaComision()
        {
            CursoLogic cursoLogic = new CursoLogic();
            MateriaLogic materiaLogic = new MateriaLogic();
            ComisionLogic comisionLogic = new ComisionLogic();


            List <Curso> cursos = cursoLogic.GetAll();

            List<CursoMateriaComsion> listcmc = new List<CursoMateriaComsion>();
            
            foreach(Curso cur in cursos)
            {
                CursoMateriaComsion cmc = new CursoMateriaComsion
                {
                    IdCurso = cur.ID,
                    CurMatCom = "Materia: "+materiaLogic.GetOne(cur.IdMateria).Descripcion+" "+
                    "Comision: "+comisionLogic.GetOne(cur.IdComision).Descripcion

                };
                listcmc.Add(cmc);

            }
            return listcmc;
        }
        public static List<AlumnoInscripcion> InscripcionesParaAlumno(int id)
        {
            AlumnoInscripcionLogic ail = new AlumnoInscripcionLogic();
            List<AlumnoInscripcion> listaAlumnosInscrips = ail.GetAll();

            List<AlumnoInscripcion> listaParaAlumno = (from AlumnoInscripcion a in listaAlumnosInscrips
                                                        where a.IdAlumno == id
                                                        select a).ToList();
            return listaParaAlumno;
                
                
        }
        public static void Eliminar(int id_inscripcion)
        {
            AlumnoInscripcionLogic ail = new AlumnoInscripcionLogic();
            ail.Delete(id_inscripcion);
        }

    }
    public class CursoMateriaComsion
    {
        public int IdCurso { get; set; }
        public string CurMatCom { get; set; }

    }

}
