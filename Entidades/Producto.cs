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
        public int Unidades { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public float PrecioV { get; set; }
        public Producto(String Codigo, String NombreProducto, String Descripcion, int Unidades, float PrecioV)
        {
            
            this.Unidades = Unidades;
            this.Codigo = Codigo;
            this.NombreProducto = NombreProducto;
            this.Descripcion = Descripcion;
            this.PrecioV = PrecioV;
        }
        public Producto()
        {

        }
        public override string ToString()
        {
            return  Codigo + ";" + NombreProducto + ";" + Descripcion + ";"+ Unidades + ";" + PrecioV;
        }
    }
}
