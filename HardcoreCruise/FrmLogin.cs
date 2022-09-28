using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace HardcoreCruise
{
    public partial class FrmLogin : Form
    {
        Central ventana = new Central();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            lb_mensajeError.Visible = false;
            lb_mensajeError.Text = "ERROR, REINGRESE DATOS";
            
            
        }
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
        private static bool ValidarDatosIngresados(string usuario, string pass)
        {
            return Validador.ValidarTexto(usuario) && Validador.ValidarTexto(pass);
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
