using System;

namespace Panaderia;

public class Factura{
    List<Pan> panes = new List<Pan>();

    Cliente cliente;

    public void AsociarCliente(Cliente c){
        this.cliente = c;
    }

    public void AñadirProducto(Pan pan){
        panes.Add(pan);
    }

    public double CalcularPrecio(){
        double total = 0;

        foreach (var item in panes)
        {
            total+= item.precio * item.cantidad;
        }
        return total;
    }

    public void Imprimir()
        {
            Console.WriteLine("Factura del cliente: ");
            this.cliente.Imprimir();
            Console.WriteLine("Lista de productos: ");
            foreach (var item in panes)
            {
                item.Imprimir();
            }
            Console.WriteLine("Total Factura: " + this.CalcularPrecio() + " euro/s");
        }
}
