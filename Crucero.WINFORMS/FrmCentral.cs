using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Crucero.WINFORMS
{
    public partial class FrmCentral : Form
    {
        #region Atributos

        private bool frmUsuariosAbierto;

        private bool frmPaisesAbierto;

        private bool frmCiudadesAbierto;

        private bool frmCrucerosAbierto;

        private bool frmViajesAbierto;

        private bool frmTicketsAbierto;

        private bool frmPasajerosAbierto;

        #endregion

        #region Constructores

        public FrmCentral()
        {
            InitializeComponent();
        }

        #endregion

        #region Metodos

        private void ListadoUsuarios(object sender, EventArgs e)
        {
            if (!frmUsuariosAbierto)
            {
                frmUsuariosAbierto = true;

                FrmUsuarios frmUsuarios = new FrmUsuarios();

                frmUsuarios.MdiParent = this;

                frmUsuarios.FormClosed += (s, e) => { frmUsuariosAbierto = false; };

                frmUsuarios.Show();
            }
        }

        private void ListadoPaises(object sender, EventArgs e)
        {
            if (!frmPaisesAbierto)
            {
                frmPaisesAbierto = true;

                FrmPaises frmPaises = new FrmPaises();

                frmPaises.MdiParent = this;

                frmPaises.FormClosed += (s, e) => { frmPaisesAbierto = false; };

                frmPaises.Show();
            }
        }

        private void ListadoCiudades(object sender, EventArgs e)
        {
            if (!frmCiudadesAbierto)
            {
                frmCiudadesAbierto = true;

                FrmCiudades frmCiudades = new FrmCiudades();

                frmCiudades.MdiParent = this;

                frmCiudades.FormClosed += (s, e) => { frmCiudadesAbierto = false; };

                frmCiudades.Show();
            }
        }

        private void ListadoCruceros(object sender, EventArgs e)
        {
            if (!frmCrucerosAbierto)
            {
                frmCrucerosAbierto = true;

                FrmCruceros frmCruceros = new FrmCruceros();

                frmCruceros.MdiParent = this;

                frmCruceros.FormClosed += (s, e) => { frmCrucerosAbierto = false; };

                frmCruceros.Show();
            }
        }

        private void ListadoViajes(object sender, EventArgs e)
        {
            if (!frmViajesAbierto)
            {
                frmViajesAbierto = true;

                FrmViajes frmViajes = new FrmViajes();

                frmViajes.MdiParent = this;

                frmViajes.FormClosed += (s, e) => { frmViajesAbierto = false; };

                frmViajes.Show();
            }
        }

        private void ListadoTickets(object sender, EventArgs e)
        {
            if (!frmTicketsAbierto)
            {
                frmTicketsAbierto = true;

                FrmTickets frmTickets = new FrmTickets();

                frmTickets.MdiParent = this;

                frmTickets.FormClosed += (s, e) => { frmTicketsAbierto = false; };

                frmTickets.Show();
            }
        }

        private void ListadoPasajeros(object sender, EventArgs e)
        {
            if (!frmPasajerosAbierto)
            {
                frmPasajerosAbierto = true;

                FrmPasajeros frmPasajeros = new FrmPasajeros();

                frmPasajeros.MdiParent = this;

                frmPasajeros.FormClosed += (s, e) => { frmPasajerosAbierto = false; };

                frmPasajeros.Show();
            }
        }

        #endregion
    }
}