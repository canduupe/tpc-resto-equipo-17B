using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;

namespace NEGOCIO
{
    public class UsuarioNegocio
    {
        public bool Login(Usuarios usuario)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearConsulta("select Id, Usuario, Contraseña, Tipo from Usuarios where Usuario = @Usser AND Contraseña = @Pass  ");
                datos.setearParametro("@Usser", usuario.Usuario);
                datos.setearParametro("@Pass",usuario.Contraseña);

                datos.realizarLectura();

                while (datos.Lector.Read())
                {
                    usuario.Id = (int)datos.Lector["Id"];
                    usuario.TipoUsuario = (int)(datos.Lector["Tipo"]) == 1 ? tipoUsuario.GERENTE : tipoUsuario.MESERO;

                    return true;
                }
                return false;   

            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

        public bool Login2(Usuarios usuario)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearConsulta("select Id, Usuario, Contraseña, Tipo from Usuarios where Usuario = @Usser AND Contraseña = @Pass  ");
                datos.setearParametro("@Usser", usuario.Usuario);
                datos.setearParametro("@Pass", usuario.Contraseña);

                datos.realizarLectura();

                if(datos.Lector.Read())
                {
                    usuario.Id = (int)datos.Lector["Id"];
                    usuario.TipoUsuario = (int)(datos.Lector["Tipo"]) == 1 ? tipoUsuario.GERENTE : tipoUsuario.MESERO;

                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }



        }



    }
}
