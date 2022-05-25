using System;

namespace Panaderia;

public class MostrarFacturas{
    public static void mostrar(){

        foreach (var item in FacturaRepositorio.ListaFacturas())
            {
                item.Imprimir();
            }
    }
}