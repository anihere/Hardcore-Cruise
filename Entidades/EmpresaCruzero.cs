using System;
using System.Collections.Generic;
using System.Text;
using Entidades;

namespace Entidades
{
    public static class EmpresaCruzero
    {
        private static List<Cruzero> ListadeCruzeros;
        private static List<Pasajero> ListadePasajeros;
        private static List<Viaje> ListadeViajes;

        static EmpresaCruzero()
        {
            ListadeCruzeros = new List<Cruzero>();
            ListadePasajeros = new List<Pasajero>();
            ListadeViajes = new List<Viaje>();
            //Creo la lista de cruzero la inicializo con los Cruzeros. Para mostrarlos en los ListBox de la clase FrmCentral.

            ListadeCruzeros = new List<Cruzero>();
            ListadeCruzeros.Add(new Cruzero("ADJ134", "Hardcore", 50, 3, 1, 500));
            ListadeCruzeros.Add(new Cruzero("NJV768", "Royal Pride", 40, 2, 1, 500));
            ListadeCruzeros.Add(new Cruzero("INJ890", "Transatlantico del Sur", 30, 2, 1, 500));
            ListadeCruzeros.Add(new Cruzero("LNX213", "Costero", 30, 3, 2, 500));
            ListadeCruzeros.Add(new Cruzero("ADJ134", "Fenix USA", 50, 3, 1, 500));
            ListadeCruzeros.Add(new Cruzero("FNQ879", "Sol del oceano", 50, 3, 1, 500));
            ListadeCruzeros.Add(new Cruzero("FYN319", "MSC", 50, 3, 1, 500));

        }
        public static List<Cruzero> ListaDeCruzeros { get => ListadeCruzeros; set => ListadeCruzeros = value; }
        public static List<Pasajero> ListaDePasajeros { get => ListadePasajeros; set => ListadePasajeros = value; }
        public static List<Viaje> ListaDeViaje { get => ListadeViajes; set => ListadeViajes = value; }


    }

}
