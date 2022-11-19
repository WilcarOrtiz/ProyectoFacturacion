using Entidades;
using Logica;
using Presentacion_GUI.Utilidades;
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
        Logica.NuevasFuncionesProductos NuevasFuncionesProductos = new Logica.NuevasFuncionesProductos();
        Logica.NuevaFuncionesClientes NuevaFuncionesClientes = new NuevaFuncionesClientes();

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
            foreach (var item in NuevasFuncionesProductos.Listar())
            {
                ComboBoxProductos.Items.Add(item.Nombre + "  -  " + item.Descripcion);
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
            foreach (var item in NuevasFuncionesProductos.Listar())
            {
                if (ComboBoxProductos.Text == (item.Nombre + "  -  " + item.Descripcion))
                {
                    DataGrillaProductosVenta.Rows.Add(item.Codigo, item.Nombre, item.Descripcion, Cant, item.PrecioVenta, (item.PrecioVenta * Cant));
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
            foreach (var item in NuevasFuncionesProductos.Listar())
            {
                if (ComboBoxProductos.Text == (item.Nombre + "  -  " + item.Descripcion))
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

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FrmNuevoCliente nuevoCliente = new FrmNuevoCliente();
            nuevoCliente.ShowDialog();
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

        private void ComboBoxUnidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxCantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }




        private void CargarComboBoxClientes()
        {
            List<Cliente> listaCliente = NuevaFuncionesClientes.Listar();
            foreach (Cliente item in listaCliente)
            { 
                comboBoxClientes.Items.Add(new OpcionesCombo() { Valor = item.ID, Texto = item.Descripcion });
            }
            comboBoxClientes.SelectedIndex = 0;
            comboBoxClientes.DisplayMember = "Texto";
            comboBoxClientes.ValueMember = "Valor";
        }

    }
}
