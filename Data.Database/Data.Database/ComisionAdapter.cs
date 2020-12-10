using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{

    public class ComisionAdapter: Adapter
    {
        public List<Comision> GetAll()
        {
            List<Comision> comisiones = new List<Comision>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdComisiones = new SqlCommand("select * from comisiones",SqlConn);
                SqlDataReader drComisiones = cmdComisiones.ExecuteReader();
                while (drComisiones.Read())
                {
                    Comision com = new Comision
                    {
                        ID = (int)drComisiones["id_comision"],
                        Descripcion = (string)drComisiones["desc_comision"],
                        AñoEspecialidad = (int)drComisiones["anio_especialidad"],
                        IdPlan = (int)drComisiones["id_plan"]
                    };
                    comisiones.Add(com);
                }
                drComisiones.Close();
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                this.CloseConnection();
            }
            return comisiones;
        }
        public Comision GetOne(int ID)
        {
            Comision com = new Comision();
            try
            {
                this.OpenConnection();
                SqlCommand cmdComision = new SqlCommand("select * from comisiones where id_comision = @id ", SqlConn);
                cmdComision.Parameters.Add("@id",SqlDbType.Int).Value = ID;
                SqlDataReader drComision = cmdComision.ExecuteReader();
                if (drComision.Read())
                {
                    com.ID = (int)drComision["id_comision"];
                    com.Descripcion = (string)drComision["desc_comision"];
                    com.AñoEspecialidad = (int)drComision["anio_especialidad"];
                    com.IdPlan = (int)drComision["id_plan"];
                }
                drComision.Close();
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                this.CloseConnection();
            }
            return com;
        }

       
        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdComisionDelete = new SqlCommand("delete comisiones where id_comision = @id", SqlConn);
                cmdComisionDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdComisionDelete.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Update(Comision comision)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdComisionUpdate = new SqlCommand(
                    "update comisiones set desc_comision = @desc_comision, anio_especialidad = @anio_especialidad, id_plan = @id_plan " +
                    "where id_comision = @id", SqlConn);
                cmdComisionUpdate.Parameters.Add("@id", SqlDbType.Int).Value = comision.ID;
                cmdComisionUpdate.Parameters.Add("@desc_comision",SqlDbType.VarChar, 50).Value = comision.Descripcion;
                cmdComisionUpdate.Parameters.Add("@anio_especialidad",SqlDbType.Int).Value = comision.AñoEspecialidad;
                cmdComisionUpdate.Parameters.Add("@id_plan",SqlDbType.Int).Value = comision.IdPlan;
                cmdComisionUpdate.ExecuteNonQuery();
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
        public void Insert(Comision comision)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdComisionInsert = new SqlCommand(
                    "insert into comisiones (desc_comision,anio_especialidad,id_plan) " +
                    "values (@desc_comision,@anio_especialidad,@id_plan) " +
                    "select @@identity" ,SqlConn);
                cmdComisionInsert.Parameters.Add("@desc_comision",SqlDbType.VarChar,50).Value = comision.Descripcion;
                cmdComisionInsert.Parameters.Add("@anio_especialidad", SqlDbType.Int).Value = comision.AñoEspecialidad;
                cmdComisionInsert.Parameters.Add("@id_plan", SqlDbType.Int).Value = comision.IdPlan;
                comision.ID = decimal.ToInt32((decimal)cmdComisionInsert.ExecuteScalar());
            }
            catch (Exception e )
            {
                throw e;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Comision comision)
        {
            if (comision.State == BusinessEntity.States.Deleted)
            {
                this.Delete(comision.ID);
            }
            else if (comision.State == BusinessEntity.States.New)
            {
                this.Insert(comision);
            }
            else if (comision.State == BusinessEntity.States.Modified)
            {
                this.Update(comision);
            }
            comision.State = BusinessEntity.States.Unmodified;
        }

    }
}
