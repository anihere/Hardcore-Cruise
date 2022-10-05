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
    public partial class FrmAltadeviaje : Form
    {
        #region Atributos
        Viaje viajeDelForm;
         #endregion
        #region Propiedades
        public Viaje ViajeDelForm
        {
            get
            {
                return this.viajeDelForm;
            }
        }
        #endregion
        #region Metodos
        public FrmAltadeviaje()
        {
            InitializeComponent();

        }
        /// <summary>
        /// //////////////////////////////////////////////////////////////////BOTONES////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
       
        private void button1_Click(object sender, EventArgs e)
        {
            viajeDelForm = new Viaje(textBox2.Text, textBox2.Text, dateTimePicker1.Value, int.Parse(textBox4.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));

            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        #endregion

       
    }
}
