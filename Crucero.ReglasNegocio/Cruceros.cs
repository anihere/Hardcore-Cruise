using System;
using System.Collections.Generic;
using System.Text;

using Crucero.Entidades;

namespace Crucero.ReglasNegocio
{
    public static class Cruceros
    {
        #region Propiedades

        public static List<Entidades.Crucero> ListadoCruceros { get; }

        #endregion

        #region Constructores

        static Cruceros()
        {
            ListadoCruceros = new List<Entidades.Crucero>();

            ListadoCruceros.Add(new Entidades.Crucero("C1", "Hércules", 3, 1, 1500, new List<Camarote>() 
            { 
                new Camarote("T1", 4, CamaroteTipo.Turista),
                new Camarote("T2", 4, CamaroteTipo.Turista),
                new Camarote("T3", 4, CamaroteTipo.Turista),
                new Camarote("T4", 4, CamaroteTipo.Turista),
                new Camarote("T5", 4, CamaroteTipo.Turista),
                new Camarote("P1", 4, CamaroteTipo.Premium),
                new Camarote("P2", 4, CamaroteTipo.Premium),
                new Camarote("P3", 4, CamaroteTipo.Premium)
            }));

            ListadoCruceros.Add(new Entidades.Crucero("C2", "Aquíles", 4, 2, 3000, new List<Camarote>()
            {
                new Camarote("T1", 4, CamaroteTipo.Turista),
                new Camarote("T2", 4, CamaroteTipo.Turista),
                new Camarote("T3", 4, CamaroteTipo.Turista),
                new Camarote("T4", 4, CamaroteTipo.Turista),
                new Camarote("T5", 4, CamaroteTipo.Turista),
                new Camarote("T6", 4, CamaroteTipo.Turista),
                new Camarote("T7", 4, CamaroteTipo.Turista),
                new Camarote("T8", 4, CamaroteTipo.Turista),
                new Camarote("P1", 4, CamaroteTipo.Premium),
                new Camarote("P2", 4, CamaroteTipo.Premium),
                new Camarote("P3", 4, CamaroteTipo.Premium),
                new Camarote("P4", 4, CamaroteTipo.Premium),
                new Camarote("P5", 4, CamaroteTipo.Premium)
            }));

            ListadoCruceros.Add(new Entidades.Crucero("C3", "Hector", 1, 0, 500, new List<Camarote>()
            {
                new Camarote("T1", 4, CamaroteTipo.Turista),
                new Camarote("T2", 4, CamaroteTipo.Turista),
                new Camarote("T3", 4, CamaroteTipo.Turista),
                new Camarote("P1", 4, CamaroteTipo.Premium),
                new Camarote("P2", 4, CamaroteTipo.Premium)
            }));

            ListadoCruceros.Add(new Entidades.Crucero("C4", "Paris", 1, 2, 1000, new List<Camarote>()
            {
                new Camarote("T1", 4, CamaroteTipo.Turista),
                new Camarote("T2", 4, CamaroteTipo.Turista),
                new Camarote("T3", 4, CamaroteTipo.Turista),
                new Camarote("T4", 4, CamaroteTipo.Turista),
                new Camarote("P1", 4, CamaroteTipo.Premium),
                new Camarote("P2", 4, CamaroteTipo.Premium)
            }));

            ListadoCruceros.Add(new Entidades.Crucero("C5", "Helena", 1, 1, 1200, new List<Camarote>()
            {
                new Camarote("T1", 4, CamaroteTipo.Turista),
                new Camarote("T2", 4, CamaroteTipo.Turista),
                new Camarote("T3", 4, CamaroteTipo.Turista),
                new Camarote("T4", 4, CamaroteTipo.Turista),
                new Camarote("P1", 4, CamaroteTipo.Premium),
                new Camarote("P2", 4, CamaroteTipo.Premium),
                new Camarote("P3", 4, CamaroteTipo.Premium),
                new Camarote("P4", 4, CamaroteTipo.Premium)
            }));

            ListadoCruceros.Add(new Entidades.Crucero("C6", "Agamenón", 3, 3, 1800, new List<Camarote>()
            {
                new Camarote("T1", 4, CamaroteTipo.Turista),
                new Camarote("T2", 4, CamaroteTipo.Turista),
                new Camarote("T3", 4, CamaroteTipo.Turista),
                new Camarote("T4", 4, CamaroteTipo.Turista),
                new Camarote("T5", 4, CamaroteTipo.Turista),
                new Camarote("T6", 4, CamaroteTipo.Turista),
                new Camarote("T7", 4, CamaroteTipo.Turista),
                new Camarote("T8", 4, CamaroteTipo.Turista),
                new Camarote("P1", 4, CamaroteTipo.Premium),
                new Camarote("P2", 4, CamaroteTipo.Premium),
                new Camarote("P3", 4, CamaroteTipo.Premium),
                new Camarote("P4", 4, CamaroteTipo.Premium)
            }));

            ListadoCruceros.Add(new Entidades.Crucero("C7", "Menelao", 1, 1, 1000, new List<Camarote>()
            {
                new Camarote("T1", 4, CamaroteTipo.Turista),
                new Camarote("T2", 4, CamaroteTipo.Turista),
                new Camarote("T3", 4, CamaroteTipo.Turista),
                new Camarote("T4", 4, CamaroteTipo.Turista),
                new Camarote("T5", 4, CamaroteTipo.Turista),
                new Camarote("T6", 4, CamaroteTipo.Turista),
                new Camarote("T7", 4, CamaroteTipo.Turista),
                new Camarote("T8", 4, CamaroteTipo.Turista),
                new Camarote("P1", 4, CamaroteTipo.Premium)
            }));
        }

        #endregion

        #region Metodos

        #endregion
    }
}
