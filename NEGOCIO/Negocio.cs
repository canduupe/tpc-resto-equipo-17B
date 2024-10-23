using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using DOMINIO;


namespace NEGOCIO
{
    public class Negocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select IdArticulo, Nombre, Descripcion, Precio, Tipo, CantidadDisponible from Articulo");

                datos.realizarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo
                    {
                        IdArticulo = (int)datos.Lector["IdArticulo"],
                        Nombre = (string)datos.Lector["Nombre"],
                        Descripcion = (string)datos.Lector["Descripcion"],
                        Precio = (decimal)datos.Lector["Precio"],
                        Tipo = (string)datos.Lector["Tipo"],
                        CantidadDisponible = (int)datos.Lector["CantidadDisponible"],
                    };

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los artículos: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
