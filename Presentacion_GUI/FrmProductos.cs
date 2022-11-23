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
using static iTextSharp.tool.xml.html.HTML;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Presentacion_GUI.Utilidades;

namespace Presentacion_GUI
{
    public partial class FrmProductos : Form
    {

    
        NuevasFuncionesProductos procesosProductos = new NuevasFuncionesProductos();
        Logica.NuevaFuncionesCategoria NuevaFuncionesCategoria = new NuevaFuncionesCategoria();
        Logica.NuevasFuncionEstado NuevasFuncionEstado = new NuevasFuncionEstado();


        public FrmProductos()
        {
            InitializeComponent();
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





        public void BloqueoProduct()
        {
            txtNombreProduc.Enabled = false;
            txtDescrip.Enabled = false;
            txtPrecioC.Enabled = false;
            txtCodigo.Enabled = false;
            txtPrecioV.Enabled = false;
            Cantidad.Enabled = false;

        }

        public void DesbloqueoProduct()
        {
            txtNombreProduc.Enabled = true;
            txtDescrip.Enabled = true;
            txtPrecioC.Enabled = true;
            txtCodigo.Enabled = true;
            txtPrecioV.Enabled = true;
            Cantidad.Enabled = true;
        }

        public void SeleccionUnidades()
        {
            if (cmbUnidades.Text == "")
            {
                BloqueoProduct();
            }
            else
            {
                DesbloqueoProduct();
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtCodigo.TextLength < 0)
                {
                    MessageBox.Show("Debe ingresar un codigo correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
        }

        private void txtNombreProduc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && txtNombreProduc.TextLength == 0)
            {
                e.Handled = true;
            }
            if ((e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                if (txtNombreProduc.TextLength <= 2)
                {
                    MessageBox.Show("El texto es muy corto...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    txtDescrip.Focus();
                }
            }
        }

        private void txtDescrip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && txtDescrip.TextLength == 0)
            {
                e.Handled = true;
            }
            if ((e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                txtPrecioC.Focus();
            }
        }

        private void txtPrecioC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtPrecioC.TextLength == 0 || (Int32.Parse(txtPrecioC.Text) <= 0))
                {
                    MessageBox.Show("Debe ingresar un precio correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    txtPrecioV.Focus()
;
                }
            }
        }

        private void cmbUnidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeleccionUnidades();
        }

        private void Cantidad_SelectedItemChanged(object sender, EventArgs e)
        {
            Cantidad.UpButton();
        }

        private void txtPrecioV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtPrecioV.TextLength == 0 || (Int32.Parse(txtPrecioV.Text) <= 0))
                {
                    MessageBox.Show("Debe ingresar un precio correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    Cantidad.Focus()
;
                }
            }
        }

        public void RestablecerProductos()
        {
            txtCodigo.Text = "";
            txtNombreProduc.Text = "";
            txtDescrip.Text = "";
            Cantidad.Value = 1;
            txtPrecioC.Text = "";
            txtPrecioV.Text = "";
            cmbUnidades.SelectedIndex = 0;
            cbnCategoria.SelectedIndex = 0;
            cbnCategoria.DisplayMember = "Texto";
            cbnCategoria.ValueMember = "Valor";
            cmbEstado.SelectedIndex = 0;
            cmbEstado.DisplayMember = "Texto";
            cmbEstado.ValueMember = "Valor";

        }

        public Boolean vacioProductos()
        {
            if (txtCodigo.Text == "" || txtNombreProduc.Text == "" || txtDescrip.Text == "" || Cantidad.Value == 0
                || cmbUnidades.Text == "" || txtPrecioC.Text == "" || txtPrecioV.Text == "")
            {
                return true;
            }
            return false;
        }








        #region MEODO PARA CARGAR LOS LISTBOX DESDE LA BASE
        private void CargarLisBoxCategoria()
        {
            List<NCategoria> listaCategorias = NuevaFuncionesCategoria.Listar();
            foreach (NCategoria item in listaCategorias)
            {
                cbnCategoria.Items.Add(new OpcionesCombo() { Valor = item.IdCategoria, Texto = item.Descripcion });
            }
            cbnCategoria.SelectedIndex = 0;
            cbnCategoria.DisplayMember = "Texto";
            cbnCategoria.ValueMember = "Valor";
        }
        private void CargarLisBoxEstado()
        {
            List<NEstado> listaEstados = NuevasFuncionEstado.Listar();
            foreach (NEstado item in listaEstados)
            {
                cmbEstado.Items.Add(new OpcionesCombo() { Valor = item.IdEstado, Texto = item.Descripcion });
            }
            cmbEstado.SelectedIndex = 0;
            cmbEstado.DisplayMember = "Texto";
            cmbEstado.ValueMember = "Valor";
        }

        #endregion
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarLisBoxEstado();
            CargarLisBoxCategoria();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            GuardarProducto();
            RestablecerProductos();
        }


        public void GuardarProducto()
        {
            if (vacioProductos() == true)
            {
                MessageBox.Show("Algun Campo esta vacio..");
            }
            else
            {

                String Mensaje = String.Empty;
                int Cant = 0;
                Cant = (int)Cantidad.Value;
                NProducto obj = new NProducto()
                {

                    Codigo = txtCodigo.Text,
                    Nombre = txtNombreProduc.Text,
                    Descripcion = txtDescrip.Text,
                    PCategoria = new NCategoria { IdCategoria = (int)(((OpcionesCombo)cbnCategoria.SelectedItem).Valor) },
                    Stock = (procesosProductos.CantidadUnitaria(cmbUnidades.Text.ToString()) * Cant),
                    PrecioCompra = decimal.Parse(txtPrecioC.Text),
                    PrecioVenta = decimal.Parse(txtPrecioV.Text),
                    PEstado = new NEstado { IdEstado = (int)(((OpcionesCombo)cmbEstado.SelectedItem).Valor) }

                };
                int IdGenerado = procesosProductos.Registrar(obj, out Mensaje);
                if (IdGenerado == 0)
                {
                    MessageBox.Show(Mensaje);
                }
                else
                {
                    GrillaProductos.Rows.Add("", obj.Codigo, obj.Nombre, obj.Descripcion, cbnCategoria.Text, obj.Stock, obj.PrecioCompra, obj.PrecioVenta);
                    MessageBox.Show("Producto ingresado en bodega");
                }
            }
        }
    }


}

