using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class NuevasFuncionesCliente : IProcesos<NCliente>
    {
      NuevoRepositorioCliente NuevoRepositorioCliente = new NuevoRepositorioCliente();
        public int Editar(NCliente obj, out string Mensaje)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(NCliente obj, out string Mensaje)
        {
            throw new NotImplementedException();
        }

        public List<NCliente> Listar()
        {
            return NuevoRepositorioCliente.Listar(); 
        }

        public int Registrar(NCliente obj, out string Mensaje)
        {
            return NuevoRepositorioCliente.Registrar(obj, out Mensaje); 
        }

        public int BuscarCliente(string cedula ,out string Mensaje)
        {
            return NuevoRepositorioCliente.BuscarCliente(cedula, out Mensaje); 
        }


    }
}
