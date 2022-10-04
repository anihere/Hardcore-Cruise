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

        }

        public static List<Cruzero> ListaDeCruzeros { get => ListadeCruzeros; set => ListadeCruzeros = value; }
        public static List<Pasajero> ListaDePasajeros { get => ListadePasajeros; set => ListadePasajeros = value; }
        public static List<Viaje> ListaDeViaje { get => ListadeViajes; set => ListadeViajes = value; }

      }
    
   /* private string Mostrar()
    {
        StringBuilder lista = new StringBuilder();
        lista.AppendLine($"Nombre:");
        lista.AppendLine($"Apellido: ");
        lista.AppendLine($"Pasaporte: ");
        lista.AppendLine($"Capacidad de la bodega en Kilogramos: ");
        return lista.ToString();
    }*/
   /* public override string ToString()
    {
          return this.Mostrar();
        
    }*/
    
}


   
