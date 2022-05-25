using System;
using System.Collections.Generic;

namespace Panaderia
{
    public class Cliente
    {
        public string dni;
        string nombre;
        string apellidos;
        int telefono;
        string localidad;

        public Cliente(string dni, string nombre, string apellidos, int telefono, string localidad)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.localidad = localidad;
        }
        public void Imprimir()
        {
            Console.WriteLine(dni + " | " + nombre + " | " + apellidos + " | " + telefono + " | " + localidad);
        }
    }
}