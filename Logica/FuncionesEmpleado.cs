using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class FuncionesEmpleado : IServiciosPersona<Empleado>
    {
        List<Empleado> empleados;
        RepositorioEmpleado repositorioEmpleado = new RepositorioEmpleado();

        public FuncionesEmpleado()
        {
            empleados = new List<Empleado>();
            empleados = repositorioEmpleado.GetAll();
        }
        public string Agregar(Empleado persona)
        {
            String Mensaje;
            try
            {
                empleados.Add(persona);
                Mensaje = repositorioEmpleado.GuardarEmpleado(persona);
            }
            catch (Exception EX)
            {
                Mensaje = " " + EX;
            }
            return Mensaje;
        }

        public string Editar(Empleado persona)
        {
            throw new NotImplementedException();
        }

        public string Eliminar(Empleado persona)
        {
            throw new NotImplementedException();
        }

        public List<Empleado> GetAllUsuarios()
        {
            return repositorioEmpleado.GetAll();
        }
    }
}
