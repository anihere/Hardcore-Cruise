using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Entidades;

namespace HardcoreCruise
{
    public partial class FrmLogin : Form
    {
        #region Atributos
        Central ventana = new Central();
        #endregion
        #region Metodos
        public FrmLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] 
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            lb_mensajeError.Visible = false;
            lb_mensajeError.Text = "ERROR, REINGRESE DATOS";     
        }
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////BOTONES//////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            string usuario = this.txt_usuario.Text;
            string pass = this.txt_password.Text;
            ventana.Show();

            if (ValidarDatosIngresados(usuario, pass) == true)
            {
                if (Vendedores.LoguearEmpleado(usuario, pass) == true)
                {
                    ventana.Show();
                    Hide();
                    lb_mensajeError.Visible = false;                 
                }
            }
            else
            {
                lb_mensajeError.Text = "ERROR, REINGRESE DATOS";
                lb_mensajeError.Visible = true;
            }
        }

        private void btn_Aceptar_Click_1(object sender, EventArgs e)
        {
            string usuario = this.txt_usuario.Text;
            string pass = this.txt_password.Text;
            Central ventana = new Central();
            ventana.Show();
            if (ValidarDatosIngresados(usuario, pass))
            {
                if (Vendedores.LoguearEmpleado(usuario, pass))
                {
                    ventana.Show();
                    Hide();
                    lb_mensajeError.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("USUARIO NO VALIDO");
                lb_mensajeError.Text = "ERROR, REINGRESE DATOS";
                lb_mensajeError.Visible = true;
            }
        }
        /// <summary>
        /// ////////////////////////////////////////////////////////////////////OTROS EVENTOS/////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
         /// <returns></returns>
        private static bool ValidarDatosIngresados(string usuario, string pass)
        {
            return Validador.ValidarTexto(usuario) && Validador.ValidarTexto(pass);
        }   
       private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_usuario_Enter(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "USUARIO")
            {
                txt_usuario.Text = "";
                txt_usuario.ForeColor = Color.DimGray;

            }
        }

        private void txt_usuario_Leave(object sender, EventArgs e)
        {
            if(txt_usuario.Text=="")
            {
                txt_usuario.ForeColor = Color.DimGray;
            }
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "PASSWORD")
            {
                txt_password.Text = "";
                txt_password.ForeColor = Color.DimGray;
                txt_password.UseSystemPasswordChar = true;

            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
            
                txt_password.ForeColor = Color.DimGray;
                txt_password.UseSystemPasswordChar = false;
            }
        }

       
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////Controlador Cerrar y minimizar de la Ventana/////////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion


    }
}
