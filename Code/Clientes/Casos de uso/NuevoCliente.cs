using System;

namespace Panaderia{

    public class NuevoCliente{

    public static void addCliente()
        {
            string dni;
            string nombre;
            string apellidos;
            int telefono;
            string localidad;

            Console.WriteLine("Introduce el DNI:");
            dni = Console.ReadLine();

            Console.WriteLine("Introduce el nombre:");
            nombre = Console.ReadLine();

            Console.WriteLine("Introduce los apellidos:");
            apellidos = Console.ReadLine();

            Console.WriteLine("Introduce el telefono:");
            telefono = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la localidad:");
            localidad = Console.ReadLine();

            ClienteRepositorio.Guardar(new Cliente(dni, nombre, apellidos, telefono, localidad));
            Console.WriteLine("El cliente ha sido dado de alta");
        }
    }
}