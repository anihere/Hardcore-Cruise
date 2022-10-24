using System;
using System.Windows.Forms;

using Crucero.ReglasNegocio;

namespace Crucero.WINFORMS
{
    public partial class FrmLogin : Form
    {
        #region Constructores

        public FrmLogin()
        {
            InitializeComponent();
        }

        #endregion

        #region Metodos

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (Usuarios.Login(txtUsuario.Text, txtClave.Text))
            {
                FrmCentral central = new FrmCentral();

                central.Text = central.Text + " - " + Usuarios.LoginUsuario.UsuarioNombre + " (" + Usuarios.LoginUsuario.FechaHoraLogin.ToString() + ")";

                central.Show();

                central.FormClosed += (s, e) => { Close(); };

                Hide();
            }
            else
                lblError.Visible = true;
        }

        #endregion
    }
}
