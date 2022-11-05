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
        public RepositorioUsuario() : base("Usuarios.txt")
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
                Usuarios.NombreUser = linea.Split(';')[0];
                Usuarios.Contraseña = linea.Split(';')[1];
                Usuarios.Cedula = linea.Split(';')[2];

                return Usuarios;
            }
            catch (Exception)
            {

                return null;

            }

        }
    }
}
