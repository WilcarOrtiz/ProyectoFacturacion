using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IServiciosPersona<T>
    {
        String Agregar(T persona);

      
        List<T> GetAll();

        
    }
}
