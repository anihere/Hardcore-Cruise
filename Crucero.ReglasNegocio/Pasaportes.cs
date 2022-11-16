using System;
using System.Collections.Generic;
using System.Text;

namespace Crucero.ReglasNegocio
{
    public static class Pasaportes
    {
        #region Metodos

        public static string ValidarPasaporte(Entidades.Pasaporte pasaporte)
        {
            if (pasaporte != null)
            {
                if (string.IsNullOrWhiteSpace(pasaporte.Identificador))
                    return "Debe asignar el identificador del pasaporte.";

                if (string.IsNullOrWhiteSpace(pasaporte.Nombre))
                    return "Debe asignar el nombre del pasaporte.";

                if (string.IsNullOrWhiteSpace(pasaporte.Apellido))
                    return "Debe asignar el apellido del pasaporte.";

                if (pasaporte.FechaNacimiento == default)
                    return "Debe asignar la fecha de nacimiento del pasaporte.";

                return null;
            }

            return "Debe crear un pasaporte.";
        }

        #endregion
    }
}