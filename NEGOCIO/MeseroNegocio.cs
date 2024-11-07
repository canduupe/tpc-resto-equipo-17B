using DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
    public class MeseroNegocio
    {

        public List<Mesero> listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Mesero> meseroList = new List<Mesero>();

            try
            {
                datos.setearConsulta("select IdMesero, Nombre, Apellido, IdUsuario, Activo from Mesero");
                datos.realizarLectura();

                while (datos.Lector.Read())
                {
                    Mesero mesero = new Mesero();

                    mesero.IdMesero = (int)datos.Lector["IdMesero"];
                    mesero.Nombre = (string)datos.Lector["Nombre"];
                    mesero.Apellido = (string)datos.Lector["Apellido"];
                    mesero.IdUsuario = (int)datos.Lector["IdUsuario"];
                    mesero.Activo = (int)datos.Lector["Activo"];

                    meseroList.Add(mesero);

                }

                return meseroList;
               
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





        public void AgregarSP(Mesero mesero)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("spAltaMesero");
                datos.setearParametro("@Nombre", mesero.Nombre);
                datos.setearParametro("@apellido", mesero.Apellido );
                datos.setearParametro("@Usuario", mesero.usuario);
                datos.setearParametro("@Contraseña", mesero.contraseña);

                datos.realizarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }






    }
}
