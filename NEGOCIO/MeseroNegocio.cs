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
