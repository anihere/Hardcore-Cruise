using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HardcoreCruise
{
    public partial class FrmVentadepasajes : Form
    {

        #region Atributos
        Pasajero pasajeroDelForm;
        private int n = 0;
        #endregion
        #region Propiedades
        //Propiedades
        public Pasajero PasajeroDelForm
        {
            get
            {
                return this.pasajeroDelForm;
            }
        }
        #endregion
        #region Metodos
        public FrmVentadepasajes()
        {
            InitializeComponent();
        }


        /// <summary>
        /// ////////////////////////////////////////////////////////////////BOTONES///////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        private void button2_Click(object sender, EventArgs e)
        {
            
            //pasajeroDelForm = new Pasajero(txtnombre.Text, txtapellido.Text, int.Parse(txtdni.Text), int.Parse(txt_Equipaje.Text));

            // EmpresaCruzero.ListaDePasajeros.Add(pasajeroDelForm);

            this.DialogResult = DialogResult.OK;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
          //Adiciono renglon
            n = dtgvPasajeros.Rows.Add();
          //colocamos la informacion
            dtgvPasajeros.Rows[n].Cells[0].Value = txtnombre.Text;
            dtgvPasajeros.Rows[n].Cells[1].Value = txtapellido.Text;
            dtgvPasajeros.Rows[n].Cells[2].Value = txtdni.Text;
            dtgvPasajeros.Rows[n].Cells[3].Value = txt_Equipaje.Text;

            string aux1 = txtnombre.Text;
            String aux2 = txtapellido.Text;
            int aux3 = int.Parse(txtdni.Text);
            int aux4 = int.Parse(txt_Equipaje.Text);

            //LLenamos la lista
            pasajeroDelForm = new Pasajero(aux1, aux2, aux3, aux4);

            EmpresaCruzero.ListaDePasajeros.Add(pasajeroDelForm);
            listBox1.Items.Clear();
            foreach (Pasajero item in EmpresaCruzero.ListaDePasajeros)
            {
                listBox1.Items.Add(item.ToString());
            }
            //Limpiamos los textbox
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtdni.Text = "";
            txt_Equipaje.Text = "";
        }
        
        
        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////TEXTBOX////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string ciudadedest = textBox2.Text;
        }

        #endregion

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (n!=-1)
            {
                dtgvPasajeros.Rows.RemoveAt(n);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Turista")
                textBox7.Text = "2000";
            else
                textBox7.Text = "5000";

            Random Rnd = new Random();

            if (textBox2.Text == "La Habana" | textBox2.Text == "Venecia" | textBox2.Text == "Acapulco" | textBox2.Text == "Miami" | textBox2.Text == "Nueva York" | textBox2.Text == "Bangkok" | textBox2.Text == "Taipei" | textBox2.Text == "Atenas")
            {
                int numero = Rnd.Next(480, 720);
                textBox10.Text = numero.ToString();
            }
            if (textBox2.Text == "Montevideo" | textBox2.Text == "Ushuaia" | textBox2.Text == "Recife" | textBox2.Text == "Santiago" | textBox2.Text == "Lima" | textBox2.Text == "Isla de Pascua" | textBox2.Text == "Isla Galapagos" | textBox2.Text == "Puerto Madryn"| textBox2.Text=="Rio de Janeiro"| textBox2.Text=="Cartagena")
            {
                int numero = Rnd.Next(72, 380);
                textBox10.Text = numero.ToString();
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
