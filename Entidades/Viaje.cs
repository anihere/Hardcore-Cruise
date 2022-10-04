using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Entidades
{
    public class Viaje
    {
        #region Atributos
        //atributos
        Cruzero cruzero;
        List<Pasajero> pasajeros;
        string ciudadpartida;
        string ciudaddestino;
        DateTime fechainicioviaje;
        int costoviaje;
        int duracionviaje;
        int Capacidadbodega;
        #endregion
        #region Constructores
        public Viaje(string ciudaddestino)
        {
            this.ciudaddestino = ciudaddestino;
        }

        public Viaje(string ciudaddestino,DateTime fechainicioviaje)
        {
            this.ciudaddestino = ciudaddestino;
            this.fechainicioviaje = fechainicioviaje;
        }
        public Viaje
            (string ciudadpartida, string ciudaddestino, DateTime fechainicioviaje, int costoviaje, int duracionviaje, Cruzero cruzero, int capacidabodega)
        {
            this.ciudadpartida = ciudadpartida;
            this.ciudaddestino = ciudaddestino;
            this.fechainicioviaje = fechainicioviaje;
            this.costoviaje = costoviaje;
            this.duracionviaje = duracionviaje;
            this.cruzero = cruzero;
            this.pasajeros = new List<Pasajero>();
            this.Capacidadbodega = capacidabodega;
        }
        #endregion
        #region Propiedades
        public List<Pasajero> Pasajeros
        {
            get
            {
                return this.pasajeros;
            }
        }
        #endregion
        #region Metodos
        //Metodo de instancia

        private string Mostrar()
        {
            StringBuilder Viaje = new StringBuilder();
            // Viaje.AppendLine($"Ciudad de partida: {this.ciudadpartida}");
            Viaje.AppendLine($"Ciudad de destino: {this.ciudaddestino} ");
            Viaje.AppendLine($"Fecha de inicio de viaje: {this.fechainicioviaje} ");
            Viaje.AppendLine($"Costo del viaje: {this.costoviaje} ");
            Viaje.AppendLine($"Nombre del Cruzero: {this.cruzero}");
            Viaje.AppendLine($"Duracion del viaje: {this.duracionviaje} ");
            Viaje.AppendLine($"Capacidad de la bodega: {this.Capacidadbodega}");
            Viaje.AppendLine($"N° Pasajeros: {this.pasajeros.Count}");
            return Viaje.ToString();
        }
        #endregion
        #region Sobrecarga Operadores
        public override string ToString()
        {
            return Mostrar();
        }
        #endregion
    }
}
