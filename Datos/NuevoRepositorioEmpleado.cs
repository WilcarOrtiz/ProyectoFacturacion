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
            throw new NotImplementedException();
        }

        public int Eliminar(NEmpleado obj, out string Mensaje)
        {
            throw new NotImplementedException();
        }

        public List<NEmpleado> Listar()
        {
            List<NEmpleado> listaEmpleados = new List<NEmpleado>();

            using (SqlConnection objconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdEmpleado , CedulaEmpleado , PrimerNombre , PrimerApelldido , Telefono , Correo , e.Descripcion , FechaContratacion ");
                    query.AppendLine("FROM EMPLEADO p INNER JOIN ESTADO e ");
                    query.AppendLine("ON e.IdEstado = p.IdEstado");

                    SqlCommand cmd = new SqlCommand(query.ToString(), objconexion);
                    cmd.CommandType = CommandType.Text;
                    objconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listaEmpleados.Add(new NEmpleado()
                            {
                               // ID = dr["IdEmpleado"].ToString(),
                                Cedula = dr["CedulaEmpleado"].ToString(),
                                Nombre = dr["PrimerNombre"].ToString(),
                                Apellido = dr["PrimerApelldido"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                PEstado = new NEstado() { IdEstado = Convert.ToInt32(dr["IdEstado"]), Descripcion = dr["Descripcion"].ToString() },
                                //FechaContratacion = Convert.ToDateTime(dr["FechaContratacion"].ToString())

                            }) ; ;
                        }
                    }
                }
                catch (Exception ex)
                {
                    listaEmpleados = new List<NEmpleado>();
                }
            }
            return listaEmpleados;
        }

        public int Registrar(NEmpleado obj, out string Mensaje)
        {
            throw new NotImplementedException();
        }
    }
} 

