using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    class Viaje
    {
        //atributos
        private string ciudadpartida;
        private string ciudaddestino;
        private DateTime fechainicioviaje;
        private int costoviaje;
        private int duracionviaje;

        //constructores
        public Viaje
            (string ciudadpartida, string ciudaddestino, DateTime fechainicioviaje, int costoviaje, int duracionviaje)
        {
            this.ciudadpartida = ciudadpartida;
            this.ciudaddestino = ciudaddestino;
            this.fechainicioviaje = fechainicioviaje;
            this.costoviaje = costoviaje;
            this.duracionviaje = duracionviaje;
            
        }

        //Metodo de instancia
        private string Mostrar()
        {
            StringBuilder Viaje = new StringBuilder();
            Viaje.AppendLine($"Ciudad de partida: {this.ciudadpartida}");
            Viaje.AppendLine($"Ciudad de destino: {this.ciudaddestino}");
            Viaje.AppendLine($"Fecha de inicio de viaje: {this.fechainicioviaje}");
            Viaje.AppendLine($"Costo del viaje: {this.costoviaje}");
            Viaje.AppendLine($"Duracion del viaje: {this.duracionviaje}");
            return Viaje.ToString();
        }


    }
}
