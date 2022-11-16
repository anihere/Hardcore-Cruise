using System.Collections.Generic;
using System.Windows.Forms;

using Crucero.Entidades;
using Crucero.ReglasNegocio;

namespace Crucero.WINFORMS
{
    public partial class FrmViaje : Form
    {
        #region Atributos

        private Viaje auxViaje = null;

        #endregion

        #region Constructores

        public FrmViaje(Viaje viaje)
        {
            InitializeComponent();

            dtgCruceros.AutoGenerateColumns = false;

            dtgCruceros.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgCruceros.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgCruceros.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgCruceros.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgCruceros.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgCruceros.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgCruceros.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            auxViaje = viaje;

            if (auxViaje == null)
                auxViaje = new Viaje();
            else
            {
                if (viaje.Tickets != null && viaje.Tickets.Count > 0)
                    PermiteModificaiones(false);
            }
        }

        #endregion

        #region Metodos

        private void FrmViaje_Load(object sender, System.EventArgs e)
        {
            cmbCiudadPartida.DataSource = new List<Ciudad>(Ciudades.ListadoCiudades);
            cmbCiudadPartida.SelectedItem = null;

            cmbCiudadDestino.DataSource = new List<Ciudad>(Ciudades.ListadoCiudades);
            cmbCiudadDestino.SelectedItem = null;

            dtgCruceros.DataSource = Cruceros.ListadoCruceros;

            dtgCruceros.DataBindingComplete += (s, e) => 
            {
                dtgCruceros.ClearSelection();
                dtgCruceros.SelectionChanged += (s, e) =>
                {
                    if (dtgCruceros.CurrentRow.Selected == true && dtgCruceros.CurrentRow.DataBoundItem is Crucero.Entidades.Crucero cru)
                        txtCrucero.Text = cru.MatriculaNombre;
                    else
                        txtCrucero.Text = null;
                };

                MostrarViaje(auxViaje);
            };
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            SetearViaje();

            string resultado = Viajes.GuardarViaje(auxViaje);

            if (resultado == null)
            {
                MessageBox.Show(this, "Viaje guardado correctamente.");

                Close();
            }
            else
                MessageBox.Show(this, resultado);
        }

        private void MostrarViaje(Viaje viaje)
        {
            if (viaje != null)
            {
                txtIdentificador.Text = viaje.Identificador.ToString();

                if (viaje.FechaInicio != default)
                    dtpFechaInicio.Value = viaje.FechaInicio;

                cmbCiudadPartida.SelectedItem = viaje.CiudadPartida;
                cmbCiudadDestino.SelectedItem = viaje.CiudadDestino;

                txtTipoViaje.Text = viaje.TipoViaje;
                nudHoras.Value = viaje.DuracionViaje;

                if (viaje.CostoTurista != default)
                    txtCostoTurista.Text = viaje.CostoTurista.ToString();

                if (viaje.CostoPremium != default)
                    txtCostoPremium.Text = viaje.CostoPremium.ToString();

                if (viaje.Crucero != null)
                {
                    foreach (DataGridViewRow row in dtgCruceros.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == viaje.Crucero.Matricula)
                        {
                            row.Selected = true;
                            txtCrucero.Text = viaje.Crucero.MatriculaNombre;
                            break;
                        }
                    }
                }

                lblTV.Text = viaje.TicketsVendidos.ToString();
                lblTMT.Text = "$ " + viaje.TicketsVendidosMonto.ToString();
                
                lblTVP.Text = viaje.TicketsVendidosPremium.ToString();
                lblTMP.Text = "$ " + viaje.TicketsVendidosMontoPremium.ToString();

                lblTVT.Text = viaje.TicketsVendidosTurista.ToString();
                lblTMTU.Text = "$ " + viaje.TicketsVendidosMontoTurista.ToString();
            }
        }

        private void SetearViaje()
        {
            if (auxViaje.Tickets != null && auxViaje.Tickets.Count > 0)
            {
                PermiteModificaiones(false);

                MessageBox.Show(this, "El viaje posee tickets vendidos, no se puede modificar.", "Modificaciones");

                MostrarViaje(auxViaje);
            }
            else
            {
                auxViaje.FechaInicio = dtpFechaInicio.Value;

                if (cmbCiudadPartida.SelectedItem is Ciudad cpp)
                    auxViaje.CiudadPartida = cpp;

                if (cmbCiudadDestino.SelectedItem is Ciudad cpd)
                    auxViaje.CiudadDestino = cpd;

                auxViaje.DuracionViaje = nudHoras.Value;

                if (dtgCruceros.CurrentRow != null && dtgCruceros.CurrentRow.Selected == true && dtgCruceros.CurrentRow.DataBoundItem is Crucero.Entidades.Crucero cru)
                    auxViaje.Crucero = cru;
            }
        }

        private void PermiteModificaiones(bool bandera)
        {
            cmbCiudadPartida.Enabled = bandera;
            cmbCiudadDestino.Enabled = bandera;
            dtpFechaInicio.Enabled = bandera;
            nudHoras.Enabled = bandera;
            dtgCruceros.Enabled = bandera;
            btnGuardar.Enabled = bandera;
        }

        #endregion

        
    }
}
