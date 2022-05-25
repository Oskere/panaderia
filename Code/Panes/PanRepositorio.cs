using System;
using System.Collections.Generic;
using System.IO;

namespace Panaderia{
    public class PanRepositorio{
        private static List<Pan> listaPanes = new List<Pan>();

        public static Pan BuscarID(string id)
        {
            return listaPanes.Find(x => x.id == id);
        }

        public static Pan BuscarTipo(Tipo tipo)
        {
            return listaPanes.Find(x => x.tipo == tipo);
        }

        public static void Borrar(Pan pan)
        {
            listaPanes.Remove(pan);
        }

        public static void Guardar(Pan pan)
        {
            listaPanes.Add(pan);
        }

        public static List<Pan> MostrarPanes()
        {
           return listaPanes;
        }
    }
}