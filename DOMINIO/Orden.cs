using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class Orden
    {
        public int IdPedido { get; set; }
        public int IdArticulo { get; set; }
        public int Mesero { get; set; }
        public int Activo { get; set; }
        public decimal Precio { get; set; }
    }
}
