using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class RepositorioProducto : ArchivosProducto
    {
        public RepositorioProducto() : base()
        {
            ruta = "ListaProductos.TXT";
        }

        public RepositorioProducto(String FileName) : base(FileName) { }

        public List<Producto> GetAll()
        {
            StreamReader sr = new StreamReader(ruta);
            List<Producto> products = new List<Producto>();
            while (!sr.EndOfStream)
            {
                products.Add(Mappear(sr.ReadLine()));
            }
            sr.Close();
            return products;
        }

        Producto Mappear(String linea)
        {
            var Articulo = new Producto();
            Articulo.ID = linea.Split(';')[0];
            Articulo.Codigo = linea.Split(';')[1];
            Articulo.NombreProducto = linea.Split(';')[2];
            Articulo.Descripcion = linea.Split(';')[3];
            Articulo.Cantidad = int.Parse(linea.Split(';')[4]);
            Articulo.Unidad = linea.Split(';')[5];
            Articulo.PrecioC = float.Parse(linea.Split(';')[6]);
            Articulo.PrecioV = float.Parse(linea.Split(';')[7]);
            return Articulo;
        }

        public string Actualizar(List<Producto> products, bool Modo)
        {

            var sw = new StreamWriter(ruta, Modo);
            foreach (var item in products)
            {
                sw.WriteLine(item.ToString());
            }
            sw.Close();
            return "Correcto";

        }
    }
}
