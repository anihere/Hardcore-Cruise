using System;
using System.Collections.Generic;
using System.Text;

using Crucero.Entidades;

namespace Crucero.ReglasNegocio
{
    public static class Ciudades
    {
        #region Propiedades

        public static List<Ciudad> ListadoCiudades { get; }

        #endregion

        #region Constructores

        static Ciudades()
        {
            ListadoCiudades = new List<Ciudad>();

            ListadoCiudades.Add(new Ciudad("Montevideo", Paises.PaisPorNombre("Uruguay")));
            ListadoCiudades.Add(new Ciudad("Ushuaia", Paises.PaisPorNombre("Argentina")));
            ListadoCiudades.Add(new Ciudad("Recife", Paises.PaisPorNombre("Brasil")));
            ListadoCiudades.Add(new Ciudad("Santiago", Paises.PaisPorNombre("Chile")));
            ListadoCiudades.Add(new Ciudad("Lima", Paises.PaisPorNombre("Perú")));
            ListadoCiudades.Add(new Ciudad("Isla de Pascua", Paises.PaisPorNombre("Chile")));
            ListadoCiudades.Add(new Ciudad("Isla Galápagos", Paises.PaisPorNombre("Ecuador")));
            ListadoCiudades.Add(new Ciudad("Puerto Madryn", Paises.PaisPorNombre("Argentina")));
            ListadoCiudades.Add(new Ciudad("Río de Janeiro", Paises.PaisPorNombre("Brasil")));
            ListadoCiudades.Add(new Ciudad("Cartagena", Paises.PaisPorNombre("Colombia")));

            ListadoCiudades.Add(new Ciudad("La Habana", Paises.PaisPorNombre("Cuba")));
            ListadoCiudades.Add(new Ciudad("Venecia", Paises.PaisPorNombre("Italia")));
            ListadoCiudades.Add(new Ciudad("Acapulco", Paises.PaisPorNombre("México")));
            ListadoCiudades.Add(new Ciudad("Miami", Paises.PaisPorNombre("EE.UU.")));
            ListadoCiudades.Add(new Ciudad("Nueva York", Paises.PaisPorNombre("EE.UU.")));
            ListadoCiudades.Add(new Ciudad("Bangkok", Paises.PaisPorNombre("Tailandia")));
            ListadoCiudades.Add(new Ciudad("Taipei", Paises.PaisPorNombre("Taiwán")));
            ListadoCiudades.Add(new Ciudad("Atenas", Paises.PaisPorNombre("Grecia")));
        }

        #endregion

        #region Metodos

        public static Pais Pais(string nombre)
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
