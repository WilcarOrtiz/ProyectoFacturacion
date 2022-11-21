using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            //String cedula = "";
            //foreach (Empleado item in repositorioEmpleado.GetAll())
            //{
            //    if (item.ID == id)
            //    {
            //        cedula = item.Cedula;
            //    }
            //}
            return "";
        }

        public int GetById()
        {
            return GetAll().Count + 1;
        }


        public string ValidarUser(String Cedula)
        {
            string Nombre = null; 
            foreach (var item in repositorioEmpleado.GetAll())
            {
                if (Cedula==item.Cedula )
                {
                    Nombre =item.Nombre;
                }
            }
            return Nombre;
        }

        public String IdXEmpleado(String cedula)
        {
            String ID = "";
            foreach (Empleado item in repositorioEmpleado.GetAll())
            {
                if (item.Cedula == cedula)
                {
                 //  ID = item.ID;
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
                //item.ID = Conta.ToString();
                Conta++;
            }
            return empleados;
        }

        public string Editar(String ID, String Cedula , String Nombre , String Apellido , String Telefono , String Correo, Empleado persona)
        {
            try
            {
               // persona.ID = ID;
                persona.Cedula = Cedula;
                persona.Nombre = Nombre;
                persona.Apellido = Apellido;
                persona.Telefono = Telefono;
                persona.Correo = Correo;   

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
