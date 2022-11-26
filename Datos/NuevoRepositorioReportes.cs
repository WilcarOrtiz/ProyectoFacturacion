using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Collections;

namespace Datos
{
    public class NuevoRepositorioReportes
    {

        public NFactura ObtenerFacutra(string numero)
        {
            NFactura factura = new NFactura();

            using (SqlConnection objconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    objconexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT F.IdFactura,E.CedulaEmpleado,");
                    query.AppendLine(" E.PrimerNombre[Nombre_Empleado], E.PrimerApelldido[Apellido_Empleado] ,");
                    query.AppendLine(" C.CedulaCliente, C.PrimerNombre[Nombre_Cliente], C.PrimerApelldido[Apellido_Cliente] , ");
                    query.AppendLine(" F.MontoPago, F.MontoCambio, F.Descuento, F.Iva,  F.MontoTotal,");
                    query.AppendLine("  CONVERT(char(10), F.FechaFacturacion,103 )[FechaRegistro]");
                    query.AppendLine("  FROM FACTURA F INNER JOIN  CLIENTE C ON C.IdCliente = F.IdCliente");
                    query.AppendLine(" INNER JOIN EMPLEADO E on F.IdEmpleado = E.IdEmpleado");
                    query.AppendLine(" where F.NumeroFactura = @numero");


                    SqlCommand cmd = new SqlCommand(query.ToString(), objconexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            factura = new NFactura()
                            {
                                IdFactura = Convert.ToInt32(dr["IdFactura"]),
                                cliente = new NCliente() { Nombre = dr["Nombre_Cliente"].ToString(), Apellido = dr["Apellido_Cliente"].ToString(), Cedula = dr["CedulaCliente"].ToString() },
                                empleado = new NEmpleado() { Nombre = dr["Nombre_Empleado"].ToString(), Apellido = dr["Apellido_Empleado"].ToString(), Cedula = dr["CedulaEmpleado"].ToString() },
                                MontoPago = Convert.ToDecimal(dr["MontoPago"]),
                                MontoCambio = Convert.ToDecimal(dr["MontoCambio"]),
                                Descuento = Convert.ToDecimal(dr["Descuento"]),
                                Iva = Convert.ToDecimal(dr["Iva"]),
                                Total = Convert.ToDecimal(dr["MontoTotal"]),
                                FechaFacturacion = Convert.ToDateTime(dr["FechaRegistro"].ToString())

                            };
                        }
                    }


                }
                catch (Exception)
                {

                    factura = new NFactura();
                }
            }
            return factura;
        }
        public List<Detalle_Facturas> ObtenerDetallesFactura(int IdFactura)
        {
            List<Detalle_Facturas> DetalleFactura = new List<Detalle_Facturas>();

            using (SqlConnection objconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    objconexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("  SELECT P.Nombre, P.PrecioVenta, DF.Cantidad, DF.SubTotal");
                    query.AppendLine("FROM DETALLE_FACTURA DF INNER JOIN PRODUCTO P");
                    query.AppendLine(" ON P.IdProducto = DF.IdProducto");
                    query.AppendLine(" WHERE DF.IdFactura=@IdFactura; ");


                    SqlCommand cmd = new SqlCommand(query.ToString(), objconexion);
                    cmd.Parameters.AddWithValue("@IdFactura", IdFactura);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            DetalleFactura.Add(new Detalle_Facturas()
                            {
                                DF_producto = new NProducto() { Nombre = dr["Nombre"].ToString() },
                                DF_Subtotal = Convert.ToDecimal(dr["SubTotal"]),
                                DF_Cantidad = Convert.ToInt32(dr["Cantidad"]),
                                DF_PrecioVenta = Convert.ToInt32(dr["PrecioVenta"])

                            });
                        }
                    }
                }
                catch (Exception)
                {
                    DetalleFactura = new List<Detalle_Facturas>();
                }
            }
            return DetalleFactura;
        }

        public List<ReportesFacturasPorFecha> ReportesFacturasPorFechas(String FehchaIcnicio, string FechaFinal)
        {

            List<ReportesFacturasPorFecha> listaReportesFacturasPorFechas = new List<ReportesFacturasPorFecha>();

            using (SqlConnection objconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("P_REPORTESFACTURAS_POR_FECHAS", objconexion);
                    cmd.Parameters.AddWithValue("FechaInicio", FehchaIcnicio);
                    cmd.Parameters.AddWithValue("FechaFin", FechaFinal);
                    cmd.CommandType = CommandType.StoredProcedure;
                    objconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listaReportesFacturasPorFechas.Add(new ReportesFacturasPorFecha()
                            {

                                FecharRegistro = dr["FechaRegistro"].ToString(),
                                NumeroFactura = dr["NumeroFactura"].ToString(),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString()),
                                CedulaCliente = dr["CedulaCliente"].ToString(),
                                CedulaEmpleado = dr["CedulaEmpleado"].ToString(),
                                CodigoProducto = dr["Codigo"].ToString(),
                                NombreProducto = dr["Nombre"].ToString(),
                                DescripcionProducto = dr["Descripcion"].ToString(),
                                precioVenta = Convert.ToDecimal(dr["PrecioVenta"].ToString())

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    listaReportesFacturasPorFechas = new List<ReportesFacturasPorFecha>();
                }
            }
            return listaReportesFacturasPorFechas;
        }
        
        //ESTA RETORNA DATOS SOBRE EL N° DE CLIENTES, PRODUCTOS, FACTURA Y DEMAS 
        public void Informacion_General(out string P_total, out string P_CantidadFacturas, out string P_CantidadEmpleado, out string P_CantidadClientes, out string P_CantidadProducto)
        {
            using (SqlConnection objconexion = new SqlConnection(Conexion.cadena))
            {

                StringBuilder query = new StringBuilder();
                SqlCommand cmd = new SqlCommand("DatosGenerales", objconexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter total = new SqlParameter("@TotalVentas", 0); total.Direction = ParameterDirection.Output;
                SqlParameter CantidadFacturas = new SqlParameter("@CantidadFacturas", 0); CantidadFacturas.Direction = ParameterDirection.Output;
                SqlParameter CantidadEmpleado = new SqlParameter("@CantidadEmpleado", 0); CantidadEmpleado.Direction = ParameterDirection.Output;
                SqlParameter CantidadClientes = new SqlParameter("@CantidadClientes", 0); CantidadClientes.Direction = ParameterDirection.Output;
                SqlParameter CantidadProducto = new SqlParameter("@CantidadProducto", 0); CantidadProducto.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(total);
                cmd.Parameters.Add(CantidadFacturas);
                cmd.Parameters.Add(CantidadEmpleado);
                cmd.Parameters.Add(CantidadClientes);
                cmd.Parameters.Add(CantidadProducto);
                objconexion.Open();
                cmd.ExecuteNonQuery();

                P_total = cmd.Parameters["@TotalVentas"].Value.ToString();
                P_CantidadFacturas = cmd.Parameters["@CantidadFacturas"].Value.ToString();
                P_CantidadEmpleado = cmd.Parameters["@CantidadEmpleado"].Value.ToString();
                P_CantidadClientes = cmd.Parameters["@CantidadClientes"].Value.ToString();
                P_CantidadProducto = cmd.Parameters["@CantidadProducto"].Value.ToString();

            }
        }
        public ArrayList Productos_Preferidos(out ArrayList CantidadProductosPreferidos)
        {
            ArrayList NombreProductosPreferidos = new ArrayList();
            CantidadProductosPreferidos = new ArrayList();

            using (SqlConnection objconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("PRODUCTOS_PREFERIDOS", objconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    objconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            NombreProductosPreferidos.Add(dr.GetString(0));
                            CantidadProductosPreferidos.Add(dr.GetInt32(1));
                        }
                    }
                }
                catch
                {

                }

            }
            return NombreProductosPreferidos;
        }
    }
}
