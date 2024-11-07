using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class Mesero
    {
        public int IdMesero { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Usuarios usuario { get; set; }
        public Usuarios contraseña { get; set; }
        public int IdUsuario { get; set; }
        ///public List<Mesas> MesasAsignadas { get; set; }




    }






}
