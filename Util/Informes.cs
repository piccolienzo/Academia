using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;


namespace Util
{
    public class Informes
    {
        private AlumnoInscripcionLogic alumnoInscripcionLogic;
        private CursoLogic cursoLogic;
        private ComisionLogic comisionLogic;
        private PersonaLogic personaLogic;
        private MateriaLogic materiaLogic;
        private PlanLogic planLogic;
        private EspecialidadLogic especialidadLogic;

        #region
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
        #endregion

        




        public List<InformeNotas> GetInformeNotas()
        {
            List<InformeNotas> informeNotas = new List<InformeNotas>();

            List<AlumnoInscripcion> alumnoInscripciones = AlumnoInscripcionLogic.GetAll();
            List < Curso > cursos = CursoLogic.GetAll();
            List<Comision> comisiones = ComisionLogic.GetAll();
            List<Business.Entities.Persona> personas = PersonaLogic.GetAll();
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
            var total = informeNotas.Where(x => x.Nota > 6).Sum(x=>x.Nota);

            return informeNotas;
        }

        public List<InformePlanes> GetInformePlanes()
        {
            List<Comision> comisiones = ComisionLogic.GetAll();
            List<Business.Entities.Persona> personas = PersonaLogic.GetAll();
            List<Especialidad> especialidades = EspecialidadLogic.GetAll();
            List<Plan> planes = PlanLogic.GetAll();

            List < InformePlanes > informePlanes= (
                from plan in planes
                join especialidad in especialidades on plan.IdEspecialidad equals especialidad.ID
                join comision in comisiones on plan.ID equals comision.IdPlan
                join persona in personas on plan.ID equals persona.IdPlan

                where persona.TipoPersona == Business.Entities.Persona.TiposPersonas.Alumno
                              
                select new InformePlanes
                {
                    IdPlan = plan.ID,
                    DescripcionPlan = plan.Descripcion,
                    DescripcionEspecialidad = especialidad.Descripcion,
                    DescripcionComision = comision.Descripcion,
                    TipoPersona = persona.Nombre+" "+persona.Apellido,
                    Legajo = persona.Legajo,

                }


              ).ToList();
            return informePlanes;

        }

        public List<InformeCursos> GetInformeComisiones()
        {
            List<AlumnoInscripcion> alumnoInscripciones = AlumnoInscripcionLogic.GetAll();
            List<Curso> cursos = CursoLogic.GetAll();
            List<Comision> comisiones = ComisionLogic.GetAll();
            List<Business.Entities.Persona> personas = PersonaLogic.GetAll();
            List<Materia> materias = MateriaLogic.GetAll();

            List<InformeCursos> x = (

                from curso in cursos
                join materia in materias on curso.IdMateria equals materia.ID
                join comision in comisiones on curso.IdComision equals comision.ID
                join alumnoinscripcion in alumnoInscripciones on curso.ID equals alumnoinscripcion.IdCurso

                 select new InformeCursos
                 {
                     IdCurso = curso.ID,
                     Cupo = curso.Cupo,
                     DescComision = comision.Descripcion,
                     DescMateria = materia.Descripcion,
                     IdAlumnos = alumnoinscripcion.IdAlumno
                 }



                ).ToList();
            return x;

        }



    }
    public class InformeCursos
    {
        public int IdCurso { get; set; }
        public int Cupo { get; set; }
        public string DescMateria { get; set; }
        public string DescComision { get; set; }
        public int IdAlumnos { get; set; }
    }

    public class InformePlanes
    {
        public int IdPlan { get; set; }
        public string DescripcionPlan { get; set; }
        public string DescripcionEspecialidad { get; set; }
        public string DescripcionComision { get; set; }
        public string TipoPersona { get; set; }
        public int Legajo { get; set; }
    }

    public class InformeNotas
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
/*
         List<LiquidacionGasto> listaGastosAgrupados = (from liquidacionGasto in listaLiquidacionGastos
                                                               select new LiquidacionGasto
                                                               {
                                                                   Aprobado = true,
                                                                   EsGastoBldAgro = liquidacionGasto.EsGastoBldAgro,
                                                                   FechaGasto = fechaHasta,
                                                                   IdLote = idLote,
                                                                   IdSubTipoGasto = liquidacionGasto.IdSubTipoGasto,
                                                                   LiquidacionSubTipoGasto = liquidacionGasto.LiquidacionSubTipoGasto,
                                                                   ImporteTotal = listaLiquidacionGastos.Where(x => x.IdSubTipoG
From Andrés Sangrá to Everyone:  07:39 PM
ImporteTotal = listaLiquidacionGastos.Where(x => x.IdSubTipoGasto == liquidacionGasto.IdSubTipoGasto && x.EsGastoBldAgro == liquidacionGasto.EsGastoBldAgro).Sum(y => y.ImporteTotal)
                                                               }).GroupBy(x => new { x.EsGastoBldAgro, x.IdSubTipoGasto }).Select(g => g.First()).ToList();


var listaDtesRepetido = listaOrdenesNegocioMasDeUnLoteAgriness.GroupBy(x => x.NumeroDteFormateado)
                            .Select(c => new
                            {
                                c.Key,
                                Cantidad = c.Select(x => x.NumeroDteFormateado).Count()
                            }).Where(y => y.Cantidad > 1).Select(z => z.Key).ToList();





 */