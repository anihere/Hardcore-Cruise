using System.Collections.Generic;
using System.Windows.Forms;

using Crucero.Entidades;
using Crucero.ReglasNegocio;

namespace Crucero.WINFORMS
{
    public partial class FrmPasajero : Form
    {
        #region Atributos

        private Pasajero auxPasajero = null;

        #endregion

        #region Constructores

        public FrmPasajero(Pasajero pasajero)
        {
            InitializeComponent();

            auxPasajero = pasajero;

            if (auxPasajero == null)
            {
                auxPasajero = new Pasajero();
                auxPasajero.Pasaporte = new Pasaporte();
            }
            else
                MostrarPasajero(auxPasajero);
        }

        #endregion

        #region Metodos
        
        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            SetearPasajero();

            bool auxGuardar = true;

            if (Pasajeros.PasajeroExistente(auxPasajero.PasaporteIdentificador))
            {
                DialogResult dialogResult = MessageBox.Show(this, "Número de pasaporte existente, ¿desea reemplazar los datos?. ", "Modificación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                    auxGuardar = false;
            }

            if (auxGuardar)
            {
                string resultado = Pasajeros.GuardarPasajero(auxPasajero);

                MostrarPasajero(auxPasajero);

                MessageBox.Show(this, resultado);
            }
        }

        private void MostrarPasajero(Pasajero pasajero)
        {
            if (pasajero != null)
            {
                nudEdad.Value = auxPasajero.Edad;

                if (pasajero.Pasaporte != null)
                {
                    txtPasaporte.Text = pasajero.Pasaporte.Identificador;
                    txtNombre.Text = pasajero.Pasaporte.Nombre;
                    txtApellido.Text = pasajero.Pasaporte.Apellido;
                    dtpFechaNacimiento.Value = pasajero.Pasaporte.FechaNacimiento;
                }                
            }
        }

        private void SetearPasajero()
        {
            auxPasajero.Pasaporte.Identificador = txtPasaporte.Text;
            auxPasajero.Pasaporte.Nombre = txtNombre.Text;
            auxPasajero.Pasaporte.Apellido = txtApellido.Text;
            auxPasajero.Pasaporte.FechaNacimiento = dtpFechaNacimiento.Value;
            auxPasajero.Edad = (int)nudEdad.Value;
        }
        
        #endregion
    }
}
