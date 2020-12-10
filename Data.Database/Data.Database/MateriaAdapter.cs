using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class MateriaAdapter : Adapter
    {


        public List<Materia> GetAll()
        {
            List<Materia> materias = new List<Materia>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdGetAll = new SqlCommand("select * from materias", SqlConn);
                SqlDataReader drmaterias = cmdGetAll.ExecuteReader();

                while (drmaterias.Read())
                {
                    Materia mat = new Materia
                    {
                        ID = (int)drmaterias["id_materia"],
                        Descripcion = (string)drmaterias["desc_materia"],
                        HsSemanales = (int)drmaterias["hs_semanales"],
                        HsTotales = (int)drmaterias["hs_totales"],
                        IdPlan = (int)drmaterias["id_plan"]
                    };

                    materias.Add(mat);
                }
                drmaterias.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de materias", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return materias;
        }

        public Business.Entities.Materia GetOne(int ID)
        {
            Materia mat = new Materia();
            try
            {
                this.OpenConnection();
                SqlCommand cmdMateria = new SqlCommand("select * from materias where id_materia = @id", SqlConn);
                cmdMateria.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drMaterias = cmdMateria.ExecuteReader();

                if (drMaterias.Read())
                {

                    mat.ID = (int)drMaterias["id_materia"];
                    mat.Descripcion = (string)drMaterias["desc_materia"];
                    mat.HsSemanales = (int)drMaterias["hs_semanales"];
                    mat.HsTotales = (int)drMaterias["hs_totales"];
                    mat.IdPlan = (int)drMaterias["id_plan"];

                }
                drMaterias.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar datos de la materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return mat;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete materias where id_materia = @id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Materia materia)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpdate = new SqlCommand("UPDATE materias SET  desc_materia=@descripcion, hs_semanales=@hssemanales, " +
                    "hs_totales=@hstotales, id_plan = @id_plan WHERE id_materia=@id", SqlConn);
                cmdUpdate.Parameters.Add("@id_plan", SqlDbType.Int).Value = materia.IdPlan;
                cmdUpdate.Parameters.Add("@id", SqlDbType.Int).Value = materia.ID;
                cmdUpdate.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = materia.Descripcion;
                cmdUpdate.Parameters.Add("@hssemanales", SqlDbType.Int).Value = materia.HsSemanales;
                cmdUpdate.Parameters.Add("@hstotales", SqlDbType.Int).Value = materia.HsTotales;
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de la materia", e);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Materia materia)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand("insert into materias(desc_materia,id_plan,hs_semanales,hs_totales) " +
                    "values(@descripcion,@idplan,@hssemanales,@hstotales) " +
                    "select @@identity", SqlConn);


                cmdInsert.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = materia.Descripcion;
                cmdInsert.Parameters.Add("@idplan", SqlDbType.Int).Value = materia.IdPlan;
                cmdInsert.Parameters.Add("@hssemanales", SqlDbType.Int).Value = materia.HsSemanales;
                cmdInsert.Parameters.Add("@hstotales", SqlDbType.Int).Value = materia.HsTotales;
                materia.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            }
            catch (Exception e)
            {
                Exception ExcepcionManejada = new Exception("Error al crear materia", e);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Materia materia)
        {
            if (materia.State == BusinessEntity.States.New)
            {
                this.Insert(materia);
            }
            else if (materia.State == BusinessEntity.States.Deleted)
            {
                this.Delete(materia.ID);
            }
            else if (materia.State == BusinessEntity.States.Modified)
            {
                this.Update(materia);
            }
            materia.State = BusinessEntity.States.Unmodified;
        }
    }
}