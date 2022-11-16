
namespace Crucero.WINFORMS
{
    partial class FrmTickets
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
            this.dtgTickets = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.clmIdentificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmViajeIdentificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPasajeroDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCiudadPaisPartida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCiudadPaisDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipoViaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCruceroMatriculaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCamaroteOcupacionTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgTickets
            // 
            this.dtgTickets.AllowUserToAddRows = false;
            this.dtgTickets.AllowUserToDeleteRows = false;
            this.dtgTickets.AllowUserToOrderColumns = true;
            this.dtgTickets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdentificador,
            this.clmViajeIdentificador,
            this.clmPasajeroDetalle,
            this.clmCiudadPaisPartida,
            this.clmCiudadPaisDestino,
            this.clmFecha,
            this.clmDuracion,
            this.clmTipoViaje,
            this.clmCruceroMatriculaNombre,
            this.clmCamaroteOcupacionTipo,
            this.clmCosto});
            this.dtgTickets.Location = new System.Drawing.Point(12, 41);
            this.dtgTickets.MultiSelect = false;
            this.dtgTickets.Name = "dtgTickets";
            this.dtgTickets.ReadOnly = true;
            this.dtgTickets.RowHeadersVisible = false;
            this.dtgTickets.RowTemplate.Height = 25;
            this.dtgTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTickets.Size = new System.Drawing.Size(1463, 374);
            this.dtgTickets.TabIndex = 0;
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
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(174, 12);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 3;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
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
            this.clmIdentificador.HeaderText = "Ticket";
            this.clmIdentificador.Name = "clmIdentificador";
            this.clmIdentificador.ReadOnly = true;
            // 
            // clmViajeIdentificador
            // 
            this.clmViajeIdentificador.DataPropertyName = "ViajeIdentificador";
            this.clmViajeIdentificador.HeaderText = "Viaje";
            this.clmViajeIdentificador.Name = "clmViajeIdentificador";
            this.clmViajeIdentificador.ReadOnly = true;
            // 
            // clmPasajeroDetalle
            // 
            this.clmPasajeroDetalle.DataPropertyName = "PasajeroDetalle";
            this.clmPasajeroDetalle.FillWeight = 200F;
            this.clmPasajeroDetalle.HeaderText = "Pasajero";
            this.clmPasajeroDetalle.Name = "clmPasajeroDetalle";
            this.clmPasajeroDetalle.ReadOnly = true;
            this.clmPasajeroDetalle.Width = 200;
            // 
            // clmCiudadPaisPartida
            // 
            this.clmCiudadPaisPartida.DataPropertyName = "CiudadPaisPartida";
            this.clmCiudadPaisPartida.FillWeight = 180F;
            this.clmCiudadPaisPartida.HeaderText = "Partida";
            this.clmCiudadPaisPartida.Name = "clmCiudadPaisPartida";
            this.clmCiudadPaisPartida.ReadOnly = true;
            this.clmCiudadPaisPartida.Width = 180;
            // 
            // clmCiudadPaisDestino
            // 
            this.clmCiudadPaisDestino.DataPropertyName = "CiudadPaisDestino";
            this.clmCiudadPaisDestino.FillWeight = 180F;
            this.clmCiudadPaisDestino.HeaderText = "Destino";
            this.clmCiudadPaisDestino.Name = "clmCiudadPaisDestino";
            this.clmCiudadPaisDestino.ReadOnly = true;
            this.clmCiudadPaisDestino.Width = 180;
            // 
            // clmFecha
            // 
            this.clmFecha.DataPropertyName = "Fecha";
            this.clmFecha.HeaderText = "Fecha";
            this.clmFecha.Name = "clmFecha";
            this.clmFecha.ReadOnly = true;
            // 
            // clmDuracion
            // 
            this.clmDuracion.DataPropertyName = "Duracion";
            this.clmDuracion.HeaderText = "Duracion";
            this.clmDuracion.Name = "clmDuracion";
            this.clmDuracion.ReadOnly = true;
            // 
            // clmTipoViaje
            // 
            this.clmTipoViaje.DataPropertyName = "TipoViaje";
            this.clmTipoViaje.HeaderText = "Tipo Viaje";
            this.clmTipoViaje.Name = "clmTipoViaje";
            this.clmTipoViaje.ReadOnly = true;
            // 
            // clmCruceroMatriculaNombre
            // 
            this.clmCruceroMatriculaNombre.DataPropertyName = "CruceroMatriculaNombre";
            this.clmCruceroMatriculaNombre.FillWeight = 120F;
            this.clmCruceroMatriculaNombre.HeaderText = "Crucero";
            this.clmCruceroMatriculaNombre.Name = "clmCruceroMatriculaNombre";
            this.clmCruceroMatriculaNombre.ReadOnly = true;
            this.clmCruceroMatriculaNombre.Width = 120;
            // 
            // clmCamaroteOcupacionTipo
            // 
            this.clmCamaroteOcupacionTipo.DataPropertyName = "CamaroteOcupacionTipo";
            this.clmCamaroteOcupacionTipo.HeaderText = "Camarote";
            this.clmCamaroteOcupacionTipo.Name = "clmCamaroteOcupacionTipo";
            this.clmCamaroteOcupacionTipo.ReadOnly = true;
            // 
            // clmCosto
            // 
            this.clmCosto.DataPropertyName = "Costo";
            this.clmCosto.HeaderText = "Costo";
            this.clmCosto.Name = "clmCosto";
            this.clmCosto.ReadOnly = true;
            // 
            // FrmTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 427);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dtgTickets);
            this.Name = "FrmTickets";
            this.Text = "Tickets";
            ((System.ComponentModel.ISupportInitialize)(this.dtgTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgTickets;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdentificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmViajeIdentificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPasajeroDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCiudadPaisPartida;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCiudadPaisDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDuracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipoViaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCruceroMatriculaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCamaroteOcupacionTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCosto;
    }
}