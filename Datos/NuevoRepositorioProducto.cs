using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos
{
    public class NuevoRepositorioProducto : ICrud<NProducto>
    {
        public int Editar(NProducto obj, out string Mensaje)
        {
            int idProductogenerado = 0;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection objconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("F_Editar_Producto", objconexion);
                    cmd.Parameters.AddWithValue("IdProducto", obj.IdProducto);
                    cmd.Parameters.AddWithValue("Codigo", obj.Codigo);
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("IdCategoria", obj.PCategoria.IdCategoria);
                    cmd.Parameters.AddWithValue("Stock", obj.Stock);
                    cmd.Parameters.AddWithValue("PrecioCompra", obj.PrecioCompra);
                    cmd.Parameters.AddWithValue("PrecioVenta", obj.PrecioVenta);
                    cmd.Parameters.AddWithValue("IdEstado", obj.PEstado.IdEstado);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 45).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    objconexion.Open();

                    cmd.ExecuteNonQuery();

                    idProductogenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception EX)
            {
                idProductogenerado = 0;
                Mensaje = EX.Message;
            }
            return idProductogenerado;
        }

        public int Eliminar(NProducto obj, out string Mensaje)
        {
            throw new NotImplementedException();
        }

        public List<NProducto> Listar()
        {
            List<NProducto> listaProductos = new List<NProducto>();

            using (SqlConnection objconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.IdProducto, p.Codigo, p.Nombre, p.Descripcion, c.IdCategoria, c.Descripcion[DescripcionCategoria], p.Stock, p.PrecioCompra, p.PrecioVenta, e.IdEstado, e.Descripcion[DescripcionEstado],p.FechaIngreso FROM PRODUCTO p");
                    query.AppendLine("inner join CATEGORIA c ON c.IdCategoria = p.IdCategoria");
                    query.AppendLine("inner join ESTADO e ON e.IdEstado = p.IdEstado");

                    SqlCommand cmd = new SqlCommand(query.ToString(), objconexion);
                    cmd.CommandType = CommandType.Text;
                    objconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listaProductos.Add(new NProducto()
                            {
                                IdProducto = Convert.ToInt32(dr["IdProducto"]),
                                Codigo = dr["Codigo"].ToString(),
                                Nombre = dr["Nombre"].ToString(),
                                Descripcion = dr["Descripcion"].ToString(),
                                PCategoria = new NCategoria() { IdCategoria = Convert.ToInt32(dr["IdCategoria"]), Descripcion = dr["DescripcionCategoria"].ToString() },
                                Stock = Convert.ToInt32(dr["Stock"].ToString()),
                                PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"].ToString()),
                                PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"].ToString()),
                                PEstado = new NEstado() { IdEstado = Convert.ToInt32(dr["IdEstado"]), Descripcion = dr["DescripcionEstado"].ToString() },
                                FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"].ToString())

                            });  ;
                        }
                    }
                }
                catch (Exception ex)
                {
                    listaProductos = new List<NProducto>();
                }
            }
            return listaProductos;
        }

        public int Registrar(NProducto obj, out string Mensaje)
        {
            int idProductogenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection objconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("F_Registrar_Producto", objconexion);
                    cmd.Parameters.AddWithValue("Codigo", obj.Codigo);
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("IdCategoria", obj.PCategoria.IdCategoria);
                    cmd.Parameters.AddWithValue("Stock", obj.Stock);
                    cmd.Parameters.AddWithValue("PrecioCompra", obj.PrecioCompra);
                    cmd.Parameters.AddWithValue("PrecioVenta", obj.PrecioVenta);
                    cmd.Parameters.AddWithValue("IdEstado", obj.PEstado.IdEstado);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 45).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    objconexion.Open();

                    cmd.ExecuteNonQuery();

                    idProductogenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception EX)
            {
                idProductogenerado = 0;
                Mensaje = EX.Message;
            }
            return idProductogenerado;
        }
    }


    
}