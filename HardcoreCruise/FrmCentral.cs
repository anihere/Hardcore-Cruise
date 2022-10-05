using System;
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
    using Entidades;
    public partial class Central : Form
    {
        #region Atributos
        //ATRIBUTOS 2 listas
        List <Viaje> viajes;
        List <Cruzero> cruzero;
        #endregion
        #region Propiedades
        //PROPIEDADES
        public Central()
        {
            InitializeComponent();
            this.viajes = new List<Viaje>();
            this.cruzero = new List<Cruzero>();
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
            //this.viajes.Add(new Viaje("Miami")); 
            

            //this.viajes.Add(new Viaje("Buenos Aires", "Miami", DateTime.Now, 4000, 123, flota.Listadecruzero[1]));


            //ListBox1 los utilizo para mostrar en el listbox 1 y 2 los destinos en este form FrmCentral

            listBox1.DataSource = Enum.GetNames(typeof(Sudamericano));

            listBox2.DataSource = Enum.GetNames(typeof(Internacionales));

            foreach (Cruzero item in EmpresaCruzero.ListaDeCruzeros)
            {
               listBox3.Items.Add(item.nombre);
            }
            //Con estos metodos 

            this.CargarViajes();
            this.CargarLista();

            
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

        //Boton para Vender un viaje
        private void btn_ventaviaje(object sender, EventArgs e)
        {
            FrmVentadepasajes ventana = new FrmVentadepasajes();
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                Pasajero pasajeronuevo = ventana.PasajeroDelForm;
                //jhbviajes[0].Pasajeros.Add(pasajeronuevo);
                MessageBox.Show("pasaje vendido");
            }
            CargarViajes();
        }

        //Boton  para dar de alta un nuevo viaje
        private void btn_altaviaje(object sender, EventArgs e)
        {
            FrmAltadeviaje ventana = new FrmAltadeviaje();
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                Viaje viajenuevo = ventana.ViajeDelForm;
                viajes.Add(viajenuevo);
                MessageBox.Show("Viaje agregado");
            }
            CargarViajes();
        }
        

        //////////////////////////////////////////////////////////////////////////////////////METODOS//////////////////////////////////////////////////////////////////////////

        //Con este Metodo agrego en el ListBox4 los nuevos viajes que cargamos en el frmAltadeviaje
        private void CargarViajes()
        {
            listBox4.Items.Clear();
            foreach (Viaje item in viajes)
            {
                listBox4.Items.Add(item);
            }
        }
        //Con este Metodo muestro en el ListBox3 los nombres de los Cruzeros
        private void CargarLista()
        {
            listBox3.DataSource = null;
           // listBox3.DataSource = Listadecruzero;
        }

        #endregion

     
    }
}
            