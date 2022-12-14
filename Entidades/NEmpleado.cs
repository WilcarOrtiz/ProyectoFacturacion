using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NEmpleado : Persona
    {

        public DateTime FechaContratacion { get; set; }
        public  NEstado PEstado { get; set; }

        public NEmpleado(int ID, String Cedula, String Nombre,String Apellido, String Telefono, String Correo, NEstado PEstado, DateTime FechaContratacion)
        {
            this.ID = ID;
            this.Cedula = Cedula;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Telefono = Telefono;
            this.Correo = Correo;
            this.PEstado = PEstado;
            this.FechaContratacion = FechaContratacion;
        }

        public NEmpleado()
        {

        }
    }
}
