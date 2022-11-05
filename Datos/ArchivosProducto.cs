using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class ArchivosProducto
    {
        protected String ruta;

        public ArchivosProducto()
        {
            ruta = "Producto.txt";
        }
        public ArchivosProducto(string FileName)
        {
            ruta = FileName;
        }

        public String GuardarProducto(Producto Articulo)
        {
            StreamWriter sw = new StreamWriter(ruta, true);
            sw.WriteLine(Articulo.ToString());
            sw.Close();
            return "Correcto";
        }

    }
}
