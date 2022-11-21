using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NCliente : Persona
    {
        public NCliente(int ID, String Cedula, String Nombre, String Apellido, String Telefono, String Correo, NEstado PEstado)
        {
            this.ID = ID;
            this.Cedula = Cedula;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Telefono = Telefono;
            this.Correo = Correo;
            this.PEstado = PEstado;
           
        }

        public NCliente()
        {

        }
    }
}
