using System.Windows.Forms;

using Crucero.ReglasNegocio;

namespace Crucero.WINFORMS
{
    public partial class FrmTickets : Form
    {
        #region Atributos

        private bool frmTicketAbierto;

        #endregion

        #region Constructores

        public FrmTickets()
        {
            InitializeComponent();

            dtgTickets.AutoGenerateColumns = false;
        }

        #endregion

        #region Metodos

        private void btnActualizar_Click(object sender, System.EventArgs e)
        {
            ActualizarListado();
        }

        private void btnCrear_Click(object sender, System.EventArgs e)
        {
            if (!frmTicketAbierto)
            {
                frmTicketAbierto = true;

                FrmTicket frmTicket = new FrmTicket(null);

                frmTicket.MdiParent = this.MdiParent;

                frmTicket.FormClosed += (s, e) =>
                {
                    frmTicketAbierto = false;
                    ActualizarListado();
                };

                frmTicket.Show();
            }
        }

        private void btnVer_Click(object sender, System.EventArgs e)
        {
            if (!frmTicketAbierto)
            {
                if (dtgTickets.CurrentRow != null && dtgTickets.CurrentRow.DataBoundItem is Entidades.TicketViaje ticket)
                {
                    frmTicketAbierto = true;

                    FrmTicket frmTicket = new FrmTicket(ticket);

                    frmTicket.MdiParent = this.MdiParent;

                    frmTicket.FormClosed += (s, e) =>
                    {
                        frmTicketAbierto = false;
                        ActualizarListado();
                    };

                    frmTicket.Show();
                }
            }
        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            if (dtgTickets.CurrentRow != null && dtgTickets.CurrentRow.DataBoundItem is Entidades.TicketViaje ticket)
            {
                DialogResult dialogResult = MessageBox.Show(this, "Esta seguro que desea eliminar el ticket número " + ticket.Identificador.ToString(), "Eliminar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Tickets.EliminarTicket(ticket);
                    ActualizarListado();
                }

            }
        }

        private void ActualizarListado()
        {
            dtgTickets.DataSource = null;
            dtgTickets.DataSource = Tickets.ListadoTickets;
        }

        #endregion
    }
}
