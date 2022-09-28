using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Vendedores
    {
        private string usuario;
        private string pass;
        static List<Vendedores> empleados;


        //constructor
        public Vendedores(string pass, string usuario)
        {
            this.usuario = usuario;
            this.pass = pass;
        }
        //geterr
        public string Usuario
        {
            get { return usuario; }
        }

        public bool CheckearPassword(string pass)
        {
            return pass == this.pass;
        }

        static Vendedores()
        {
            empleados = new List<Vendedores>();
            HardcodearEmpleados();
        }

        private static void HardcodearEmpleados()
        {
            empleados.Add(new Vendedores("Barby", "asd132"));
            empleados.Add(new Vendedores("Romero", "gatuso132"));
            empleados.Add(new Vendedores("Gimena", "la8"));
            empleados.Add(new Vendedores("Maria", "do90"));
        }


        public static bool LoguearEmpleado(string usuario, string pass)
        {
            bool resultado = false;
            foreach (Vendedores auxEmpleado in empleados)
            {
                if (auxEmpleado.usuario == usuario)
                {
                    resultado = auxEmpleado.CheckearPassword(pass);
                }
            }
            return resultado;
        }


    }


}

