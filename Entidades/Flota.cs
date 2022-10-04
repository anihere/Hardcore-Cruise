using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Flota
    {
        #region Atributos
        public List<Cruzero> Listadecruzero;
        #endregion
        #region Constructores
        public Flota()
        {
            
            //Creo la lista de cruzero la inicializo con los Cruzeros. Para mostrarlos en los ListBox de la clase FrmCentral.
            Listadecruzero = new List<Cruzero>();
            
            Listadecruzero.Add(new Cruzero("ADJ134", "Hardcore", 50, 3, 1, 500));
            Listadecruzero.Add(new Cruzero("NJV768", "Royal Pride", 40, 2, 1, 500));
            Listadecruzero.Add(new Cruzero("INJ890", "Transatlantico del Sur", 30, 2, 1, 500));
            Listadecruzero.Add(new Cruzero("LNX213", "Costero", 30, 3, 2, 500));
            Listadecruzero.Add(new Cruzero("ADJ134", "Fenix USA", 50, 3, 1, 500));
            Listadecruzero.Add(new Cruzero("FNQ879", "Sol del oceano", 50, 3, 1, 500));
            Listadecruzero.Add(new Cruzero("FYN319", "MSC", 50, 3, 1, 500));


        }
        #endregion
        #region Sobrecarga Operadores 

       /* //Sobrecarga de operadores
        public static bool operator ==(Flota p1,Flota p2)
        {
            return (p1== p2);
        }

        public static bool operator !=(Flota p1, Flota p2)
        {
            return !(p1 == p2);

        }
       */
        #endregion
       
    }
}
