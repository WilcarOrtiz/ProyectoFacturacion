using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        public DateTime FechaVenta { get; set; }
        public String CedulaVendedor { get; set; }
        public String NombreVendedor { get; set; }
        public String CedulaComprador { get; set; }
        public String NombreComprador { get; set; }
        public List<string> ProductosComprados { get; set; }
        public float Subtotal { get; set; }
        public float Iva { get; set; }
        public float Descuento { get; set; }
        public float Total { get; set; }
    }
}
