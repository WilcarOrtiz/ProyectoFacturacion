using Entidades;
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

namespace Presentacion_GUI
{
    public partial class FrmEditarEmpleado : Form
    {
        FuncionesEmpleado funcionesEmpleado = new FuncionesEmpleado();  
        String ID;
        public FrmEditarEmpleado(FrmPersonal.Datos informacion)
        {
            InitializeComponent();

            ID = informacion.ID;
            txtCedulaEditar.Text   = informacion.Cedula;
            txtNombreEditar.Text   = informacion.Nombre;
            txtApellidoEditar.Text = informacion.Apellido;
            txtTelefonoEditar.Text = informacion.Telefono;
            txtCorreoEditar.Text   = informacion.Correo;
        }

        public void Actualizar()
        {
            String cedula = funcionesEmpleado.EmpleadoXId(ID);
            Empleado empleado = funcionesEmpleado.ObtenerPorCedula(cedula);
            String IDeditada = funcionesEmpleado.IdXEmpleado(txtCedulaEditar.Text);

            if ((ID == IDeditada)||(funcionesEmpleado.ObtenerPorCedula(txtCedulaEditar.Text)==null))
            {
                MessageBox.Show(funcionesEmpleado.Editar(ID,txtCedulaEditar.Text,txtNombreEditar.Text,txtApellidoEditar.Text,
                    txtTelefonoEditar.Text,txtCorreoEditar.Text,empleado));
            }
            else
            {
                switch (MessageBox.Show("La cedula ya existe \nDesea continuar con la actulizacion", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.OK:
                        txtCedulaEditar.Text = "";
                        txtCedulaEditar.Focus();
                        break;
                    case DialogResult.Cancel:
                        this.Close();
                        break;
                }
            }
        }

        private void brnGuardarCambios_Click(object sender, EventArgs e)
        {
            Actualizar();
            this.Close();
        }
    }
}
