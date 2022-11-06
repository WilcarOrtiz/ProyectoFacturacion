using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class ProductoComprado : Producto
    {

        public string ID { get; set; }
        public float PrecioC { get; set; }
        public ProductoComprado(String ID, String Codigo, String NombreProducto, String Descripcion, int Unidades, float PrecioC, float PrecioV): base( Codigo,  NombreProducto,Descripcion, Unidades, PrecioV )
        {
            this.ID = ID;
            this.PrecioC= PrecioC;
        }
        public ProductoComprado()
        {

        }
        public override string ToString()
        {
            return ID + ";" + Codigo + ";" + NombreProducto + ";" + Descripcion + ";" + Unidades + ";" + PrecioC + ";" + PrecioV;
        }
    }

}
