using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class Notas
    {
        private CursoLogic cursoLogic;
        private ComisionLogic comisionLogic;
        private MateriaLogic materiaLogic;
        private DocenteCursoLogic docenteCursoLogic;

        public DocenteCursoLogic DocenteCursoLogic
        {
            get
            {
                if (docenteCursoLogic == null)
                {
                    docenteCursoLogic = new DocenteCursoLogic();
                }
                return docenteCursoLogic;
            }
        }

        public CursoLogic CursoLogic
        {
            get
            {
                if (cursoLogic == null)
                {
                    cursoLogic = new CursoLogic();
                }
                return cursoLogic;
            }
        }
        public ComisionLogic ComisionLogic
        {
            get
            {
                if (comisionLogic == null)
                {
                    comisionLogic = new ComisionLogic();
                }
                return comisionLogic;
            }
        }
        public MateriaLogic MateriaLogic
        {
            get
            {
                if (materiaLogic == null)
                {
                    materiaLogic = new MateriaLogic();
                }
                return materiaLogic;
            }
        }


        public List<CursoMateriaComsionDocente> CursosMateriaComisionParaDocente(int id_docente)
        {
            
            List<Curso> cursos = CursoLogic.GetAll();
            List<Comision> comisiones = ComisionLogic.GetAll();
            List < Materia > materias = MateriaLogic.GetAll();
            List<DocenteCurso> docentes = DocenteCursoLogic.GetAll();
            
            List< CursoMateriaComsionDocente> x = (
               
                from docente in docentes 
                join curso in cursos on docente.IdCurso equals curso.ID
                join materia in materias on curso.IdMateria equals materia.ID
                join comision in comisiones on curso.IdComision equals comision.ID
                where docente.IdDocente == id_docente
                select new CursoMateriaComsionDocente
                {
                    IdCurso = docente.IdCurso,
                    CurMatCom = curso.ID.ToString() + " " + materia.Descripcion+
                    " " + comision.Descripcion + " "+ curso.AñoCalendario.ToString()
                }

                ).ToList();
            

            return x;



        }
        public static List<ListaParaNotas> GetListaParaNotas(int id_curso,int id_docente)
        {
            List<AlumnoInscripcion> alumnoInscripciones = new Business.Logic.AlumnoInscripcionLogic().GetAll();
            List<Business.Entities.Persona> alumnos = Personas.GetAlumnos();
            List<DocenteCurso> docenteCursos = new DocenteCursoLogic().GetAll();


            List<ListaParaNotas> x = (

                from docentecurso in docenteCursos
                join alumins in alumnoInscripciones on docentecurso.IdCurso equals alumins.IdCurso
                join alumno in alumnos on alumins.IdAlumno equals alumno.ID
                where docentecurso.IdDocente == id_docente && docentecurso.IdCurso == id_curso
                select new ListaParaNotas
                {
                    IDInscripcion = alumins.ID,
                    ApellidoNombreAlumno = alumno.Apellido + " " + alumno.Nombre,
                    Nota = alumins.Nota,
                    LegajoAlumno = alumno.Legajo,
                    Condicion = alumins.Condicion
                }


                ).ToList();
            return x;


        }
    }


    public class CursoMateriaComsionDocente
    {
        public int IdCurso { get; set; }
        public string CurMatCom { get; set; }

    }

    public class ListaParaNotas //Listado para gridview de notas
    {
        public int IDInscripcion { get; set; }
        public int Nota { get; set; }
        public string ApellidoNombreAlumno { get; set; }
        public int LegajoAlumno { get; set; }
        public string Condicion { get; set; }

    }
}
