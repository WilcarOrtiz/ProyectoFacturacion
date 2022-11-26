using Entidades;
using System;
using System.Collections;
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
        public ArrayList Productos_Preferidos(out ArrayList CantidadProductosPreferidos)
        {
            return NuevoRepositorioReportes.Productos_Preferidos(out CantidadProductosPreferidos);
        }
        public void Informacion_General(out string P_total, out string P_CantidadFacturas, out string P_CantidadEmpleado, out string P_CantidadClientes, out string P_CantidadProducto)
        {
            NuevoRepositorioReportes.Informacion_General(out P_total, out P_CantidadFacturas, out P_CantidadEmpleado, out P_CantidadClientes, out P_CantidadProducto);
        }

    }
}
