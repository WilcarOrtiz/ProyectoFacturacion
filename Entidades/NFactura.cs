using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NFactura
    {

        public int IdFactura { get; set; }
        public string NumeroFactura { get; set; }
        public DateTime FechaFacturacion { get; set; }
        public NEmpleado empleado { get; set; }
        public NCliente cliente { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Iva { get; set; }
        public decimal Descuento { get; set; }
        public decimal MontoCambio { get; set; }
        public decimal MontoPago { get; set; }
        public decimal Total { get; set; }
    }
}
