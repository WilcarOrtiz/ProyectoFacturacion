using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class NuevasFuncionesDetalles_Factura
    {
        private Datos.NuevoRepositorioReportes NuevoRepositorioReportes = new Datos.NuevoRepositorioReportes();
        public NFactura ObtenerFacutra(string numero)
        {
            NFactura nFactura = NuevoRepositorioReportes.ObtenerFacutra(numero);

            if (nFactura.IdFactura != 0)
            {
                List<Detalle_Facturas> detalle = NuevoRepositorioReportes.ObtenerDetallesFactura(nFactura.IdFactura);
                nFactura.detalle_Facturas = detalle;
            }
            return nFactura;
        }
        public List<ReportesFacturasPorFecha> ReportesFacturasPorFechas(String FehchaIcnicio, string FechaFinal)
        {
            return NuevoRepositorioReportes.ReportesFacturasPorFechas(FehchaIcnicio, FechaFinal);

        }

    }
}
