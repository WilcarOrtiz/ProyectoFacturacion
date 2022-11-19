using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class NuevaFuncionesClientes : IProcesos<Cliente>
    {
        private NuevoRepositorioCliente NuevoRepositorioCliente = new NuevoRepositorioCliente();
        public int Editar(Cliente obj, out string Mensaje)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(Cliente obj, out string Mensaje)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> Listar()
        {
            throw new NotImplementedException();
        }

        public int Registrar(Cliente obj, out string Mensaje)
        {
            throw new NotImplementedException();
        }

        public int BuscarCliente(string cedula, out string Mensaje)
        {
            return NuevoRepositorioCliente.BuscarCliente(cedula, out Mensaje);
        }
    }
}
