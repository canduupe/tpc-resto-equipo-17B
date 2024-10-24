using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{

   public enum tipoUsuario
    {
        GERENTE = 1,
        MESERO = 2
    }

    public class Usuarios
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public tipoUsuario TipoUsuario { get; set; }

        public Usuarios(string usuario, string contraseña, bool gerente)
        {
            Usuario = usuario;
            Contraseña = contraseña;
            TipoUsuario = gerente ? tipoUsuario.GERENTE : tipoUsuario.MESERO;



        }


    }



}
