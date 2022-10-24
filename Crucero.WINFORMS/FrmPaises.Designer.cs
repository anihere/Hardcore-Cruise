
namespace Crucero.WINFORMS
{
    partial class FrmPaises
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
            this.dtgPaises = new System.Windows.Forms.DataGridView();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPaises)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPaises
            // 
            this.dtgPaises.AllowUserToAddRows = false;
            this.dtgPaises.AllowUserToDeleteRows = false;
            this.dtgPaises.AllowUserToOrderColumns = true;
            this.dtgPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPaises.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNombre});
            this.dtgPaises.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPaises.Location = new System.Drawing.Point(0, 0);
            this.dtgPaises.Name = "dtgPaises";
            this.dtgPaises.ReadOnly = true;
            this.dtgPaises.RowHeadersVisible = false;
            this.dtgPaises.RowTemplate.Height = 25;
            this.dtgPaises.Size = new System.Drawing.Size(203, 450);
            this.dtgPaises.TabIndex = 0;
            // 
            // clmNombre
            // 
            this.clmNombre.DataPropertyName = "Nombre";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmNombre.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmNombre.FillWeight = 200F;
            this.clmNombre.HeaderText = "Pais";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            this.clmNombre.Width = 200;
            // 
            // FrmPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 450);
            this.Controls.Add(this.dtgPaises);
            this.Name = "FrmPaises";
            this.Text = "Paises";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPaises)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPaises;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
    }
}