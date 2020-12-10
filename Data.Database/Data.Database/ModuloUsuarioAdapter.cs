using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class ModuloUsuarioAdapter : Adapter
    {
        public List<ModuloUsuario> GetAll()
        {
            List<ModuloUsuario> modulousuario = new List<ModuloUsuario>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdModulosUsuarios = new SqlCommand("select * from modulos_usuarios", SqlConn);
                SqlDataReader drModulosUsuarios = cmdModulosUsuarios.ExecuteReader();

                while (drModulosUsuarios.Read())
                {
                    ModuloUsuario modusr = new ModuloUsuario();
                    modusr.ID = (int)drModulosUsuarios["id_modulo_usuario"];
                    modusr.IdModulo = (int)drModulosUsuarios["id_modulo"];
                    modusr.IdUsuario = (int)drModulosUsuarios["id_usuario"];
                    modusr.PermiteAlta = (bool)drModulosUsuarios["alta"];
                    modusr.PermiteBaja = (bool)drModulosUsuarios["baja"];
                    modusr.PermiteModificacion = (bool)drModulosUsuarios["modificacion"];
                    modusr.PermiteConsulta = (bool)drModulosUsuarios["consulta"];

                    modulousuario.Add(modusr);
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
            return modulousuario;
        }

        public ModuloUsuario GetOne(int id) 
        {
            ModuloUsuario modusr = new ModuloUsuario();
            try
            {
                this.OpenConnection();
                SqlCommand cmdModulosUsuarios = new SqlCommand("select * from modulos_usuarios where id_modulo_usuario = @id", SqlConn);
                cmdModulosUsuarios.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader drModulosUsuarios = cmdModulosUsuarios.ExecuteReader();
                if (drModulosUsuarios.Read())
                {
                    modusr.ID = (int)drModulosUsuarios["id_modulo_usuario"];
                    modusr.IdModulo = (int)drModulosUsuarios["id_modulo"];
                    modusr.IdUsuario = (int)drModulosUsuarios["id_usuario"];
                    modusr.PermiteAlta = (bool)drModulosUsuarios["alta"];
                    modusr.PermiteBaja = (bool)drModulosUsuarios["baja"];
                    modusr.PermiteModificacion = (bool)drModulosUsuarios["modificacion"];
                    modusr.PermiteConsulta = (bool)drModulosUsuarios["consulta"];
                }
                drModulosUsuarios.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.CloseConnection();
            }
            return modusr;

        }

        public void Delete(int ID)
        {

            try
            {
                this.OpenConnection();
                SqlCommand cmdModDelete = new SqlCommand("delete modulos_usuarios where id_modulo_usuario = @id", SqlConn);
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

        public void Insert(ModuloUsuario modusr) //OK
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdModuloUsuarioInsert = new SqlCommand(
                    "insert into modulos_usuarios(id_modulo,id_usuario,alta,baja,modificacion,consulta) " +
                    "values(@id_modulo,@id_usuario,@alta,@baja,@modificacion,@consulta) " +
                    "select @@identity", SqlConn);

                cmdModuloUsuarioInsert.Parameters.Add("@id_modulo", SqlDbType.Int).Value = modusr.IdModulo;
                cmdModuloUsuarioInsert.Parameters.Add("@id_usuario", SqlDbType.Int).Value = modusr.IdUsuario;
                cmdModuloUsuarioInsert.Parameters.Add("@alta", SqlDbType.Bit).Value =modusr.PermiteAlta ;
                cmdModuloUsuarioInsert.Parameters.Add("@baja", SqlDbType.Bit).Value = modusr.PermiteBaja;
                cmdModuloUsuarioInsert.Parameters.Add("@modificacion", SqlDbType.Bit).Value = modusr.PermiteModificacion;
                cmdModuloUsuarioInsert.Parameters.Add("@consulta", SqlDbType.Bit).Value = modusr.PermiteConsulta ;

                modusr.ID = decimal.ToInt32((decimal)cmdModuloUsuarioInsert.ExecuteScalar());
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

        public void Update(ModuloUsuario modusr)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdModulosUsuariosUpdate = new SqlCommand(
                    "update modulos_usuarios " +
                    "set id_modulo=@id_modulo , id_usuario = @id_usuario , alta = @alta , " +
                    "baja = @baja , modificacion = @modificacion , consulta = @consulta " +

                    "where id_modulo_usuario = @id;", SqlConn);
                cmdModulosUsuariosUpdate.Parameters.Add("@id", SqlDbType.Int).Value = modusr.ID;

                cmdModulosUsuariosUpdate.Parameters.Add("@id_modulo", SqlDbType.Int).Value = modusr.IdModulo;
                cmdModulosUsuariosUpdate.Parameters.Add("@id_usuario", SqlDbType.Int).Value = modusr.IdUsuario;
                cmdModulosUsuariosUpdate.Parameters.Add("@alta", SqlDbType.Bit).Value = modusr.PermiteAlta;
                cmdModulosUsuariosUpdate.Parameters.Add("@baja", SqlDbType.Bit).Value = modusr.PermiteBaja;
                cmdModulosUsuariosUpdate.Parameters.Add("@modificacion", SqlDbType.Bit).Value = modusr.PermiteModificacion;
                cmdModulosUsuariosUpdate.Parameters.Add("@consulta", SqlDbType.Bit).Value = modusr.PermiteConsulta;

                cmdModulosUsuariosUpdate.ExecuteNonQuery();
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

        public void Save(ModuloUsuario modusr) //OK
        {
            if (modusr.State == BusinessEntity.States.Deleted)
            {
                this.Delete(modusr.ID);
            }
            else if (modusr.State == BusinessEntity.States.New)
            {
                this.Insert(modusr);
            }
            else if (modusr.State == BusinessEntity.States.Modified)
            {
                this.Update(modusr);
            }
            modusr.State = BusinessEntity.States.Unmodified;
        }
    }
}
