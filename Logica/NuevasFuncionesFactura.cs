using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class NuevasFuncionesFactura
    {
        private NuevoRespositorioFactura NuevoRespositorioFactura = new NuevoRespositorioFactura(); 
        public int Cantidad(String Unidad, int Cantidad)
        {
            //CALCULA LA CANTIDAD DE PRODUCTO A LLEVAR BASANDOSE EN LA UNIDAD 
            int Cant = 0;
            switch (Unidad)
            {
                case "UNIDAD":
                    Cant = 1;
                    break;
                case "CAJA (24 Unds)":
                    Cant = 24;
                    break;
                case "SIXPACK":
                    Cant = 6;
                    break;
                case "DOCEPACK":
                    Cant = 12;
                    break;
                case "CANASTA (30 Unds)":
                    Cant = 30;
                    break;
            }
            return (Cant*Cantidad);
        }
        public decimal Descuento(String Descuento)
        {
            //CALCULA EL VALOR DEL DESCUENTO DECIMAL 
           double Desc = 0;
            switch (Descuento)
            {
                case "0%":
                    Desc = 0.0;
                    break;
                case "4%":
                    Desc = 0.04; 
                    break;
                case "6%":
                    Desc = 0.06;
                    break;
                case "8%":
                    Desc = 0.08;
                    break;
                case "10%":
                    Desc = 0.10;
                    break;
                case "12%":
                    Desc = 0.12;
                    break;
                case "14%":
                    Desc = 0.14;
                    break;
                case "16%":
                    Desc = 0.16;
                    break;

            }
            return (decimal)Desc;
        }
        public int RegistrarFacturacion(NFactura obj, DataTable DetellaFactura, out string Mensaje)
        {
            return NuevoRespositorioFactura.RegistrarFacturacion(obj, DetellaFactura, out Mensaje); 
        }
        public bool AumentarStock(int IdProducto, int Cantidad)
        {
            return NuevoRespositorioFactura.AumentarStock( IdProducto,  Cantidad);   
        }
        public bool RestarStock(int IdProducto, int Cantidad)
        {

            return NuevoRespositorioFactura.RestarStock(IdProducto, Cantidad);
        }
        public int ObtenerNumeroFactura()
        {
            return NuevoRespositorioFactura.ObtenerNumeroFactura(); 
     }
    }
}
