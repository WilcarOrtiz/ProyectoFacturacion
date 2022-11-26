using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion_GUI
{
    public partial class FormDatosGenerales : Form
    {
        Logica.NuevasFuncionesDetalles_Factura nuevasFuncionesDetalles_Factura = new Logica.NuevasFuncionesDetalles_Factura();
        public FormDatosGenerales()
        {
            InitializeComponent();
        }
        private void FormDatosGenerales_Load(object sender, EventArgs e)
        {
            GraficaProductosPreferidos();
            CargarTextBoxInformacionGeneral();

        }
        private void GraficaProductosPreferidos()
        {
            ArrayList CantidadProductosPreferidos = new ArrayList();
            ArrayList NombreProductosPreferidos = nuevasFuncionesDetalles_Factura.Productos_Preferidos(out CantidadProductosPreferidos);
            GraficoProductosPreferidos.Series[0].Points.DataBindXY(NombreProductosPreferidos, CantidadProductosPreferidos);

        }

        private void CargarTextBoxInformacionGeneral()
        {
            string P_total = string.Empty;
            string P_CantidadFacturas = string.Empty;
            string P_CantidadEmpleado = string.Empty;
            string P_CantidadClientes = string.Empty;
            string P_CantidadProducto = string.Empty;
            nuevasFuncionesDetalles_Factura.Informacion_General(out  P_total, out  P_CantidadFacturas, out P_CantidadEmpleado, out P_CantidadClientes, out  P_CantidadProducto);

            labeltotalVenta.Text = P_total.ToString();
            labelCantidadFactura.Text = P_CantidadFacturas.ToString();
            labelEmpleado.Text = P_CantidadEmpleado.ToString();
            labelCliente.Text = P_CantidadClientes.ToString();
            labelProducto.Text = P_CantidadProducto.ToString(); 
        }

    }
}
