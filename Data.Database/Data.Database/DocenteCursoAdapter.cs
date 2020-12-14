using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class DocenteCursoAdapter : Adapter
    {


        public List<DocenteCurso> GetAll()
        {
            List<DocenteCurso> docentesCursos = new List<DocenteCurso>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdGetAll = new SqlCommand("select * from docentes_cursos", SqlConn);
                SqlDataReader drDocentesCursos = cmdGetAll.ExecuteReader();

                while (drDocentesCursos.Read())
                {
                    DocenteCurso docCur = new DocenteCurso
                    {
                        ID = (int)drDocentesCursos["id_dictado"],
                        IdCurso = (int)drDocentesCursos["id_curso"],
                        IdDocente = (int)drDocentesCursos["id_docente"],
                        Cargo = (Business.Entities.DocenteCurso.TiposCargos)(int)drDocentesCursos["cargo"]
                    };

                    docentesCursos.Add(docCur);
                }
                drDocentesCursos.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return docentesCursos;
        }

        public Business.Entities.DocenteCurso GetOne(int ID)
        {
            DocenteCurso docenteCurso = new DocenteCurso();
            try
            {
                this.OpenConnection();
                SqlCommand cmdDocenteCurso = new SqlCommand("select * from docentes_cursos", SqlConn);
                cmdDocenteCurso.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drDocentesCursos = cmdDocenteCurso.ExecuteReader();

                if (drDocentesCursos.Read())
                {

                    docenteCurso.ID = (int)drDocentesCursos["id_dictado"];
                    docenteCurso.IdCurso = (int)drDocentesCursos["id_curso"];
                    docenteCurso.IdDocente = (int)drDocentesCursos["id_docente"];
                    docenteCurso.Cargo = (Business.Entities.DocenteCurso.TiposCargos)(int)drDocentesCursos["cargo"];


                }
                drDocentesCursos.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar datos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return docenteCurso;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete docentes_cursos where id_dictado = @id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(DocenteCurso docenteCurso)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpdate = new SqlCommand("UPDATE docentes_cursos SET  id_curso=@idcurso, id_docente=@iddocente, " +
                    "cargo=@cargo WHERE id_dictado=@id", SqlConn);

                cmdUpdate.Parameters.Add("@id", SqlDbType.Int).Value = docenteCurso.ID;
                cmdUpdate.Parameters.Add("@idcurso", SqlDbType.Int).Value = docenteCurso.IdCurso;
                cmdUpdate.Parameters.Add("@iddocente", SqlDbType.Int).Value = docenteCurso.IdDocente;
                cmdUpdate.Parameters.Add("@cargo", SqlDbType.Int).Value = docenteCurso.Cargo;
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos", e);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(DocenteCurso docenteCurso)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand("insert into docentes_cursos(id_curso,id_docente,cargo) " +
                    "values(@idcurso,@iddocente,@cargo) " +
                    "select @@identity", SqlConn);


                cmdInsert.Parameters.Add("@idcurso", SqlDbType.VarChar).Value = docenteCurso.IdCurso;
                cmdInsert.Parameters.Add("@iddocente", SqlDbType.Int).Value = docenteCurso.IdDocente;
                cmdInsert.Parameters.Add("@cargo", SqlDbType.Int).Value = docenteCurso.Cargo;
                docenteCurso.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            }
            catch (Exception e)
            {
                Exception ExcepcionManejada = new Exception("Error al crear", e);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(DocenteCurso docenteCurso)
        {
            if (docenteCurso.State == BusinessEntity.States.New)
            {
                this.Insert(docenteCurso);
            }
            else if (docenteCurso.State == BusinessEntity.States.Deleted)
            {
                this.Delete(docenteCurso.ID);
            }
            else if (docenteCurso.State == BusinessEntity.States.Modified)
            {
                this.Update(docenteCurso);
            }
            docenteCurso.State = BusinessEntity.States.Unmodified;
        }
    }
}