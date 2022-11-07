using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion_GUI
{
    public partial class FrmProductos : Form
    {

        Logica.FuncionesProducto funcionesProductos = new Logica.FuncionesProducto();
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
           
            CargarGrillaProductos();  
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
                else
                {
                    txtNombreProduc.Focus();
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
                if (txtPrecioC.TextLength == 0)
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
                if (txtPrecioV.TextLength == 0)
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

        void GuardarP()
        {
            int Cant = 0; 
            var Articulo = new Entidades.ProductoComprado();
            Articulo.ID = funcionesProductos.GetById().ToString();
            Articulo.Codigo = txtCodigo.Text;
            Articulo.NombreProducto = txtNombreProduc.Text;
            Articulo.Descripcion = txtDescrip.Text;
            Cant = (int)Cantidad.Value;
            Articulo.Unidades = (funcionesProductos.CantidadUnitaria(cmbUnidades.Text.ToString())*Cant);
            int Val = Articulo.Unidades;
            Articulo.PrecioC = float.Parse(txtPrecioC.Text);
            Articulo.PrecioV = float.Parse(txtPrecioV.Text);
            var Respuesta = funcionesProductos.AgregarProducto(Articulo);
            MessageBox.Show(Respuesta, "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            switch (vacioProductos())
            {
                case true:
                    MessageBox.Show("Verifique los campos obligatorios", "VERIFICAR.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case false:
                    GuardarP();
                    RestablecerProductos();
                    CargarGrillaProductos();
                    break;
            }
        }

        public void RestablecerProductos()
        {
            txtCodigo.Text = "";
            txtNombreProduc.Text = "";
            txtDescrip.Text = "";
            Cantidad.Value = 1;
            cmbUnidades.Text = "";
            txtPrecioC.Text = "";
            txtPrecioV.Text = "";
            cmbUnidades.Focus();

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

        void CargarGrillaProductos()
        {
            GrillaProductos.Rows.Clear();
            foreach (var item in funcionesProductos.GetAllProductos())
            {
                GrillaProductos.Rows.Add(item.Codigo, item.NombreProducto, item.Descripcion, item.Unidades, item.PrecioC, item.PrecioV);
            }
        }

        
    }
}
