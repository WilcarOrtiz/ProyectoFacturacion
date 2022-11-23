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
    public class NuevoRepositorioEmpleado : ICrud<NEmpleado>
    {
        public int Editar(NEmpleado obj, out string Mensaje)
        {


            int idEmpleadoEditado = 0;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection objconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("F_Editar_Empleado", objconexion);
                    cmd.Parameters.AddWithValue("IdEmpleado", obj.ID);
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

                    idEmpleadoEditado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception EX)
            {
                idEmpleadoEditado = 0;
                Mensaje = EX.Message;
            }
            return idEmpleadoEditado;
        }
        public int Eliminar(NEmpleado obj, out string Mensaje)
        {
            throw new NotImplementedException();
        }
        public List<NEmpleado> Listar()
        {
            List<NEmpleado> ListaEmpleados = new List<NEmpleado>();

            using (SqlConnection objconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.IdEmpleado,p.CedulaEmpleado,p.PrimerNombre,p.PrimerApelldido , p.Telefono , p.Correo,e.IdEstado,e.Descripcion, p.FechaContratacion FROM EMPLEADO p");
                    query.AppendLine("INNER JOIN ESTADO e ON e.IdEstado = p.IdEstado");
         

                    SqlCommand cmd = new SqlCommand(query.ToString(), objconexion);
                    cmd.CommandType = CommandType.Text;
                    objconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ListaEmpleados.Add(new NEmpleado(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5),



                                new NEstado() { IdEstado = dr.GetInt32(6), Descripcion = dr.GetString(7) }, dr.GetDateTime(8)));
                            
                          
                        }
                    }
                }
                catch (Exception ex)
                {
                    ListaEmpleados = new List<NEmpleado>();
                }
            }
            return ListaEmpleados;

        }
        public int Registrar(NEmpleado obj, out string Mensaje)
        {
            throw new NotImplementedException();
        }


        public int UsuarioEmpleado(int Id)
        {
            using (SqlConnection objconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    objconexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdEmpleado From Empleado");
                    query.AppendLine(" where F.NumeroFactura = @Id");


                    SqlCommand cmd = new SqlCommand(query.ToString(), objconexion);
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Id = Convert.ToInt32(dr["IdEmpleado"]); 
                        }
                    }
                }
                catch (Exception)
                {
                    Id = 0; 
                }
            }
            return Id; 
        }

    }
} 

