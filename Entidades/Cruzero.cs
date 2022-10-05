using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Cruzero
    {

        #region Atributos
        //Atributos de las embarcaciones
        private string matricula;
        public string nombre;
        private int camarote4p;
        private int salones;
        private int casino;
        private float bodega;
        #endregion
        #region Constructores
        //Constructor
        public Cruzero(string matricula, string nombre, int camarote4p, int salones, int casino, float bodega)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.camarote4p = camarote4p;
            this.salones = salones;
            this.casino = casino;
            this.bodega = bodega;
        }
        #endregion
        #region Propiedades
        //PROPIEDADES
        public Cruzero()
        {
        }

        //Getter setter
        public string Matricula
        {
            get;
            set;
        }
        public string Nombre
        {
            get;
            set;
        }
        public int Camarotes
        {
            get;
            set;
        }

        #endregion
        #region Metodos
        //Metodo de instancia
        private string Mostrar()
        {
            StringBuilder Cruzero = new StringBuilder();
            Cruzero.AppendLine($"Matricula: {this.matricula}");
            Cruzero.AppendLine($"Nombre del Cruzero: {this.nombre}");
            Cruzero.AppendLine($"Cantidad de camarotes maximo 4 peronas: {this.camarote4p}");
            Cruzero.AppendLine($"Cantidad de salones: {this.salones}");
            Cruzero.AppendLine($"Cantidad de de casinos: {this.casino}");
            Cruzero.AppendLine($"Capacidad de la bodega en Kilogramos: {this.bodega}");
            return Cruzero.ToString();
        }
        //Metodo de clase
       // public static string Mostrar(Cruzero nacional)
        //{
         //   return nacional.Mostrar();
        //}
        #endregion
        #region Sobrecarga Operadores
        //Sobrecarga operadores
        /*public static bool operator ==(Cruzero nacional1, Cruzero nacional2)
        {
            bool confirmacion = false;
            if (nacional1 is null)
            {
                return nacional2 is null;
            }
            if (nacional2 is null)
            {
                return confirmacion;
            }
            return nacional1.matricula == nacional2.matricula;

        }
        public static bool operator !=(Cruzero nacional1, Cruzero nacional2)
        {
            return !(nacional1 == nacional2);
        }
        */
        public override string ToString()
        {
            //return this.Mostrar();
            return this.nombre;
        }
        
        #endregion

    }
}
