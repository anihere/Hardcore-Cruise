using System;
using System.Collections.Generic;
using System.Text;

namespace Crucero.Entidades
{
    public enum PaisTipo
    {
        Regional = 0,
        ExtraRegional = 1
    }

    public class Pais
    {
        #region "Propiedades"

        public PaisTipo PaisTipo { get; set; }

        public string Nombre { get; set; }

        #endregion

        #region Constructores

        public Pais() { }

        public Pais(string nombre, PaisTipo paisTipo)
        {
            Nombre = nombre;
            PaisTipo = paisTipo;
        }

        #endregion
    }
}