﻿using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioCliente : ArchivosPersona
    {
        public RepositorioCliente() : base("ListaClientes.txt")
        {

        }

        public List<Cliente> GetAll()
        {
            StreamReader sr = new StreamReader(ruta);
            List<Cliente> clientes = new List<Cliente>();
            while (!sr.EndOfStream)
            {
                clientes.Add(Mappear(sr.ReadLine()));
            }
            sr.Close();
            return clientes;
        }

        Cliente Mappear(String linea)
        {
            try
            {
                var clientes = new Cliente();

                clientes.ID = linea.Split(';')[0];
                clientes.Cedula = linea.Split(';')[1];
                clientes.Nombre = linea.Split(';')[2];
                clientes.Apellido = linea.Split(';')[3];
                clientes.Telefono = linea.Split(';')[4];
                clientes.Correo = linea.Split(';')[5];

                return clientes;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public string Actualizar(List<Cliente> cliente, bool Modo)
        {

            var sw = new StreamWriter(ruta, Modo);
            foreach (var item in cliente)
            {
                sw.WriteLine(item.ToString());
            }
            sw.Close();
            return "Correcto";

        }
    }
}
