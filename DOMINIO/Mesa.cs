using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class Mesa
    {
        public int IdMesa { get; set; }
        public int IdMesero { get; set; }
        public int Disponible { get; set; }
        public string Sector { get; set; }
    }
}
