using System;

namespace Panaderia;

public class NuevaFactura{
    public static void new(){
        Console.WriteLine("Introduce el DNI del cliente:");
        string dni = Console.ReadLine();

        Cliente cliente = ClienteRepositorio.BuscarID(dni);
        if(cliente == null){
            Console.WriteLine("El cliente no existe");
            return;
        }

        Factura factura = new Factura();

        factura.AsociarCliente(cliente);
        string respuesta;
        do{
            Console.WriteLine("Introduce el ID del producto: ");
            string id = Console.ReadLine();

            Pan pan = PanRepositorio.BuscarID(id);
            if(pan == null){
                Console.WriteLine("No hay panes");
                return;
            }

            Console.WriteLine("Introduce la cantidad:");
            int cantidad = int.Parse(Console.ReadLine());

            pan.cantidad = cantidad;

            factura.AñadirProducto(pan);

            Console.WriteLine("Desea añadir mas productos? [s/n]");
            respuesta = Console.ReadLine();

        }while(respuesta == "s");

        Console.WriteLine("Total a pagar: " + factura.CalcularPrecio());

        FacturaRepositorio.Guardar(factura);

        Console.WriteLine("Factura guardada con exito en la base de datos");
    }
}