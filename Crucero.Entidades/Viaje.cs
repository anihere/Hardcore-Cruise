using System;
using System.Collections.Generic;
using System.Text;

namespace Crucero.Entidades
{
    public class Viaje
    {
        #region Atributos

        public readonly int CostoHoraRegional = 57;

        public readonly int CostoHoraExtraRegional = 120;

        public readonly int MinimoDuracionViaje = 72;

        public readonly int MaximoDuracionViaje = 720;

        #endregion

        #region "Propiedades"

        public int Identificador { get; set; }

        public Ciudad CiudadPartida { get; set; }

        public string CiudadPaisPartida
        {
            get
            {
                if (CiudadPartida != null)
                    return CiudadPartida.CiudadPais;

                return null;
            }
        }

        public Ciudad CiudadDestino { get; set; }
        public string CiudadPaisDestino
        {
            get
            {
                if (CiudadDestino != null)
                    return CiudadDestino.CiudadPais;

                return null;
            }
        }

        public DateTime FechaInicio { get; set; }

        public decimal DuracionViaje { get; set; } = 72;

        public Crucero Crucero { get; set; }
        public string CruceroMatriculaNombre
        {
            get
            {
                if (Crucero != null)
                    return Crucero.MatriculaNombre;

                return null;
            }
        }

        public List<TicketViaje> Tickets { get; set; }
        public int TicketsVendidos
        {
            get
            {
                if (Tickets != null)
                    return Tickets.Count;

                return 0;
            }
        }

        public int TicketsVendidosPremium
        {
            get
            {
                int cantidad = 0;
                if (Tickets != null)
                {
                    foreach (TicketViaje tvj in Tickets)
                    {
                        if (tvj.CamaroteOcupacion != null && tvj.CamaroteOcupacion.Camarote != null)
                            if (tvj.CamaroteOcupacion.Camarote.CamaroteTipo == CamaroteTipo.Premium)
                                cantidad = cantidad + 1;
                    }
                }

                return cantidad;
            }
        }

        public int TicketsVendidosTurista
        {
            get
            {
                int cantidad = 0;
                if (Tickets != null)
                {
                    foreach (TicketViaje tvj in Tickets)
                    {
                        if (tvj.CamaroteOcupacion != null && tvj.CamaroteOcupacion.Camarote != null)
                            if (tvj.CamaroteOcupacion.Camarote.CamaroteTipo == CamaroteTipo.Turista)
                                cantidad = cantidad + 1;
                    }
                }

                return cantidad;
            }
        }

        public decimal TicketsVendidosMontoTurista
        {
            get
            {
                decimal monto = 0;
                if (Tickets != null)
                {
                    foreach (TicketViaje tvj in Tickets)
                    {
                        if (tvj.CamaroteOcupacion != null && tvj.CamaroteOcupacion.Camarote != null)
                            if (tvj.CamaroteOcupacion.Camarote.CamaroteTipo == CamaroteTipo.Turista)
                                monto = monto + tvj.Costo;
                    }
                }

                return monto;
            }
        }

        public decimal TicketsVendidosMontoPremium
        {
            get
            {
                decimal monto = 0;
                if (Tickets != null)
                {
                    foreach (TicketViaje tvj in Tickets)
                    {
                        if (tvj.CamaroteOcupacion != null && tvj.CamaroteOcupacion.Camarote != null)
                            if (tvj.CamaroteOcupacion.Camarote.CamaroteTipo == CamaroteTipo.Premium)
                                monto = monto + tvj.Costo;
                    }
                }

                return monto;
            }
        }

        public decimal TicketsVendidosMonto
        {
            get
            {
                return TicketsVendidosMontoTurista + TicketsVendidosMontoPremium;
            }
        }

        public List<CamaroteOcupacion> CamarotesOcupaciones { get; set; }

        public decimal CostoTurista { get; set; }

        public decimal CostoPremium { get; set; }

        public string TipoViaje
        {
            get
            {
                if (CiudadPartida != null && CiudadPartida.Pais != null && CiudadPartida.Pais.PaisTipo == PaisTipo.ExtraRegional)
                    if (CiudadDestino != null && CiudadDestino.Pais != null && CiudadDestino.Pais.PaisTipo == PaisTipo.Regional)
                        return "Extra Regional";

                if (CiudadPartida != null && CiudadPartida.Pais != null && CiudadPartida.Pais.PaisTipo == PaisTipo.Regional)
                    if (CiudadDestino != null && CiudadDestino.Pais != null && CiudadDestino.Pais.PaisTipo == PaisTipo.ExtraRegional)
                        return "Extra Regional";

                if (CiudadPartida != null && CiudadDestino != null)
                    return "Regional";

                return null;
            }
        }

        #endregion

        #region Constructores

        public Viaje() { }

        public Viaje(int identificador)
        {
            Identificador = identificador;
        }

        #endregion
    }
}