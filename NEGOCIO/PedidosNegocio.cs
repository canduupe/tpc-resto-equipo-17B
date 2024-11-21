using DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
    public class PedidosNegocio
    {
        public List<Pedidos> Listar()
        {
            List<Pedidos> ListaPedidos = new List<Pedidos>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select IdPedido, IdMesa, IdArticulo, Fecha, Mesero, Activo from Pedidos");
                datos.realizarLectura();

                while (datos.Lector.Read())
                {
                    Pedidos pedidos = new Pedidos();
                    pedidos.IdPedido = (int)datos.Lector["IdPedido"];
                    pedidos.IdMesa = (int)datos.Lector["IdMesa"];
                    pedidos.IdArticulo = (int)datos.Lector["IdArticulo"];
                    pedidos.Mesero = (int)datos.Lector["Mesero"];
                    pedidos.Activo = (int)datos.Lector["Activo"];
                    pedidos.FechaPedido = (DateTime)datos.Lector["Fecha"];


                    ListaPedidos.Add(pedidos);

                }

                return ListaPedidos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void setearPedido()
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into Pedidos values (1,GETDATE())");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void AgregarConSp(int art, int mese, int Ped, float pre)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("InsertarArticulosXPedido");
                datos.setearParametro("@IdPedido", Ped);
                datos.setearParametro("@IdArticulo", art);
                datos.setearParametro("@IdUsuM", mese);
                datos.setearParametro("@Precio", pre);

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

        public void NuevoPedido(Pedidos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("InsertarPedido");
                datos.setearParametro("@IdMesa", nuevo.IdMesa);
                datos.setearParametro("@Fecha", nuevo.FechaPedido);

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
