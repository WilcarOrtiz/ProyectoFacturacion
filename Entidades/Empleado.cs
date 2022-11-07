using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
       
        public override string ToString()
        {
            return Cedula + ";" + Nombre + ";" + Apellido + ";" + Telefono + ";" + Correo ;
        }
    }
}
