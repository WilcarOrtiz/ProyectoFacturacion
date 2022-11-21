using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioEmpleado : ArchivosPersona
    {
        public RepositorioEmpleado() : base("ListaEmpleados.txt")
        {

        }

        public List<Empleado> GetAll()
        {
            StreamReader sr = new StreamReader(ruta);
            List<Empleado> empleados = new List<Empleado>();
            while (!sr.EndOfStream)
            {
                empleados.Add(Mappear(sr.ReadLine()));
            }
            sr.Close();
            return empleados;
        }

        Empleado Mappear(String linea)
        {
            try
            {
                var empleado = new Empleado();

                //empleado.ID = linea.Split(';')[0];    
                //empleado.Cedula = linea.Split(';')[1];
                //empleado.Nombre = linea.Split(';')[2];
                //empleado.Apellido = linea.Split(';')[3];
                //empleado.Telefono = linea.Split(';')[4];
                //empleado.Correo = linea.Split(';')[5];

                return empleado;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public string Actualizar(List<Empleado> empleado, bool Modo)
        {

            var sw = new StreamWriter(ruta, Modo);
            foreach (var item in empleado)
            {
                sw.WriteLine(item.ToString());
            }
            sw.Close();
            return "Correcto";

        }
    }
}
