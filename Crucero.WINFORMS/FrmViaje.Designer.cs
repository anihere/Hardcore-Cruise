
namespace Crucero.WINFORMS
{
    partial class FrmViaje
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.lblCiudadPartida = new System.Windows.Forms.Label();
            this.cmbCiudadPartida = new System.Windows.Forms.ComboBox();
            this.cmbCiudadDestino = new System.Windows.Forms.ComboBox();
            this.lblCiudadDestino = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblHorasAprox = new System.Windows.Forms.Label();
            this.nudHoras = new System.Windows.Forms.NumericUpDown();
            this.lblCostoTurista = new System.Windows.Forms.Label();
            this.txtCostoTurista = new System.Windows.Forms.TextBox();
            this.txtTipoViaje = new System.Windows.Forms.TextBox();
            this.lblTipoViaje = new System.Windows.Forms.Label();
            this.txtCostoPremium = new System.Windows.Forms.TextBox();
            this.lblCostoPremium = new System.Windows.Forms.Label();
            this.lblCrucero = new System.Windows.Forms.Label();
            this.dtgCruceros = new System.Windows.Forms.DataGridView();
            this.clmMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCasinos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidadCamarotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidadCamarotesTurista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidadCamarotesPremium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCapacidadBodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCrucero = new System.Windows.Forms.TextBox();
            this.lblTickets = new System.Windows.Forms.Label();
            this.lblTicketsMontoTotal = new System.Windows.Forms.Label();
            this.lblTicketsPremium = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTMTU = new System.Windows.Forms.Label();
            this.lblTVT = new System.Windows.Forms.Label();
            this.lblTMP = new System.Windows.Forms.Label();
            this.lblTVP = new System.Windows.Forms.Label();
            this.lblTMT = new System.Windows.Forms.Label();
            this.lblTV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCruceros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGuardar.Location = new System.Drawing.Point(0, 482);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(30);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(984, 29);
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
            this.txtIdentificador.Location = new System.Drawing.Point(105, 10);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.ReadOnly = true;
            this.txtIdentificador.Size = new System.Drawing.Size(200, 23);
            this.txtIdentificador.TabIndex = 2;
            this.txtIdentificador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCiudadPartida
            // 
            this.lblCiudadPartida.AutoSize = true;
            this.lblCiudadPartida.Location = new System.Drawing.Point(13, 44);
            this.lblCiudadPartida.Name = "lblCiudadPartida";
            this.lblCiudadPartida.Size = new System.Drawing.Size(85, 15);
            this.lblCiudadPartida.TabIndex = 3;
            this.lblCiudadPartida.Text = "Ciudad Partida";
            // 
            // cmbCiudadPartida
            // 
            this.cmbCiudadPartida.DisplayMember = "CiudadPais";
            this.cmbCiudadPartida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudadPartida.FormattingEnabled = true;
            this.cmbCiudadPartida.Location = new System.Drawing.Point(105, 39);
            this.cmbCiudadPartida.Name = "cmbCiudadPartida";
            this.cmbCiudadPartida.Size = new System.Drawing.Size(200, 23);
            this.cmbCiudadPartida.TabIndex = 4;
            // 
            // cmbCiudadDestino
            // 
            this.cmbCiudadDestino.DisplayMember = "CiudadPais";
            this.cmbCiudadDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudadDestino.FormattingEnabled = true;
            this.cmbCiudadDestino.Location = new System.Drawing.Point(105, 68);
            this.cmbCiudadDestino.Name = "cmbCiudadDestino";
            this.cmbCiudadDestino.Size = new System.Drawing.Size(200, 23);
            this.cmbCiudadDestino.TabIndex = 6;
            // 
            // lblCiudadDestino
            // 
            this.lblCiudadDestino.AutoSize = true;
            this.lblCiudadDestino.Location = new System.Drawing.Point(12, 73);
            this.lblCiudadDestino.Name = "lblCiudadDestino";
            this.lblCiudadDestino.Size = new System.Drawing.Size(88, 15);
            this.lblCiudadDestino.TabIndex = 5;
            this.lblCiudadDestino.Text = "Ciudad Destino";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(311, 13);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(70, 15);
            this.lblFechaInicio.TabIndex = 7;
            this.lblFechaInicio.Text = "Fecha Inicio";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(407, 10);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaInicio.TabIndex = 8;
            // 
            // lblHorasAprox
            // 
            this.lblHorasAprox.AutoSize = true;
            this.lblHorasAprox.Location = new System.Drawing.Point(311, 44);
            this.lblHorasAprox.Name = "lblHorasAprox";
            this.lblHorasAprox.Size = new System.Drawing.Size(73, 15);
            this.lblHorasAprox.TabIndex = 9;
            this.lblHorasAprox.Text = "Horas aprox.";
            // 
            // nudHoras
            // 
            this.nudHoras.Location = new System.Drawing.Point(407, 39);
            this.nudHoras.Maximum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.nudHoras.Minimum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.nudHoras.Name = "nudHoras";
            this.nudHoras.Size = new System.Drawing.Size(200, 23);
            this.nudHoras.TabIndex = 10;
            this.nudHoras.Value = new decimal(new int[] {
            72,
            0,
            0,
            0});
            // 
            // lblCostoTurista
            // 
            this.lblCostoTurista.AutoSize = true;
            this.lblCostoTurista.Location = new System.Drawing.Point(311, 73);
            this.lblCostoTurista.Name = "lblCostoTurista";
            this.lblCostoTurista.Size = new System.Drawing.Size(77, 15);
            this.lblCostoTurista.TabIndex = 11;
            this.lblCostoTurista.Text = "Costo Turista";
            // 
            // txtCostoTurista
            // 
            this.txtCostoTurista.Location = new System.Drawing.Point(407, 68);
            this.txtCostoTurista.Name = "txtCostoTurista";
            this.txtCostoTurista.ReadOnly = true;
            this.txtCostoTurista.Size = new System.Drawing.Size(200, 23);
            this.txtCostoTurista.TabIndex = 12;
            // 
            // txtTipoViaje
            // 
            this.txtTipoViaje.Location = new System.Drawing.Point(105, 97);
            this.txtTipoViaje.Name = "txtTipoViaje";
            this.txtTipoViaje.ReadOnly = true;
            this.txtTipoViaje.Size = new System.Drawing.Size(200, 23);
            this.txtTipoViaje.TabIndex = 13;
            // 
            // lblTipoViaje
            // 
            this.lblTipoViaje.AutoSize = true;
            this.lblTipoViaje.Location = new System.Drawing.Point(13, 100);
            this.lblTipoViaje.Name = "lblTipoViaje";
            this.lblTipoViaje.Size = new System.Drawing.Size(59, 15);
            this.lblTipoViaje.TabIndex = 14;
            this.lblTipoViaje.Text = "Tipo Viaje";
            // 
            // txtCostoPremium
            // 
            this.txtCostoPremium.Location = new System.Drawing.Point(407, 97);
            this.txtCostoPremium.Name = "txtCostoPremium";
            this.txtCostoPremium.ReadOnly = true;
            this.txtCostoPremium.Size = new System.Drawing.Size(200, 23);
            this.txtCostoPremium.TabIndex = 16;
            // 
            // lblCostoPremium
            // 
            this.lblCostoPremium.AutoSize = true;
            this.lblCostoPremium.Location = new System.Drawing.Point(311, 102);
            this.lblCostoPremium.Name = "lblCostoPremium";
            this.lblCostoPremium.Size = new System.Drawing.Size(90, 15);
            this.lblCostoPremium.TabIndex = 15;
            this.lblCostoPremium.Text = "Costo Premium";
            // 
            // lblCrucero
            // 
            this.lblCrucero.AutoSize = true;
            this.lblCrucero.Location = new System.Drawing.Point(12, 131);
            this.lblCrucero.Name = "lblCrucero";
            this.lblCrucero.Size = new System.Drawing.Size(49, 15);
            this.lblCrucero.TabIndex = 17;
            this.lblCrucero.Text = "Crucero";
            // 
            // dtgCruceros
            // 
            this.dtgCruceros.AllowUserToAddRows = false;
            this.dtgCruceros.AllowUserToDeleteRows = false;
            this.dtgCruceros.AllowUserToOrderColumns = true;
            this.dtgCruceros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCruceros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMatricula,
            this.clmNombre,
            this.clmSalones,
            this.clmCasinos,
            this.clmCantidadCamarotes,
            this.clmCantidadCamarotesTurista,
            this.clmCantidadCamarotesPremium,
            this.clmCapacidadBodega});
            this.dtgCruceros.Location = new System.Drawing.Point(12, 157);
            this.dtgCruceros.MultiSelect = false;
            this.dtgCruceros.Name = "dtgCruceros";
            this.dtgCruceros.ReadOnly = true;
            this.dtgCruceros.RowHeadersVisible = false;
            this.dtgCruceros.RowTemplate.Height = 25;
            this.dtgCruceros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCruceros.Size = new System.Drawing.Size(960, 248);
            this.dtgCruceros.TabIndex = 19;
            // 
            // clmMatricula
            // 
            this.clmMatricula.DataPropertyName = "Matricula";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmMatricula.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmMatricula.FillWeight = 120F;
            this.clmMatricula.HeaderText = "Matricula";
            this.clmMatricula.Name = "clmMatricula";
            this.clmMatricula.ReadOnly = true;
            this.clmMatricula.Width = 120;
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
            // clmSalones
            // 
            this.clmSalones.DataPropertyName = "Salones";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmSalones.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmSalones.HeaderText = "Salones";
            this.clmSalones.Name = "clmSalones";
            this.clmSalones.ReadOnly = true;
            // 
            // clmCasinos
            // 
            this.clmCasinos.DataPropertyName = "Casinos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmCasinos.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmCasinos.HeaderText = "Casinos";
            this.clmCasinos.Name = "clmCasinos";
            this.clmCasinos.ReadOnly = true;
            // 
            // clmCantidadCamarotes
            // 
            this.clmCantidadCamarotes.DataPropertyName = "CantidadCamarotes";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmCantidadCamarotes.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmCantidadCamarotes.HeaderText = "Camarotes";
            this.clmCantidadCamarotes.Name = "clmCantidadCamarotes";
            this.clmCantidadCamarotes.ReadOnly = true;
            // 
            // clmCantidadCamarotesTurista
            // 
            this.clmCantidadCamarotesTurista.DataPropertyName = "CantidadCamarotesTurista";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmCantidadCamarotesTurista.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmCantidadCamarotesTurista.HeaderText = "Turista";
            this.clmCantidadCamarotesTurista.Name = "clmCantidadCamarotesTurista";
            this.clmCantidadCamarotesTurista.ReadOnly = true;
            // 
            // clmCantidadCamarotesPremium
            // 
            this.clmCantidadCamarotesPremium.DataPropertyName = "CantidadCamarotesPremium";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmCantidadCamarotesPremium.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmCantidadCamarotesPremium.HeaderText = "Premium";
            this.clmCantidadCamarotesPremium.Name = "clmCantidadCamarotesPremium";
            this.clmCantidadCamarotesPremium.ReadOnly = true;
            // 
            // clmCapacidadBodega
            // 
            this.clmCapacidadBodega.DataPropertyName = "CapacidadBodega";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.clmCapacidadBodega.DefaultCellStyle = dataGridViewCellStyle7;
            this.clmCapacidadBodega.HeaderText = "Bodega KG";
            this.clmCapacidadBodega.Name = "clmCapacidadBodega";
            this.clmCapacidadBodega.ReadOnly = true;
            // 
            // txtCrucero
            // 
            this.txtCrucero.Location = new System.Drawing.Point(105, 128);
            this.txtCrucero.Name = "txtCrucero";
            this.txtCrucero.ReadOnly = true;
            this.txtCrucero.Size = new System.Drawing.Size(200, 23);
            this.txtCrucero.TabIndex = 20;
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTickets.Location = new System.Drawing.Point(13, 417);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(100, 15);
            this.lblTickets.TabIndex = 21;
            this.lblTickets.Text = "Tickets Vendidos";
            // 
            // lblTicketsMontoTotal
            // 
            this.lblTicketsMontoTotal.AutoSize = true;
            this.lblTicketsMontoTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTicketsMontoTotal.Location = new System.Drawing.Point(154, 417);
            this.lblTicketsMontoTotal.Name = "lblTicketsMontoTotal";
            this.lblTicketsMontoTotal.Size = new System.Drawing.Size(117, 15);
            this.lblTicketsMontoTotal.TabIndex = 22;
            this.lblTicketsMontoTotal.Text = "Tickets Monto Total";
            // 
            // lblTicketsPremium
            // 
            this.lblTicketsPremium.AutoSize = true;
            this.lblTicketsPremium.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTicketsPremium.Location = new System.Drawing.Point(307, 417);
            this.lblTicketsPremium.Name = "lblTicketsPremium";
            this.lblTicketsPremium.Size = new System.Drawing.Size(154, 15);
            this.lblTicketsPremium.TabIndex = 23;
            this.lblTicketsPremium.Text = "Tickets Vendidos Premium";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(497, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tickets Monto Premium";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(843, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tickets Monto Turista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(670, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tickets Vendidos Turista";
            // 
            // lblTMTU
            // 
            this.lblTMTU.AutoSize = true;
            this.lblTMTU.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTMTU.Location = new System.Drawing.Point(833, 443);
            this.lblTMTU.MinimumSize = new System.Drawing.Size(150, 0);
            this.lblTMTU.Name = "lblTMTU";
            this.lblTMTU.Size = new System.Drawing.Size(150, 19);
            this.lblTMTU.TabIndex = 32;
            this.lblTMTU.Text = "0";
            this.lblTMTU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTVT
            // 
            this.lblTVT.AutoSize = true;
            this.lblTVT.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTVT.Location = new System.Drawing.Point(662, 443);
            this.lblTVT.MinimumSize = new System.Drawing.Size(150, 0);
            this.lblTVT.Name = "lblTVT";
            this.lblTVT.Size = new System.Drawing.Size(150, 19);
            this.lblTVT.TabIndex = 31;
            this.lblTVT.Text = "0";
            this.lblTVT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTMP
            // 
            this.lblTMP.AutoSize = true;
            this.lblTMP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTMP.Location = new System.Drawing.Point(497, 443);
            this.lblTMP.MinimumSize = new System.Drawing.Size(150, 0);
            this.lblTMP.Name = "lblTMP";
            this.lblTMP.Size = new System.Drawing.Size(150, 19);
            this.lblTMP.TabIndex = 30;
            this.lblTMP.Text = "0";
            this.lblTMP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTVP
            // 
            this.lblTVP.AutoSize = true;
            this.lblTVP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTVP.Location = new System.Drawing.Point(297, 443);
            this.lblTVP.MinimumSize = new System.Drawing.Size(150, 0);
            this.lblTVP.Name = "lblTVP";
            this.lblTVP.Size = new System.Drawing.Size(150, 19);
            this.lblTVP.TabIndex = 29;
            this.lblTVP.Text = "0";
            this.lblTVP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTMT
            // 
            this.lblTMT.AutoSize = true;
            this.lblTMT.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTMT.Location = new System.Drawing.Point(141, 443);
            this.lblTMT.MinimumSize = new System.Drawing.Size(150, 0);
            this.lblTMT.Name = "lblTMT";
            this.lblTMT.Size = new System.Drawing.Size(150, 19);
            this.lblTMT.TabIndex = 28;
            this.lblTMT.Text = "0";
            this.lblTMT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTV
            // 
            this.lblTV.AutoSize = true;
            this.lblTV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTV.Location = new System.Drawing.Point(-14, 443);
            this.lblTV.MinimumSize = new System.Drawing.Size(150, 0);
            this.lblTV.Name = "lblTV";
            this.lblTV.Size = new System.Drawing.Size(150, 19);
            this.lblTV.TabIndex = 27;
            this.lblTV.Text = "0";
            this.lblTV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.lblTMTU);
            this.Controls.Add(this.lblTVT);
            this.Controls.Add(this.lblTMP);
            this.Controls.Add(this.lblTVP);
            this.Controls.Add(this.lblTMT);
            this.Controls.Add(this.lblTV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTicketsPremium);
            this.Controls.Add(this.lblTicketsMontoTotal);
            this.Controls.Add(this.lblTickets);
            this.Controls.Add(this.txtCrucero);
            this.Controls.Add(this.dtgCruceros);
            this.Controls.Add(this.lblCrucero);
            this.Controls.Add(this.txtCostoPremium);
            this.Controls.Add(this.lblCostoPremium);
            this.Controls.Add(this.lblTipoViaje);
            this.Controls.Add(this.txtTipoViaje);
            this.Controls.Add(this.txtCostoTurista);
            this.Controls.Add(this.lblCostoTurista);
            this.Controls.Add(this.nudHoras);
            this.Controls.Add(this.lblHorasAprox);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.cmbCiudadDestino);
            this.Controls.Add(this.lblCiudadDestino);
            this.Controls.Add(this.cmbCiudadPartida);
            this.Controls.Add(this.lblCiudadPartida);
            this.Controls.Add(this.txtIdentificador);
            this.Controls.Add(this.lblIdentificador);
            this.Controls.Add(this.btnGuardar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 550);
            this.MinimumSize = new System.Drawing.Size(1000, 550);
            this.Name = "FrmViaje";
            this.Text = "Viaje";
            this.Load += new System.EventHandler(this.FrmViaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCruceros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.Label lblCiudadPartida;
        private System.Windows.Forms.ComboBox cmbCiudadPartida;
        private System.Windows.Forms.ComboBox cmbCiudadDestino;
        private System.Windows.Forms.Label lblCiudadDestino;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblHorasAprox;
        private System.Windows.Forms.NumericUpDown nudHoras;
        private System.Windows.Forms.Label lblCostoTurista;
        private System.Windows.Forms.TextBox txtCostoTurista;
        private System.Windows.Forms.TextBox txtTipoViaje;
        private System.Windows.Forms.Label lblTipoViaje;
        private System.Windows.Forms.TextBox txtCostoPremium;
        private System.Windows.Forms.Label lblCostoPremium;
        private System.Windows.Forms.Label lblCrucero;
        private System.Windows.Forms.DataGridView dtgCruceros;
        private System.Windows.Forms.TextBox txtCrucero;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.Label lblTicketsMontoTotal;
        private System.Windows.Forms.Label lblTicketsPremium;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTMTU;
        private System.Windows.Forms.Label lblTVT;
        private System.Windows.Forms.Label lblTMP;
        private System.Windows.Forms.Label lblTVP;
        private System.Windows.Forms.Label lblTMT;
        private System.Windows.Forms.Label lblTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalones;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCasinos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidadCamarotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidadCamarotesTurista;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidadCamarotesPremium;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCapacidadBodega;
    }
}