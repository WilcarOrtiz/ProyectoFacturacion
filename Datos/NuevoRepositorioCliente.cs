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
    public class NuevoRepositorioCliente : ICrud<NCliente>
    {
        public int Editar(NCliente obj, out string Mensaje)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(NCliente obj, out string Mensaje)
        {
            throw new NotImplementedException();
        }

        public List<NCliente> Listar()
        {
            List<NCliente> ListaClientes = new List<NCliente>();
            using (SqlConnection objconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT c.IdCliente,c.CedulaCliente,c.PrimerNombre,c.PrimerApelldido , c.Telefono , c.Correo,e.IdEstado,e.Descripcion FROM CLIENTE c");
                    query.AppendLine("INNER JOIN ESTADO e ON e.IdEstado = c.IdEstado");
                    SqlCommand cmd = new SqlCommand(query.ToString(), objconexion);
                    cmd.CommandType = CommandType.Text;
                    objconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ListaClientes.Add(new NCliente(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5),
                                new NEstado() { IdEstado = dr.GetInt32(6), Descripcion = dr.GetString(7) }));
                        }
                    }
                }
                catch (Exception ex)
                {
                    ListaClientes = new List<NCliente>();
                }
            }
            return ListaClientes;
        }

        public int Registrar(NCliente obj, out string Mensaje)
        {
            int idClienteGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection objconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("F_Registrar_Cliente", objconexion);
                    cmd.Parameters.AddWithValue("CedulaCliente", obj.Cedula);
                    cmd.Parameters.AddWithValue("PrimerNombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("PrimerApellido", obj.Apellido);
                    cmd.Parameters.AddWithValue("Telefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("Correo", obj.Correo);
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
