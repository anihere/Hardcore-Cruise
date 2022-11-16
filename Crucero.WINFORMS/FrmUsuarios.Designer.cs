
namespace Crucero.WINFORMS
{
    partial class FrmUsuarios
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
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.clmUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmClave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.AllowUserToAddRows = false;
            this.dtgUsuarios.AllowUserToDeleteRows = false;
            this.dtgUsuarios.AllowUserToOrderColumns = true;
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmUsuario,
            this.clmClave});
            this.dtgUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.ReadOnly = true;
            this.dtgUsuarios.RowHeadersVisible = false;
            this.dtgUsuarios.RowTemplate.Height = 25;
            this.dtgUsuarios.Size = new System.Drawing.Size(800, 450);
            this.dtgUsuarios.TabIndex = 0;
            // 
            // clmUsuario
            // 
            this.clmUsuario.DataPropertyName = "UsuarioNombre";
            this.clmUsuario.HeaderText = "Usuario";
            this.clmUsuario.Name = "clmUsuario";
            this.clmUsuario.ReadOnly = true;
            // 
            // clmClave
            // 
            this.clmClave.DataPropertyName = "Clave";
            this.clmClave.HeaderText = "Clave";
            this.clmClave.Name = "clmClave";
            this.clmClave.ReadOnly = true;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgUsuarios);
            this.Name = "FrmUsuarios";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClave;
    }
}