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
    public class NuevoRespositorioFactura
    {
        public int ObtenerNumeroFactura()
        {

            int IdNumeroFactura = 0;
            using (SqlConnection objconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT COUNT(*) + 1 FROM FACTURA");
                    SqlCommand cmd = new SqlCommand(query.ToString(), objconexion);
                    cmd.CommandType = CommandType.Text;
                    objconexion.Open();
                    IdNumeroFactura = Convert.ToInt32(cmd.ExecuteScalar());

                }
                catch (Exception ex)
                {
                    IdNumeroFactura = 0;
                }
            }
            return IdNumeroFactura;
        }
        public bool RestarStock(int IdProducto, int Cantidad)
        {

            bool Respuesta = true;
            using (SqlConnection objconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE PRODUCTO SET Stock = Stock -@Cantidad WHERE IdProducto = @IdProducto");
                    SqlCommand cmd = new SqlCommand(query.ToString(), objconexion);
                    cmd.Parameters.AddWithValue("@Cantidad", Cantidad);
                    cmd.Parameters.AddWithValue("@IdProducto", IdProducto);
                    cmd.CommandType = CommandType.Text;
                    objconexion.Open();
                    Respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;

                }
                catch (Exception ex)
                {
                    Respuesta = false;
                }
            }
            return Respuesta;

        }
        public bool AumentarStock(int IdProducto, int Cantidad)
        {

            bool Respuesta = true;
            using (SqlConnection objconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE PRODUCTO SET Stock = Stock + @Cantidad WHERE IdProducto = @IdProducto");
                    SqlCommand cmd = new SqlCommand(query.ToString(), objconexion);
                    cmd.Parameters.AddWithValue("@Cantidad", Cantidad);
                    cmd.Parameters.AddWithValue("@IdProducto", IdProducto);
                    cmd.CommandType = CommandType.Text;
                    objconexion.Open();
                    Respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;

                }
                catch (Exception ex)
                {
                    Respuesta = false;
                }
            }
            return Respuesta;

        }

        public int RegistrarFacturacion(NFactura obj, DataTable DetellaFactura, out string Mensaje)
        {
            int respuesta;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection objconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("F_Registrar_Factura", objconexion);
                    cmd.Parameters.AddWithValue("IdEmpleado", obj.empleado.ID);
                    cmd.Parameters.AddWithValue("IdCliente", obj.cliente.ID);
                    cmd.Parameters.AddWithValue("NumeroFactura", obj.NumeroFactura);
                    cmd.Parameters.AddWithValue("Iva", obj.Iva);
                    cmd.Parameters.AddWithValue("Descuento", obj.Descuento);
                    cmd.Parameters.AddWithValue("MontoPago", obj.MontoPago);
                    cmd.Parameters.AddWithValue("MontoCambio", obj.MontoCambio);
                    cmd.Parameters.AddWithValue("MontoTotal", obj.Total);
                    cmd.Parameters.AddWithValue("DetalleVenta", DetellaFactura);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 45).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    objconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception EX)
            {
                respuesta = 0;
                Mensaje = EX.Message;
            }
            return respuesta;
        }

    }
}
