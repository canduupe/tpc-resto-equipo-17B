using DOMINIO;
using System;
using System.Collections;
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
                datos.setearConsulta("select IdPedido, IdMesa, IdArticulo, Fecha, IdMesero, Activo from Pedidos");
                datos.realizarLectura();

                while (datos.Lector.Read())
                {
                    Pedidos pedidos = new Pedidos();
                    pedidos.IdPedido = (int)datos.Lector["IdPedido"];
                    pedidos.IdMesa = (int)datos.Lector["IdMesa"];
                    pedidos.IdArticulo = (int)datos.Lector["IdArticulo"];
                    pedidos.Mesero = (int)datos.Lector["IdMesero"];
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
                datos.setearConsulta("INSERT INTO Pedidos (IdMesa, IdMesero, Fecha) VALUES (1, 7, GETDATE())");

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

        public int LeerPedido(Pedidos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "select IdPedido, IdMesa, Fecha, Activo from Pedidos ";
              
                    consulta += "where IdMesa= " + nuevo.IdMesa;

                datos.setearConsulta(consulta);

                datos.realizarLectura();

                while (datos.Lector.Read())
                {
                    nuevo.IdPedido = (int)datos.Lector["IdPedido"];
                }

                return nuevo.IdPedido;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer pedido" + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }




        public List<Pedidos> PxM(int idMese)
        {
            AccesoDatos datos = new AccesoDatos();
            List<Pedidos> filtro = new List<Pedidos>(); 
            try
            {
                datos.setearProcedimiento("PedidosXMese");
                datos.setearParametro("@IdMesero", idMese);
                datos.realizarLectura();

                while (datos.Lector.Read())
                {
                    Pedidos Aux = new Pedidos();

                    Aux.IdPedido = (int)datos.Lector["IdPedido"];
                    Aux.Mesero = (int)datos.Lector["Mesero"];


                    filtro.Add(Aux);
                }

                return filtro;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

      

    }
}
