using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class ModuloAdapter: Adapter
    {
        public List<Modulo> GetAll()
        {
            List<Modulo> modulo = new List<Modulo>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdModulos = new SqlCommand("select * from modulos", SqlConn);
                SqlDataReader drModulos = cmdModulos.ExecuteReader();

                while (drModulos.Read())
                {
                    Modulo mod = new Modulo();
                    mod.ID = (int)drModulos["id_modulo"];
                    mod.Descripcion = (string)drModulos["desc_modulo"];
                    mod.Ejecuta = (string)drModulos["ejecuta"];
                    modulo.Add(mod);
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
            return modulo;
        }

        public Modulo GetOne(int id) //OK
        {
            Modulo mod = new Modulo();
            try
            {
                this.OpenConnection();
                SqlCommand cmdModulo = new SqlCommand("select * from modulos where id_modulo = @id", SqlConn);
                cmdModulo.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader drModulo = cmdModulo.ExecuteReader();
                if (drModulo.Read())
                {
                    mod.Descripcion = (string)drModulo["desc_modulo"];
                    mod.ID = (int)drModulo["id_modulo"];
                    mod.Ejecuta = (string)drModulo["ejecuta"];
                    //mod.Ejecuta Este dato está implementado en bd preguntar
                }
                drModulo.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.CloseConnection();
            }
            return mod;

        }

        public void Delete(int ID)
        {

            try
            {
                this.OpenConnection();
                SqlCommand cmdModDelete = new SqlCommand("delete modulos where id_modulo = @id", SqlConn);
                cmdModDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdModDelete.ExecuteNonQuery();

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

        public void Insert(Modulo mod) //OK
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdModuloInsert = new SqlCommand(
                    "insert into modulos(desc_modulo,ejecuta) " +
                    "values(@desc_modulo,@ejecuta) " +
                    "select @@identity", SqlConn);

                cmdModuloInsert.Parameters.Add("@desc_modulo", SqlDbType.VarChar, 50).Value = mod.Descripcion;
                if(mod.Ejecuta==null)
                    cmdModuloInsert.Parameters.Add("@ejecuta", SqlDbType.VarChar, 50).Value = "No especificado";
                else
                    cmdModuloInsert.Parameters.Add("@ejecuta", SqlDbType.VarChar, 50).Value = mod.Ejecuta;

                mod.ID = decimal.ToInt32((decimal)cmdModuloInsert.ExecuteScalar());
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

        public void Update(Modulo mod)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdModuloUpdate = new SqlCommand(
                    "update modulos " +
                    "set desc_modulo = @desc_modulo, ejecuta = @ejecuta " +
                    "where id_modulo = @id;", SqlConn);
                cmdModuloUpdate.Parameters.Add("@id", SqlDbType.Int).Value = mod.ID;
                cmdModuloUpdate.Parameters.Add("@desc_modulo", SqlDbType.VarChar, 50).Value = mod.Descripcion;
                cmdModuloUpdate.Parameters.Add("@ejecuta", SqlDbType.VarChar, 50).Value = mod.Ejecuta;

                cmdModuloUpdate.ExecuteNonQuery();
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

        public void Save(Modulo mod) //OK
        {
            if (mod.State == BusinessEntity.States.Deleted)
            {
                this.Delete(mod.ID);
            }
            else if (mod.State == BusinessEntity.States.New)
            {
                this.Insert(mod);
            }
            else if (mod.State == BusinessEntity.States.Modified)
            {
                this.Update(mod);
            }
            mod.State = BusinessEntity.States.Unmodified;
        }

    }
}

