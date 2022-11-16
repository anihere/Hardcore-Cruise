using System;
using System.Collections.Generic;
using System.Text;

namespace Crucero.Entidades
{
    public enum CamaroteTipo
    {
        Turista = 0,
        Premium = 1
    }

    public class Camarote
    {
        #region "Propiedades"

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

        public CamaroteTipo CamaroteTipo { get; set; }

        public string Identificador { get; set; }

        public int Capacidad { get; set; }

        #endregion

        #region Constructores

        public Camarote() { }

        public Camarote(string identificador, int capacidad, CamaroteTipo camaroteTipo)
        {
            Identificador = identificador;
            Capacidad = capacidad;
            CamaroteTipo = camaroteTipo;
        }

        #endregion
    }
}