using System;
using System.Collections.Generic;
using System.Text;

namespace Crucero.Entidades
{
    public class TicketViaje
    {
        #region "Propiedades"

        public string Identificador { get; set; }

        public Pasajero Pasajero { get; set; }
        public string PasajeroDetalle
        {
            get
            {
                if (Pasajero != null)
                    return Pasajero.PasajeroDetalle;

                return null;
            }
        }

        public CamaroteOcupacion CamaroteOcupacion { get; set; }

        public string CruceroMatriculaNombre
        {
            get
            {
                if (CamaroteOcupacion != null && CamaroteOcupacion.Camarote != null)
                    return CamaroteOcupacion.Camarote.CruceroMatriculaNombre;

                return null;
            }
        }

        public string CamaroteOcupacionTipo
        {
            get
            {
                if (CamaroteOcupacion != null && CamaroteOcupacion.Camarote != null)
                    return CamaroteOcupacion.Camarote.Identificador + " - " + CamaroteOcupacion.Camarote.CamaroteTipo.ToString();

                return null;
            }
        }

        public Viaje Viaje { get; set; }

        public decimal Costo { get; set; }

        public int ViajeIdentificador
        {
            get
            {
                if (Viaje != null)
                    return Viaje.Identificador;

                return 0;
            }
        }

        public string CiudadPaisPartida
        {
            get
            {
                if (Viaje != null)
                    return Viaje.CiudadPaisPartida;

                return null;
            }
        }

        public string CiudadPaisDestino
        {
            get
            {
                if (Viaje != null)
                    return Viaje.CiudadPaisDestino;

                return null;
            }
        }

        public DateTime Fecha
        {
            get
            {
                if (Viaje != null)
                    return Viaje.FechaInicio;

                return default;
            }
        }

        public decimal Duracion
        {
            get
            {
                if (Viaje != null)
                    return Viaje.DuracionViaje;

                return default;
            }
        }

        public string TipoViaje
        {
            get
            {
                if (Viaje != null)
                    return Viaje.TipoViaje;

                return null;
            }
        }

        #endregion
    }
}