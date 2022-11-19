using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos; 


namespace Logica
{
   
    public class NuevaFuncionesCategoria : IProcesos<NCategoria>
    {
        private NuevoRepositorioCategoria NuevoRepositorioCategoria = new NuevoRepositorioCategoria();



        public List<NCategoria> Listar()
        {
            return NuevoRepositorioCategoria.Listar();
        }

        #region NO SE IMPLEMENTA 
        public int Registrar(NCategoria obj, out string Mensaje)
        {
            throw new NotImplementedException();
        }

        public int Editar(NCategoria obj, out string Mensaje)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(NCategoria obj, out string Mensaje)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
