using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class CursoAdapter: Adapter
    {
        public List<Curso> GetAll()
        {
            List<Curso> cursos = new List<Curso>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCursos = new SqlCommand("select * from cursos", SqlConn);
                SqlDataReader drCursos = cmdCursos.ExecuteReader();
                while (drCursos.Read())
                {
                    Curso cur = new Curso
                    {
                        ID = (int)drCursos["id_curso"],
                        
                        IdMateria = (int)drCursos["id_materia"],
                        IdComision = (int)drCursos["id_comision"],
                        AñoCalendario = (int)drCursos["anio_calendario"],
                        Cupo = (int)drCursos["cupo"]
                    };
                    cursos.Add(cur);
                }
                drCursos.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.CloseConnection();
            }
            return cursos;
        }
        public Curso GetOne(int ID)
        {
            Curso cur = new Curso();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCursos = new SqlCommand("select * from cursos where id_curso = @id ", SqlConn);
                cmdCursos.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drCursos = cmdCursos.ExecuteReader();
                if (drCursos.Read())
                {
                    cur.ID = (int)drCursos["id_curso"];
                    cur.IdMateria = (int)drCursos["id_materia"];
                    cur.IdComision = (int)drCursos["id_comision"];
                    cur.AñoCalendario = (int)drCursos["anio_calendario"];
                    cur.Cupo = (int)drCursos["cupo"];
                }
                drCursos.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.CloseConnection();
            }
            return cur;
        }


        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdCursoDelete = new SqlCommand("delete cursos where id_curso = @id", SqlConn);
                cmdCursoDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdCursoDelete.ExecuteNonQuery();
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
        public void Update(Curso curso)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdCursoUpdate = new SqlCommand(
                    "update cursos set id_comision = @id_comision, id_materia = @id_materia, anio_calendario = @anio_calendario, cupo = @cupo " +
                    "where id_comision = @id", SqlConn);
                cmdCursoUpdate.Parameters.Add("@id", SqlDbType.Int).Value = curso.ID;
                cmdCursoUpdate.Parameters.Add("@id_comision", SqlDbType.Int).Value = curso.IdComision;
                cmdCursoUpdate.Parameters.Add("@id_materia", SqlDbType.Int).Value = curso.IdMateria;
                cmdCursoUpdate.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = curso.AñoCalendario;
                cmdCursoUpdate.Parameters.Add("@cupo", SqlDbType.Int).Value = curso.Cupo;
                cmdCursoUpdate.ExecuteNonQuery();
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
        public void Insert(Curso curso)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdCursoInsert = new SqlCommand(
                    "insert into cursos (id_comision, id_materia, anio_calendario, cupo) " +
                    "values (@id_comision, @id_materia, @anio_calendario, @cupo) " +
                    "select @@identity", SqlConn);
                cmdCursoInsert.Parameters.Add("@id_comision", SqlDbType.Int).Value = curso.IdComision;
                cmdCursoInsert.Parameters.Add("@id_materia", SqlDbType.Int).Value = curso.IdMateria;
                cmdCursoInsert.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = curso.AñoCalendario;
                cmdCursoInsert.Parameters.Add("@cupo", SqlDbType.Int).Value = curso.Cupo;
                curso.ID = decimal.ToInt32((decimal)cmdCursoInsert.ExecuteScalar());
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

        public void Save(Curso curso)
        {
            if (curso.State == BusinessEntity.States.Deleted)
            {
                this.Delete(curso.ID);
            }
            else if (curso.State == BusinessEntity.States.New)
            {
                this.Insert(curso);
            }
            else if (curso.State == BusinessEntity.States.Modified)
            {
                this.Update(curso);
            }
            curso.State = BusinessEntity.States.Unmodified;
        }

    }
}
