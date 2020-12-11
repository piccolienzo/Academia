﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;


namespace Util
{
    class Informes
    {
        private AlumnoInscripcionLogic alumnoInscripcionLogic;
        private CursoLogic cursoLogic;
        private ComisionLogic comisionLogic;
        private PersonaLogic personaLogic;
        private MateriaLogic materiaLogic;
        private PlanLogic planLogic;
        private EspecialidadLogic especialidadLogic;

        public PlanLogic PlanLogic
        {
            get
            {
                if (planLogic == null)
                {
                    planLogic = new PlanLogic();
                }
                return planLogic;
            }
        }
        public EspecialidadLogic EspecialidadLogic
        {
            get
            {
                if(especialidadLogic==null)
                {
                    especialidadLogic = new EspecialidadLogic();
                }
                return especialidadLogic;
            }
        }


        public AlumnoInscripcionLogic AlumnoInscripcionLogic {
            get
            {
                if(alumnoInscripcionLogic == null)
                {
                    alumnoInscripcionLogic = new AlumnoInscripcionLogic();
                }
                return alumnoInscripcionLogic;
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
        public PersonaLogic PersonaLogic
        {
            get
            {
                if (personaLogic == null)
                {
                    personaLogic = new PersonaLogic();
                }
                return personaLogic;
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





        public List<InformeNotas> GetInformeNotas()
        {
            List<InformeNotas> informeNotas = new List<InformeNotas>();

            List<AlumnoInscripcion> alumnoInscripciones = AlumnoInscripcionLogic.GetAll();
            List < Curso > cursos = CursoLogic.GetAll();
            List<Comision> comisiones = ComisionLogic.GetAll();
            List<Business.Entities.Personas> personas = PersonaLogic.GetAll();
            List<Materia> materias = MateriaLogic.GetAll();



            List<InformeNotas> i = (
                    from informe in alumnoInscripciones
                    join persona in personas on informe.IdAlumno equals persona.ID
                    join curso in cursos on informe.IdCurso equals curso.ID
                    join materia in materias on curso.IdMateria equals materia.ID
                    join comision in comisiones on curso.IdComision equals comision.ID

                    select new InformeNotas
                    {
                        IdInscripcion = informe.ID,
                        IdAlumno = persona.ID,
                        NombreApellidoAlumno = persona.Nombre + " " + persona.Apellido,
                        IdCurso = curso.ID,
                        Nota = informe.Nota,
                        LegajoAlumno = persona.Legajo,
                        ComisionDesc = comision.Descripcion,
                        MateriaDesc = materia.Descripcion
                    }
                ).ToList();

            informeNotas = (List<InformeNotas>)i;

            return informeNotas;
        }

        public List<InformePlanes> GetInformePlanes()
        {
            List<Comision> comisiones = ComisionLogic.GetAll();
            List<Business.Entities.Personas> personas = PersonaLogic.GetAll();
            List<Especialidad> especialidades = EspecialidadLogic.GetAll();
            List<Plan> planes = PlanLogic.GetAll();

            List < InformePlanes > informePlanes= (
                from plan in planes
                join especialidad in especialidades on plan.IdEspecialidad equals especialidad.ID
                join comision in comisiones on plan.ID equals comision.IdPlan
                join persona in personas on plan.ID equals persona.IdPlan

                where persona.TipoPersona == Business.Entities.Personas.TiposPersonas.Alumno
                
               
               
            

                select new InformePlanes
                {
                    IdPlan = plan.ID,
                    DescripcionPlan = plan.Descripcion,
                    DescripcionEspecialidad = especialidad.Descripcion,
                    DescripcionComision = comision.Descripcion,
                    TipoPersona = persona.TipoPersona.ToString(),
                    Legajo = persona.Legajo,

                }


              ).ToList();
            return informePlanes;

        }





    }
    class InformePlanes
    {
        public int IdPlan { get; set; }
        public string DescripcionPlan { get; set; }
        public string DescripcionEspecialidad { get; set; }
        public string DescripcionComision { get; set; }
        public string TipoPersona { get; set; }
        public int Legajo { get; set; }
    }
    
    class InformeNotas
    {
        public int IdInscripcion { get; set; }
        public int IdAlumno { get; set; }
        public int IdCurso { get; set; }
        public int Nota { get; set; }
        public int LegajoAlumno { get; set; }
        public string NombreApellidoAlumno { get; set; }
        public string ComisionDesc { get; set; }
        public string MateriaDesc { get; set; }
       
    }

}
