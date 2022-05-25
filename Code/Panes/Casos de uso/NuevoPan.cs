using System;

namespace Panaderia{
    public class NuevoPan{
        public static void addPan(){
            string id;
            Tipo tipo;
            Tamaño tamaño;
            int cantidad;
            double precio;

            Console.WriteLine("Introduce el id:");
            id=Console.ReadLine();

            Console.WriteLine("Introduce el tipo:");
            Console.WriteLine("[B] -> Baguete, [C] -> Chapata, [I] -> Integral, [CE] -> Cereales, [M] -> Maíz, por defecto Barra:");
            String elegir = Console.ReadLine().ToUpper();
            if(elegir == "B"){
                tipo = Tipo.Baguete;
            }else if (elegir == "C"){
                tipo = Tipo.Chapata;
            }else if(elegir == "I"){
                tipo = Tipo.Integral;
            }else if (elegir == "CE"){
                tipo = Tipo.Cereales;
            }else if (elegir == "M"){
                tipo = Tipo.Maíz;
            }else{
                tipo = Tipo.Barra;
            }

            Console.WriteLine("Introduce el tamaño:");
            Console.WriteLine("[P] -> Pequeño, [G] -> Grande, por defecto Mediano:");
            String escoger = Console.ReadLine().ToUpper();
            if(escoger == "P"){
                tamaño = Tamaño.Pequeño;
            }else if (escoger == "G"){
                tamaño = Tamaño.Grande;
            }else{
                tamaño = Tamaño.Mediano;
            }

            Console.WriteLine("Introduce la cantidad:");
            cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el precio:");
            precio = double.Parse(Console.ReadLine());

            PanRepositorio.Guardar(new Pan(id, tipo, tamaño, cantidad, precio));
            Console.WriteLine("Has añadido el pan");
        }
    }
}