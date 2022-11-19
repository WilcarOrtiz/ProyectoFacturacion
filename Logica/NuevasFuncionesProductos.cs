using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class NuevasFuncionesProductos : IProcesos<NProducto>
    {
        private NuevoRepositorioProducto nuevoRepositorioProducto = new NuevoRepositorioProducto();

        public int Editar(NProducto obj, out string Mensaje)
        {
            return nuevoRepositorioProducto.Editar(obj, out Mensaje);
        }

        public int Eliminar(NProducto obj, out string Mensaje)
        {
            throw new NotImplementedException();
        }

        public List<NProducto> Listar()
        {
            return nuevoRepositorioProducto.Listar();
        }

        public int Registrar( NProducto obj, out string Mensaje)
        {
             return nuevoRepositorioProducto.Registrar(obj, out Mensaje);
        }

    }
}