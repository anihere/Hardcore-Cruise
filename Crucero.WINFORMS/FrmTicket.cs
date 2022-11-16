using System.Collections.Generic;
using System.Windows.Forms;

using Crucero.Entidades;
using Crucero.ReglasNegocio;

namespace Crucero.WINFORMS
{
    public partial class FrmTicket : Form
    {
        #region Atributos

        private TicketViaje auxTicket = null;

        #endregion

        #region Constructores

        public FrmTicket(TicketViaje ticket)
        {
            InitializeComponent();

            auxTicket = ticket;

            dtgPasajeros.AutoGenerateColumns = false;
            dtgViajes.AutoGenerateColumns = false;

            if (auxTicket == null)
            {
                auxTicket = new TicketViaje();
                dtgPasajeros.DataSource = Pasajeros.ListadoPasajeros;
                dtgPasajeros.DataBindingComplete += (s, e) =>
                {
                    dtgPasajeros.ClearSelection();
                    dtgPasajeros.SelectionChanged += (s, e) =>
                    {
                        if (dtgPasajeros.CurrentRow.Selected == true && dtgPasajeros.CurrentRow.DataBoundItem is Crucero.Entidades.Pasajero psj)
                            MostrarPasajero(psj);
                    };
                };

                dtgViajes.DataSource = Viajes.ListadoViajes;
                dtgViajes.DataBindingComplete += (s, e) =>
                {
                    dtgViajes.ClearSelection();
                    dtgViajes.SelectionChanged += (s, e) =>
                    {
                        if (dtgViajes.CurrentRow.Selected == true && dtgViajes.CurrentRow.DataBoundItem is Crucero.Entidades.Viaje vje)
                            MostrarViaje(vje);
                        else
                            MostrarViaje(null);
                    };
                };

                cmbTickets.SelectedValueChanged += (s, e) =>
                {
                    if (dtgViajes.CurrentRow != null && dtgViajes.CurrentRow.Selected == true && dtgViajes.CurrentRow.DataBoundItem is Crucero.Entidades.Viaje vje)
                        SetearCamarotes(vje);
                };
            }
            else
            {
                PermiteModificaiones(false);
            }
        }

        #endregion

        #region Metodos

        private void FrmTicket_Load(object sender, System.EventArgs e)
        {
            MostrarTicket(auxTicket);
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            SetearTicket();

            string resultado = Tickets.GuardarTicket(auxTicket);

            MostrarTicket(auxTicket);

            if (resultado == null)
            {
                MessageBox.Show(this, "Ticket guardado correctamente.");

                Close();
            }
            else
                MessageBox.Show(this, resultado);
        }

        private void MostrarTicket(TicketViaje ticket)
        {
            if (ticket != null)
            {
                txtIdentificador.Text = ticket.Identificador;

                MostrarPasajero(ticket.Pasajero);
                MostrarViaje(ticket.Viaje);

                if (ticket.CamaroteOcupacion != null && ticket.CamaroteOcupacion.Camarote != null)
                {
                    cmbTickets.SelectedItem = ticket.CamaroteOcupacion.Camarote.CamaroteTipo;
                    txtCosto.Text = ticket.Costo.ToString();
                    SetearCamarotes(ticket.Viaje);
                    cmbCamarotes.SelectedItem = ticket.CamaroteOcupacion;
                }
            }
        }

        private void SetearTicket()
        {
            if (dtgPasajeros.CurrentRow != null && dtgPasajeros.CurrentRow.Selected == true && dtgPasajeros.CurrentRow.DataBoundItem is Crucero.Entidades.Pasajero psj)
                auxTicket.Pasajero = psj;

            if (dtgViajes.CurrentRow != null && dtgViajes.CurrentRow.Selected == true && dtgViajes.CurrentRow.DataBoundItem is Crucero.Entidades.Viaje vje)
                auxTicket.Viaje = vje;

            if (cmbTickets.SelectedItem != null && auxTicket.Viaje != null && cmbTickets.SelectedItem is CamaroteTipo ct)
            {
                if (ct.Equals(CamaroteTipo.Turista))
                    auxTicket.Costo = auxTicket.Viaje.CostoTurista;
                else
                    auxTicket.Costo = auxTicket.Viaje.CostoPremium;
            }  

            if (cmbCamarotes.SelectedItem != null && cmbCamarotes.SelectedItem is CamaroteOcupacion co)
                auxTicket.CamaroteOcupacion = co;
        }

        private void MostrarPasajero(Pasajero pasajero)
        {
            if (pasajero != null)
            {
                if (pasajero.Edad != default)
                    txtEdad.Text = pasajero.Edad.ToString();

                if (pasajero.Pasaporte != null)
                {
                    txtPasaporte.Text = pasajero.Pasaporte.Identificador;
                    txtNombre.Text = pasajero.Pasaporte.Nombre;
                    txtApellido.Text = pasajero.Pasaporte.Apellido;
                    if (pasajero.Pasaporte.FechaNacimiento != default)
                        dtpFechaNacimiento.Value = pasajero.Pasaporte.FechaNacimiento;
                }
            }
            else
            {
                txtEdad.Text = null;
                txtPasaporte.Text = null;
                txtNombre.Text = null;
                txtApellido.Text = null;
                dtpFechaNacimiento.Value = dtpFechaNacimiento.MinDate;
            }
        }

        private void MostrarViaje(Viaje viaje)
        {
            txtViaje.Text = null;
            MostrarCrucero(null);

            if (viaje != null)
            {
                txtViaje.Text = viaje.Identificador.ToString() + "- (" + viaje.CiudadPaisPartida + " <-> " + viaje.CiudadPaisDestino + ")";
                MostrarCrucero(viaje.Crucero);
            }
        }

        private void MostrarCrucero(Entidades.Crucero crucero)
        {
            cmbTickets.Items.Clear();
            cmbTickets.SelectedItem = null;

            cmbCamarotes.Items.Clear();
            cmbCamarotes.SelectedItem = null;

            txtCrucero.Text = null;
            txtCosto.Text = null;

            if (crucero != null)
            {
                txtCrucero.Text = crucero.MatriculaNombre;
                foreach (CamaroteTipo tc in crucero.TipoCamarotes)
                    cmbTickets.Items.Add(tc);
            }
        }

        private void SetearCamarotes(Viaje viaje)
        {
            cmbCamarotes.Items.Clear();
            txtCosto.Text = null;
            if (viaje != null)
            {
                if (cmbTickets.SelectedItem.Equals(CamaroteTipo.Turista))
                {
                    txtCosto.Text = viaje.CostoTurista.ToString();
                    foreach (CamaroteOcupacion co in viaje.CamarotesOcupaciones)
                        if (co.Camarote.CamaroteTipo == CamaroteTipo.Turista)
                            cmbCamarotes.Items.Add(co);
                }
                else if (cmbTickets.SelectedItem.Equals(CamaroteTipo.Premium))
                {
                    txtCosto.Text = viaje.CostoPremium.ToString();
                    foreach (CamaroteOcupacion co in viaje.CamarotesOcupaciones)
                        if (co.Camarote.CamaroteTipo == CamaroteTipo.Premium)
                            cmbCamarotes.Items.Add(co);
                }
            }
        }

        private void PermiteModificaiones(bool bandera)
        {
            btnGuardar.Visible = bandera;
            dtgPasajeros.Enabled = bandera;
            dtgViajes.Enabled = bandera;
            cmbTickets.Enabled = bandera;
            cmbCamarotes.Enabled = bandera;
        }

        #endregion
    }
}
