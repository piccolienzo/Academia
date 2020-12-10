using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class UsuarioAdapter:Adapter
    {
        /*
        #region DatosEnMemoria
        // Esta región solo se usa en esta etapa donde los datos se mantienen en memoria.
        // Al modificar este proyecto para que acceda a la base de datos esta será eliminada
        private static List<Usuario> _Usuarios;

        private static List<Usuario> Usuarios
        {
            get
            {
                if (_Usuarios == null)
                {
                    _Usuarios = new List<Business.Entities.Usuario>();
                    Business.Entities.Usuario usr;
                    usr = new Business.Entities.Usuario();
                    usr.ID = 1;
                    usr.State = Business.Entities.BusinessEntity.States.Unmodified;
                    usr.Nombre = "Casimiro";
                    usr.Apellido = "Cegado";
                    usr.NombreUsuario = "casicegado";
                    usr.Clave = "miro";
                    usr.Email = "casimirocegado@gmail.com";
                    usr.Habilitado = true;
                    _Usuarios.Add(usr);

                    usr = new Business.Entities.Usuario();
                    usr.ID = 2;
                    usr.State = Business.Entities.BusinessEntity.States.Unmodified;
                    usr.Nombre = "Armando Esteban";
                    usr.Apellido = "Quito";
                    usr.NombreUsuario = "aequito";
                    usr.Clave = "carpintero";
                    usr.Email = "armandoquito@gmail.com";
                    usr.Habilitado = true;
                    _Usuarios.Add(usr);

                    usr = new Business.Entities.Usuario();
                    usr.ID = 3;
                    usr.State = Business.Entities.BusinessEntity.States.Unmodified;
                    usr.Nombre = "Alan";
                    usr.Apellido = "Brado";
                    usr.NombreUsuario = "alanbrado";
                    usr.Clave = "abrete sesamo";
                    usr.Email = "alanbrado@gmail.com";
                    usr.Habilitado = true;
                    _Usuarios.Add(usr);

                }
                return _Usuarios;
            }
        }
        #endregion
        */

        public List<Usuario> GetAll()
        {

            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuarios = new SqlCommand("select * from usuarios", SqlConn);
                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
                while (drUsuarios.Read())
                {
                    Usuario usr = new Usuario
                    {
                        ID = (int)drUsuarios["id_usuario"],
                        NombreUsuario = (string)drUsuarios["nombre_usuario"],
                        Clave = (string)drUsuarios["clave"],
                        Nombre = (string)drUsuarios["nombre"],
                        Apellido = (string)drUsuarios["apellido"],
                        Email = (string)drUsuarios["email"],
                        Habilitado = (bool)drUsuarios["habilitado"],
                        Id_Persona = Convert.ToInt32(drUsuarios["id_persona"])

                    };
                    



                    usuarios.Add(usr);
                }
                drUsuarios.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally 
            {
                this.CloseConnection(); 
            }


            return usuarios;
        }

        public Business.Entities.Usuario GetOne(int ID)
        {   
            Usuario usr = new Usuario();
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuaros = new SqlCommand("select * from usuarios where id_usuario = @id", SqlConn);
                cmdUsuaros.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drUsuarios = cmdUsuaros.ExecuteReader();
                if (drUsuarios.Read())
                {
                    
                    usr.ID = (int)drUsuarios["id_usuario"];
                    usr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                    usr.Clave = (string)drUsuarios["clave"];
                    usr.Nombre = (string)drUsuarios["nombre"];
                    usr.Apellido = (string)drUsuarios["apellido"];
                    usr.Email = (string)drUsuarios["email"];
                    usr.Habilitado = (bool)drUsuarios["habilitado"];
                    usr.Id_Persona = (int)drUsuarios["id_persona"];
                }
                drUsuarios.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally{
                this.CloseConnection();
            }
            return usr;

        }
        public Business.Entities.Usuario GetOneByUsername(string username)
        {
            Usuario usr = new Usuario();
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuaros = new SqlCommand("select * from usuarios where nombre_usuario = @nombre_usuario", SqlConn);
                cmdUsuaros.Parameters.Add("@nombre_usuario", SqlDbType.VarChar).Value = username;
                SqlDataReader drUsuarios = cmdUsuaros.ExecuteReader();
                if (drUsuarios.Read())
                {

                    usr.ID = (int)drUsuarios["id_usuario"];
                    usr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                    usr.Clave = (string)drUsuarios["clave"];
                    usr.Nombre = (string)drUsuarios["nombre"];
                    usr.Apellido = (string)drUsuarios["apellido"];
                    usr.Email = (string)drUsuarios["email"];
                    usr.Habilitado = (bool)drUsuarios["habilitado"];
                    usr.Id_Persona = (int)drUsuarios["id_persona"];
                }
                drUsuarios.Close();
            }
            catch (Exception e)
            {
                usr = null;
                //throw e;
            }


        
            finally
            {
                this.CloseConnection();
            }
            return usr;

        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuarioDelete = new SqlCommand("delete usuarios where id_usuario = @id", SqlConn);
                cmdUsuarioDelete.Parameters.Add("@id",SqlDbType.Int).Value=ID;
                cmdUsuarioDelete.ExecuteNonQuery();

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

        public void Update(Usuario usuario)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuarioSave = new SqlCommand(
                    "update usuarios set nombre_usuario = @nombre_usuario, clave = @clave, " +
                    "habilitado = @habilitado, nombre = @nombre, apellido = @apellido, email= @email,id_persona=@id_persona " +
                    "where id_usuario = @id",SqlConn);
                cmdUsuarioSave.Parameters.Add("@id",SqlDbType.Int).Value = usuario.ID;
                cmdUsuarioSave.Parameters.Add("@clave", SqlDbType.VarChar,50).Value = usuario.Clave;
                cmdUsuarioSave.Parameters.Add("@habilitado",SqlDbType.Bit).Value = usuario.Habilitado;
                cmdUsuarioSave.Parameters.Add("@nombre", SqlDbType.VarChar,50).Value = usuario.Nombre;
                cmdUsuarioSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = usuario.Apellido;
                cmdUsuarioSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = usuario.Email;
                cmdUsuarioSave.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                cmdUsuarioSave.Parameters.Add("@id_persona", SqlDbType.Int).Value = usuario.Id_Persona;
                cmdUsuarioSave.ExecuteNonQuery();
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

        public void Insert (Usuario usuario)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuarioSave = new SqlCommand(
                    "insert into usuarios(nombre_usuario,clave,habilitado,nombre,apellido,email,id_persona) " +
                    "values(@nombre_usuario,@clave,@habilitado,@nombre,@apellido,@email,@id_persona) " +
                    "select @@identity", SqlConn); //


                cmdUsuarioSave.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave;
                cmdUsuarioSave.Parameters.Add("@habilitado", SqlDbType.Bit).Value = usuario.Habilitado;
                cmdUsuarioSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = usuario.Nombre;
                cmdUsuarioSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = usuario.Apellido;
                cmdUsuarioSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = usuario.Email;
                cmdUsuarioSave.Parameters.Add("@id_persona", SqlDbType.Int).Value = usuario.Id_Persona;
                cmdUsuarioSave.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                usuario.ID = decimal.ToInt32((decimal)cmdUsuarioSave.ExecuteScalar());
                //cmdUsuarioSave.ExecuteNonQuery();
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
        public void Save(Usuario usuario)
        {
            if (usuario.State == BusinessEntity.States.Deleted)
            {
                this.Delete(usuario.ID);
            }
            else if (usuario.State == BusinessEntity.States.New)
            {
                this.Insert(usuario);
            }
            else if (usuario.State == BusinessEntity.States.Modified)
            {
                this.Update(usuario);
            }
            usuario.State = BusinessEntity.States.Unmodified;
        }


    }
}
