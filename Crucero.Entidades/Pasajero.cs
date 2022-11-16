using System;
using System.Collections.Generic;
using System.Text;

namespace Crucero.Entidades
{
    public class Pasajero
    {
        #region "Propiedades"

        public Pasaporte Pasaporte { get; set; }

        public string Nombre
        {
            get 
            {
                if (Pasaporte != null)
                    return Pasaporte.Nombre;

                return null;
            }
        }

        public string Apellido
        {
            get
            {
                if (Pasaporte != null)
                    return Pasaporte.Apellido;

                return null;
            }
        }

        public string PasaporteIdentificador
        {
            get
            {
                if (Pasaporte != null)
                    return Pasaporte.Identificador;

                return null;
            }
        }

        public string PasajeroDetalle
        {
            get
            {
                if (Pasaporte != null)
                    return Pasaporte.Identificador + " - " + "(" + Pasaporte.Nombre + " " + Pasaporte.Apellido + ")";

                return null;
            }
        }

        public int Edad { get; set; }

        #endregion
    }
}