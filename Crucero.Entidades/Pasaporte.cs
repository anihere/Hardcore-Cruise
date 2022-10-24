using System;
using System.Collections.Generic;
using System.Text;

namespace Crucero.Entidades
{
    public class Pasaporte
    {
        #region "Propiedades"

        public string Identificador { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }

        #endregion

        #region Constructores

        public Pasaporte() { }

        public Pasaporte(string identificador, string nombre, string apellido, DateTime fechaNacimiento)
        {
            Identificador = identificador;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
        }

        #endregion
    }
}