using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Detalle_Facturas
    {
        public NProducto DF_producto { get; set; }
        public int DF_Cantidad { get; set; }
        public decimal DF_Subtotal { get; set; }
        public decimal DF_PrecioVenta { get; set; }
    }
}
