using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;

namespace NEGOCIO
{
    public class TipoArticuloNegocio
    {
        public List<TipoArticulo> listar()
        {
            List<TipoArticulo> lista = new List<TipoArticulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select Id, Descripcion from TipoArticulo");

                datos.realizarLectura();

                while (datos.Lector.Read())
                {
                    TipoArticulo aux = new TipoArticulo
                    {
                        Id = (int)datos.Lector["Id"],                       
                        Descripcion = (string)datos.Lector["Descripcion"],               
                    };

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los tipos de articulos: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
