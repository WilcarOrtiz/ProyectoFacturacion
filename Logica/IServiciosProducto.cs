using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Logica
{
    public interface IServiciosProducto<T>
    {
        string AgregarProducto(ProductoComprado Articulo);
        string EliminarProducto(ProductoComprado Articulo);
        List<T> GetAllProductos();
        T ObtenerPorCodigo(String Codigo);
        string Editar(String ID, String Codigo, String NombreProducto,
            String Descripcion, int Unidades,float PrecioC, float PrecioV, ProductoComprado Articulo);
    }
}
