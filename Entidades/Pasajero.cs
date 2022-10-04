using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Pasajero
    {
        #region Atributos
        string nombre;
        string apellido;
        int Pasaporte;
        int equipaje;
        List<Pasajero> Listadepasajeros;
        #endregion
        #region Constructor
        public Pasajero(string nombre, string apellido, int Pasaporte, int equipaje)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.Pasaporte = Pasaporte;
            this.equipaje = equipaje;
            this.Listadepasajeros = new List<Pasajero>();


        }
        #endregion
        #region Propiedades

        public List<Pasajero> Pasajeros
        {
            get
            {
                return this.Listadepasajeros;
            }
        }


        #endregion
        #region Metodos

        private string MostrarPasajeros()
        {
            StringBuilder pasajero = new StringBuilder();
            pasajero.AppendLine($"Nombre: {this.nombre}");
            pasajero.AppendLine($"Apellido: {this.apellido}");
            pasajero.AppendLine($"Pasaporte: {this.Pasaporte}");
            pasajero.AppendLine($"Equipaje: {this.equipaje}");

            return pasajero.ToString();
        }
        #endregion
        #region Sobrecarga De Operadores
        public override string ToString()
        {
            return this.MostrarPasajeros();
            // return this.nombre;
        }
        #endregion

    }
}
