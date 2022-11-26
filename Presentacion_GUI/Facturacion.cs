using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office2010.Excel;
using Entidades;
using Logica;
using Presentacion_GUI.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace Presentacion_GUI
{
    public partial class Facturacion : Form
    {

        #region INSTANCIAS DE FUNCIONES DESDE LOGICA
        Logica.NuevasFuncionesFactura CreacionFactura = new Logica.NuevasFuncionesFactura();
        Logica.NuevasFuncionesProductos NuevasFuncionesProductos = new Logica.NuevasFuncionesProductos();
        Logica.NuevasFuncionesCliente NuevaFuncionesClientes = new NuevasFuncionesCliente();

        #endregion

        #region DECLARACION DE VARIABLES LOCALES 
        decimal SubTotal, SubtotalSinDescuento;
        List<NCliente> listaCliente;
        List<NProducto> listaProducto;

        #endregion

        public Facturacion(string IdEmpleado)
        {
            InitializeComponent();
            labelIdEmpleado.Text = IdEmpleado.ToString();
            listaCliente = NuevaFuncionesClientes.Listar();
            listaProducto = NuevasFuncionesProductos.Listar();
        }
        private void Facturacion_Load(object sender, EventArgs e)
        {
            textFecha.Text = DateTime.Now.ToString();
            CargarComboBoxClientes();
            CargarComboBoxProductos();
            comboBoxDescuento.SelectedIndex = 0;
        }

        #region VALIDACIONES ANTES DE AGREGAR EL PRODUCTO A LA GRILLA 
        private void AgregarProducto()
        {
            int CantidadLLevar = Cantidad();
            bool Producto_Agregado = false;
            if (textBoxIdProducto.Text == "")
            {
                MessageBox.Show("Debe seleccionar un producto ... ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ComboBoxUnidades.Text == "")
            {
                MessageBox.Show("Debe seleccionatr la medida de compra ... ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            NProducto nProducto = NuevasFuncionesProductos.Listar().Where(p => p.Codigo == textBoxBusquedaProducto.Text && p.PEstado.Descripcion == "Activo").FirstOrDefault();


            if (nProducto.Stock == 0)
            {
                MessageBox.Show("No tiene stock de este producto ", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nProducto.Stock <= CantidadLLevar)
            {
                var result = MessageBox.Show("Solo tiene disponible  : \n" + nProducto.Stock + "\n ¿Desea realizar la venta ?", "Informacion",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    CantidadLLevar = nProducto.Stock;
                }
                if (result == DialogResult.No)
                {
                    return;
                }

            }
            foreach (DataGridViewRow item in DataGrillaProductosVenta.Rows)
            {
                if (item.Cells[0].Value.ToString().Equals(textBoxIdProducto.Text))
                {
                    Producto_Agregado = true;
                    MessageBox.Show("Ya tiene el producto agregado ", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Limpiar();
                    return;
                }
            }

            if (!Producto_Agregado)
            {
                bool respuesta = CreacionFactura.RestarStock(Convert.ToInt32(textBoxIdProducto.Text), CantidadLLevar);

                if (respuesta)
                {
                    DataGrillaProductosVenta.Rows.Add(new object[]
                    {
                    textBoxIdProducto.Text,
                    textNombreProducto.Text,
                    textBoxPrecio.Text,
                    CantidadLLevar.ToString(),
                    (CantidadLLevar* decimal.Parse(textBoxPrecio.Text))
                    });
                    TextBoxTarifas();
                    Limpiar();
                    textBoxBusquedaProducto.Select();
                }
            }
        }
        #endregion

        #region EVENTOS CLICK'S, SELECT'S Y DE MAS DE LAS HERRAMIENTAS UTILIZAS CON SUS PROPIAS ACCIONES
        private void iconButton3_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }
        private void comboBoxDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxTarifas();
        }
        private void textBoxBusquedaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BuscarCliente();
            }
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            #region Validaciones necesaria al realizar enter en el text box de buscar por codigo
            if (e.KeyData == Keys.Enter)
            {
                NProducto nProducto = NuevasFuncionesProductos.Listar().Where(p => p.Codigo == textBoxBusquedaProducto.Text).FirstOrDefault();
                if (nProducto == null)
                {
                    MessageBox.Show("El producto no se encuentra registrado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (nProducto.Stock == 0)
                {
                    MessageBox.Show("No tiene stock de este producto ", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (nProducto.PEstado.Descripcion != "Activo")
                {

                    MessageBox.Show("El producto no se encuentra disponible en el momento", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (nProducto != null)
                {
                    textBoxIdProducto.Text = nProducto.IdProducto.ToString();
                    textNombreProducto.Text = nProducto.Nombre.ToString();
                    textBoxPrecio.Text = nProducto.PrecioVenta.ToString();
                }


            }
            #endregion
        }
        private void txtEfectivo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                CalcularVueltos();
            }
        }
        private void txtEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtEfectivo.TextLength == 0 || (Int32.Parse(txtEfectivo.Text) <= 0))
                {
                    MessageBox.Show("Debe ingresar un precio correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

        }

        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES ANTES DE LA VENTA
            if (txtEfectivo.Text == "")
            {
                MessageBox.Show("Ingrese el monto de pago ..", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxClientes.Text == "")
            {
                MessageBox.Show("Debe ingresar el documento del cliente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Convert.ToDecimal(txtEfectivo.Text) < Convert.ToDecimal(txtTotalPagar.Text))
            {
                MessageBox.Show("El monto de pago no puede ser menor al total de la venta", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DataGrillaProductosVenta.Rows.Count < 1)
            {
                MessageBox.Show("No puede facturar sin ingresar productos ..", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            #endregion

            TextBoxTarifas();

            #region SE CREA LA TABLA DE DETALLES FACTURA ADEMAS DE SU LLENADO

            DataTable DetalleFactura = new DataTable();
            DetalleFactura.Columns.Add("IdProducto", typeof(int));
            DetalleFactura.Columns.Add("Precio", typeof(decimal));
            DetalleFactura.Columns.Add("Unidades", typeof(int));
            DetalleFactura.Columns.Add("Importe", typeof(decimal));

            foreach (DataGridViewRow row in DataGrillaProductosVenta.Rows)
            {

                DetalleFactura.Rows.Add(new object[]
                {
                    row.Cells["IdProducto"].Value.ToString(),
                    row.Cells["Precio"].Value.ToString(),
                    row.Cells["Unidades"].Value.ToString(),
                    row.Cells["Importe"].Value.ToString()
                });
            }
            #endregion

            #region SE INSTANCIA UNA NUEVA FACTURA Y SE GUARDA 
            int CorrelativoEnBaseFactura = CreacionFactura.ObtenerNumeroFactura();
            string NumeroFactura = string.Format("{0:00000000}", CorrelativoEnBaseFactura);
            TextBoxTarifas();
            NFactura factura = new NFactura()
            {
                empleado = new NEmpleado() { ID = Convert.ToInt32(labelIdEmpleado.Text) },
                cliente = new NCliente() { ID = Convert.ToInt32(textBoxIdCliente.Text) },
                NumeroFactura = NumeroFactura,
                Subtotal = Convert.ToDecimal(txtSubTotal.Text),
                MontoPago = Convert.ToDecimal(txtEfectivo.Text),
                MontoCambio = Convert.ToDecimal(txtCambio.Text),
                Iva = Convert.ToDecimal(txtIva.Text),
                Descuento = Convert.ToDecimal((SubtotalSinDescuento * CreacionFactura.Descuento(comboBoxDescuento.Text)).ToString("0.00")),
                Total = Convert.ToDecimal(txtTotalPagar.Text)
            };


            string Mensaje = string.Empty;
            int respuesta = CreacionFactura.RegistrarFacturacion(factura, DetalleFactura, out Mensaje);
            if (respuesta == 1)
            {
                var result = MessageBox.Show("Numero de factura : \n" + NumeroFactura + "\n ¿Desea copiarlo en portapapeles ?", "Informacion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Clipboard.SetText(NumeroFactura);
                }
                Limpiar();
                limpiarLuegoVenta();
            }

            #endregion
        }

        //PONE EL ID DEL CLIENTE EN EL TEXTBOX CUANDO SE SELECCIONA DESDE EL COMBOBOX
        private void comboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            NFactura nFactura = new NFactura()
            {
                cliente = new NCliente { ID = (int)(((OpcionesCombo)comboBoxClientes.SelectedItem).Valor) }
            };
            textBoxIdCliente.Text = nFactura.cliente.ID.ToString();
        }

        //PONE EL LA INFORMACION DEL PRODUCTO CUANDO SE SELECCIONA DESDE EL COMBOBOX
        private void comboBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            NProducto nProducto = new NProducto
            {
                IdProducto = (int)(((OpcionesCombosProductos)comboBoxProductos.SelectedItem).Valor),
                Nombre = ((OpcionesCombosProductos)comboBoxProductos.SelectedItem).Nombre.ToString(),
                PrecioVenta = Convert.ToDecimal(((OpcionesCombosProductos)comboBoxProductos.SelectedItem).PrecioVenta),
                Codigo = ((OpcionesCombosProductos)comboBoxProductos.SelectedItem).Codigo.ToString()
            };
            textBoxPrecio.Text = nProducto.PrecioVenta.ToString("0.00");
            textBoxIdProducto.Text = nProducto.IdProducto.ToString();
            textNombreProducto.Text = nProducto.Nombre.ToString();
            textBoxBusquedaProducto.Text = nProducto.Codigo.ToString();

        }

        //EVENTO PARA CUANDO SE ELIMINA UN PRODUCTO AGREGADO EL LA GRILA
        private void DataGrillaProductosVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (this.DataGrillaProductosVenta.Columns[e.ColumnIndex].Index == 5)
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    bool respuesta = CreacionFactura.AumentarStock(
                        Convert.ToInt32(DataGrillaProductosVenta.Rows[index].Cells[0].Value.ToString())
                        ,
                           Convert.ToInt32(DataGrillaProductosVenta.Rows[index].Cells[3].Value.ToString())
                        );

                    if (respuesta)
                    {
                        DataGrillaProductosVenta.Rows.RemoveAt(index);
                        TextBoxTarifas();
                    }
                }
            }
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in DataGrillaProductosVenta.Rows)
            {

                bool respuesta = CreacionFactura.AumentarStock(
                       Convert.ToInt32(item.Cells[0].Value.ToString())
                ,
                          Convert.ToInt32(item.Cells[3].Value.ToString())
                       );

            }
            limpiarLuegoVenta();
        }

        #endregion

        #region METODO CREADO PARA CUANDO NO EXISTE EL CLIENTE EN LA BASE INGRESARLO 
        void EnviarInformacionANuevoCliente(String Cedula)
        {
            Datos informacion;
            informacion.Cedula = Cedula;
            FrmNuevoCliente FPE = new FrmNuevoCliente(informacion);
            FPE.ShowDialog();
        }

        public struct Datos
        {
            public string Cedula;
        }

        #endregion

        #region FUNCIONES CREADAS NECESARIAS PARA EL CORRECTO FUNCIONAMIENTO 

        void limpiarLuegoVenta()
        {
            DataGrillaProductosVenta.Rows.Clear();
            comboBoxProductos.Text = "";
            textBoxIdCliente.Text = "";
            comboBoxClientes.Text = "";
            comboBoxProductos.Text = "";
            textBoxBusquedaCliente.Text = "";
            txtSubTotal.Text = "";
            txtIva.Text = "";
            txtTotalPagar.Text = "";
            txtEfectivo.Text = "";
            txtCambio.Text = "";
            comboBoxClientes.Text = "";
            comboBoxDescuento.SelectedIndex = 0;
            ComboBoxUnidades.SelectedIndex = 0;
        }
        public void Limpiar()
        {
            comboBoxProductos.Text = "";
            textBoxBusquedaProducto.Text = "";
            ComboBoxCantidad.Value = 1;
            textBoxIdProducto.Text = "";
            textNombreProducto.Text = "";
            textBoxPrecio.Text = "0";
            ComboBoxUnidades.SelectedIndex = 0;
        }
        //ESTE SE UTILIZA PARA HACER LOS CALCULOS DEL IVA, DESCUENTO , ETC...
        void TextBoxTarifas()
        {
            SubTotal = 0;
            if (DataGrillaProductosVenta.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in DataGrillaProductosVenta.Rows)
                {
                    SubTotal += decimal.Parse(item.Cells[4].Value.ToString());
                }

            }
            txtSubTotal.Text = SubTotal.ToString("0.00");
            txtIva.Text = (SubTotal * (decimal)0.19).ToString("0.00");
            SubtotalSinDescuento = (decimal.Parse(txtSubTotal.Text) + decimal.Parse(txtIva.Text));
            txtTotalPagar.Text = (SubtotalSinDescuento - (SubtotalSinDescuento * CreacionFactura.Descuento(comboBoxDescuento.Text))).ToString("0.00");
        }
        void CalcularVueltos()
        {
            txtCambio.Text = (decimal.Parse(txtEfectivo.Text) - decimal.Parse(txtTotalPagar.Text)).ToString();
        }

        //METODO CREADO PARA LA BUSQUEDA DEL CLIENTE CUANDO SE INGRESA LA CEDULA POR EL TEXTBOX DE BUSQUEDA CLIENTE
        public void BuscarCliente()
        {
            String Mensaje = String.Empty;
            int IdClienteBuscado = NuevaFuncionesClientes.BuscarCliente(textBoxBusquedaCliente.Text, out Mensaje);
            if (IdClienteBuscado == 0)
            {
                MessageBox.Show("El cliente no se encuentra en la base de informacion \n registrelo");
                EnviarInformacionANuevoCliente(textBoxBusquedaCliente.Text.ToString());
                comboBoxClientes.Text = (textBoxBusquedaCliente.Text);
                IdClienteBuscado = NuevaFuncionesClientes.BuscarCliente(textBoxBusquedaCliente.Text, out Mensaje);
            }
            else
            {
                comboBoxClientes.Text = (Mensaje);
            }
            textBoxIdCliente.Text = IdClienteBuscado.ToString();
            textBoxBusquedaCliente.Text = "";
        }
        //METODO PARA OBTENER LA CANTIDAD A COMPRAR BASANDOSE EN LA MEDIDA SIXPACK, DOCEPACK, ETC ... Y LA CANTIDA DE ELLOS 
        public int Cantidad()
        {
            return CreacionFactura.Cantidad(ComboBoxUnidades.Text, (int)ComboBoxCantidad.Value);
        }

        #endregion

        #region METODOS PARA CARGAR LOS COMBOBOX 
        private void CargarComboBoxProductos()
        {
            foreach (NProducto item in NuevasFuncionesProductos.Listar())
            {
                if (item.PEstado.Descripcion == "Activo")
                {
                    comboBoxProductos.Items.Add(new OpcionesCombosProductos() { Valor = item.IdProducto, Nombre = item.Nombre, Codigo = item.Codigo, PrecioVenta = item.PrecioVenta });
                }
            }
            comboBoxProductos.DisplayMember = "Nombre";
            comboBoxProductos.ValueMember = "Valor";
        }
        private void CargarComboBoxClientes()
        {
            foreach (NCliente item in listaCliente)
            {
                comboBoxClientes.Items.Add(new OpcionesCombo() { Valor = item.ID, Texto = (item.Nombre + " " + item.Apellido) });
            }

            comboBoxClientes.DisplayMember = "Texto";
            comboBoxClientes.ValueMember = "Valor";
        }

        #endregion
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
    }
}
