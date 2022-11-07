using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioUsuario : ArchivosPersona
    {
        public RepositorioUsuario() : base("ListaUsuarios.txt")
        {

        }

        public List<Usuario> GetAll()
        {
            StreamReader sr = new StreamReader(ruta);
            List<Usuario> usuarios = new List<Usuario>();
            while (!sr.EndOfStream)
            {
                usuarios.Add(Mappear(sr.ReadLine()));
            }
            sr.Close();
            return usuarios;
        }

        Usuario Mappear(String linea)
        {
            try
            {
                var Usuarios = new Usuario();

                Usuarios.Cedula = linea.Split(';')[0];
                Usuarios.Contraseña = linea.Split(';')[1];
                
                return Usuarios;
            }
            catch (Exception)
            {

                return null;

            }

        }
    }
}
