using System.Windows.Forms;

using Crucero.ReglasNegocio;

namespace Crucero.WINFORMS
{
    public partial class FrmViajes : Form
    {
        #region Atributos

        private bool frmViajeAbierto;

        #endregion

        #region Constructores

        public FrmViajes()
        {
            InitializeComponent();

            dtgViajes.AutoGenerateColumns = false;

            dtgViajes.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgViajes.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgViajes.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgViajes.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgViajes.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgViajes.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgViajes.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        #endregion

        #region Metodos

        private void btnActualizar_Click(object sender, System.EventArgs e)
        {
            ActualizarListado();
        }

        private void btnCrear_Click(object sender, System.EventArgs e)
        {
            if (!frmViajeAbierto)
            {
                frmViajeAbierto = true;

                FrmViaje frmViaje = new FrmViaje(null);

                frmViaje.MdiParent = this.MdiParent;

                frmViaje.FormClosed += (s, e) =>
                {
                    frmViajeAbierto = false;
                    ActualizarListado();
                };

                frmViaje.Show();
            }
        }

        private void btnModificar_Click(object sender, System.EventArgs e)
        {
            if (!frmViajeAbierto)
            {
                if (dtgViajes.CurrentRow != null && dtgViajes.CurrentRow.DataBoundItem is Entidades.Viaje viaje)
                {
                    frmViajeAbierto = true;

                    FrmViaje frmViaje = new FrmViaje(viaje);

                    frmViaje.MdiParent = this.MdiParent;

                    frmViaje.FormClosed += (s, e) =>
                    {
                        frmViajeAbierto = false;
                        ActualizarListado();
                    };

                    frmViaje.Show();
                }
            }
        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            if (dtgViajes.CurrentRow != null && dtgViajes.CurrentRow.DataBoundItem is Entidades.Viaje viaje)
            {
                DialogResult dialogResult = MessageBox.Show(this, "Esta seguro que desea eliminar el viaje número " + viaje.Identificador.ToString(), "Eliminar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string resultado = Viajes.EliminarViaje(viaje);

                    MessageBox.Show(this, resultado);

                    ActualizarListado();
                }                
            }
        }

        private void ActualizarListado()
        {
            dtgViajes.DataSource = null;
            dtgViajes.DataSource = Viajes.ListadoViajes;
        }

        #endregion
    }
}
