using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ArchivosProductos
    {
        protected String ruta;

        public ArchivosProductos()
        {
            ruta = "Producto.txt";
        }
        public ArchivosProductos(string FileName)
        {
            ruta = FileName;
        }

        public String GuardarProducto(Entitades.Producto Articulo)
        {
            StreamWriter sw = new StreamWriter(ruta, true);
            sw.WriteLine(Articulo.ToString());
            sw.Close();
            return "Correcto";
        }

    }
}
