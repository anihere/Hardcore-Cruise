using System;
using System.Collections.Generic;
using System.Text;

using Crucero.Entidades;

namespace Crucero.ReglasNegocio
{
    public static class Viajes
    {
        #region Propiedades

        public static List<Viaje> ListadoViajes { get; }

        #endregion

        #region Constructores

        static Viajes()
        {
            ListadoViajes = new List<Viaje>();

            Viaje v = new Viaje();
            v.CiudadPartida = Ciudades.ListadoCiudades[0];
            v.CiudadDestino = Ciudades.ListadoCiudades[1];

            v.DuracionViaje = 72;
            v.FechaInicio = DateTime.Now;
            v.Crucero = Cruceros.ListadoCruceros[0];

            Viaje v2 = new Viaje();
            v2.CiudadPartida = Ciudades.ListadoCiudades[1];
            v2.CiudadDestino = Ciudades.ListadoCiudades[0];

            v2.DuracionViaje = 72;
            v2.FechaInicio = DateTime.Now;
            v2.Crucero = Cruceros.ListadoCruceros[1];

            GuardarViaje(v);
            GuardarViaje(v2);
        }

        #endregion

        #region Metodos

        public static string EliminarViaje(Viaje viaje)
        {
            if (viaje != null && viaje.Identificador != default)
            {
                Viaje aux = null;

                foreach (Viaje vje in Viajes.ListadoViajes)
                {
                    if (vje.Identificador == viaje.Identificador)
                    {
                        aux = vje;
                        break;
                    }
                }

                if (aux != null)
                {
                    if (aux.Tickets != null && aux.Tickets.Count > 0)
                        return "El viaje posee tickets vendidos, no se puede modificar.";

                    if (Viajes.ListadoViajes.Remove(aux))
                        return "Viaje eliminado exitosamente.";
                }
            }

            return "No se ha seleccionado un viaje para eliminar.";
        }

        public static string GuardarViaje(Viaje viaje)
        {
            string validacion = null;

            validacion = ValidarViaje(viaje);

            if (string.IsNullOrWhiteSpace(validacion))
            {
                if (viaje.Identificador == 0)
                    viaje.Identificador = GenerarViajeIdentificador();
                else
                {
                    Viaje aux = null;

                    foreach (Viaje vje in Viajes.ListadoViajes)
                    {
                        if (vje.Identificador == viaje.Identificador)
                        {
                            aux = vje;
                            break;
                        }
                    }

                    if (aux != null)
                        Viajes.ListadoViajes.Remove(aux);
                }

                AplicarLogica(viaje);

                Viajes.ListadoViajes.Add(viaje);

                return null;
            }

            return validacion;
        }

        private static string ValidarViaje(Viaje viaje)
        {
            if (viaje != null)
            {
                if (viaje.CiudadPartida == null)
                    return "Debe seleccionar una ciudad de origen.";

                if (viaje.CiudadDestino == null)
                    return "Debe seleccionar una ciudad de destino.";

                if (viaje.FechaInicio == default)
                    return "Debe seleccionar una fecha de inicio.";

                if (viaje.DuracionViaje == default)
                    return "Debe seleccionar una duracion del viaje.";

                if (viaje.DuracionViaje < viaje.MinimoDuracionViaje || viaje.DuracionViaje > viaje.MaximoDuracionViaje)
                    return "La duración del viaje debe estar comprendida entre 72hs y 720hs.";

                if (viaje.TipoViaje == "Regional" && (viaje.DuracionViaje < 72 || viaje.DuracionViaje > 360))
                    return "La duración del viaje debe estar comprendida entre 72hs y 360hs. para viajes regionales.";

                if (viaje.TipoViaje == "Extra Regional" && (viaje.DuracionViaje < 480 || viaje.DuracionViaje > 720))
                    return "La duración del viaje debe estar comprendida entre 480hs y 720hs. para viajes extra regionales.";

                if (viaje.Crucero == null)
                    return "Debe seleccionar un crucero.";

                if (viaje.Tickets != null && viaje.Tickets.Count > 0)
                    return "El viaje posee tickets vendidos, no se puede modificar.";

                return null;
            }

            return "Debe crear un viaje.";
        }

        private static int GenerarViajeIdentificador()
        {
            int identificador = 0;

            if (ListadoViajes != null)
                foreach (Viaje vje in ListadoViajes)
                {
                    if (vje.Identificador > identificador)
                        identificador = vje.Identificador;
                }

            return identificador + 1;
        }

        private static void AplicarLogica(Viaje viaje)
        {
            if (viaje.TipoViaje == "Regional")
                viaje.CostoTurista = viaje.CostoHoraRegional * viaje.DuracionViaje;

            if (viaje.TipoViaje == "Extra Regional")
                viaje.CostoTurista = viaje.CostoHoraExtraRegional * viaje.DuracionViaje;

            viaje.CostoPremium = viaje.CostoTurista + ((viaje.CostoTurista * 20) / 100);

            viaje.CamarotesOcupaciones = new List<CamaroteOcupacion>();

            foreach (Camarote crt in viaje.Crucero.ListadoCamarotes)
                viaje.CamarotesOcupaciones.Add(new CamaroteOcupacion(crt));
        }

        #endregion
    }
}