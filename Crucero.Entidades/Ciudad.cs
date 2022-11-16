using System;
using System.Collections.Generic;
using System.Text;

namespace Crucero.Entidades
{
    public class Ciudad
    {
        #region "Propiedades"

        public Pais Pais { get; set; }

        public string Nombre { get; set; }

        public string PaisNombre
        {
            get
            {
                if (Pais != null)
                    return Pais.Nombre;

                return null;
            }
        }

        public string PaisTipo
        {
            get
            {
                if (Pais != null)
                {
                    if (Pais.PaisTipo == Entidades.PaisTipo.Regional)
                        return "Regional";

                    if (Pais.PaisTipo == Entidades.PaisTipo.ExtraRegional)
                        return "Extra Regional";
                }

                return null;
            }
        }

        public string CiudadPais
        {
            get
            {
                return Nombre + " - " + PaisNombre;
            }
        }

        #endregion

        #region Constructores

        public Ciudad() { }

        public Ciudad(string nombre, Pais pais)
        {
            Nombre = nombre;
            Pais = pais;
        }

        #endregion
    }
}