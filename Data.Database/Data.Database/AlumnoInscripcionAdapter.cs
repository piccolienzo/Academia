using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{

    public class AlumnoInscripcionAdapter : Adapter
    {
        public List<AlumnoInscripcion> GetAll()
        {
            List<AlumnoInscripcion> alumnosInscripciones = new List<AlumnoInscripcion>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdaluminsc = new SqlCommand("select * from alumnos_inscripciones", SqlConn);
                SqlDataReader draluminsc = cmdaluminsc.ExecuteReader();
                while (draluminsc.Read())
                {
                    AlumnoInscripcion aluminsc = new AlumnoInscripcion
                    {
                        ID = (int)draluminsc["id_inscripcion"],
                        IdAlumno = (int)draluminsc["id_alumno"],
                        IdCurso = (int)draluminsc["id_curso"],
                        Nota = (int)draluminsc["nota"],
                        Condicion = (string)draluminsc["condicion"]
                    };
                    alumnosInscripciones.Add(aluminsc);
                }
                draluminsc.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.CloseConnection();
            }
            return alumnosInscripciones;
        }
        public AlumnoInscripcion GetOne(int ID)
        {
            AlumnoInscripcion aluminsc = new AlumnoInscripcion();
            try
            {
                this.OpenConnection();
                SqlCommand cmdaluminsc = new SqlCommand("select * from alumnos_inscripciones where id_inscripcion = @id ", SqlConn);
                cmdaluminsc.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader draluminsc = cmdaluminsc.ExecuteReader();
                if (draluminsc.Read())
                {
                    aluminsc.ID = (int)draluminsc["id_inscripcion"];
                    aluminsc.IdAlumno = (int)draluminsc["id_alumno"];
                    aluminsc.IdCurso = (int)draluminsc["id_curso"];
                    aluminsc.Nota = (int)draluminsc["nota"];
                    aluminsc.Condicion = (string)draluminsc["condicion"];
                }
                draluminsc.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.CloseConnection();
            }
            return aluminsc;
        }


        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdaluminscDelete = new SqlCommand("delete alumnos_inscripciones where id_inscripcion = @id", SqlConn);
                cmdaluminscDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdaluminscDelete.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Update(AlumnoInscripcion alumnoInscripcion)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdaluminscUpdate = new SqlCommand(
                    "update alumnos_inscripciones set id_alumno = @id_alumno, id_curso = @id_curso, condicion = @condicion, nota = @nota " +
                    "where id_inscripcion = @id", SqlConn);
                cmdaluminscUpdate.Parameters.Add("@id", SqlDbType.Int).Value = alumnoInscripcion.ID;
                cmdaluminscUpdate.Parameters.Add("@id_alumno", SqlDbType.Int).Value = alumnoInscripcion.IdAlumno;
                cmdaluminscUpdate.Parameters.Add("@id_curso", SqlDbType.Int).Value = alumnoInscripcion.IdCurso;
                cmdaluminscUpdate.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = alumnoInscripcion.Condicion;
                cmdaluminscUpdate.Parameters.Add("@nota", SqlDbType.Int).Value = alumnoInscripcion.Nota;
                cmdaluminscUpdate.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Insert(AlumnoInscripcion alumnoInscripcion)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdaluminscInsert = new SqlCommand(
                    "insert into alumnos_inscripciones (id_alumno,id_curso,condicion,nota) " +
                    "values (@id_alumno,@id_curso,@condicion,@nota) " +
                    "select @@identity", SqlConn);

                cmdaluminscInsert.Parameters.Add("@id_alumno", SqlDbType.Int).Value = alumnoInscripcion.IdAlumno;
                cmdaluminscInsert.Parameters.Add("@id_curso", SqlDbType.Int).Value = alumnoInscripcion.IdCurso;
                cmdaluminscInsert.Parameters.Add("@condicion", SqlDbType.VarChar,50).Value = alumnoInscripcion.Condicion;
                cmdaluminscInsert.Parameters.Add("@nota", SqlDbType.Int).Value = alumnoInscripcion.Nota;
                alumnoInscripcion.ID = decimal.ToInt32((decimal)cmdaluminscInsert.ExecuteScalar());
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(AlumnoInscripcion alumnoInscripcion)
        {
            if (alumnoInscripcion.State == BusinessEntity.States.Deleted)
            {
                this.Delete(alumnoInscripcion.ID);
            }
            else if (alumnoInscripcion.State == BusinessEntity.States.New)
            {
                this.Insert(alumnoInscripcion);
            }
            else if (alumnoInscripcion.State == BusinessEntity.States.Modified)
            {
                this.Update(alumnoInscripcion);
            }
            alumnoInscripcion.State = BusinessEntity.States.Unmodified;
        }

    }
}