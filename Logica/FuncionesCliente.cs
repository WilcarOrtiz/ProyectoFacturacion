using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class FuncionesCliente : IServiciosPersona<Cliente>
    {
        List<Cliente> clientes;
        RepositorioCliente repositorioCliente = new RepositorioCliente();

        public FuncionesCliente()
        {
            clientes = new List<Cliente>();
            clientes = repositorioCliente.GetAll();
        }
        public string Agregar(Cliente persona)
        {
            String Mensaje;
            try
            {
                clientes.Add(persona);
                Mensaje = repositorioCliente.GuardarClientes(persona);
            }
            catch (Exception EX)
            {
                Mensaje = " " + EX;
            }
            return Mensaje;
        }

        public string Editar(string ID, string Cedula, string Nombre, string Apellido, string Telefono, string Correo, Cliente persona)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> GetAll()
        {
            return repositorioCliente.GetAll();
        }

        public String ClienteXId(String id)
        {
            String cedula = "";
            foreach (Cliente item in repositorioCliente.GetAll())
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

        public String IdXCliente(String cedula)
        {
            String ID = "";
            foreach (Cliente item in repositorioCliente.GetAll())
            {
                if (item.Cedula == cedula)
                {
                    ID = item.ID;
                }
            }
            return ID;
        }

        public Cliente ObtenerPorCedula(string cedula)
        {
            foreach (var item in clientes)
            {
                if (item.Cedula == cedula)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Cliente> DisminuirId(List<Cliente> clientes)
        {
            int Conta = 1;
            foreach (var item in clientes)
            {
                item.ID = Conta.ToString();
                Conta++;
            }
            return clientes;
        }


    }
}
