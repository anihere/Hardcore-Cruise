using System;
using System.Collections.Generic;
using System.Text;

using Crucero.Entidades;

namespace Crucero.ReglasNegocio
{
    public static class Paises
    {
        #region Propiedades

        public static List<Pais> ListadoPaises { get; }

        #endregion

        #region Constructores

        static Paises()
        {
            ListadoPaises = new List<Pais>();

            ListadoPaises.Add(new Pais("Argentina", PaisTipo.Regional));
            ListadoPaises.Add(new Pais("Uruguay", PaisTipo.Regional));
            ListadoPaises.Add(new Pais("Brasil", PaisTipo.Regional));
            ListadoPaises.Add(new Pais("Chile", PaisTipo.Regional));
            ListadoPaises.Add(new Pais("Perú", PaisTipo.Regional));
            ListadoPaises.Add(new Pais("Ecuador", PaisTipo.Regional));
            ListadoPaises.Add(new Pais("Colombia", PaisTipo.Regional));

            ListadoPaises.Add(new Pais("Cuba", PaisTipo.ExtraRegional));
            ListadoPaises.Add(new Pais("Italia", PaisTipo.ExtraRegional));
            ListadoPaises.Add(new Pais("México", PaisTipo.ExtraRegional));
            ListadoPaises.Add(new Pais("EE.UU.", PaisTipo.ExtraRegional));
            ListadoPaises.Add(new Pais("Tailandia", PaisTipo.ExtraRegional));
            ListadoPaises.Add(new Pais("Taiwán", PaisTipo.ExtraRegional));
            ListadoPaises.Add(new Pais("Grecia", PaisTipo.ExtraRegional));
        }

        #endregion

        #region Metodos

        public static Pais PaisPorNombre(string nombre)
        {
            if (!string.IsNullOrWhiteSpace(nombre))
            {
                foreach (Pais pais in Paises.ListadoPaises)
                {
                    if (pais.Nombre == nombre)
                        return pais;
                }
            }

            return null;
        }

        #endregion
    }
}
