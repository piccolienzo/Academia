using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data.Database
{
    public class PersonaAdapter : Adapter
    {
        public List<Personas> GetAll()
        {
            List<Personas> personas = new List<Personas>();
            try
            {
                
                this.OpenConnection();
                SqlCommand cmdPersonas = new SqlCommand("select * from personas", SqlConn);

                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();

                while (drPersonas.Read())
                {
                    Personas per = new Personas
                    {
                        ID = (int)drPersonas["id_persona"],
                        Nombre = (string)drPersonas["nombre"],
                        Apellido = (string)drPersonas["apellido"],
                        Direccion = (string)drPersonas["direccion"],
                        Email = (string)drPersonas["email"],
                        Telefono = (string)drPersonas["telefono"],
                        FechaNacimiento = (DateTime)drPersonas["fecha_nac"],
                        Legajo = (int)drPersonas["legajo"],
                        TipoPersona = ((Personas.TiposPersonas)(int)drPersonas["tipo_persona"]),
                        IdPlan = (int)drPersonas["id_plan"]


                    };
                    personas.Add(per);
                }
                drPersonas.Close();
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                this.CloseConnection();
            }
            return personas;
            
        }

        public Personas GetOne(int ID)
        {
            Personas per = new Personas();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPersonas = new SqlCommand("select * from personas where id_persona = @id ", SqlConn);
                cmdPersonas.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();
                if (drPersonas.Read())
                {
                    per.ID = (int)drPersonas["id_persona"];
                    per.Nombre = (string)drPersonas["nombre"];
                    per.Apellido = (string)drPersonas["apellido"];
                    per.Direccion = (string)drPersonas["direccion"];
                    per.Email = (string)drPersonas["email"];
                    per.Telefono = (string)drPersonas["telefono"];
                    per.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                    per.Legajo = (int)drPersonas["legajo"];
                    per.TipoPersona = ((Personas.TiposPersonas)(int)drPersonas["tipo_persona"]);
                    per.IdPlan = (int)drPersonas["id_plan"];
                }
                drPersonas.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.CloseConnection();
            }
            return per;
        }


        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdPersonaDelete = new SqlCommand("delete personas where id_persona = @id", SqlConn);
                cmdPersonaDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdPersonaDelete.ExecuteNonQuery();
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
        public void Update(Personas persona)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdPersonaUpdate = new SqlCommand(
                    "update personas set nombre = @nombre, apellido = @apellido, direccion = @direccion, email = @email," +
                    "telefono = @telefono, fecha_nac = @fecha_nac, legajo = @legajo, tipo_persona = @tipo_persona, id_plan = @id_plan " +
                    "where id_persona = @id", SqlConn);
                cmdPersonaUpdate.Parameters.Add("@id", SqlDbType.Int).Value = persona.ID;
                cmdPersonaUpdate.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = persona.Nombre;
                cmdPersonaUpdate.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = persona.Apellido;
                cmdPersonaUpdate.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = persona.Direccion;
                cmdPersonaUpdate.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = persona.Email;
                cmdPersonaUpdate.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = persona.Telefono;
                cmdPersonaUpdate.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = persona.FechaNacimiento;
                cmdPersonaUpdate.Parameters.Add("@legajo", SqlDbType.VarChar, 50).Value = persona.Legajo;
                cmdPersonaUpdate.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = (int)persona.TipoPersona;
                cmdPersonaUpdate.Parameters.Add("@id_plan", SqlDbType.Int).Value = persona.IdPlan;
                cmdPersonaUpdate.ExecuteNonQuery();
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
        public void Insert(Personas persona)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdPersonaInsert = new SqlCommand(
                    "insert into personas (nombre,apellido,direccion,email,telefono,fecha_nac,legajo,tipo_persona,id_plan) " +
                    "values (@nombre,@apellido,@direccion,@email,@telefono,@fecha_nac,@legajo,@tipo_persona,@id_plan) " +
                    "select @@identity", SqlConn);
                cmdPersonaInsert.Parameters.Add("@nombre", SqlDbType.VarChar,50).Value = persona.Nombre;
                cmdPersonaInsert.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = persona.Apellido;
                cmdPersonaInsert.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = persona.Direccion;
                cmdPersonaInsert.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = persona.Email;
                cmdPersonaInsert.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = persona.Telefono;
                cmdPersonaInsert.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = persona.FechaNacimiento;
                cmdPersonaInsert.Parameters.Add("@legajo", SqlDbType.VarChar, 50).Value = persona.Legajo;
                cmdPersonaInsert.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = (int)persona.TipoPersona;
                cmdPersonaInsert.Parameters.Add("@id_plan", SqlDbType.Int).Value = persona.IdPlan;

                persona.ID = decimal.ToInt32((decimal)cmdPersonaInsert.ExecuteScalar());
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

        public void Save(Personas persona)
        {
            if (persona.State == BusinessEntity.States.Deleted)
            {
                this.Delete(persona.ID);
            }
            else if (persona.State == BusinessEntity.States.New)
            {
                this.Insert(persona);
            }
            else if (persona.State == BusinessEntity.States.Modified)
            {
                this.Update(persona);
            }
            persona.State = BusinessEntity.States.Unmodified;
        }








    }
}
