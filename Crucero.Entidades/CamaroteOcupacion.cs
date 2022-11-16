using System;
using System.Collections.Generic;
using System.Text;

namespace Crucero.Entidades
{
    public class CamaroteOcupacion
    {
        #region "Propiedades"

        public Camarote Camarote { get;}

        public int Ocupacion { get; set; }

        public bool Disponibilidad
        {
            get
            {
                if (Camarote != null && Ocupacion < Camarote.Capacidad)
                    return true;

                return false;
            }
        }

        public string Detalle
        {
            get
            {
                if (Camarote != null)
                    return Camarote.Identificador + " - (" + Camarote.CamaroteTipo.ToString() + ") Capacidad: " + Camarote.Capacidad.ToString() + " Ocupación: " + Ocupacion.ToString();

                return null;
            }
        }

        #endregion

        #region Constructores

        public CamaroteOcupacion() { }

        public CamaroteOcupacion(Camarote camarote)
        {
            Camarote = camarote;
        }

        #endregion
    }
}