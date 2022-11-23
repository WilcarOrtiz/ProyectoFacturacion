using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ReportesFacturasPorFecha
    {
        public string FecharRegistro { get; set; }  
        public string NumeroFactura { get; set; }
        public decimal MontoTotal { get; set; }
        public string CedulaEmpleado { get; set; }
        public string CedulaCliente { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal precioVenta { get; set; }

    }
}
