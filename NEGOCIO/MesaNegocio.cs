using DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
    public class MesaNegocio
    {
        public List<Mesa> listar()
        {
            List<Mesa> lista = new List<Mesa>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select IdMesa, IdMesero, NumeroMesa, Disponible, Sector from Mesa where Disponible=1");

                datos.realizarLectura();

                while (datos.Lector.Read())
                {
                    Mesa aux = new Mesa();

                    aux.IdMesa = (int)datos.Lector["IdMesa"];
                    aux.IdMesero = datos.Lector["IdMesero"] != DBNull.Value ? (int)datos.Lector["IdMesero"] : (int?)null;
                    aux.NumeroMesa = (int)datos.Lector["NumeroMesa"];
                    aux.Disponible = (int)datos.Lector["Disponible"];
                    aux.Sector = (string)datos.Lector["Sector"];
                   
                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar las mesas: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Mesa> ListarPorMesero()
        {
            List<Mesa> lista = new List<Mesa>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select IdMesa, IdMesero, NumeroMesa, Disponible, Sector from Mesa where Disponible=0");

                datos.realizarLectura();

                while (datos.Lector.Read())
                {
                    Mesa aux = new Mesa();

                    aux.IdMesa = (int)datos.Lector["IdMesa"];
                    aux.IdMesero = datos.Lector["IdMesero"] != DBNull.Value ? (int)datos.Lector["IdMesero"] : (int?)null;
                    aux.NumeroMesa = (int)datos.Lector["NumeroMesa"];
                    aux.Disponible = (int)datos.Lector["Disponible"];
                    aux.Sector = (string)datos.Lector["Sector"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar las mesas: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }


        public void agregarSP(Mesa nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("storedAltaMesa");
                datos.setearParametro("@NumeroMesa", nuevo.NumeroMesa);
                datos.setearParametro("@Disponible", nuevo.Disponible);
                datos.setearParametro("@Sector", nuevo.Sector);
              
                datos.realizarAccion();

            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar mesa" + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void AsignarMesero(Mesa mesa)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("SpAsignarMesero");

                datos.setearParametro("@IdMesa", mesa.IdMesa);
                datos.setearParametro("@IdMesero", mesa.IdMesero);
                datos.setearParametro("@Disponible", mesa.Disponible);

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
                datos.setearProcedimiento("SpElimnarMesa");
                datos.setearParametro("@IdMesa", Id);

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
