using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CreacionFactura
    {

        Logica.FuncionesProducto funcionesProductos = new Logica.FuncionesProducto();
        Datos.RepositorioProducto RepositorioProducto = new Datos.RepositorioProducto();

        List<ProductoComprado> products;



        public Boolean Stock( string Codigo,int Cantidad)
        {
            foreach (var item in funcionesProductos.GetAllProductos())
            {
                if (item.Codigo.Equals(Codigo))
                {
                    if (Cantidad <= item.Unidades)
                    {
                        return true;
                    }
                }
            }
            return false; 
        }


        public int Cantidad(String Unidad, int Cantidad)
        {
            //CALCULA LA CANTIDAD DE PRODUCTO A LLEVAR BASANDOSE EN LA UNIDAD 
            int Cant = 0;
            switch (Unidad)
            {
                case "UNIDAD":
                    Cant = 1;
                    break;
                case "CAJA (24 Unds)":
                    Cant = 24;
                    break;
                case "SIXPACK":
                    Cant = 6;
                    break;
                case "DOCEPACK":
                    Cant = 12;
                    break;
                case "CANASTA (30 Unds)":
                    Cant = 30;
                    break;
            }
            return (Cant*Cantidad);
        }



        public double Descuento(String Descuento)
        {
            //CALCULA EL VALOR DEL DESCUENTO DECIMAL 
           double Desc = 0;
            switch (Descuento)
            {
                case "4%":
                    Desc = 0.04; 
                    break;
                case "6%":
                    Desc = 0.06;
                    break;
                case "8%":
                    Desc = 0.08;
                    break;
                case "10%":
                    Desc = 0.10;
                    break;
                case "12%":
                    Desc = 0.12;
                    break;
                case "14%":
                    Desc = 0.14;
                    break;
                case "16%":
                    Desc = 0.16;
                    break;

            }
            return Desc;
        }

        public string RestarStock(List<string> codigoProdVendidos, List<int> cantProdVendidos)
        {
            products = new List<ProductoComprado>();
            products = funcionesProductos.GetAllProductos();
            foreach (var item in products)
            {
                foreach (var itemCod in codigoProdVendidos)
                {

                    if (item.Codigo == itemCod)
                    {

                        foreach (var itemCant in cantProdVendidos)
                        {
                            item.Unidades = (item.Unidades - itemCant);
                            cantProdVendidos.Remove(itemCant);
                            break;
                        }


                    }
                    codigoProdVendidos.Remove(itemCod);
                    break;
                }
            }
            RepositorioProducto.Actualizar(products,false);

            return "Venta realizada con exito";
        }


    }
}
