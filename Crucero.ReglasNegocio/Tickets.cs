using System;
using System.Collections.Generic;
using System.Text;

using Crucero.Entidades;

namespace Crucero.ReglasNegocio
{
    public static class Tickets
    {
        #region Propiedades

        public static List<TicketViaje> ListadoTickets
        {
            get
            {
                List<TicketViaje> tickets = new List<TicketViaje>();

                foreach (Viaje viaje in Viajes.ListadoViajes)
                    if (viaje.Tickets != null && viaje.Tickets.Count > 0)
                        tickets.AddRange(viaje.Tickets);

                return tickets;
            }
        }

        #endregion

        #region Constructores

        static Tickets()
        {
        }

        #endregion

        #region Metodos

        public static void EliminarTicket(TicketViaje ticket)
        {
            if (ticket != null && ticket.Identificador != default)
            {
                TicketViaje aux = null;

                foreach (TicketViaje tck in ticket.Viaje.Tickets)
                {
                    if (tck.Identificador == ticket.Identificador)
                    {
                        aux = tck;
                        break;
                    }
                }

                if (aux != null)
                {
                    ticket.Viaje.Tickets.Remove(aux);
                    if (aux.CamaroteOcupacion != null && aux.CamaroteOcupacion.Camarote != null)
                        if (ticket.Viaje.CamarotesOcupaciones != null)
                            foreach (CamaroteOcupacion co in ticket.Viaje.CamarotesOcupaciones)
                                if (co.Camarote.Identificador == aux.CamaroteOcupacion.Camarote.Identificador)
                                    co.Ocupacion = co.Ocupacion - 1;
                }
            }
        }

        public static string GuardarTicket(TicketViaje ticket)
        {
            string validacion = null;

            validacion = ValidarTicket(ticket);

            if (string.IsNullOrWhiteSpace(validacion))
            {
                if (string.IsNullOrWhiteSpace(ticket.Identificador))
                    GenerarTicketIdentificador(ticket);
                else
                    EliminarTicket(ticket);

                ticket.Viaje.Tickets.Add(ticket);
                ticket.CamaroteOcupacion.Ocupacion = ticket.CamaroteOcupacion.Ocupacion + 1;

                return null;
            }

            return validacion;
        }

        private static string ValidarTicket(TicketViaje ticket)
        {
            if (ticket != null)
            {
                if (ticket.Pasajero == null)
                    return "Debe crear un pasajero.";

                if (ticket.Viaje == null)
                    return "Debe seleccionar un viaje.";

                if (ticket.Costo == default)
                    return "Debe seleccionar el tipo de Camarote.";

                if (ticket.CamaroteOcupacion == null || ticket.CamaroteOcupacion.Camarote == null)
                    return "Debe seleccionar el Camarote.";

                if (ticket.CamaroteOcupacion != null && ticket.CamaroteOcupacion.Camarote != null && !ticket.CamaroteOcupacion.Disponibilidad)
                    return "Debe seleccionar un Camarote con disponibilidad.";

                return null;
            }

            return "Debe crear un ticket.";
        }

        private static void GenerarTicketIdentificador(TicketViaje ticket)
        {
            int identificador = 1;

            if (ticket.Viaje.Tickets == null || ticket.Viaje.Tickets.Count == 0)
            {
                ticket.Viaje.Tickets = new List<TicketViaje>();
                ticket.Identificador = "V" + ticket.Viaje.Identificador.ToString() + "T-" + identificador.ToString();
            }
            else
            {
                bool generado = false;
                while (!generado)
                {
                    ticket.Identificador = "V" + ticket.Viaje.Identificador.ToString() + "T-" + identificador.ToString();

                    foreach (TicketViaje tck in ticket.Viaje.Tickets)
                    {
                        if (tck.Identificador == ticket.Identificador)
                        {
                            identificador = identificador + 1;
                            generado = false;
                            break;
                        }
                        else
                            generado = true;
                    }
                }
            }
        }

        #endregion
    }
}