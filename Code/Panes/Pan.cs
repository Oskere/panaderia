using System;

namespace Panaderia
{
    public enum Tipo
    {
        Baguete, Integral, bombeta, ogaza
    }

    public enum Tamaño
    {
        Pequeño, Grande, Mediano
    }

    public class Pan
    {
        private static List<Pan> listaPanes = new List<Pan>();

        public string id;

        public Tipo tipo;

        public Tamaño tamaño;

        public int cantidad;
        
        public double precio;

        public Pan(string id, Tipo tipo, Tamaño tamaño, int cantidad, double precio)
        {
            this.id = id;
            this.tipo = tipo;
            this.tamaño = tamaño;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public void Imprimir()
        {
            Console.WriteLine(tipo + " | " + tamaño + " | " + cantidad + " unidad/es" + " | " + precio + " euro/s");
        }
    }
}