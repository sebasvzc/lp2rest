namespace LP2Rest
{
    partial class frmCajero
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
            this.lblAsistencia = new System.Windows.Forms.Label();
            this.btnAsistencia = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnMesas = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.imgCompras = new System.Windows.Forms.PictureBox();
            this.imgUsuarios = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAsistencia
            // 
            this.lblAsistencia.AutoSize = true;
            this.lblAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistencia.Location = new System.Drawing.Point(675, 133);
            this.lblAsistencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsistencia.Name = "lblAsistencia";
            this.lblAsistencia.Size = new System.Drawing.Size(149, 31);
            this.lblAsistencia.TabIndex = 49;
            this.lblAsistencia.Text = "Asistencia";
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.Image = global::LP2Rest.Properties.Resources.asistencia;
            this.btnAsistencia.Location = new System.Drawing.Point(708, 32);
            this.btnAsistencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(80, 79);
            this.btnAsistencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAsistencia.TabIndex = 48;
            this.btnAsistencia.TabStop = false;
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSalir.Image = global::LP2Rest.Properties.Resources.retroceder_salir;
            this.btnSalir.Location = new System.Drawing.Point(850, 32);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(157, 79);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 47;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.lblTitulo.FlatAppearance.BorderSize = 0;
            this.lblTitulo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Peru;
            this.lblTitulo.Location = new System.Drawing.Point(257, 53);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(272, 81);
            this.lblTitulo.TabIndex = 46;
            this.lblTitulo.Text = "Sistema de caja";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.UseVisualStyleBackColor = true;
            // 
            // btnVentas
            // 
            this.btnVentas.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.Black;
            this.btnVentas.Location = new System.Drawing.Point(572, 351);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(4);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(160, 37);
            this.btnVentas.TabIndex = 44;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            // 
            // btnMesas
            // 
            this.btnMesas.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMesas.FlatAppearance.BorderSize = 0;
            this.btnMesas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesas.ForeColor = System.Drawing.Color.Black;
            this.btnMesas.Location = new System.Drawing.Point(274, 351);
            this.btnMesas.Margin = new System.Windows.Forms.Padding(4);
            this.btnMesas.Name = "btnMesas";
            this.btnMesas.Size = new System.Drawing.Size(160, 37);
            this.btnMesas.TabIndex = 43;
            this.btnMesas.Text = "Mesas";
            this.btnMesas.UseVisualStyleBackColor = true;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::LP2Rest.Properties.Resources.LogoCrema;
            this.pictureBox9.Location = new System.Drawing.Point(139, 45);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(109, 97);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 42;
            this.pictureBox9.TabStop = false;
            // 
            // imgCompras
            // 
            this.imgCompras.Image = global::LP2Rest.Properties.Resources.imgReportesIcon_medium;
            this.imgCompras.Location = new System.Drawing.Point(581, 211);
            this.imgCompras.Margin = new System.Windows.Forms.Padding(4);
            this.imgCompras.Name = "imgCompras";
            this.imgCompras.Size = new System.Drawing.Size(137, 133);
            this.imgCompras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCompras.TabIndex = 40;
            this.imgCompras.TabStop = false;
            this.imgCompras.Click += new System.EventHandler(this.imgCompras_Click);
            // 
            // imgUsuarios
            // 
            this.imgUsuarios.Image = global::LP2Rest.Properties.Resources.pngegg__1_;
            this.imgUsuarios.Location = new System.Drawing.Point(286, 211);
            this.imgUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.imgUsuarios.Name = "imgUsuarios";
            this.imgUsuarios.Size = new System.Drawing.Size(137, 133);
            this.imgUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUsuarios.TabIndex = 39;
            this.imgUsuarios.TabStop = false;
            this.imgUsuarios.Click += new System.EventHandler(this.imgUsuarios_Click);
            // 
            // frmCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 503);
            this.Controls.Add(this.lblAsistencia);
            this.Controls.Add(this.btnAsistencia);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnMesas);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.imgCompras);
            this.Controls.Add(this.imgUsuarios);
            this.Name = "frmCajero";
            this.Text = "frmCajero";
            ((System.ComponentModel.ISupportInitialize)(this.btnAsistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAsistencia;
        private System.Windows.Forms.PictureBox btnAsistencia;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Button lblTitulo;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnMesas;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox imgCompras;
        private System.Windows.Forms.PictureBox imgUsuarios;
    }
}