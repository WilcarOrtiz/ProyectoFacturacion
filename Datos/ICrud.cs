using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
    public interface ICrud<T>
    {
        List<T> Listar();

        int Registrar(T obj, out string Mensaje);

        int Editar(T obj, out string Mensaje);

        int Eliminar(T obj, out string Mensaje);
    }
}