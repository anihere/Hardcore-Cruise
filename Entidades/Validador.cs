using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Validador
    {

        public static bool ValidarTexto(string dato)
        {
            return !string.IsNullOrEmpty(dato);

        }
    }
}
