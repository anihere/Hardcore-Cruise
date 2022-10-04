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

        private void FrmVentadepasajes_Load(object sender, EventArgs e)
        {
            string aux = comboBox1.ToString();
            if (aux == " TURISTA")
             textBox7.Text = "3000";
             if (aux == "PREMIUM")
             textBox7.Text = "2000";
            
        }
    }
}
