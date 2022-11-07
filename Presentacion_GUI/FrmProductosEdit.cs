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

namespace Presentacion_GUI
{
    public partial class FrmProductosEdit : Form
    {
        Logica.FuncionesProducto FuncionesProductos = new Logica.FuncionesProducto();
        String Id;
        int CantidadI;   
        public FrmProductosEdit(FrmVistaProductos.Datos informacion)
        {
            InitializeComponent();
            Id = informacion.ID;
            txtNombreProducEditar.Text = informacion.NombreProducto;
            txtDescripEditar.Text = informacion.Descripcion;
            textCodigoEditar.Text = informacion.Codigo;
            txtPrecioCEdit.Text = informacion.PrecioC.ToString();
            txtPrecioVEdit.Text = informacion.PrecioV.ToString();
            CantidadI = informacion.Cantidad;
            CantidadInicial.Text = informacion.Cantidad.ToString();
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
            MessageBox.Show(textCodigoEditar.Text);

            //traer el codigo del objeto a editar
            String Cod = FuncionesProductos.ArticuloXId(Id);

            //trae el objeto a editar
            ProductoComprado Articulo = FuncionesProductos.ObtenerPorCodigo(Cod);

            //trae el ID del objeto a editar
            String IdEdit = FuncionesProductos.IdXArticulo(textCodigoEditar.Text);

            if ((Id == IdEdit) || (FuncionesProductos.ObtenerPorCodigo(textCodigoEditar.Text) == null))
            {
                MessageBox.Show(
                    FuncionesProductos.Editar(
                        Id, textCodigoEditar.Text, txtNombreProducEditar.Text,
                    txtDescripEditar.Text, 
                    ((FuncionesProductos.CantidadUnitaria(cmbUnidadesEdit.Text.ToString()) * (int)CantidadEdit.Value) + CantidadI),
                    float.Parse(txtPrecioCEdit.Text), float.Parse(txtPrecioVEdit.Text)
                    , Articulo));

            }
            else
            {
                switch (MessageBox.Show("El codigo ya existe para otro producto\nDesea continuar con la actulizacion", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.OK:
                        textCodigoEditar.Text = "";
                        textCodigoEditar.Focus();
                        break;
                    case DialogResult.Cancel:
                        this.Close();
                        break;
                }
            }
        }
        private void BtnGuardarEdit_Click(object sender, EventArgs e)
        {
            CapturarActualizacion();
            this.Close(); 
        }

        private void BtnCancelarEdit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void FrmProductosEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
