using System;
using System.Collections.Generic;

namespace Panaderia
{
    public class FacturaRepositorio
    {
        private static List<Factura> listaFacturas = new List<Factura>();

        public static void addFactura(Factura factura)
        {
            listaFacturas.Add(factura);
        }
        public static List<Factura> ListaFacturas()
        {
            return listaFacturas;
        }
    }
}