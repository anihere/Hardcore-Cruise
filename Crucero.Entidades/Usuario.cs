using System;
using System.Collections.Generic;
using System.Text;

namespace Crucero.Entidades
{
    public class Usuario
    {
        #region Propiedades

        public string UsuarioNombre { get; set; }

        public string Clave { get; set; }

        public DateTime FechaHoraLogin { get; set; }

        #endregion

        #region Constructores

        public Usuario() { }

        public Usuario(string usuarioNombre, string clave) 
        {
            UsuarioNombre = usuarioNombre;
            Clave = clave;
        }

        #endregion
    }
}