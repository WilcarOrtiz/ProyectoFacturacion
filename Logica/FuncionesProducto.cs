using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class FuncionesProducto : IServiciosProducto<ProductoComprado>
    {
        Datos.RepositorioProducto RepositorioProducto = new Datos.RepositorioProducto();
        List<ProductoComprado> products;

        public FuncionesProducto()
        {
            products = new List<ProductoComprado>();
            products = RepositorioProducto.GetAll();
        }
        public string AgregarProducto(ProductoComprado Articulo)
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

        public string Editar(string ID, string Codigo, string NombreProducto, string Descripcion, int Unidades, float PrecioC, float PrecioV, ProductoComprado Articulo)
        {
            try
            {
                Articulo.ID = ID;
                Articulo.Codigo = Codigo;
                Articulo.NombreProducto = NombreProducto;
                Articulo.Descripcion = Descripcion;
                Articulo.Unidades = Unidades;
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

        public string EliminarProducto(ProductoComprado Articulo)
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

        public List<ProductoComprado> GetAllProductos()
        {
            return RepositorioProducto.GetAll();
        }

        public ProductoComprado ObtenerPorCodigo(string Codigo)
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

        public List<ProductoComprado> DisminuirId(List<ProductoComprado> products)

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
            foreach (ProductoComprado item in RepositorioProducto.GetAll())
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
            foreach (ProductoComprado item in RepositorioProducto.GetAll())
            {
                if (item.Codigo == Cod)
                {
                    ID = item.ID;
                }
            }
            return ID;
        }

        public int CantidadUnitaria(String Unidad)
        {
            int Cant = 0;
            switch (Unidad)
            {
                case "UNIDAD":
                    Cant = 1;
                    break;
                case "CAJA (24 Unds)":
                    Cant = 24;
                    break;
                case "CANASTA (30 Unds)":
                    Cant = 30;
                    break;
            }
            return Cant;
         
        }

        public decimal ValorFinal(int Unidades, float Precio)
        {
            return (decimal)(Precio * Unidades);
        }
    }
}
