using System;

namespace Panaderia{
    public class BajaCliente{
        //introducir clientes
        public static void Ejecutar()
        {
            Console.WriteLine("Introduce el DNI del cliente que quieres eliminar:");
            String dniEliminar = Console.ReadLine();

            Cliente cliente = ClienteRepositorio.BuscarID(dniEliminar);
            if (cliente != null)
            {
                ClienteRepositorio.Borrar(cliente);
                Console.WriteLine("El cliente ha sido dado de baja");
            }
            else
            {
                Console.WriteLine("No existe ningún cliente con ese DNI");
            }
        }
    }
}