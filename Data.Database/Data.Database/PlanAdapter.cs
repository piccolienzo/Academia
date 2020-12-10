using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class PlanAdapter : Adapter
    {
        public List<Plan> GetAll()
        {
            List<Plan> planes = new List<Plan>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPlanes = new SqlCommand("select * from planes", SqlConn);
                SqlDataReader drPlanes = cmdPlanes.ExecuteReader();

                while (drPlanes.Read())
                {
                    Plan plan = new Plan
                    {
                        ID = (int)drPlanes["id_plan"],
                        Descripcion = (string)drPlanes["desc_plan"],
                        IdEspecialidad = (int)drPlanes["id_especialidad"]
                    };
                    planes.Add(plan);
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
            return planes;
        }

        public Plan GetOne(int id)
        {
            Plan plan = new Plan();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPlanes = new SqlCommand("select * from planes where id_plan = @id", SqlConn);
                cmdPlanes.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader drPlanes = cmdPlanes.ExecuteReader();
                if (drPlanes.Read())
                {
                    plan.Descripcion = (string)drPlanes["desc_plan"];
                    plan.IdEspecialidad = (int)drPlanes["id_especialidad"];
                    plan.ID = (int)drPlanes["id_plan"];
                }
                drPlanes.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.CloseConnection();
            }
            return plan;

        }

        public void Delete(int ID)
        {

            try
            {
                this.OpenConnection();
                SqlCommand cmdPlanDelete = new SqlCommand("delete planes where id_plan = @id", SqlConn);
                cmdPlanDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                
                cmdPlanDelete.ExecuteNonQuery();

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

        public void Insert(Plan plan)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdPlanesInsert = new SqlCommand(
                    "insert into planes(desc_plan,id_especialidad) " +
                    "values(@desc_plan, @id_especialidad) " +
                    "select @@identity", SqlConn);

                cmdPlanesInsert.Parameters.Add("@desc_plan", SqlDbType.VarChar, 50).Value = plan.Descripcion;
                cmdPlanesInsert.Parameters.Add("@id_especialidad", SqlDbType.VarChar, 50).Value = plan.IdEspecialidad;

                plan.ID = decimal.ToInt32((decimal)cmdPlanesInsert.ExecuteScalar());
                //cmdPlanesInsert.ExecuteNonQuery();
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

        public void Update(Plan plan)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdPlanUpdate = new SqlCommand(
                    "update planes set desc_plan = @desc_plan " +
                    "where id_plan = @id", SqlConn);
                cmdPlanUpdate.Parameters.Add("@id", SqlDbType.Int).Value = plan.ID;
                cmdPlanUpdate.Parameters.Add("@desc_plan", SqlDbType.VarChar, 50).Value = plan.Descripcion;

                cmdPlanUpdate.ExecuteNonQuery();
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

        public void Save(Plan plan)
        {
            if (plan.State == BusinessEntity.States.Deleted)
            {
                this.Delete(plan.ID);
            }
            else if (plan.State == BusinessEntity.States.New)
            {
                this.Insert(plan);
            }
            else if (plan.State == BusinessEntity.States.Modified)
            {
                this.Update(plan);
            }
            plan.State = BusinessEntity.States.Unmodified;
        }

    }
}