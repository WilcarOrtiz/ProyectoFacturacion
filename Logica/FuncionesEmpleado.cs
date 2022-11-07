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

        public String EmpleadoXId(String id)
        {
            String cedula = "";
            foreach (Empleado item in repositorioEmpleado.GetAll())
            {
                if (item.ID == id)
                {
                    cedula = item.Cedula;
                }
            }
            return cedula;
        }

        public int GetById()
        {
            return GetAll().Count + 1;
        }

        public String IdXEmpleado(String cedula)
        {
            String ID = "";
            foreach (Empleado item in repositorioEmpleado.GetAll())
            {
                if (item.Cedula == cedula)
                {
                    ID = item.ID;
                }
            }
            return ID;
        }

        public Empleado ObtenerPorCedula(string cedula)
        {
            foreach (var item in empleados)
            {
                if (item.Cedula == cedula)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Empleado> DisminuirId(List<Empleado> empelado)

        {
            int Conta = 1;
            foreach (var item in empleados)
            {
                item.ID = Conta.ToString();
                Conta++;
            }
            return empleados;
        }

        public string Editar(String ID, String Cedula , String Nombre , String Apellido , String Telefono , String Correo, Empleado empleado)
        {
            try
            {
                empleado.ID = ID;
                empleado.Cedula = Cedula;
                empleado.Nombre = Nombre;
                empleado.Apellido = Apellido;
                empleado.Telefono = Telefono;   
                empleado.Correo = Correo;   

                return repositorioEmpleado.Actualizar(empleados,false);
            }
            catch (Exception EX)
            {

                return "" + EX;
            }
        }

        public string Eliminar(Empleado persona)
        {
            try
            {
                empleados.Remove(persona);
                return repositorioEmpleado.Actualizar(DisminuirId(empleados), false);
            }
            catch (Exception EX)
            {
                return " " + EX;
                throw;
            }
        }

        public List<Empleado> GetAll()
        {
            return repositorioEmpleado.GetAll();
        }
    }
}
