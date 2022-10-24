
namespace Crucero.WINFORMS
{
    partial class FrmTicket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.lblPasaporte = new System.Windows.Forms.Label();
            this.txtPasaporte = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtViaje = new System.Windows.Forms.TextBox();
            this.lblViaje = new System.Windows.Forms.Label();
            this.dtgViajes = new System.Windows.Forms.DataGridView();
            this.clmIdentificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCiudadPaisPartida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCiudadPaisDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDuracionViaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipoViaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCostoTurista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCostoPremium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCruceroMatriculaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCrucero = new System.Windows.Forms.TextBox();
            this.lblCrucero = new System.Windows.Forms.Label();
            this.lblPasajeros = new System.Windows.Forms.Label();
            this.dtgPasajeros = new System.Windows.Forms.DataGridView();
            this.clmPasaporteIdentificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTickets = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCamarotes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGuardar.Location = new System.Drawing.Point(0, 484);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(30);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(1084, 29);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.AutoSize = true;
            this.lblIdentificador.Location = new System.Drawing.Point(13, 13);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(74, 15);
            this.lblIdentificador.TabIndex = 1;
            this.lblIdentificador.Text = "Identificador";
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Location = new System.Drawing.Point(122, 10);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.ReadOnly = true;
            this.txtIdentificador.Size = new System.Drawing.Size(200, 23);
            this.txtIdentificador.TabIndex = 2;
            this.txtIdentificador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPasaporte
            // 
            this.lblPasaporte.AutoSize = true;
            this.lblPasaporte.Location = new System.Drawing.Point(13, 42);
            this.lblPasaporte.Name = "lblPasaporte";
            this.lblPasaporte.Size = new System.Drawing.Size(59, 15);
            this.lblPasaporte.TabIndex = 3;
            this.lblPasaporte.Text = "Pasaporte";
            // 
            // txtPasaporte
            // 
            this.txtPasaporte.Location = new System.Drawing.Point(122, 39);
            this.txtPasaporte.Name = "txtPasaporte";
            this.txtPasaporte.ReadOnly = true;
            this.txtPasaporte.Size = new System.Drawing.Size(200, 23);
            this.txtPasaporte.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(122, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(200, 23);
            this.txtNombre.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 71);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(122, 97);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(200, 23);
            this.txtApellido.TabIndex = 8;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(13, 100);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Enabled = false;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(122, 126);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaNacimiento.TabIndex = 10;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(13, 132);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(103, 15);
            this.lblFechaNacimiento.TabIndex = 9;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(13, 157);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 11;
            this.lblEdad.Text = "Edad";
            // 
            // txtViaje
            // 
            this.txtViaje.Location = new System.Drawing.Point(122, 184);
            this.txtViaje.Name = "txtViaje";
            this.txtViaje.ReadOnly = true;
            this.txtViaje.Size = new System.Drawing.Size(950, 23);
            this.txtViaje.TabIndex = 23;
            // 
            // lblViaje
            // 
            this.lblViaje.AutoSize = true;
            this.lblViaje.Location = new System.Drawing.Point(14, 187);
            this.lblViaje.Name = "lblViaje";
            this.lblViaje.Size = new System.Drawing.Size(32, 15);
            this.lblViaje.TabIndex = 21;
            this.lblViaje.Text = "Viaje";
            // 
            // dtgViajes
            // 
            this.dtgViajes.AllowUserToAddRows = false;
            this.dtgViajes.AllowUserToDeleteRows = false;
            this.dtgViajes.AllowUserToOrderColumns = true;
            this.dtgViajes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgViajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdentificador,
            this.clmCiudadPaisPartida,
            this.clmCiudadPaisDestino,
            this.clmFechaInicio,
            this.clmDuracionViaje,
            this.clmTipoViaje,
            this.clmCostoTurista,
            this.clmCostoPremium,
            this.clmCruceroMatriculaNombre});
            this.dtgViajes.Location = new System.Drawing.Point(12, 213);
            this.dtgViajes.MultiSelect = false;
            this.dtgViajes.Name = "dtgViajes";
            this.dtgViajes.ReadOnly = true;
            this.dtgViajes.RowHeadersVisible = false;
            this.dtgViajes.RowTemplate.Height = 25;
            this.dtgViajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgViajes.Size = new System.Drawing.Size(1060, 175);
            this.dtgViajes.TabIndex = 24;
            // 
            // clmIdentificador
            // 
            this.clmIdentificador.DataPropertyName = "Identificador";
            this.clmIdentificador.HeaderText = "Identificador";
            this.clmIdentificador.Name = "clmIdentificador";
            this.clmIdentificador.ReadOnly = true;
            // 
            // clmCiudadPaisPartida
            // 
            this.clmCiudadPaisPartida.DataPropertyName = "CiudadPaisPartida";
            this.clmCiudadPaisPartida.FillWeight = 200F;
            this.clmCiudadPaisPartida.HeaderText = "Partida";
            this.clmCiudadPaisPartida.Name = "clmCiudadPaisPartida";
            this.clmCiudadPaisPartida.ReadOnly = true;
            this.clmCiudadPaisPartida.Width = 200;
            // 
            // clmCiudadPaisDestino
            // 
            this.clmCiudadPaisDestino.DataPropertyName = "CiudadPaisDestino";
            this.clmCiudadPaisDestino.FillWeight = 200F;
            this.clmCiudadPaisDestino.HeaderText = "Destino";
            this.clmCiudadPaisDestino.Name = "clmCiudadPaisDestino";
            this.clmCiudadPaisDestino.ReadOnly = true;
            this.clmCiudadPaisDestino.Width = 200;
            // 
            // clmFechaInicio
            // 
            this.clmFechaInicio.DataPropertyName = "FechaInicio";
            this.clmFechaInicio.HeaderText = "Fecha";
            this.clmFechaInicio.Name = "clmFechaInicio";
            this.clmFechaInicio.ReadOnly = true;
            // 
            // clmDuracionViaje
            // 
            this.clmDuracionViaje.DataPropertyName = "DuracionViaje";
            this.clmDuracionViaje.FillWeight = 120F;
            this.clmDuracionViaje.HeaderText = "Duracion Viaje";
            this.clmDuracionViaje.Name = "clmDuracionViaje";
            this.clmDuracionViaje.ReadOnly = true;
            this.clmDuracionViaje.Width = 120;
            // 
            // clmTipoViaje
            // 
            this.clmTipoViaje.DataPropertyName = "TipoViaje";
            this.clmTipoViaje.HeaderText = "Tipo Viaje";
            this.clmTipoViaje.Name = "clmTipoViaje";
            this.clmTipoViaje.ReadOnly = true;
            // 
            // clmCostoTurista
            // 
            this.clmCostoTurista.DataPropertyName = "CostoTurista";
            this.clmCostoTurista.FillWeight = 120F;
            this.clmCostoTurista.HeaderText = "Costo Turista";
            this.clmCostoTurista.Name = "clmCostoTurista";
            this.clmCostoTurista.ReadOnly = true;
            this.clmCostoTurista.Width = 120;
            // 
            // clmCostoPremium
            // 
            this.clmCostoPremium.DataPropertyName = "CostoPremium";
            this.clmCostoPremium.FillWeight = 120F;
            this.clmCostoPremium.HeaderText = "Costo Premium";
            this.clmCostoPremium.Name = "clmCostoPremium";
            this.clmCostoPremium.ReadOnly = true;
            this.clmCostoPremium.Width = 120;
            // 
            // clmCruceroMatriculaNombre
            // 
            this.clmCruceroMatriculaNombre.DataPropertyName = "CruceroMatriculaNombre";
            this.clmCruceroMatriculaNombre.HeaderText = "Crucero";
            this.clmCruceroMatriculaNombre.Name = "clmCruceroMatriculaNombre";
            this.clmCruceroMatriculaNombre.ReadOnly = true;
            // 
            // txtCrucero
            // 
            this.txtCrucero.Location = new System.Drawing.Point(122, 394);
            this.txtCrucero.Name = "txtCrucero";
            this.txtCrucero.ReadOnly = true;
            this.txtCrucero.Size = new System.Drawing.Size(950, 23);
            this.txtCrucero.TabIndex = 26;
            // 
            // lblCrucero
            // 
            this.lblCrucero.AutoSize = true;
            this.lblCrucero.Location = new System.Drawing.Point(13, 397);
            this.lblCrucero.Name = "lblCrucero";
            this.lblCrucero.Size = new System.Drawing.Size(49, 15);
            this.lblCrucero.TabIndex = 25;
            this.lblCrucero.Text = "Crucero";
            // 
            // lblPasajeros
            // 
            this.lblPasajeros.AutoSize = true;
            this.lblPasajeros.Location = new System.Drawing.Point(328, 13);
            this.lblPasajeros.Name = "lblPasajeros";
            this.lblPasajeros.Size = new System.Drawing.Size(56, 15);
            this.lblPasajeros.TabIndex = 27;
            this.lblPasajeros.Text = "Pasajeros";
            // 
            // dtgPasajeros
            // 
            this.dtgPasajeros.AllowUserToAddRows = false;
            this.dtgPasajeros.AllowUserToDeleteRows = false;
            this.dtgPasajeros.AllowUserToOrderColumns = true;
            this.dtgPasajeros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPasajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPasaporteIdentificador,
            this.clmNombre,
            this.clmApellido,
            this.clmEdad});
            this.dtgPasajeros.Location = new System.Drawing.Point(328, 39);
            this.dtgPasajeros.MultiSelect = false;
            this.dtgPasajeros.Name = "dtgPasajeros";
            this.dtgPasajeros.ReadOnly = true;
            this.dtgPasajeros.RowHeadersVisible = false;
            this.dtgPasajeros.RowTemplate.Height = 25;
            this.dtgPasajeros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPasajeros.Size = new System.Drawing.Size(744, 139);
            this.dtgPasajeros.TabIndex = 28;
            // 
            // clmPasaporteIdentificador
            // 
            this.clmPasaporteIdentificador.DataPropertyName = "PasaporteIdentificador";
            this.clmPasaporteIdentificador.FillWeight = 120F;
            this.clmPasaporteIdentificador.HeaderText = "Pasaporte";
            this.clmPasaporteIdentificador.Name = "clmPasaporteIdentificador";
            this.clmPasaporteIdentificador.ReadOnly = true;
            this.clmPasaporteIdentificador.Width = 120;
            // 
            // clmNombre
            // 
            this.clmNombre.DataPropertyName = "Nombre";
            this.clmNombre.FillWeight = 150F;
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            this.clmNombre.Width = 150;
            // 
            // clmApellido
            // 
            this.clmApellido.DataPropertyName = "Apellido";
            this.clmApellido.FillWeight = 150F;
            this.clmApellido.HeaderText = "Apellido";
            this.clmApellido.Name = "clmApellido";
            this.clmApellido.ReadOnly = true;
            this.clmApellido.Width = 150;
            // 
            // clmEdad
            // 
            this.clmEdad.DataPropertyName = "Edad";
            this.clmEdad.FillWeight = 50F;
            this.clmEdad.HeaderText = "Edad";
            this.clmEdad.Name = "clmEdad";
            this.clmEdad.ReadOnly = true;
            this.clmEdad.Width = 50;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(122, 155);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(200, 23);
            this.txtEdad.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ticket";
            // 
            // cmbTickets
            // 
            this.cmbTickets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTickets.Location = new System.Drawing.Point(122, 423);
            this.cmbTickets.Name = "cmbTickets";
            this.cmbTickets.Size = new System.Drawing.Size(200, 23);
            this.cmbTickets.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Costo";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(372, 423);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.ReadOnly = true;
            this.txtCosto.Size = new System.Drawing.Size(167, 23);
            this.txtCosto.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Camarote";
            // 
            // cmbCamarotes
            // 
            this.cmbCamarotes.DisplayMember = "Detalle";
            this.cmbCamarotes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCamarotes.Location = new System.Drawing.Point(122, 453);
            this.cmbCamarotes.Name = "cmbCamarotes";
            this.cmbCamarotes.Size = new System.Drawing.Size(417, 23);
            this.cmbCamarotes.TabIndex = 35;
            // 
            // FrmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 513);
            this.Controls.Add(this.cmbCamarotes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTickets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.dtgPasajeros);
            this.Controls.Add(this.lblPasajeros);
            this.Controls.Add(this.txtCrucero);
            this.Controls.Add(this.lblCrucero);
            this.Controls.Add(this.dtgViajes);
            this.Controls.Add(this.txtViaje);
            this.Controls.Add(this.lblViaje);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtPasaporte);
            this.Controls.Add(this.lblPasaporte);
            this.Controls.Add(this.txtIdentificador);
            this.Controls.Add(this.lblIdentificador);
            this.Controls.Add(this.btnGuardar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 552);
            this.MinimumSize = new System.Drawing.Size(1100, 552);
            this.Name = "FrmTicket";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.FrmTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgViajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPasajeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.Label lblPasaporte;
        private System.Windows.Forms.TextBox txtPasaporte;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtViaje;
        private System.Windows.Forms.Label lblViaje;
        private System.Windows.Forms.DataGridView dtgViajes;
        private System.Windows.Forms.TextBox txtCrucero;
        private System.Windows.Forms.Label lblCrucero;
        private System.Windows.Forms.Label lblPasajeros;
        private System.Windows.Forms.DataGridView dtgPasajeros;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTickets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCamarotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdentificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCiudadPaisPartida;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCiudadPaisDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDuracionViaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipoViaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCostoTurista;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCostoPremium;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCruceroMatriculaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPasaporteIdentificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEdad;
    }
}