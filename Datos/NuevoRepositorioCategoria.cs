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
    public class NuevoRepositorioCategoria : ICrud<NCategoria>
    {
        public int Editar(NCategoria obj, out string Mensaje)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(NCategoria obj, out string Mensaje)
        {
            throw new NotImplementedException();
        }

        public List<NCategoria> Listar()
        {
            List<NCategoria> listaCategorias = new List<NCategoria>();
            using (SqlConnection objconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdCategoria, Descripcion FROM CATEGORIA ");
                    SqlCommand cmd = new SqlCommand(query.ToString(), objconexion);
                    cmd.CommandType = CommandType.Text;
                    objconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listaCategorias.Add(new NCategoria()
                            {
                                IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                                Descripcion = dr["Descripcion"].ToString()
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    listaCategorias = new List<NCategoria>();
                }
            }
            return listaCategorias;
        }

        public int Registrar(NCategoria obj, out string Mensaje )
        {
            throw new NotImplementedException();
        }
    }
}
