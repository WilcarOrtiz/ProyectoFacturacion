﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : Empleado
    {
        public String Contraseña { get; set; }

        public override string ToString()
        {
            return Cedula + ";" + Contraseña;
        }
    }
}
