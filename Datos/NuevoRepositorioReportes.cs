using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class NuevoRepositorioReportes
    {
        public DataTable ObtenerOrdenVenta(DateTime FechaInicio, DateTime FechaFinal)
        {
            using (SqlConnection objconexion = new SqlConnection(Conexion.cadena))
            {
                objconexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objconexion;
                cmd.CommandText = @"select 
	                                        F.IdFactura,
	                                        F.FechaFacturacion,
	                                        C.PrimerNombre + ',' + C.PrimerApelldido as CLiente, 
	                                        PRODUCTO = STUFF((select ' - ' + 'x'+convert(varchar(10), DF2.Cantidad)+ ' '+Nombre
	                                        from DETALLE_FACTURA DF2
	                                        inner join PRODUCTO on PRODUCTO.IdProducto = DF2.IdProducto 
	                                        where DF2.IdFactura = DF.IdFactura
	                                        FOR XML PATH('')),1,2,''),
	                                        F.MontoTotal
                                        from FACTURA F
                                        INNER JOIN CLIENTE C ON C.IdCliente = F.IdCliente 
                                        INNER JOIN DETALLE_FACTURA DF ON DF.IdFactura = F.IdFactura 
                                        WHERE F.FechaFacturacion BETWEEN @FechaInicio AND @FechaFinal
                                        GROUP BY F.IdFactura, DF.IdFactura, F.FechaFacturacion, C.PrimerNombre, C.PrimerApelldido, F.MontoTotal
                                        ORDER BY F.IdFactura ASC";

                cmd.Parameters.AddWithValue("@FechaInicio", SqlDbType.Date).Value = FechaInicio;
                cmd.Parameters.AddWithValue("@FechaFinal", SqlDbType.Date).Value = FechaFinal;
                cmd.CommandType = CommandType.Text;
                var reader = cmd.ExecuteReader();
                var table = new DataTable();
                table.Load(reader);
                reader.Dispose();


                return table;
            }



        }
    }
}
