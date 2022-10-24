
namespace Crucero.WINFORMS
{
    partial class FrmCiudades
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
            this.dtgCiudades = new System.Windows.Forms.DataGridView();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPaisTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCiudades)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCiudades
            // 
            this.dtgCiudades.AllowUserToAddRows = false;
            this.dtgCiudades.AllowUserToDeleteRows = false;
            this.dtgCiudades.AllowUserToOrderColumns = true;
            this.dtgCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCiudades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNombre,
            this.clmPais,
            this.clmPaisTipo});
            this.dtgCiudades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgCiudades.Location = new System.Drawing.Point(0, 0);
            this.dtgCiudades.Name = "dtgCiudades";
            this.dtgCiudades.ReadOnly = true;
            this.dtgCiudades.RowHeadersVisible = false;
            this.dtgCiudades.RowTemplate.Height = 25;
            this.dtgCiudades.Size = new System.Drawing.Size(410, 450);
            this.dtgCiudades.TabIndex = 0;
            // 
            // clmNombre
            // 
            this.clmNombre.DataPropertyName = "Nombre";
            this.clmNombre.FillWeight = 150F;
            this.clmNombre.HeaderText = "Ciudad";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            this.clmNombre.Width = 150;
            // 
            // clmPais
            // 
            this.clmPais.DataPropertyName = "PaisNombre";
            this.clmPais.FillWeight = 150F;
            this.clmPais.HeaderText = "Pais";
            this.clmPais.Name = "clmPais";
            this.clmPais.ReadOnly = true;
            this.clmPais.Width = 150;
            // 
            // clmPaisTipo
            // 
            this.clmPaisTipo.DataPropertyName = "PaisTipo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmPaisTipo.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmPaisTipo.FillWeight = 90F;
            this.clmPaisTipo.HeaderText = "Tipo País";
            this.clmPaisTipo.Name = "clmPaisTipo";
            this.clmPaisTipo.ReadOnly = true;
            this.clmPaisTipo.Width = 90;
            // 
            // FrmCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 450);
            this.Controls.Add(this.dtgCiudades);
            this.Name = "FrmCiudades";
            this.Text = "Ciudades";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCiudades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCiudades;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPaisTipo;
    }
}