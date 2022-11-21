using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class NuevasFuncionesEmpleado : ICrud<NEmpleado>
    {
        NuevoRepositorioEmpleado repositorioEmpleado = new NuevoRepositorioEmpleado();
        public int Editar(NEmpleado obj, out string Mensaje)
        {
            return repositorioEmpleado.Editar(obj, out  Mensaje); 
        }

        public int Eliminar(NEmpleado obj, out string Mensaje)
        {
            throw new NotImplementedException();
        }

        public List<NEmpleado> Listar()
        {
            return repositorioEmpleado.Listar();
        }

        public int Registrar(NEmpleado obj, out string Mensaje)
        {
            throw new NotImplementedException();
        }
    }
}
