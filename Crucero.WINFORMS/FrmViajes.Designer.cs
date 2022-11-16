
namespace Crucero.WINFORMS
{
    partial class FrmViajes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgViajes = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.clmIdentificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTicketsVendidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTicketsVendidosMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCiudadPaisPartida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCiudadPaisDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDuracionViaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipoViaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCostoTurista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCostoPremium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCruceroMatriculaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViajes)).BeginInit();
            this.SuspendLayout();
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
            this.clmTicketsVendidos,
            this.clmTicketsVendidosMonto,
            this.clmCiudadPaisPartida,
            this.clmCiudadPaisDestino,
            this.clmFechaInicio,
            this.clmDuracionViaje,
            this.clmTipoViaje,
            this.clmCostoTurista,
            this.clmCostoPremium,
            this.clmCruceroMatriculaNombre});
            this.dtgViajes.Location = new System.Drawing.Point(12, 41);
            this.dtgViajes.MultiSelect = false;
            this.dtgViajes.Name = "dtgViajes";
            this.dtgViajes.ReadOnly = true;
            this.dtgViajes.RowHeadersVisible = false;
            this.dtgViajes.RowTemplate.Height = 25;
            this.dtgViajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgViajes.Size = new System.Drawing.Size(1311, 374);
            this.dtgViajes.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(12, 12);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(93, 12);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(174, 12);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(255, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // clmIdentificador
            // 
            this.clmIdentificador.DataPropertyName = "Identificador";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmIdentificador.DefaultCellStyle = dataGridViewCellStyle8;
            this.clmIdentificador.FillWeight = 85F;
            this.clmIdentificador.Frozen = true;
            this.clmIdentificador.HeaderText = "Identificador";
            this.clmIdentificador.Name = "clmIdentificador";
            this.clmIdentificador.ReadOnly = true;
            this.clmIdentificador.Width = 85;
            // 
            // clmTicketsVendidos
            // 
            this.clmTicketsVendidos.DataPropertyName = "TicketsVendidos";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmTicketsVendidos.DefaultCellStyle = dataGridViewCellStyle9;
            this.clmTicketsVendidos.FillWeight = 117F;
            this.clmTicketsVendidos.Frozen = true;
            this.clmTicketsVendidos.HeaderText = "Tickets Vendidos";
            this.clmTicketsVendidos.Name = "clmTicketsVendidos";
            this.clmTicketsVendidos.ReadOnly = true;
            this.clmTicketsVendidos.Width = 117;
            // 
            // clmTicketsVendidosMonto
            // 
            this.clmTicketsVendidosMonto.DataPropertyName = "TicketsVendidosMonto";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmTicketsVendidosMonto.DefaultCellStyle = dataGridViewCellStyle10;
            this.clmTicketsVendidosMonto.FillWeight = 106F;
            this.clmTicketsVendidosMonto.HeaderText = "Tickets Monto";
            this.clmTicketsVendidosMonto.Name = "clmTicketsVendidosMonto";
            this.clmTicketsVendidosMonto.ReadOnly = true;
            this.clmTicketsVendidosMonto.Width = 106;
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmDuracionViaje.DefaultCellStyle = dataGridViewCellStyle11;
            this.clmDuracionViaje.FillWeight = 106F;
            this.clmDuracionViaje.HeaderText = "Duracion Viaje";
            this.clmDuracionViaje.Name = "clmDuracionViaje";
            this.clmDuracionViaje.ReadOnly = true;
            this.clmDuracionViaje.Width = 106;
            // 
            // clmTipoViaje
            // 
            this.clmTipoViaje.DataPropertyName = "TipoViaje";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmTipoViaje.DefaultCellStyle = dataGridViewCellStyle12;
            this.clmTipoViaje.FillWeight = 81F;
            this.clmTipoViaje.HeaderText = "Tipo Viaje";
            this.clmTipoViaje.Name = "clmTipoViaje";
            this.clmTipoViaje.ReadOnly = true;
            this.clmTipoViaje.Width = 81;
            // 
            // clmCostoTurista
            // 
            this.clmCostoTurista.DataPropertyName = "CostoTurista";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmCostoTurista.DefaultCellStyle = dataGridViewCellStyle13;
            this.clmCostoTurista.FillWeight = 99F;
            this.clmCostoTurista.HeaderText = "Costo Turista";
            this.clmCostoTurista.Name = "clmCostoTurista";
            this.clmCostoTurista.ReadOnly = true;
            this.clmCostoTurista.Width = 99;
            // 
            // clmCostoPremium
            // 
            this.clmCostoPremium.DataPropertyName = "CostoPremium";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmCostoPremium.DefaultCellStyle = dataGridViewCellStyle14;
            this.clmCostoPremium.FillWeight = 113F;
            this.clmCostoPremium.HeaderText = "Costo Premium";
            this.clmCostoPremium.Name = "clmCostoPremium";
            this.clmCostoPremium.ReadOnly = true;
            this.clmCostoPremium.Width = 113;
            // 
            // clmCruceroMatriculaNombre
            // 
            this.clmCruceroMatriculaNombre.DataPropertyName = "CruceroMatriculaNombre";
            this.clmCruceroMatriculaNombre.HeaderText = "Crucero";
            this.clmCruceroMatriculaNombre.Name = "clmCruceroMatriculaNombre";
            this.clmCruceroMatriculaNombre.ReadOnly = true;
            // 
            // FrmViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 427);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dtgViajes);
            this.Name = "FrmViajes";
            this.Text = "Viajes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgViajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgViajes;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdentificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTicketsVendidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTicketsVendidosMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCiudadPaisPartida;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCiudadPaisDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDuracionViaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipoViaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCostoTurista;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCostoPremium;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCruceroMatriculaNombre;
    }
}