using System;
using Entidades;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Contracts;
using Logica;
using Presentacion_GUI.Utilidades;

namespace Presentacion_GUI
{
    public partial class FrmProductosEdit : Form
    {
     
        Logica.NuevaFuncionesCategoria NuevaFuncionesCategoria = new NuevaFuncionesCategoria();
        Logica.NuevasFuncionEstado NuevasFuncionEstado = new NuevasFuncionEstado();
        Logica.NuevasFuncionesProductos nuevasFuncionesProductos = new NuevasFuncionesProductos();

        int CantidadI;   
        public FrmProductosEdit(FrmVistaProductos.Datos informacion)
        {
            InitializeComponent();
            textIDProductoEdit.Text = informacion.ID.ToString();
            txtNombreProducEditar.Text = informacion.NombreProducto;
            txtDescripEditar.Text = informacion.Descripcion;
            textCodigoEditar.Text = informacion.Codigo;
            txtPrecioCEdit.Text = informacion.PrecioC.ToString();
            txtPrecioVEdit.Text = informacion.PrecioV.ToString();
            cbnCategoriaEdit.Text = informacion.Categoria.Descripcion;
            cmbEstadoEdit.Text = informacion.Estado.Descripcion; 
            CantidadI = informacion.Cantidad;
            CantidadInicial.Text = informacion.Cantidad.ToString();


            CargarLisBoxEstado();
            CargarLisBoxCategoria();
        }
        public Boolean vacio()
        {
            if (txtNombreProducEditar.Text == "" || txtDescripEditar.Text == "" || cmbUnidadesEdit.Text == "" || textCodigoEditar.Text == "" || txtPrecioCEdit.Text == "" || txtPrecioVEdit.Text == "")
            {
                MessageBox.Show("Falta informacion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
        void CapturarActualizacion()
        {




            String Mensaje = String.Empty;
            int Cant = 0;
            Cant = (int)CantidadEdit.Value;
            NProducto obj = new NProducto()
            {
                IdProducto = int.Parse(textIDProductoEdit.Text),
                Codigo = textCodigoEditar.Text,
                Nombre = txtNombreProducEditar.Text,
                Descripcion = txtDescripEditar.Text,
                PCategoria = new NCategoria { IdCategoria = (int)(((OpcionesCombo)cbnCategoriaEdit.SelectedItem).Valor) },
                Stock = ((nuevasFuncionesProductos.CantidadUnitaria(cmbUnidadesEdit.Text.ToString()) * (int)CantidadEdit.Value) + CantidadI),
                PrecioCompra = decimal.Parse(txtPrecioCEdit.Text),
                PrecioVenta = decimal.Parse(txtPrecioVEdit.Text),
                PEstado = new NEstado { IdEstado = (int)(((OpcionesCombo)cmbEstadoEdit.SelectedItem).Valor) }

            };
            int IdGenerado = nuevasFuncionesProductos.Editar(obj, out Mensaje);
            if (IdGenerado == 0)
            {
                MessageBox.Show(Mensaje);
            }
            else
            {
                MessageBox.Show("Producto actualizado con exito");
            }
        }


        private void txtPrecioCEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtPrecioCEdit.TextLength == 0 || (Int32.Parse(txtPrecioCEdit.Text) <= 0))
                {
                    MessageBox.Show("Debe ingresar un precio correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    txtPrecioVEdit.Focus()
;
                }
            }
        }

        private void txtPrecioVEdit_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtPrecioVEdit.TextLength == 0 || (Int32.Parse(txtPrecioVEdit.Text) <= 0))
                {
                    MessageBox.Show("Debe ingresar un precio correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    CantidadEdit.Focus()
;
                }
            }
        }

        private void textCodigoEditar_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (textCodigoEditar.TextLength < 0)
                {
                    MessageBox.Show("Debe ingresar un codigo correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void txtNombreProducEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && txtNombreProducEditar.TextLength == 0)
            {
                e.Handled = true;
            }
            if ((e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                if (txtNombreProducEditar.TextLength <= 2)
                {
                    MessageBox.Show("El texto es muy corto...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    txtDescripEditar.Focus();
                }
            }
        }

        private void txtDescripEditar_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar) && txtDescripEditar.TextLength == 0)
            {
                e.Handled = true;
            }
            if ((e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                if (txtDescripEditar.TextLength <= 2)
                {
                    MessageBox.Show("El texto es muy corto...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    cmbUnidadesEdit.Focus();
                }
            }
        }

        private void BtnGuardarEdit_Click_1(object sender, EventArgs e)
        {
             CapturarActualizacion();
            this.Close(); 
        }

        private void BtnCancelarEdit_Click(object sender, EventArgs e)
        {
            this.Close();
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



        private void CargarLisBoxCategoria()
        {
            List<NCategoria> listaCategorias = NuevaFuncionesCategoria.Listar();
            foreach (NCategoria item in listaCategorias)
            {
                cbnCategoriaEdit.Items.Add(new OpcionesCombo() { Valor = item.IdCategoria, Texto = item.Descripcion });
            }
            cbnCategoriaEdit.SelectedIndex = 0;
            cbnCategoriaEdit.DisplayMember = "Texto";
            cbnCategoriaEdit.ValueMember = "Valor";
        }


        private void CargarLisBoxEstado()
        {
            List<NEstado> listaEstados = NuevasFuncionEstado.Listar();
            foreach (NEstado item in listaEstados)
            {
                cmbEstadoEdit.Items.Add(new OpcionesCombo() { Valor = item.IdEstado, Texto = item.Descripcion });
            }
            cmbEstadoEdit.SelectedIndex = 0;
            cmbEstadoEdit.DisplayMember = "Texto";
            cmbEstadoEdit.ValueMember = "Valor";
        }


        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
