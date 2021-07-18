using System;
using System.Collections.Generic;
using System.Text;

namespace BlibliotecaBodega.DTO
{
    public class Producto
    {
        
        private string nombre;
        private string modelo;
        private string descripcion;
        private double stock;
        private double stockminimo;
        private int precio;
        private string consumible;
        private int estado;

        public Producto(string nombre, string modelo, string descripcion, double stock, double stockminimo, int precio, string consumible, int estado)
        {
            
            this.nombre = nombre;
            this.modelo = modelo;
            this.descripcion = descripcion;
            this.stock = stock;
            this.stockminimo = stockminimo;
            this.precio = precio;
            this.consumible = consumible;
            this.estado = estado;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Stock { get => stock; set => stock = value; }
        public double Stockminimo { get => stockminimo; set => stockminimo = value; }
        public int Precio { get => precio; set => precio = value; }
        public string Consumible { get => consumible; set => consumible = value; }
        public int Estado { get => estado; set => estado = value; }

        public override string ToString()
        {
            return this.nombre+" "+this.modelo+" "+this.stock+" ";
        }
    }
}
