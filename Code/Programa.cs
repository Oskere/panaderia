using System;
using System.Collections.Generic;

namespace Panaderia
{
    public class programa
    {
        public static void Main(string[] args)
        {
            String input;

            do
            {
                input = MenuPan();

                switch (input)
                {
                    case "1":
                        NuevoCliente.addCliente();
                    break;

                    case "2":
                        BajaCliente.Ejecutar();
                    break;

                    case "3":
                        MostrarClientes.mostrar();
                    break;

                    case "4":
                        NuevoPan.addPan();
                    break;

                    case "5":
                        EliminarPan.deletePan();
                    break;

                    case "6":
                        MostrarPanes.mostrar();
                    break;

                    case "7":
                        NuevaFactura.addFactura();
                    break;

                    case "8":
                        MostrarFacturas.mostrar();
                    break;

                    case "9":
                        Console.WriteLine("Has salido del programa");
                    break;
                }
            } while (input != "9");
        }

        public static String MenuPan()
        {
            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine("               MENU                ");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1.- Dar alta cliente panistico");
            Console.WriteLine("2.- Dar baja cliente panisitco");
            Console.WriteLine("3.- Mostrar lista clientes panisticos");
            Console.WriteLine("4.- Añadir stock panes paneados");
            Console.WriteLine("5.- Eliminar stock panes paneados");
            Console.WriteLine("6.- Almacenamiento de panes paneados");
            Console.WriteLine("7.- Nueva factura pantastica");
            Console.WriteLine("8.- Mostrar facturas pantasticas");
            Console.WriteLine("9.- Salir");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Introduce la opcion a realizar");
            return Console.ReadLine();
        }
    }
}