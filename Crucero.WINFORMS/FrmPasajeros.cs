using System.Windows.Forms;

using Crucero.ReglasNegocio;

namespace Crucero.WINFORMS
{
    public partial class FrmPasajeros : Form
    {
        #region Atributos

        private bool frmPasajeroAbierto;

        #endregion

        #region Constructores

        public FrmPasajeros()
        {
            InitializeComponent();

            dtgPasajeros.AutoGenerateColumns = false;
        }

        #endregion

        #region Metodos

        private void btnActualizar_Click(object sender, System.EventArgs e)
        {
            ActualizarListado();
        }

        private void btnCrear_Click(object sender, System.EventArgs e)
        {
            if (!frmPasajeroAbierto)
            {
                frmPasajeroAbierto = true;

                FrmPasajero frmPasajero = new FrmPasajero(null);

                frmPasajero.MdiParent = this.MdiParent;

                frmPasajero.FormClosed += (s, e) =>
                {
                    frmPasajeroAbierto = false;
                    ActualizarListado();
                };

                frmPasajero.Show();
            }
        }

        private void btnModificar_Click(object sender, System.EventArgs e)
        {
            if (!frmPasajeroAbierto)
            {
                if (dtgPasajeros.CurrentRow != null && dtgPasajeros.CurrentRow.DataBoundItem is Entidades.Pasajero pasajero)
                {
                    frmPasajeroAbierto = true;

                    FrmPasajero frmPasajero = new FrmPasajero(pasajero);

                    frmPasajero.MdiParent = this.MdiParent;

                    frmPasajero.FormClosed += (s, e) =>
                    {
                        frmPasajeroAbierto = false;
                        ActualizarListado();
                    };

                    frmPasajero.Show();
                }
            }
        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            if (dtgPasajeros.CurrentRow != null && dtgPasajeros.CurrentRow.DataBoundItem is Entidades.Pasajero pasajero)
            {
                DialogResult dialogResult = MessageBox.Show(this, "Esta seguro que desea eliminar el pasajero con pasaporte " + pasajero.PasaporteIdentificador, "Eliminar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string resultado = Pasajeros.EliminarPasajero(pasajero);

                    MessageBox.Show(this, resultado);

                    ActualizarListado();
                }
                
            }
        }

        private void ActualizarListado()
        {
            dtgPasajeros.DataSource = null;
            dtgPasajeros.DataSource = Pasajeros.ListadoPasajeros;
        }

        #endregion
    }
}
