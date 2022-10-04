﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace HardcoreCruise
{
    public partial class Central : Form
    {
        #region Atributos
        //ATRIBUTOS 2 listas: Flota para acceder a la
        Flota flota;
        List<Viaje> viajes;
        #endregion
        #region Propiedades
        //PROPIEDADES
        public Central()

        {
            InitializeComponent();
            this.flota = new Flota();
            this.viajes = new List<Viaje>();
        }
        #endregion
        #region metodos

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Central_Load(object sender, EventArgs e)
        {
            //ListBox1 los utilizo para mostrar en el listbox 1 y 2 los destinos en este form FrmCentral

            listBox1.DataSource = Enum.GetNames(typeof(ESudamericano));

            listBox2.DataSource = Enum.GetNames(typeof(EInternacionales));

         //  listBox3.DataSource = Enum.GetNames(typeof(EListadecuzeros));
         //   listBox3.Items.Add(EmpresaCruzero.ListaDeCruzeros.ToString());

          //  listBox4.Items.Add(EmpresaCruzero.ListaDeViaje);

            this.CargarViajes();
            this.CargarLista();
           // EmpresaCruzero.


        }

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////BOTONES/////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 
        ///
        //Boton de Cerrar del FrmCentral
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarLista()
        {
            listBox3.DataSource = null;
            listBox3.DataSource = flota.Listadecruzero;
        }
        //Boton para Vender un viaje
        private void btn_ventaviaje(object sender, EventArgs e)
        {
            FrmVentadepasajes ventana = new FrmVentadepasajes();
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                Pasajero pasajeronuevo = ventana.PasajeroDelForm;
                viajes[0].Pasajeros.Add(pasajeronuevo);
                MessageBox.Show("pasaje vendido");
            }
           CargarViajes();
        }

        //Boton  para dar de alta un nuevo viaje
        private void btn_altaviaje(object sender, EventArgs e)
        {
            FrmAltadeviaje ventana = new FrmAltadeviaje(flota);
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                Viaje viajenuevo = ventana.ViajeDelForm;
                viajes.Add(viajenuevo);
                MessageBox.Show("Viaje agregado");
            }
            CargarViajes();
        }

        private void CargarViajes()
        {
            listBox4.Items.Clear();
            foreach (Viaje item in viajes)
            {
                listBox4.Items.Add(item);
            }
        }




        #endregion

       
    }
}
            