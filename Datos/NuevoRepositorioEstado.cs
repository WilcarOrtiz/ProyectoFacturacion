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
    public class NuevoRepositorioEstado : ICrud<NEstado>
    {
  
        public List<NEstado> Listar()
        {
            List<NEstado> listaEstados = new List<NEstado>();
            using (SqlConnection objconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdEstado, Descripcion FROM ESTADO ");
                    SqlCommand cmd = new SqlCommand(query.ToString(), objconexion);
                    cmd.CommandType = CommandType.Text;
                    objconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listaEstados.Add(new NEstado()
                            {
                                IdEstado = Convert.ToInt32(dr["IdEstado"]),
                                Descripcion = dr["Descripcion"].ToString()
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    listaEstados = new List<NEstado>();
                }
            }
            return listaEstados;
        }

        #region NO IMPLEMENADO 
        public int Editar(NEstado obj, out string Mensaje  )
        {
            throw new NotImplementedException();
        }

        public int Eliminar(NEstado obj, out string Mensaje    )
        {
            throw new NotImplementedException();
        }


        public int Registrar(NEstado obj, out string Mensaje    )
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
