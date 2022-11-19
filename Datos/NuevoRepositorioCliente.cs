using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class NuevoRepositorioCliente : ICrud<Cliente>
    {
        public int Editar(Cliente obj, out string Mensaje)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(Cliente obj, out string Mensaje)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> Listar()
        {
            throw new NotImplementedException();
        }

        public int Registrar(Cliente obj, out string Mensaje)
        {
            int idClienteGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection objconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("F_Registrar_Empleado", objconexion);
                    cmd.Parameters.AddWithValue("CedulaEmpleado", obj.Cedula);
                    cmd.Parameters.AddWithValue("PrimerNombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("PrimerApellido", obj.Apellido);
                    cmd.Parameters.AddWithValue("Telefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("Correo", obj.Correo);
                    cmd.Parameters.AddWithValue("IdEstado", obj.PEstado.IdEstado);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 45).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    objconexion.Open();
                    cmd.ExecuteNonQuery();
                    idClienteGenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception EX)
            {
                idClienteGenerado = 0;
                Mensaje = EX.Message;
            }
            return idClienteGenerado;
        }


        public int BuscarCliente(string cedula, out string Mensaje)
        {
            int idClienteBusqueda = 0; Mensaje = string.Empty;
            try
            {
                using (SqlConnection objconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("F_Buscar_Cliente", objconexion);
                    cmd.Parameters.AddWithValue("CedulaCliente", cedula);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 45).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    objconexion.Open();
                    cmd.ExecuteNonQuery();
                    idClienteBusqueda = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception EX)
            {
                idClienteBusqueda = 0;
                Mensaje = EX.Message;
            }
            return idClienteBusqueda;
        }
    }
}
