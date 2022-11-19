using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class NuevasFuncionEstado : IProcesos<NEstado>
    {
        private NuevoRepositorioEstado NuevoRepositorioEstado = new NuevoRepositorioEstado(); 
        public int Editar(NEstado obj, out string Mensaje)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(NEstado obj, out string Mensaje)
        {
            throw new NotImplementedException();
        }

        public List<NEstado> Listar()
        {
            return NuevoRepositorioEstado.Listar();

        }

        public int Registrar(NEstado obj, out string Mensaje)
        {
            throw new NotImplementedException();
        }
    }
}
