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









    }
}
