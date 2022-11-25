using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades; 
namespace Logica
{
    public class NuevasFuncionesUsuario : IProcesos<Usuario>
    {
        NuevoRepositorioUsuario NuevoRepositorioUsuario = new NuevoRepositorioUsuario(); 
        public int Editar(Usuario obj, out string Mensaje)
        {
            throw new NotImplementedException();
        }
        public int Eliminar(Usuario obj, out string Mensaje)
        {
            throw new NotImplementedException();
        }
        public List<Usuario> Listar()
        {
            throw new NotImplementedException();
        }
        public int Registrar(Usuario obj, out string Mensaje)
        {
            return NuevoRepositorioUsuario.Registrar(obj, out Mensaje); 
        }
        public int Login(String Cedula, string Contraseña, out string Mensaje)
        {
            return NuevoRepositorioUsuario.LoginValidado( Cedula, Contraseña, out Mensaje);
        }


        public int Login_Administrador(String Cedula, string Contraseña, out string Mensaje)
        {
            return NuevoRepositorioUsuario.Login_Administrador(Cedula, Contraseña, out Mensaje);
        }

    }
}
