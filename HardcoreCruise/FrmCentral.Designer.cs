
namespace HardcoreCruise
{
    partial class Central
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Central));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Listadepasajeros = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(194, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Pasajes Sudamericanos";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(18, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(184, 154);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 191);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Pasajes Internacionales";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(6, 20);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(184, 154);
            this.listBox2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox3);
            this.groupBox3.Location = new System.Drawing.Point(377, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 178);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de Cruzeros";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(18, 18);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(184, 154);
            this.listBox3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 71);
            this.button1.TabIndex = 3;
            this.button1.Text = "Venta de Pasajes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_ventaviaje);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(618, 320);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(86, 48);
            this.btn_Cerrar.TabIndex = 4;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // listBox4
            // 
            this.listBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox4.FormattingEnabled = true;
            this.listBox4.HorizontalScrollbar = true;
            this.listBox4.ItemHeight = 15;
            this.listBox4.Location = new System.Drawing.Point(6, 21);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(804, 199);
            this.listBox4.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(241, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 71);
            this.button3.TabIndex = 6;
            this.button3.Text = "Dar de alta viaje";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_altaviaje);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox4);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(831, 225);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Viajes Disponibles";
            // 
            // btn_Listadepasajeros
            // 
            this.btn_Listadepasajeros.Location = new System.Drawing.Point(611, 254);
            this.btn_Listadepasajeros.Name = "btn_Listadepasajeros";
            this.btn_Listadepasajeros.Size = new System.Drawing.Size(93, 47);
            this.btn_Listadepasajeros.TabIndex = 8;
            this.btn_Listadepasajeros.Text = "Lista de Pasajeros";
            this.btn_Listadepasajeros.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listBox2);
            this.groupBox5.Location = new System.Drawing.Point(14, 230);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 178);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listBox1);
            this.groupBox6.Location = new System.Drawing.Point(728, 226);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(215, 182);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // Central
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1213, 420);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btn_Listadepasajeros);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Central";
            this.Text = "Central";
            this.Load += new System.EventHandler(this.Central_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Listadepasajeros;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}