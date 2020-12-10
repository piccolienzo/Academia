using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class EspecialidadAdapter : Adapter
    {
        public List<Especialidad> GetAll()
        {
            List<Especialidad> especialidades = new List<Especialidad>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdEspecialidades = new SqlCommand("select * from especialidades", SqlConn);
                SqlDataReader drEspecialidades = cmdEspecialidades.ExecuteReader();

                while (drEspecialidades.Read())
                {
                    Especialidad esp = new Especialidad();
                    esp.ID = (int)drEspecialidades["id_especialidad"];
                    esp.Descripcion = (string)drEspecialidades["desc_especialidad"];
                    especialidades.Add(esp);
                }
                
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.CloseConnection();
            }
            return especialidades;
        }

        public Especialidad GetOne(int id)
        {
            Especialidad esp = new Especialidad();
            try
            {
                this.OpenConnection();
                SqlCommand cmdEspecialidad = new SqlCommand("select * from especialidades where id_especialidad = @id", SqlConn);
                cmdEspecialidad.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader drEspecialidad = cmdEspecialidad.ExecuteReader();
                if (drEspecialidad.Read())
                {
                    esp.Descripcion = (string)drEspecialidad["desc_especialidad"];
                    esp.ID = (int)drEspecialidad["id_especialidad"];
                }
                drEspecialidad.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.CloseConnection();
            }
            return esp;

        }

        public void Delete(int ID)
        {

            try
            {
                this.OpenConnection();
                SqlCommand cmdEspDelete = new SqlCommand("delete especialidades where id_especialidad = @id", SqlConn);
                cmdEspDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdEspDelete.ExecuteNonQuery();

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

        public void Insert(Especialidad esp)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdEspecialidadInsert = new SqlCommand(
                    "insert into especialidades(desc_especialidad) " +
                    "values(@desc_especialidad) " +
                    "select @@identity", SqlConn);

                cmdEspecialidadInsert.Parameters.Add("@desc_especialidad", SqlDbType.VarChar, 50).Value = esp.Descripcion;
                              
                esp.ID = decimal.ToInt32((decimal)cmdEspecialidadInsert.ExecuteScalar());
                //cmdEspecialidadInsert.ExecuteNonQuery();
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

        public void Update(Especialidad esp)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdEspecialidadUpdate = new SqlCommand(
                    "update especialidades " +
                    "set desc_especialidad = @desc_especialidad " +
                    "where id_especialidad = @id;", SqlConn);
                cmdEspecialidadUpdate.Parameters.Add("@id", SqlDbType.Int).Value=esp.ID;
                cmdEspecialidadUpdate.Parameters.Add("@desc_especialidad", SqlDbType.VarChar,50).Value = esp.Descripcion;
               
                cmdEspecialidadUpdate.ExecuteNonQuery();
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

        public void Save(Especialidad esp)
        {
            if (esp.State == BusinessEntity.States.Deleted)
            {
                this.Delete(esp.ID);
            }
            else if (esp.State == BusinessEntity.States.New)
            {
                this.Insert(esp);
            }
            else if (esp.State == BusinessEntity.States.Modified)
            {
                this.Update(esp);
            }
            esp.State = BusinessEntity.States.Unmodified;
        }

    }
}
