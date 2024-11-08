using DOMINIO;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
    public class MeseroNegocio
    {

        public List<Mesero> listar2(string id = "")
        {
            AccesoDatos datos = new AccesoDatos();
            List<Mesero> meseroList = new List<Mesero>();

            try
            {
                string consulta = "select M.IdMesero, M.Nombre, M.Apellido, M.IdUsuario, M.Activo, U.Usuario, U.Contraseña from Mesero as M\r\ninner join Usuarios as U On u.Id = m.IdUsuario ";
                if (id != "")
                {
                    consulta += "where IdMesero = " + id;
                }
                datos.setearConsulta(consulta);

                datos.realizarLectura();

                while (datos.Lector.Read())
                {
                    Mesero mesero = new Mesero();


                    mesero.IdMesero = (int)datos.Lector["IdMesero"];
                    mesero.Nombre = (string)datos.Lector["Nombre"];
                    mesero.Apellido = (string)datos.Lector["Apellido"];
                    mesero.IdUsuario = (int)datos.Lector["IdUsuario"];
                    mesero.Activo = (int)datos.Lector["Activo"];

                    meseroList.Add(mesero);

                }

                return meseroList;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        public List<Mesero> listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Mesero> meseroList = new List<Mesero>();

            try
            {

                datos.setearConsulta("select IdMesero, Nombre, Apellido, IdUsuario, Activo from Mesero");

                datos.realizarLectura();

                while (datos.Lector.Read())
                {
                    Mesero mesero = new Mesero();

                    mesero.IdMesero = (int)datos.Lector["IdMesero"];
                    mesero.Nombre = (string)datos.Lector["Nombre"];
                    mesero.Apellido = (string)datos.Lector["Apellido"];
                    mesero.IdUsuario = (int)datos.Lector["IdUsuario"];
                    mesero.Activo = (int)datos.Lector["Activo"];

                    meseroList.Add(mesero);

                }

                return meseroList;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }





        }




        public void AgregarSP(Mesero mesero, Usuarios usu)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("spAltaMesero");
                datos.setearParametro("@Nombre", mesero.Nombre);
                datos.setearParametro("@apellido", mesero.Apellido);
                datos.setearParametro("@Usuario", usu.Usuario);
                datos.setearParametro("@Contraseña", usu.Contraseña);

                datos.realizarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }


        public void Modificar(Mesero mesero, Usuarios usu)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("sp_ActualizarUsuariosMesero");

                datos.setearParametro("@IdUsuario", usu.Id);
                datos.setearParametro("@NuevoUsuario", usu.Usuario);
                datos.setearParametro("@NuevaContraseña", usu.Contraseña);
                datos.setearParametro("@IdMesero", mesero.IdMesero);
                datos.setearParametro("@NuevoNombre", mesero.Nombre);
                datos.setearParametro("@NuevoApellido", mesero.Apellido);

                datos.realizarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion(); 
            }


        }



        public void Eliminar(int Id)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("spEliminarUsuarioYMesero");
                datos.setearParametro("@IdUsuario", Id);


                datos.realizarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }


        }


    }
}
