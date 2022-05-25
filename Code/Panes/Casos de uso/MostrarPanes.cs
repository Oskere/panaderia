using System;

namespace Panaderia{
    public class MostrarPanes{
        public static void Ejecutar()
        {
            foreach (var item in PanRepositorio.MostrarPanes())
            {
                item.Imprimir();
            }
        }
    }
}