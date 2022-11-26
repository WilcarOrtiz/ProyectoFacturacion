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
    public class NuevoRepositorioUsuario : ICrud<Usuario>
    {
        public int Editar(Usuario obj, out string Mensaje)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(Usuario obj, out string Mensaje)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> Listar()
        {
            throw new NotImplementedException();
        }

        public int LoginValidado(String Cedula, string Contraseña, out string Mensaje)
        {

            //vALIDAD ESTADO
            int idUsuario = 0;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection objconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("F_LOGIN", objconexion);
                    cmd.Parameters.AddWithValue("Cedula", Cedula);
                    cmd.Parameters.AddWithValue("Contraseña", Contraseña);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 45).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    objconexion.Open();
                    cmd.ExecuteNonQuery();
                    idUsuario = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception EX)
            {
                idUsuario = 0;
                Mensaje = EX.Message;
            }
            return idUsuario;
        }

        public int Login_Administrador(String Cedula, string Contraseña, out string Mensaje)
        {
            //Valida administrador
            int idUsuario = 0;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection objconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("F_lOGIN_Validando_Administrador", objconexion);
                    cmd.Parameters.AddWithValue("Cedula", Cedula);
                    cmd.Parameters.AddWithValue("Contraseña", Contraseña);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 45).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    objconexion.Open();
                    cmd.ExecuteNonQuery();
                    idUsuario = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception EX)
            {
                idUsuario = 0;
                Mensaje = EX.Message;
            }
            return idUsuario;
        }

        public int Registrar(Usuario obj, out string Mensaje)
        {
            int idEmpleadoGenerado = 0;
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
                    cmd.Parameters.AddWithValue("Contraseña", obj.Contraseña);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 45).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    objconexion.Open();
                    cmd.ExecuteNonQuery();

                    idEmpleadoGenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception EX)
            {
                idEmpleadoGenerado = 0;
                Mensaje = EX.Message;
            }
            return idEmpleadoGenerado;
        }
    }
}
