using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Destinos
    {   
        //atributos
        static List<Cruzero> Cruize;
        static List<Internacionales> destinoInter;
        static List<Sudamericano> destinoSudame;

        //constructores
         public Destinos()
        {
            destinoInter = new List<Internacionales>();
            destinoSudame = new List<Sudamericano>();
                      
        }
           

    }
}
