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
                datos.setearConsulta("select Id, Usuario, Contraseña, TipoUsuario from Usuarios where Usuario = @Usser AND Contraseña = @Pass");
                datos.setearParametro("@Usser", usuario.Usuario);
                datos.setearParametro("@Pass",usuario.Contraseña);

                datos.realizarLectura();

                if (datos.Lector.Read())
                {
                    usuario.Id = (int)datos.Lector["Id"];
                    usuario.TipoUsuario = (int)(datos.Lector["TipoUsuario"]) == 2 ? tipoUsuario.MESERO : tipoUsuario.GERENTE;

                    return true;
                }
                return false;   
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



        public List<Usuarios> listar2(string id = "")
        {
            AccesoDatos datos = new AccesoDatos();
            List<Usuarios> UsuList = new List<Usuarios>();

            try
            {
                string consulta = "select Id, Usuario, Contraseña, TipoUsuario from Usuarios ";
                if (id != "")
                {
                    consulta += "where Id = " + id;
                }
                datos.setearConsulta(consulta);

                datos.realizarLectura();

                while (datos.Lector.Read())
                {
                    Usuarios usu = new Usuarios();


                    usu.Id = (int)datos.Lector["Id"];
                    usu.Usuario = (string)datos.Lector["Usuario"];
                    usu.Contraseña = (string)datos.Lector["Contraseña"];
                    usu.TipoUsuario= (tipoUsuario)datos.Lector["TipoUsuario"];
                    

                    UsuList.Add(usu);

                }

                return UsuList;

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




        public Usuarios ObtenerUsuario(int idUsuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Id, Usuario, Contraseña, TipoUsuario from Usuarios  where Id = @id ");
                datos.setearParametro("@id", idUsuario);
                datos.realizarLectura();

                Usuarios usu = new Usuarios();

                while (datos.Lector.Read())
                {
                    usu.Id = (int)datos.Lector["Id"];
                    usu.Usuario = (string)datos.Lector["Usuario"];
                    usu.Contraseña = (string)datos.Lector["Contraseña"];
                    usu.TipoUsuario = (tipoUsuario)datos.Lector["TipoUsuario"];
                }

                return usu;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }





    }
}
