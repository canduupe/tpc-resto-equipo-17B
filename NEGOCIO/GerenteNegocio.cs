using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;

namespace NEGOCIO
{
    public class GerenteNegocio
    {

        public List<Gerente> listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Gerente> lista = new List<Gerente>();

            try
            {
                datos.setearConsulta("select IdGerente, Nombre, Apellido, IdUsuario, Activo from Gerente");
                datos.realizarLectura();

                while (datos.Lector.Read())
                {
                    Gerente gerente = new Gerente();

                    gerente.IdGerente = (int)datos.Lector["IdGerente"];
                    gerente.Nombre = (string)datos.Lector["Nombre"];
                    gerente.Apellido = (string)datos.Lector["Apellido"];
                    gerente.IdUsuario = (int)datos.Lector["IdUsuario"];
                    gerente.Activo = (int)datos.Lector["Activo"];

                    lista.Add(gerente);

                }

                return lista;
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



        public List<Gerente> listar2(string id = "")
        {
            AccesoDatos datos = new AccesoDatos();
            List<Gerente> gerenteList = new List<Gerente>();

            try
            {
                string consulta = "select M.IdGerente, M.Nombre, M.Apellido, M.IdUsuario, M.Activo, U.Usuario, U.Contraseña from Gerente as M inner join Usuarios as U On u.Id = M.IdUsuario ";
                if (id != "")
                {
                    consulta += "where IdGerente = " + id;
                }
                datos.setearConsulta(consulta);

                datos.realizarLectura();

                while (datos.Lector.Read())
                {
                    Gerente gerente = new Gerente();


                    gerente.IdGerente = (int)datos.Lector["IdGerente"];
                    gerente.Nombre = (string)datos.Lector["Nombre"];
                    gerente.Apellido = (string)datos.Lector["Apellido"];
                    gerente.IdUsuario = (int)datos.Lector["IdUsuario"];
                    gerente.Activo = (int)datos.Lector["Activo"];

                    gerenteList.Add(gerente);

                }

                return gerenteList;

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


        public void AgregarSP(Gerente nuevo, Usuarios usuarios)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("spAltaGerente");
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@apellido", nuevo.Apellido);
                datos.setearParametro("@Usuario", usuarios.Usuario);
                datos.setearParametro("@Contraseña", usuarios.Contraseña);

                datos.realizarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }








        public void Modificar(Gerente gerente, Usuarios usu)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("sp_ActualizarUsuariosGerentes");
                datos.setearParametro("@IdUsuario", usu.Id);
                datos.setearParametro("@NuevoUsuario", usu.Usuario);
                datos.setearParametro("@NuevaContraseña", usu.Contraseña);
                datos.setearParametro("@IdGerente", gerente.IdGerente);
                datos.setearParametro("@NuevoNombre", gerente.Nombre);
                datos.setearParametro("@NuevoApellido", gerente.Apellido);

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






    }
}
