namespace LP2Rest
{
    partial class frmRecepcionista
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
            this.lblTitulo = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnMesas = new System.Windows.Forms.Button();
            this.lblAsistencia = new System.Windows.Forms.Label();
            this.pbAsistencia = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.imgCompras = new System.Windows.Forms.PictureBox();
            this.imgUsuarios = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.lblTitulo.FlatAppearance.BorderSize = 0;
            this.lblTitulo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Peru;
            this.lblTitulo.Location = new System.Drawing.Point(189, 96);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(204, 66);
            this.lblTitulo.TabIndex = 45;
            this.lblTitulo.Text = "Sistema de recepciones";
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
            this.btnVentas.Location = new System.Drawing.Point(403, 360);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(120, 30);
            this.btnVentas.TabIndex = 43;
            this.btnVentas.Text = "Reservas";
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
            this.btnMesas.Location = new System.Drawing.Point(179, 360);
            this.btnMesas.Name = "btnMesas";
            this.btnMesas.Size = new System.Drawing.Size(120, 30);
            this.btnMesas.TabIndex = 42;
            this.btnMesas.Text = "Clientes";
            this.btnMesas.UseVisualStyleBackColor = true;
            // 
            // lblAsistencia
            // 
            this.lblAsistencia.AutoSize = true;
            this.lblAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistencia.Location = new System.Drawing.Point(438, 165);
            this.lblAsistencia.Name = "lblAsistencia";
            this.lblAsistencia.Size = new System.Drawing.Size(149, 31);
            this.lblAsistencia.TabIndex = 48;
            this.lblAsistencia.Text = "Asistencia";
            this.lblAsistencia.Click += new System.EventHandler(this.lblAsistencia_Click);
            // 
            // pbAsistencia
            // 
            this.pbAsistencia.Image = global::LP2Rest.Properties.Resources.imgAsistenciaIcon_medium;
            this.pbAsistencia.Location = new System.Drawing.Point(474, 86);
            this.pbAsistencia.Name = "pbAsistencia";
            this.pbAsistencia.Size = new System.Drawing.Size(84, 76);
            this.pbAsistencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAsistencia.TabIndex = 47;
            this.pbAsistencia.TabStop = false;
            this.pbAsistencia.Click += new System.EventHandler(this.pbAsistencia_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSalir.Image = global::LP2Rest.Properties.Resources.retroceder_salir;
            this.btnSalir.Location = new System.Drawing.Point(599, 98);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(118, 64);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 46;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::LP2Rest.Properties.Resources.LogoCrema;
            this.pictureBox9.Location = new System.Drawing.Point(101, 89);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(82, 79);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 41;
            this.pictureBox9.TabStop = false;
            // 
            // imgCompras
            // 
            this.imgCompras.Image = global::LP2Rest.Properties.Resources._2636428;
            this.imgCompras.Location = new System.Drawing.Point(410, 246);
            this.imgCompras.Name = "imgCompras";
            this.imgCompras.Size = new System.Drawing.Size(103, 108);
            this.imgCompras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCompras.TabIndex = 39;
            this.imgCompras.TabStop = false;
            this.imgCompras.Click += new System.EventHandler(this.imgCompras_Click);
            // 
            // imgUsuarios
            // 
            this.imgUsuarios.Image = global::LP2Rest.Properties.Resources.imgUsuarioIcon_medium;
            this.imgUsuarios.Location = new System.Drawing.Point(189, 246);
            this.imgUsuarios.Name = "imgUsuarios";
            this.imgUsuarios.Size = new System.Drawing.Size(103, 108);
            this.imgUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUsuarios.TabIndex = 38;
            this.imgUsuarios.TabStop = false;
            this.imgUsuarios.Click += new System.EventHandler(this.imgUsuarios_Click);
            // 
            // frmRecepcionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 492);
            this.Controls.Add(this.lblAsistencia);
            this.Controls.Add(this.pbAsistencia);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnMesas);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.imgCompras);
            this.Controls.Add(this.imgUsuarios);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRecepcionista";
            this.Text = "frmRecepcionista";
            ((System.ComponentModel.ISupportInitialize)(this.pbAsistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Button lblTitulo;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnMesas;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox imgCompras;
        private System.Windows.Forms.PictureBox imgUsuarios;
        private System.Windows.Forms.Label lblAsistencia;
        private System.Windows.Forms.PictureBox pbAsistencia;
    }
}