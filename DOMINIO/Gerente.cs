using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class Gerente
    {
        public int IdGerente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Usuarios usuario { get; set; }
        public Usuarios contraseña { get; set; }
        public int IdUsuario { get; set; }
        public int Activo { get; set; }



    }


}
