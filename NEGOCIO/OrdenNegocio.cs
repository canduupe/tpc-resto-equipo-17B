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
        public List<Orden> Listar()
        {
            List<Orden> lista = new List<Orden>();
            AccesoDatos datos = new AccesoDatos();
           
            try
            {
                datos.setearConsulta("select IdPedido, IdArticulo, Mesero, Activo, Precio from Articulos_X_Pedido where Activo = 1");
                datos.realizarLectura();

                while (datos.Lector.Read())
                {
                    Orden aux = new Orden();

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


    }
}
