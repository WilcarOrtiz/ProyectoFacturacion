using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class FuncionesProducto : IServiciosProducto<Producto>
    {
        Datos.RepositorioProducto RepositorioProducto = new Datos.RepositorioProducto();
        List<Producto> products;

        public FuncionesProducto()
        {
            products = new List<Producto>();
            products = RepositorioProducto.GetAll();
        }
        public string AgregarProducto(Producto Articulo)
        {
            String Mensaje;
            try
            {
                products.Add(Articulo);
                Mensaje = RepositorioProducto.GuardarProducto(Articulo);
            }
            catch (Exception EX)
            {
                Mensaje = " " + EX;
            }
            return Mensaje;
        }

        public string Editar(string ID, string Codigo, string NombreProducto, string Descripcion, string Unidad, int Cantidad, float PrecioC, float PrecioV, Producto Articulo)
        {
            try
            {
                Articulo.ID = ID;
                Articulo.Codigo = Codigo;
                Articulo.NombreProducto = NombreProducto;
                Articulo.Descripcion = Descripcion;
                Articulo.Cantidad = Cantidad;
                Articulo.Unidad = Unidad;
                Articulo.PrecioC = PrecioC;
                Articulo.PrecioV = PrecioV;
                return RepositorioProducto.Actualizar(products, false);

            }
            catch (Exception EX)
            {
                return "" + EX;
                throw;
            }
        }

        public string EliminarProducto(Producto Articulo)
        {
            try
            {
                products.Remove(Articulo);
                return RepositorioProducto.Actualizar(DisminuirId(products), false);
            }
            catch (Exception EX)
            {
                return " " + EX;
                throw;
            }
        }

        public List<Producto> GetAllProductos()
        {
            return RepositorioProducto.GetAll();
        }

        public Producto ObtenerPorCodigo(string Codigo)
        {
            foreach (var item in products)
            {
                if (item.Codigo == Codigo)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Producto> DisminuirId(List<Producto> products)

        {
            int Conta = 1;
            foreach (var item in products)
            {
                item.ID = Conta.ToString();
                Conta++;
            }
            return products;
        }

        public int GetById()
        {
            return GetAllProductos().Count + 1;
        }

        public String ArticuloXId(String id)
        {
            String Cod = "";
            foreach (Producto item in RepositorioProducto.GetAll())
            {
                if (item.ID == id)
                {
                    Cod = item.Codigo;
                }
            }
            return Cod;
        }

        public String IdXArticulo(String Cod)
        {
            String ID = "";
            foreach (Producto item in RepositorioProducto.GetAll())
            {
                if (item.Codigo == Cod)
                {
                    ID = item.ID;
                }
            }
            return ID;
        }

        public decimal ValorFinal(String Unidad, int Cantidad, float Precio)
        {
            //como se maneja es por unidad debemos sacar el valor final
            int Cant = 0;
            switch (Unidad)
            {
                case "UNIDAD":
                    Cant = 1;
                    break;
                case "CAJA(24 Unds)":
                    Cant = 24;
                    break;
                case "CANASTA(30 Unds)":
                    Cant = 30;
                    break;
            }
            return (decimal)(Precio * (float)(Cant * Cantidad));
        }
    }
}
