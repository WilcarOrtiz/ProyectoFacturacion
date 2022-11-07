using System;
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
    public partial class Facturacion : Form
    {
        Logica.FuncionesProducto funcionesProductos = new Logica.FuncionesProducto();
        Logica.CreacionFactura CreacionFactura = new Logica.CreacionFactura();
        List<String> CodigoProdVendidos;
        List<int> CantProdVendidos;
        float SubTotal, SubtotalSinDescuento;
        int Cant;

        public Facturacion()
        {
            InitializeComponent();
            CodigoProdVendidos = new List<String>();
            CantProdVendidos = new List<int>();
        }

        void llenadoComboBoxProductos()
        {
            foreach (var item in funcionesProductos.GetAllProductos())
            {
                ComboBoxProductos.Items.Add(item.NombreProducto + "  -  " + item.Descripcion);
            }
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            textFecha.Text = DateTime.Now.ToString();
            llenadoComboBoxProductos();
        }

        public int Cantidad()
        {
            return CreacionFactura.Cantidad(ComboBoxUnidades.Text, (int)ComboBoxCantidad.Value);
        }

        void AgregarProductoGrilla()
        {
            int Cant = Cantidad();
            foreach (var item in funcionesProductos.GetAllProductos())
            {
                if (ComboBoxProductos.Text == (item.NombreProducto + "  -  " + item.Descripcion))
                {
                    DataGrillaProductosVenta.Rows.Add(item.Codigo, item.NombreProducto, item.Descripcion, Cant, item.PrecioV, (item.PrecioV * Cant));
                }
            }
        }
        void TextBoxTarifas()
        {
            SubTotal = 0;
            for (int i = 0; i < (DataGrillaProductosVenta.RowCount) - 1; i++)
            {
                SubTotal += float.Parse(DataGrillaProductosVenta.Rows[i].Cells[5].Value.ToString());
            }
            txtSubTotal.Text = SubTotal.ToString();
            txtIva.Text = ((SubTotal * 0.19)).ToString();
            SubtotalSinDescuento = (float.Parse(txtSubTotal.Text) + float.Parse(txtIva.Text));
            txtTotalPagar.Text = (SubtotalSinDescuento - (SubtotalSinDescuento * CreacionFactura.Descuento(comboBoxDescuento.Text))).ToString();
        }
        public Boolean ValidarDisponibilidad()
        {
            Cant = Cantidad();
            foreach (var item in funcionesProductos.GetAllProductos())
            {
                if (ComboBoxProductos.Text == (item.NombreProducto + "  -  " + item.Descripcion))
                {
                    if (!CreacionFactura.Stock(item.Codigo, Cant))
                    {
                        MessageBox.Show("No hay producto disponible \ninforme al administrador", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            return true;
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (ValidarDisponibilidad())
            {
                AgregarProductoGrilla();
                TextBoxTarifas();
            }
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            RestarStockVenta();
            DataGrillaProductosVenta.Rows.Clear();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            CalcularVueltos();
        }

        void CalcularVueltos()
        {
            txtCambio.Text = (float.Parse(txtEfectivo.Text) - float.Parse(txtTotalPagar.Text)).ToString();
        }

        private void comboBoxDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxTarifas();
        }

        void RestarStockVenta()
        {
            for (int i = 0; i < (DataGrillaProductosVenta.RowCount) - 1; i++)
            {
                CantProdVendidos.Add(Convert.ToInt32(this.DataGrillaProductosVenta.Rows[i].Cells[3].Value));
                CodigoProdVendidos.Add(DataGrillaProductosVenta.Rows[i].Cells[0].Value.ToString());
            }
            MessageBox.Show(CreacionFactura.RestarStock(CodigoProdVendidos, CantProdVendidos), "VENTAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
