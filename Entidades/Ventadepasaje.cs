using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Ventadepasaje
    {
      /* public static List<Cruzero> Cruzero1;
       public static List<Cruzero> Cruzero2;
       public static List<Cruzero> Cruzero3;
       public static List<Cruzero> Cruzero4;
       public static List<Cruzero> Cruzero5;
       public static List<Cruzero> Cruzero6;
       public static List<Cruzero> Cruzero7;
       public static List<Infopasajero>  pasajero;*/
        public List<Cruzero> Listadecruzero;
        public Ventadepasaje()
        {
            Listadecruzero = new List<Cruzero>();

           /* Cruzero1.Add(new Cruzero("ADJ134", "Hardcore", 50, 3, 1, 500));
            Cruzero2.Add(new Cruzero("NJV768", "Royal Pride", 40, 2, 1, 500));
            Cruzero3.Add(new Cruzero("INJ890", "Transatlantico del Sur", 30, 2, 1, 500));
            Cruzero4.Add(new Cruzero("LNX213", "Costero", 30, 3, 2, 500));
            Cruzero5.Add(new Cruzero("ADJ134", "Fenix USA", 50, 3, 1, 500));
            Cruzero6.Add(new Cruzero("FNQ879", "Sol del oceano", 50, 3, 1, 500));
            Cruzero7.Add(new Cruzero("FYN319", "MSC", 50, 3, 1, 500));
           */
            Listadecruzero.Add(new Cruzero("ADJ134", "Hardcore", 50, 3, 1, 500));
            Listadecruzero.Add(new Cruzero("NJV768", "Royal Pride", 40, 2, 1, 500));
            Listadecruzero.Add(new Cruzero("INJ890", "Transatlantico del Sur", 30, 2, 1, 500));
            Listadecruzero.Add(new Cruzero("LNX213", "Costero", 30, 3, 2, 500));
            Listadecruzero.Add(new Cruzero("ADJ134", "Fenix USA", 50, 3, 1, 500));
            Listadecruzero.Add(new Cruzero("FNQ879", "Sol del oceano", 50, 3, 1, 500));
            Listadecruzero.Add(new Cruzero("FYN319", "MSC", 50, 3, 1, 500));
            

        }
        //Constuctores
        /*public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        //Propiedades
        public string Nombre
        { get { return this.nombre; } }
        public string Raza { get { return this.raza; } }
        */
        //Metodos
        
        

        //Sobrecarga de operadores
        /*public static bool operator ==(Ventadepasaje p1,Ventadepasaje p2)
        {
            return (p1== p2);
        }

        public static bool operator !=(Ventadepasaje p1, Ventadepasaje p2)
        {
            return !(p1 == p2);

        }*/


    }
}
