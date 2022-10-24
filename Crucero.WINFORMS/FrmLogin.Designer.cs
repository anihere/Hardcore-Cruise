
namespace Crucero.WINFORMS
{
    partial class FrmLogin
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(12, 12);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderText = "Usuario";
            this.txtUsuario.Size = new System.Drawing.Size(240, 23);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Text = "Barbara";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(12, 41);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.PlaceholderText = "Clave";
            this.txtClave.Size = new System.Drawing.Size(240, 23);
            this.txtClave.TabIndex = 1;
            this.txtClave.Text = "123";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(92, 67);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(81, 15);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "ERROR LOGIN";
            this.lblError.Visible = false;
            // 
            // btnAcceder
            // 
            this.btnAcceder.Location = new System.Drawing.Point(12, 85);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(240, 34);
            this.btnAcceder.TabIndex = 3;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 131);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(280, 170);
            this.MinimumSize = new System.Drawing.Size(280, 170);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnAcceder;
    }
}