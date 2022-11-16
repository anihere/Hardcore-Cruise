using System;
using System.Collections.Generic;
using System.Text;

namespace Crucero.ReglasNegocio
{
    public static class Pasajeros
    {
        #region Propiedades

        public static List<Entidades.Pasajero> ListadoPasajeros { get; }

        #endregion

        #region Constructores

        static Pasajeros()
        {
            ListadoPasajeros = new List<Entidades.Pasajero>()
            { 
                new Entidades.Pasajero()
                {
                    Pasaporte = new Entidades.Pasaporte("34AAA", "Anibal", "Heredia", new DateTime(1988, 9, 13)),
                    Edad = 34
                },
                new Entidades.Pasajero()
                {
                    Pasaporte = new Entidades.Pasaporte("32BBB", "Barbara", "Heredia", new DateTime(1990, 3, 9)),
                    Edad = 34
                }
            };
        }

        #endregion

        #region Metodos

        public static string EliminarPasajero(Entidades.Pasajero pasajero)
        {
            if (pasajero != null && !string.IsNullOrWhiteSpace(pasajero.PasaporteIdentificador))
            {
                Entidades.Pasajero aux = null;

                foreach (Entidades.Pasajero psj in Pasajeros.ListadoPasajeros)
                {
                    if (psj.PasaporteIdentificador == pasajero.PasaporteIdentificador)
                    {
                        aux = psj;
                        break;
                    }
                }

                if (aux != null)
                {
                    //puede eliminar
                    if (Pasajeros.ListadoPasajeros.Remove(aux))
                        return "Pasajero eliminado exitosamente.";
                }
            }

            return "No se ha seleccionado un pasajero para eliminar.";
        }

        public static string GuardarPasajero(Entidades.Pasajero pasajero)
        {
            string validacion = null;

            validacion = ValidarPasajero(pasajero);

            if (string.IsNullOrWhiteSpace(validacion))
            {
                Entidades.Pasajero aux = null;

                foreach (Entidades.Pasajero psj in Pasajeros.ListadoPasajeros)
                {
                    if (psj.PasaporteIdentificador == pasajero.PasaporteIdentificador)
                    {
                        aux = psj;
                        break;
                    }
                }

                if (aux != null)
                    Pasajeros.ListadoPasajeros.Remove(aux);

                Pasajeros.ListadoPasajeros.Add(pasajero);

                return "Pasajero guardado exitosamente!.";
            }

            return validacion;
        }

        public static bool PasajeroExistente(string pasaporteIdentificador)
        {
            if (!string.IsNullOrWhiteSpace(pasaporteIdentificador))
            {
                foreach (Entidades.Pasajero psj in Pasajeros.ListadoPasajeros)
                    if (psj.PasaporteIdentificador == pasaporteIdentificador)
                        return true;
            }

            return false;
        }

        private static string ValidarPasajero(Entidades.Pasajero pasajero)
        {
            if (pasajero != null)
            {
                string validacionPasaporte = null;

                validacionPasaporte = Pasaportes.ValidarPasaporte(pasajero.Pasaporte);

                if (!string.IsNullOrWhiteSpace(validacionPasaporte))
                    return validacionPasaporte;
                else
                {
                    if (pasajero.Edad == default)
                        return "Debe asignar la edad del pasajero.";
                }

                return null;
            }

            return "Debe crear un pasajero.";
        }

        #endregion
    }
}