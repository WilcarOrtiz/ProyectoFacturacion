using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string ID { get; set; }
        public string Unidad { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public float PrecioC { get; set; }
        public float PrecioV { get; set; }
        public Producto(String ID, String Codigo, String NombreProducto, String Descripcion, String Unidad, int Cantidad, float PrecioC, float PrecioV)
        {
            this.ID = ID;
            this.Unidad = Unidad;
            this.Codigo = Codigo;
            this.NombreProducto = NombreProducto;
            this.Descripcion = Descripcion;
            this.Cantidad = Cantidad;
            this.PrecioC = PrecioC;
            this.PrecioV = PrecioV;
        }
        public Producto()
        {

        }
        public override string ToString()
        {
            return ID + ";" + Codigo + ";" + NombreProducto + ";" + Descripcion + ";" + Cantidad + ";" + Unidad + ";" + PrecioC + ";" + PrecioV;
        }
    }
}
