using System;
using System.Collections.Generic;
using System.Text;

using Crucero.Entidades;

namespace Crucero.ReglasNegocio
{
    public static class Usuarios
    {
        #region Propiedades

        public static List<Usuario> ListadoUsuarios { get; }

        public static Usuario LoginUsuario { get; private set; }

        #endregion

        #region Constructores

        static Usuarios()
        {
            ListadoUsuarios = new List<Usuario>();

            ListadoUsuarios.Add(new Usuario("Anibal", "123"));
            ListadoUsuarios.Add(new Usuario("Barbara", "123"));
            ListadoUsuarios.Add(new Usuario("Victoria", "123"));
            ListadoUsuarios.Add(new Usuario("Ulises", "123"));
        }

        #endregion

        #region Metodos

        public static bool Login(string usuario, string clave)
        {
            if (!string.IsNullOrWhiteSpace(usuario) && !string.IsNullOrWhiteSpace(clave))
            {
                foreach (Usuario usu in ListadoUsuarios)
                {
                    if (usu.UsuarioNombre == usuario && usu.Clave == clave)
                    {
                        LoginUsuario = usu;
                        LoginUsuario.FechaHoraLogin = DateTime.Now;

                        return true;
                    }
                }
            }

            return false;
        }

        #endregion
    }
}