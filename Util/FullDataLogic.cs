using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class FullDataLogic
    {
        

        public static List<FullCom> GetAllFullComision()
        {
            var listCom = new ComisionLogic().GetAll();

            List<FullCom> fullComs = (
                from comision in listCom
                select new FullCom
                {
                    ID = comision.ID,
                    AñoEspecialidad = comision.AñoEspecialidad,
                    IdPlan = comision.IdPlan,
                    Descripcion = comision.Descripcion,
                    NombrePlan =new PlanLogic().GetOne(comision.IdPlan).Descripcion
                }
                ).ToList();

            return fullComs;

        }

        public static List<FullCurs> GetAllFullCurso()
        {
            var listCursos = new CursoLogic().GetAll();
            List<FullCurs> fullCurs = (
                from curso in listCursos
                select new FullCurs
                {
                    ID = curso.ID,
                    AñoCalendario = curso.AñoCalendario,
                    Cupo = curso.Cupo,
                    IdMateria = curso.IdMateria,
                    IdComision = curso.IdComision,
                    NombreComision = new ComisionLogic().GetOne(curso.IdComision).Descripcion,
                    NombreMateria = new MateriaLogic().GetOne(curso.IdMateria).Descripcion
                }
                ).ToList();
            return fullCurs;
        }

        public static List<FullMats> GetAllFullMateria()
        {
            var listMats = new MateriaLogic().GetAll();

            List<FullMats> fullMats = (
                from materia in listMats
                select new FullMats
                {
                    ID = materia.ID,
                    HsSemanales = materia.HsSemanales,
                    HsTotales = materia.HsTotales,
                    Descripcion = materia.Descripcion,
                    IdPlan = materia.IdPlan,

                    NombrePlan = new PlanLogic().GetOne(materia.IdPlan).Descripcion
                }
                ).ToList();

            return fullMats;

        }

        public static List<FullPlan> GetAllFullPlan()
        {
            var listPlan = new PlanLogic().GetAll();
            List<FullPlan> fullPlans = (
                from plan in listPlan 
                select new FullPlan
                {
                    ID = plan.ID,
                    Descripcion = plan.Descripcion,
                    IdEspecialidad = plan.IdEspecialidad,
                    NombreEspecialidad = new EspecialidadLogic().GetOne(plan.IdEspecialidad).Descripcion
                    
                }).ToList();
            return fullPlans;

        }
        public static List<FullDocenteCurso> GetAllFullDocenteCurso()
        {
            var docentes = new DocenteCursoLogic().GetAll();

            List<FullDocenteCurso> fullDocenteCursos = (
                from docente in docentes
                select new FullDocenteCurso
                {
                    ID = docente.ID,
                    Cargo = docente.Cargo,
                    IdCurso = docente.IdCurso,                    
                    IdDocente = docente.IdDocente,
                    NombreApellidoDocente = Personas.FindDocente(docente.IdDocente).Nombre+ " "  + Personas.FindDocente(docente.IdDocente).Apellido
                }
                ).ToList();

            return fullDocenteCursos;
        }


    }

    public class FullCom : Comision
    {
        public string NombrePlan { get; set; }
    }
    public class FullCurs : Curso
    {
        public string NombreComision { get; set; }
        public string NombreMateria { get; set; }
    }
    public class FullMats : Materia
    {
        public string NombrePlan{ get; set; }
    }
    public class FullPlan : Plan
    {
        public string NombreEspecialidad { get; set; }
    }
    public class FullDocenteCurso : DocenteCurso
    {
        
        public string NombreApellidoDocente { get; set; }
    }
}
