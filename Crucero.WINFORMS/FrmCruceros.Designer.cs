
namespace Crucero.WINFORMS
{
    partial class FrmCruceros
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
            this.dtgCruceros = new System.Windows.Forms.DataGridView();
            this.clmMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCasinos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidadCamarotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidadCamarotesTurista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidadCamarotesPremium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCapacidadBodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCruceros)).BeginInit();
            this.SuspendLayout();
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
            this.dtgCruceros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgCruceros.Location = new System.Drawing.Point(0, 0);
            this.dtgCruceros.Name = "dtgCruceros";
            this.dtgCruceros.ReadOnly = true;
            this.dtgCruceros.RowHeadersVisible = false;
            this.dtgCruceros.RowTemplate.Height = 25;
            this.dtgCruceros.Size = new System.Drawing.Size(823, 427);
            this.dtgCruceros.TabIndex = 0;
            // 
            // clmMatricula
            // 
            this.clmMatricula.DataPropertyName = "Matricula";
            this.clmMatricula.HeaderText = "Matricula";
            this.clmMatricula.Name = "clmMatricula";
            this.clmMatricula.ReadOnly = true;
            // 
            // clmNombre
            // 
            this.clmNombre.DataPropertyName = "Nombre";
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmSalones
            // 
            this.clmSalones.DataPropertyName = "Salones";
            this.clmSalones.HeaderText = "Salones";
            this.clmSalones.Name = "clmSalones";
            this.clmSalones.ReadOnly = true;
            // 
            // clmCasinos
            // 
            this.clmCasinos.DataPropertyName = "Casinos";
            this.clmCasinos.HeaderText = "Casinos";
            this.clmCasinos.Name = "clmCasinos";
            this.clmCasinos.ReadOnly = true;
            // 
            // clmCantidadCamarotes
            // 
            this.clmCantidadCamarotes.DataPropertyName = "CantidadCamarotes";
            this.clmCantidadCamarotes.HeaderText = "Camarotes";
            this.clmCantidadCamarotes.Name = "clmCantidadCamarotes";
            this.clmCantidadCamarotes.ReadOnly = true;
            // 
            // clmCantidadCamarotesTurista
            // 
            this.clmCantidadCamarotesTurista.DataPropertyName = "CantidadCamarotesTurista";
            this.clmCantidadCamarotesTurista.HeaderText = "Turista";
            this.clmCantidadCamarotesTurista.Name = "clmCantidadCamarotesTurista";
            this.clmCantidadCamarotesTurista.ReadOnly = true;
            // 
            // clmCantidadCamarotesPremium
            // 
            this.clmCantidadCamarotesPremium.DataPropertyName = "CantidadCamarotesPremium";
            this.clmCantidadCamarotesPremium.HeaderText = "Premium";
            this.clmCantidadCamarotesPremium.Name = "clmCantidadCamarotesPremium";
            this.clmCantidadCamarotesPremium.ReadOnly = true;
            // 
            // clmCapacidadBodega
            // 
            this.clmCapacidadBodega.DataPropertyName = "CapacidadBodega";
            this.clmCapacidadBodega.HeaderText = "Bodega KG";
            this.clmCapacidadBodega.Name = "clmCapacidadBodega";
            this.clmCapacidadBodega.ReadOnly = true;
            // 
            // FrmCruceros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 427);
            this.Controls.Add(this.dtgCruceros);
            this.Name = "FrmCruceros";
            this.Text = "Cruceros";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCruceros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCruceros;
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