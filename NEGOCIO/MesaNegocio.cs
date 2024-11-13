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
                datos.setearConsulta("select IdMesa, IdMesero, NumeroMesa, Disponible, Sector from Mesa");

                datos.realizarLectura();

                while (datos.Lector.Read())
                {
                    Mesa aux = new Mesa();

                    aux.IdMesa = (int)datos.Lector["IdMesa"];
                    aux.IdMesero = (int)datos.Lector["IdMesero"];
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


    }
}
