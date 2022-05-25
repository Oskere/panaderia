using System;

namespace Panaderia{
    public class EliminarPan{
        public static void Ejecutar()
        {
            Console.WriteLine("Introduzca el ID del pan que quieres eliminar:");
            string idEliminar = Console.ReadLine();

            Pan pan = PanRepositorio.BuscarID(idEliminar);
            if (pan != null)
            {
                PanRepositorio.Borrar(pan);
                Console.WriteLine("Has eliminado el pan");
            }
            else
            {
                Console.WriteLine("No tienes ningún pan de ese tipo");
            }
        }
    }
}