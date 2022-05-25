using System;

namespace Panaderia{
    public class MostrarClientes{
        public static void mostrar()
        {
            foreach (var item in ClienteRepositorio.ListaClientes())
            {
                item.Imprimir();
            }
        }
    }
}