using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;

namespace NEGOCIO
{
    public class OrdenNegocio
    {
        public List<Ordenes> Listar()
        {
            List<Ordenes> lista = new List<Ordenes>();
            AccesoDatos datos = new AccesoDatos();
           
            try
            {
                datos.setearConsulta("select IdPedido, IdArticulo, Mesero, Activo, Precio from Articulos_X_Pedido where Activo = 1");
                datos.realizarLectura();

                while (datos.Lector.Read())
                {
                    Ordenes aux = new Ordenes();

                    aux.IdPedido = (int)datos.Lector["IdPedido"];
                    aux.IdArticulo = (int)datos.Lector["IdArticulo"];
                    aux.Mesero = (int)datos.Lector["Mesero"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Activo = (int)datos.Lector["Activo"];

                    lista.Add(aux);

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


        public void EliminarArti(int arti)
        {
            AccesoDatos datos = new AccesoDatos();


            try
            {

                datos.setearProcedimiento("eliminarDeOrden");
                datos.setearParametro("@IdArti", arti);

                datos.realizarLectura();

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

        public void EnviarPedido(int pedido)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("EnviarPedidos");
                datos.setearParametro("@IdPedido", pedido);

                datos.realizarLectura();



            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }



        }




    }
}
