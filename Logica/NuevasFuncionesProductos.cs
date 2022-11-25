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
            return nuevoRepositorioProducto.Eliminar(obj, out Mensaje);
        }

        public List<NProducto> Listar()
        {
            return nuevoRepositorioProducto.Listar();
        }

        public int Registrar(NProducto obj, out string Mensaje)
        {
            return nuevoRepositorioProducto.Registrar(obj, out Mensaje);
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

        public decimal ValorFinal(int Unidades, decimal Precio)
        {
            return (Precio * Unidades);
        }

    }
}