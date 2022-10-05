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
        int pasaporte;
        int equipaje;
        List<Pasajero> Listadepasajeros;
        #endregion
        #region Constructor
        public Pasajero(string nombre, string apellido, int Pasaporte, int equipaje)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.pasaporte = Pasaporte;
            this.equipaje = equipaje;
            this.Listadepasajeros = new List<Pasajero>();


        }
        #endregion
    }
}
