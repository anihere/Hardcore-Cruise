
namespace Crucero.WINFORMS
{
    partial class FrmCentral
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crucerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasajerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ciudadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoPaisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoCiudadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viajesToolStripMenuItem,
            this.crucerosToolStripMenuItem,
            this.pasajerosToolStripMenuItem,
            this.ciudadesToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viajesToolStripMenuItem
            // 
            this.viajesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoToolStripMenuItem,
            this.listadoTicketsToolStripMenuItem});
            this.viajesToolStripMenuItem.Name = "viajesToolStripMenuItem";
            this.viajesToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.viajesToolStripMenuItem.Text = "Viajes";
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listadoToolStripMenuItem.Text = "Listado Viajes";
            this.listadoToolStripMenuItem.Click += new System.EventHandler(this.ListadoViajes);
            // 
            // listadoTicketsToolStripMenuItem
            // 
            this.listadoTicketsToolStripMenuItem.Name = "listadoTicketsToolStripMenuItem";
            this.listadoTicketsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listadoTicketsToolStripMenuItem.Text = "Listado Tickets";
            this.listadoTicketsToolStripMenuItem.Click += new System.EventHandler(this.ListadoTickets);
            // 
            // crucerosToolStripMenuItem
            // 
            this.crucerosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoToolStripMenuItem1});
            this.crucerosToolStripMenuItem.Name = "crucerosToolStripMenuItem";
            this.crucerosToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.crucerosToolStripMenuItem.Text = "Pasajeros";
            // 
            // listadoToolStripMenuItem1
            // 
            this.listadoToolStripMenuItem1.Name = "listadoToolStripMenuItem1";
            this.listadoToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.listadoToolStripMenuItem1.Text = "Listado Pasajeros";
            this.listadoToolStripMenuItem1.Click += new System.EventHandler(this.ListadoPasajeros);
            // 
            // pasajerosToolStripMenuItem
            // 
            this.pasajerosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoToolStripMenuItem3});
            this.pasajerosToolStripMenuItem.Name = "pasajerosToolStripMenuItem";
            this.pasajerosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.pasajerosToolStripMenuItem.Text = "Cruceros";
            // 
            // listadoToolStripMenuItem3
            // 
            this.listadoToolStripMenuItem3.Name = "listadoToolStripMenuItem3";
            this.listadoToolStripMenuItem3.Size = new System.Drawing.Size(162, 22);
            this.listadoToolStripMenuItem3.Text = "Listado Cruceros";
            this.listadoToolStripMenuItem3.Click += new System.EventHandler(this.ListadoCruceros);
            // 
            // ciudadesToolStripMenuItem
            // 
            this.ciudadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoPaisesToolStripMenuItem,
            this.listadoCiudadesToolStripMenuItem});
            this.ciudadesToolStripMenuItem.Name = "ciudadesToolStripMenuItem";
            this.ciudadesToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.ciudadesToolStripMenuItem.Text = "Ciudades y Paises";
            // 
            // listadoPaisesToolStripMenuItem
            // 
            this.listadoPaisesToolStripMenuItem.Name = "listadoPaisesToolStripMenuItem";
            this.listadoPaisesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.listadoPaisesToolStripMenuItem.Text = "Listado Paises";
            this.listadoPaisesToolStripMenuItem.Click += new System.EventHandler(this.ListadoPaises);
            // 
            // listadoCiudadesToolStripMenuItem
            // 
            this.listadoCiudadesToolStripMenuItem.Name = "listadoCiudadesToolStripMenuItem";
            this.listadoCiudadesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.listadoCiudadesToolStripMenuItem.Text = "Listado Ciudades";
            this.listadoCiudadesToolStripMenuItem.Click += new System.EventHandler(this.ListadoCiudades);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoToolStripMenuItem2});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // listadoToolStripMenuItem2
            // 
            this.listadoToolStripMenuItem2.Name = "listadoToolStripMenuItem2";
            this.listadoToolStripMenuItem2.Size = new System.Drawing.Size(160, 22);
            this.listadoToolStripMenuItem2.Text = "Listado Usuarios";
            this.listadoToolStripMenuItem2.Click += new System.EventHandler(this.ListadoUsuarios);
            // 
            // FrmCentral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmCentral";
            this.Text = "Central";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viajesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crucerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasajerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciudadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listadoPaisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoCiudadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem listadoTicketsToolStripMenuItem;
    }
}