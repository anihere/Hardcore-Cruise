using System;
using System.Collections.Generic;
using System.Text;

namespace Crucero.Entidades
{
    public class Crucero
    {
        #region "Propiedades"

        public string Matricula { get; set; }

        public string Nombre { get; set; }

        public string MatriculaNombre
        {
            get
            {
                string matriculaNombre = null;

                if (!string.IsNullOrWhiteSpace(Matricula))
                    matriculaNombre = Matricula;

                if (!string.IsNullOrWhiteSpace(Nombre))
                {
                    if (!string.IsNullOrWhiteSpace(Matricula))
                        matriculaNombre = matriculaNombre + " - " + Nombre;
                    else
                        matriculaNombre = Nombre;
                }

                return matriculaNombre;
            }
        }

        public List<Camarote> ListadoCamarotes { get; set; }

        public int Salones { get; set; }

        public int Casinos { get; set; }

        public int CapacidadBodega { get; set; }

        public int CantidadCamarotes
        {
            get
            {
                if (ListadoCamarotes != null && ListadoCamarotes.Count > 0)
                    return ListadoCamarotes.Count;

                return 0;
            }
        }

        public int CantidadCamarotesTurista
        {
            get
            {
                int cantidad = 0;

                if (ListadoCamarotes != null && ListadoCamarotes.Count > 0)
                {
                    foreach (Camarote camarote in ListadoCamarotes)
                        if (camarote.CamaroteTipo == CamaroteTipo.Turista)
                            cantidad = cantidad + 1;
                }

                return cantidad;
            }
        }

        public int CantidadCamarotesPremium
        {
            get
            {
                int cantidad = 0;

                if (ListadoCamarotes != null && ListadoCamarotes.Count > 0)
                {
                    foreach (Camarote camarote in ListadoCamarotes)
                        if (camarote.CamaroteTipo == CamaroteTipo.Premium)
                            cantidad = cantidad + 1;
                }

                return cantidad;
            }
        }

        public List<CamaroteTipo> TipoCamarotes
        {
            get
            {
                List<CamaroteTipo> aux = new List<CamaroteTipo>();

                if (CantidadCamarotesTurista > 0)
                    aux.Add(CamaroteTipo.Turista);

                if (CantidadCamarotesPremium > 0)
                    aux.Add(CamaroteTipo.Premium);

                return aux;
            }
        }

        #endregion

        #region Constructores

        public Crucero() { }

        public Crucero(string matricula, string nombre, int salones, int casinos, int capacidadBodega, List<Camarote> listadoCamarotes)
        {
            Matricula = matricula;
            Nombre = nombre;
            Salones = salones;
            Casinos = casinos;
            CapacidadBodega = capacidadBodega;
            if (listadoCamarotes != null)
            {
                ListadoCamarotes = listadoCamarotes;
                foreach (Camarote camarote in ListadoCamarotes)
                    camarote.Crucero = this;
            }
            
        }

        #endregion
    }
}