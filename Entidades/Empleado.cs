using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
        public string Cargo { get; set; }

        public override string ToString()
        {
            return Cargo + ";" + Cedula + ";" + Nombre + ";" + Apellido + ";" + Telefono + ";" + Correo;
        }
    }
}
