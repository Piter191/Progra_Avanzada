using BlibliotecaBodega.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlibliotecaBodega.DAL
{
    public class GestorProducto
    {
        private static List<Producto> productos = new List<Producto>();

        public void ingresar(Producto pro)
        {
            productos.Add(pro);
        }

        public List<Producto> mostrar()
        {
            return productos;
        }

        public void eliminar(Producto pro)
        {
            productos.Remove(pro);
        }

        /**
        public void modificar(string nombre, string modelo, string descripcion, double stock, double stockminimo, int precio, string consumible, int estado)
        {
            var pro = productos.Find(u => u.Id == id);

            pro.Modelo = modelo;
            pro.Descripcion = descripcion;
            pro.Stock = stock;
            pro.Stockminimo = stockminimo;
            pro.Precio = precio;
            pro.Consumible = consumible;
            pro.Estado = estado;

        }
        */
        public void modificar(int indice, Producto prod)
        {
            productos.Insert(indice, prod);
        }
    }
}
