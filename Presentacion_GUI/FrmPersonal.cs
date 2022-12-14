using Entidades;
using iTextSharp.text.pdf.codec.wmf;
using Logica;
using Presentacion_GUI.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion_GUI
{
    public partial class FrmPersonal : Form
    {
       
        private int posicion;
        DataTable Tabla;
        int fila;
        
        #region INSTANCIAS DE LOGICA
        NuevasFuncionesEmpleado nuevafuncionesEmpleado = new NuevasFuncionesEmpleado();
        
        NuevasFuncionesUsuario NuevasFuncionesUsuario = new NuevasFuncionesUsuario();

        Logica.NuevasFuncionEstado NuevasFuncionEstado = new NuevasFuncionEstado();

        #endregion
        public FrmPersonal()
        {
            InitializeComponent();
        }

        public struct Datos
        {
            public int ID;
            public String Cedula;
            public String Nombre;
            public String Apellido;
            public String Telefono;
            public String Correo;
            public NEstado Estado;
        }

        public void EditarEmpleado(NEmpleado empleado)
        {
            Datos informacion;
            informacion.ID = empleado.ID;
            informacion.Cedula = empleado.Cedula;
            informacion.Nombre = empleado.Nombre;
            informacion.Apellido = empleado.Apellido;
            informacion.Telefono = empleado.Telefono;
            informacion.Correo = empleado.Correo;
            informacion.Estado = empleado.PEstado;
            FrmEditarEmpleado frmEditar = new FrmEditarEmpleado(informacion);
            frmEditar.ShowDialog();
        }

        private void FrmPersonal_Load(object sender, EventArgs e)
        {
            CargarTabla();
            CargarLisBoxEstado();
        }

        #region Validaciones

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                if (txtCedula.TextLength != 10)
                {
                    MessageBox.Show("Deben ser 10 numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && txtNombres.TextLength == 0)
            {
                e.Handled = true;
            }
            if ((e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                if (txtNombres.TextLength <= 2)
                {
                    MessageBox.Show("El texto es muy corto...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    txtApellidos.Focus();
                }
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && txtApellidos.TextLength == 0)
            {
                e.Handled = true;
            }
            if ((e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                if (txtApellidos.TextLength <= 2)
                {
                    MessageBox.Show("El texto es muy corto...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    txtTelefono.Focus();
                }
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtTelefono.TextLength != 10)
                {
                    MessageBox.Show("Deben ser 10 numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    txtCorreo.Focus();
                }
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                if (!txtCorreo.Text.Contains("@"))
                {
                    MessageBox.Show("La direccion no contiene el caracter @ ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtCorreo.Text = "";
                    txtCorreo.Focus();
                }
                else
                {
                    txtContraseña.Focus();
                }
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtTelefono.TextLength < 5)
                {
                    MessageBox.Show("La longitud de la contraseña es muy corta...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    btnGuardarPersonal.PerformLayout();
                }
            }
        }

        public void Restablecer()
        {
            txtCedula.Text = "Cedula";
            txtNombres.Text = "Nombres";
            txtApellidos.Text = "Apellidos";
            txtTelefono.Text = "Telefono";
            txtCorreo.Text = "Correo";
            txtContraseña.Text = "Contraseña";

        }

        public void GuardarPersonal()
        {
            String Mensaje = String.Empty;
            Usuario empleado = new Usuario();
            empleado.Cedula = txtCedula.Text;
            empleado.Nombre = txtNombres.Text;
            empleado.PEstado = new NEstado { IdEstado = (int)(((OpcionesCombo)cmbEstado.SelectedItem).Valor) };
            empleado.Apellido = txtApellidos.Text;
            empleado.Correo = txtCorreo.Text;
            empleado.Telefono = txtTelefono.Text;
            empleado.Contraseña = txtContraseña.Text;
            int IdGenerado = NuevasFuncionesUsuario.Registrar(empleado, out Mensaje);
            if (IdGenerado == 0)
            {
                MessageBox.Show(Mensaje);
            }
            else
            {
                MessageBox.Show("Empleado registrado correctamente");
            }
        }


        public Boolean vacio()
        {
            if (txtContraseña.Text == "" || txtCedula.Text == "" || txtApellidos.Text == "" ||
                txtNombres.Text == "" || txtTelefono.Text == "" || txtCorreo.Text == "" ||
                txtContraseña.Text == "Contraseña" || txtCedula.Text == "Cedula" || txtApellidos.Text == "Apellido" ||
                txtNombres.Text == "Nombres" || txtTelefono.Text == "Telefono" || txtCorreo.Text == "Correo")
            {
                return true;
            }
            return false;
        }


        private void txtCedula_Enter(object sender, EventArgs e)
        {
            if (txtCedula.Text == "Cedula")
            {
                txtCedula.Clear();
            }
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            if (txtCedula.Text == "")
            {
                txtCedula.Text = "Cedula";
            }
        }

        private void txtNombres_Enter(object sender, EventArgs e)
        {
            if (txtNombres.Text == "Nombres")
            {
                txtNombres.Clear();
            }
        }

        private void txtNombres_Leave(object sender, EventArgs e)
        {
            if (txtNombres.Text == "")
            {
                txtNombres.Text = "Nombres";
            }
        }

        private void txtApellidos_Enter(object sender, EventArgs e)
        {
            if (txtApellidos.Text == "Apellidos")
            {
                txtApellidos.Clear();
            }
        }

        private void txtApellidos_Leave(object sender, EventArgs e)
        {
            if (txtApellidos.Text == "")
            {
                txtApellidos.Text = "Apellidos";
            }
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Telefono")
            {
                txtTelefono.Clear();
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Telefono";
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo")
            {
                txtCorreo.Clear();
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo";
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
            }
        }


        #endregion

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            switch (vacio())
            {
                case true:
                    MessageBox.Show("Debe llenar todos los campos", "VERIFICAR.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case false:
                    GuardarPersonal();
                    CargarTabla();
                    Restablecer();
                    break;
            }
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

        void CargarTabla()
        {
            Tabla = new DataTable();
            Tabla.Columns.Add("ID");
            Tabla.Columns.Add("Cedula");
            Tabla.Columns.Add("Nombre");
            Tabla.Columns.Add("Apellido");
            Tabla.Columns.Add("Telefono");
            Tabla.Columns.Add("Correo");
            Tabla.Columns.Add("Estado");
            Tabla.Columns.Add("Contratacion");
            foreach (NEmpleado item in nuevafuncionesEmpleado.Listar())
            {
                Tabla.Rows.Add(item.ID, item.Cedula, item.Nombre, item.Apellido, item.Telefono, item.Correo, item.PEstado.Descripcion, item.FechaContratacion.ToShortDateString());
            }
            GrillaEmpleados.DataSource = Tabla;
        }

        private void textBusqueda_TextChanged(object sender, EventArgs e)
        {
            DataView Dv = Tabla.DefaultView;
            switch (cmbTipoBusqueda.Text)
            {
                case "Cedula":
                    Dv.RowFilter = " Cedula LIKE '" + textBusqueda.Text + "%'";
                    GrillaEmpleados.DataSource = Dv;
                    break;

                case "Nombre":
                    Dv.RowFilter = " Nombre  LIKE '" + textBusqueda.Text + "%'";
                    GrillaEmpleados.DataSource = Dv;
                    break;
                case "Estado":
                    Dv.RowFilter = " Estado  LIKE '" + textBusqueda.Text + "%'";
                    GrillaEmpleados.DataSource = Dv;
                    break;
            }
        }

        private void GrillaEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Mensaje = String.Empty;
            fila = e.RowIndex;
            if (this.GrillaEmpleados.Columns[e.ColumnIndex].Index == 0)
            {

                NEmpleado nEmpleado = new NEmpleado()
                {
                    ID = Convert.ToInt32(GrillaEmpleados.Rows[fila].Cells[2].Value.ToString()),
                    Cedula = GrillaEmpleados.Rows[fila].Cells[3].Value.ToString(),
                    Nombre = GrillaEmpleados.Rows[fila].Cells[4].Value.ToString(),
                    Apellido = GrillaEmpleados.Rows[fila].Cells[5].Value.ToString(),
                    Telefono = GrillaEmpleados.Rows[fila].Cells[4].Value.ToString(),
                    Correo = GrillaEmpleados.Rows[fila].Cells[5].Value.ToString(),
                    PEstado = new NEstado { Descripcion = GrillaEmpleados.Rows[fila].Cells[8].Value.ToString() }

                };
                int IdGenerado = nuevafuncionesEmpleado.Eliminar(nEmpleado, out Mensaje);
                if (IdGenerado == 0)
                {
                    MessageBox.Show(Mensaje);
                }
                else
                {
                    MessageBox.Show("Empleado desactivado del sistema con exito");
                }
                CargarTabla();
            }
            if (this.GrillaEmpleados.Columns[e.ColumnIndex].Index == 1)
            {
                if (nuevafuncionesEmpleado.Listar().Count != 0)
                {
                    EditarEmpleado(nuevafuncionesEmpleado.Listar()[e.RowIndex]);
                    CargarTabla();
                }
                else
                {
                    MessageBox.Show("No hay productos guardados");
                }
            }
        }
    }
}
