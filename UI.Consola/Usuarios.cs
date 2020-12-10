using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Logic;
using Business.Entities;
using Microsoft.Win32;

namespace UI.Consola
{
    public class Usuarios
    {
        public UsuarioLogic UsuarioNegocio;

        public Usuarios()
        {
            UsuarioNegocio = new UsuarioLogic();
        }

        public void Menu()
        {
            Console.WriteLine(" 1– Listado General \n 2– Consulta \n 3– Agregar \n 4 - Modificar \n 5 - Eliminar \n 6 - Salir");
            ConsoleKeyInfo opcionMenu = Console.ReadKey();

            switch (opcionMenu.Key)
            {
                case ConsoleKey.D1: //Listado General
                    ListadoGeneral();
                    break;
                case ConsoleKey.D2:
                    Consulta();
                    break;
                case ConsoleKey.D3:
                    Agregar();
                    break;
                case ConsoleKey.D4:
                    Modificar();
                    break;
                case ConsoleKey.D5:
                    Eliminar();
                    break;

            }

        }

        public void ListadoGeneral()
        {
            Console.Clear();
            foreach (Usuario usr in UsuarioNegocio.GetAll())
            {
                MostrarDatos(usr);
            }
        }

        public void Consulta()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese ID de usuario a buscar");
                int idUsuario = int.Parse(Console.ReadLine());
                this.MostrarDatos(UsuarioNegocio.GetOne(idUsuario));
            } //REVISAR LA EXCEPCION
            //catch (System.Exception e)
            //{
            //    if (e is FormatException)
            //    {
            //        Console.WriteLine("Formato invalido, debe ser un numero entero");
            //    }
            //    else if (e is NullReferenceException)
            //    {
            //        Console.WriteLine("Usuario no existe");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error desconocido");
            //    }

            //}
            catch (System.FormatException e)
            {
                Console.WriteLine("Formato invalido, debe ser un numero entero" );
            }
            catch (System.NullReferenceException e)
            {
                Console.WriteLine("Usuario no existe");
            }

            catch (System.Exception e)
            {
                Console.WriteLine("Exception desconocido " + e.ToString());

            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
           
        }
        public void Agregar()
        {
            Console.Clear();
            Console.WriteLine("Nuevo Usuario");
            Usuario user = new Usuario();
            Console.WriteLine("Ingrese nombre:");
            user.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Apellido:");
            user.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese nombre de usuario:");
            user.NombreUsuario = Console.ReadLine();
            Console.WriteLine("Ingrese clave:");
            user.Clave = Console.ReadLine();
            Console.WriteLine("Ingrese Email");
            user.Email = Console.ReadLine();
            Console.WriteLine("Ingrese habilitacion usuario 1>Si otro>No :");
            user.Habilitado = (Console.ReadLine() == "1");
            user.State = BusinessEntity.States.New;
            UsuarioNegocio.Save(user);
            Console.WriteLine("ID: ",user.ID); //<<<<<<<<<<<<<-----------???????????????
            Console.WriteLine("Usuario guardado");
            MostrarDatos(user);
        }
        public void Modificar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese ID de usuario a modificar");
                int idUsuario = int.Parse(Console.ReadLine());
                Usuario user = UsuarioNegocio.GetOne(idUsuario);
                Console.WriteLine("Datos anteriores");
                MostrarDatos(user);
                Console.WriteLine("Ingrese nombre:");
                user.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese Apellido:");
                user.Apellido = Console.ReadLine();
                Console.WriteLine("Ingrese nombre de usuario:");
                user.NombreUsuario = Console.ReadLine();
                Console.WriteLine("Ingrese clave:");
                user.Clave = Console.ReadLine();
                Console.WriteLine("Ingrese Email");
                user.Email = Console.ReadLine();
                Console.WriteLine("Ingrese habilitacion usuario 1>Si otro>No :");
                user.Habilitado = (Console.ReadLine() == "1");
                user.State = BusinessEntity.States.Modified;
                UsuarioNegocio.Save(user);
                Console.WriteLine("Usuario guardado");



            } //REVISAR LA EXCEPCION
            catch (System.Exception e)
            {
                if (e is FormatException)
                {
                    Console.WriteLine("Formato invalido, debe ser un numero entero");
                }
                else if (e is NullReferenceException)
                {
                    Console.WriteLine("Usuario no existe");
                }
                else
                {
                    Console.WriteLine("Error desconocido");
                }

            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }


        }
        public void Eliminar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese ID de usuario a Borrar");
                int idUsuario = int.Parse(Console.ReadLine());
                this.MostrarDatos(UsuarioNegocio.GetOne(idUsuario));
                UsuarioNegocio.Delete(idUsuario);
            } //REVISAR LA EXCEPCION
            catch (System.Exception e)
            {
                if (e is FormatException)
                {
                    Console.WriteLine("Formato invalido, debe ser un numero entero");
                }
                else if (e is NullReferenceException)
                {
                    Console.WriteLine("Usuario no existe");
                }
                else
                {
                    Console.WriteLine("Error desconocido");
                }

            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }

        public void MostrarDatos(Usuario usr)
        {
            Console.WriteLine($"Usuario: {usr.ID}");
            Console.WriteLine($"\t\tNombre: {usr.Nombre}");
            Console.WriteLine($"\t\tApellido: {usr.Apellido}");
            Console.WriteLine($"\t\tNombre de Usuario: {usr.NombreUsuario}");
            Console.WriteLine($"\t\tClave: {usr.Clave}");
            Console.WriteLine($"\t\tEmail: {usr.Email}");
            Console.WriteLine($"\t\tHabilitado: {usr.Habilitado}");
            Console.WriteLine();
        }

    }
}
