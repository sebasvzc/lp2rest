﻿namespace LP2Rest
{
    partial class frmPrincipalA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalA));
            this.Titulo = new System.Windows.Forms.Button();
            this.lblAsistencia = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnReclamos = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnInsumos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEventos = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pbAsistencia = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Titulo.FlatAppearance.BorderSize = 0;
            this.Titulo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titulo.Font = new System.Drawing.Font("MS UI Gothic", 45F, System.Drawing.FontStyle.Bold);
            this.Titulo.ForeColor = System.Drawing.Color.Peru;
            this.Titulo.Location = new System.Drawing.Point(14, 17);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(349, 66);
            this.Titulo.TabIndex = 17;
            this.Titulo.Text = "INICIO";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Titulo.UseVisualStyleBackColor = true;
            // 
            // lblAsistencia
            // 
            this.lblAsistencia.AutoSize = true;
            this.lblAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblAsistencia.Location = new System.Drawing.Point(544, 28);
            this.lblAsistencia.Name = "lblAsistencia";
            this.lblAsistencia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAsistencia.Size = new System.Drawing.Size(105, 48);
            this.lblAsistencia.TabIndex = 19;
            this.lblAsistencia.Text = "Marcar\r\nAsistencia";
            this.lblAsistencia.Click += new System.EventHandler(this.lblAsistencia_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(153)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 643);
            this.panel1.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 643);
            this.panel4.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel2.Controls.Add(this.Titulo);
            this.panel2.Controls.Add(this.lblAsistencia);
            this.panel2.Controls.Add(this.pictureBox9);
            this.panel2.Controls.Add(this.pbAsistencia);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(106, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(842, 100);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FloralWhite;
            this.panel3.Controls.Add(this.btnReportes);
            this.panel3.Controls.Add(this.btnReclamos);
            this.panel3.Controls.Add(this.btnVentas);
            this.panel3.Controls.Add(this.btnInsumos);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnEventos);
            this.panel3.Controls.Add(this.btnCompra);
            this.panel3.Controls.Add(this.btnUsuario);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.panel3.Location = new System.Drawing.Point(106, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(842, 543);
            this.panel3.TabIndex = 22;
            // 
            // btnReportes
            // 
            this.btnReportes.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Image = global::LP2Rest.Properties.Resources._1760560;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReportes.Location = new System.Drawing.Point(620, 59);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(150, 174);
            this.btnReportes.TabIndex = 24;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnReclamos
            // 
            this.btnReclamos.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.btnReclamos.FlatAppearance.BorderSize = 0;
            this.btnReclamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReclamos.Image = global::LP2Rest.Properties.Resources._115801;
            this.btnReclamos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReclamos.Location = new System.Drawing.Point(439, 265);
            this.btnReclamos.Name = "btnReclamos";
            this.btnReclamos.Size = new System.Drawing.Size(150, 174);
            this.btnReclamos.TabIndex = 23;
            this.btnReclamos.Text = "Reclamos";
            this.btnReclamos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReclamos.UseVisualStyleBackColor = true;
            this.btnReclamos.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Image = global::LP2Rest.Properties.Resources._1236928;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVentas.Location = new System.Drawing.Point(257, 59);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(150, 174);
            this.btnVentas.TabIndex = 22;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnInsumos
            // 
            this.btnInsumos.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.btnInsumos.FlatAppearance.BorderSize = 0;
            this.btnInsumos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsumos.Image = global::LP2Rest.Properties.Resources._933310;
            this.btnInsumos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInsumos.Location = new System.Drawing.Point(75, 265);
            this.btnInsumos.Name = "btnInsumos";
            this.btnInsumos.Size = new System.Drawing.Size(150, 174);
            this.btnInsumos.TabIndex = 21;
            this.btnInsumos.Text = "Insumos";
            this.btnInsumos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInsumos.UseVisualStyleBackColor = true;
            this.btnInsumos.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::LP2Rest.Properties.Resources._98017;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(620, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 174);
            this.button1.TabIndex = 20;
            this.button1.Text = "Platos";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnEventos
            // 
            this.btnEventos.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.btnEventos.FlatAppearance.BorderSize = 0;
            this.btnEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventos.Image = global::LP2Rest.Properties.Resources._4296283;
            this.btnEventos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEventos.Location = new System.Drawing.Point(439, 59);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(150, 174);
            this.btnEventos.TabIndex = 19;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEventos.UseVisualStyleBackColor = true;
            this.btnEventos.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnCompra
            // 
            this.btnCompra.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.btnCompra.FlatAppearance.BorderSize = 0;
            this.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompra.Image = global::LP2Rest.Properties.Resources._107831;
            this.btnCompra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompra.Location = new System.Drawing.Point(257, 265);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(150, 174);
            this.btnCompra.TabIndex = 18;
            this.btnCompra.Text = "Compras";
            this.btnCompra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Image = global::LP2Rest.Properties.Resources._16363;
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsuario.Location = new System.Drawing.Point(75, 59);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(150, 174);
            this.btnUsuario.TabIndex = 17;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::LP2Rest.Properties.Resources.Pink_Modern_Monzana_Online_Shop_Logo_500_500_px_1;
            this.pictureBox9.Location = new System.Drawing.Point(767, 12);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(82, 79);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            // 
            // pbAsistencia
            // 
            this.pbAsistencia.Image = ((System.Drawing.Image)(resources.GetObject("pbAsistencia.Image")));
            this.pbAsistencia.Location = new System.Drawing.Point(655, 19);
            this.pbAsistencia.Name = "pbAsistencia";
            this.pbAsistencia.Size = new System.Drawing.Size(61, 64);
            this.pbAsistencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAsistencia.TabIndex = 18;
            this.pbAsistencia.TabStop = false;
            this.pbAsistencia.Click += new System.EventHandler(this.pbAsistencia_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LP2Rest.Properties.Resources._107831;
            this.pictureBox1.InitialImage = global::LP2Rest.Properties.Resources._1236928;
            this.pictureBox1.Location = new System.Drawing.Point(28, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LP2Rest.Properties.Resources._115801;
            this.pictureBox2.InitialImage = global::LP2Rest.Properties.Resources._1236928;
            this.pictureBox2.Location = new System.Drawing.Point(28, 239);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LP2Rest.Properties.Resources._1236928;
            this.pictureBox3.InitialImage = global::LP2Rest.Properties.Resources._1236928;
            this.pictureBox3.Location = new System.Drawing.Point(28, 311);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 53);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::LP2Rest.Properties.Resources._1760560;
            this.pictureBox4.InitialImage = global::LP2Rest.Properties.Resources._1236928;
            this.pictureBox4.Location = new System.Drawing.Point(28, 377);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(54, 53);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::LP2Rest.Properties.Resources._4296283;
            this.pictureBox5.InitialImage = global::LP2Rest.Properties.Resources._1236928;
            this.pictureBox5.Location = new System.Drawing.Point(28, 443);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(54, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 29;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::LP2Rest.Properties.Resources._933310;
            this.pictureBox6.InitialImage = global::LP2Rest.Properties.Resources._1236928;
            this.pictureBox6.Location = new System.Drawing.Point(28, 503);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(54, 53);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 30;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::LP2Rest.Properties.Resources._16363;
            this.pictureBox7.InitialImage = global::LP2Rest.Properties.Resources._1236928;
            this.pictureBox7.Location = new System.Drawing.Point(28, 109);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(54, 53);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 31;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::LP2Rest.Properties.Resources._98017;
            this.pictureBox8.InitialImage = global::LP2Rest.Properties.Resources._1236928;
            this.pictureBox8.Location = new System.Drawing.Point(28, 574);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(54, 51);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 26;
            this.pictureBox8.TabStop = false;
            // 
            // frmPrincipalA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 643);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipalA";
            this.Text = "Administración";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAsistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button Titulo;
        private System.Windows.Forms.Label lblAsistencia;
        private System.Windows.Forms.PictureBox pbAsistencia;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnReclamos;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnInsumos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}