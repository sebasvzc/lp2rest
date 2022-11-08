namespace LP2Rest
{
    partial class frmInicioChef
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblInsumos = new System.Windows.Forms.Label();
            this.lblSolicitudCompras = new System.Windows.Forms.Label();
            this.pbSolicitudCompras = new System.Windows.Forms.PictureBox();
            this.pbInsumos = new System.Windows.Forms.PictureBox();
            this.pbPlatos = new System.Windows.Forms.PictureBox();
            this.pbAsistencia = new System.Windows.Forms.PictureBox();
            this.lblAsistencia = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbVolver = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.pbSalida = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSolicitudCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInsumos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 383);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Platos";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblInsumos
            // 
            this.lblInsumos.AutoSize = true;
            this.lblInsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsumos.Location = new System.Drawing.Point(429, 383);
            this.lblInsumos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInsumos.Name = "lblInsumos";
            this.lblInsumos.Size = new System.Drawing.Size(134, 36);
            this.lblInsumos.TabIndex = 7;
            this.lblInsumos.Text = "Insumos";
            this.lblInsumos.Click += new System.EventHandler(this.lblInsumos_Click);
            // 
            // lblSolicitudCompras
            // 
            this.lblSolicitudCompras.AutoSize = true;
            this.lblSolicitudCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitudCompras.Location = new System.Drawing.Point(636, 383);
            this.lblSolicitudCompras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSolicitudCompras.Name = "lblSolicitudCompras";
            this.lblSolicitudCompras.Size = new System.Drawing.Size(322, 36);
            this.lblSolicitudCompras.TabIndex = 8;
            this.lblSolicitudCompras.Text = "Solicitud De Compras";
            // 
            // pbSolicitudCompras
            // 
            this.pbSolicitudCompras.Image = global::LP2Rest.Properties.Resources.imgReportesIcon_medium;
            this.pbSolicitudCompras.Location = new System.Drawing.Point(731, 240);
            this.pbSolicitudCompras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbSolicitudCompras.Name = "pbSolicitudCompras";
            this.pbSolicitudCompras.Size = new System.Drawing.Size(156, 119);
            this.pbSolicitudCompras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSolicitudCompras.TabIndex = 6;
            this.pbSolicitudCompras.TabStop = false;
            this.pbSolicitudCompras.Click += new System.EventHandler(this.pbSolicitudCompras_Click);
            // 
            // pbInsumos
            // 
            this.pbInsumos.Image = global::LP2Rest.Properties.Resources.imgInsumosIcon_medium;
            this.pbInsumos.Location = new System.Drawing.Point(420, 240);
            this.pbInsumos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbInsumos.Name = "pbInsumos";
            this.pbInsumos.Size = new System.Drawing.Size(156, 119);
            this.pbInsumos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInsumos.TabIndex = 5;
            this.pbInsumos.TabStop = false;
            this.pbInsumos.Click += new System.EventHandler(this.pbInsumos_Click);
            // 
            // pbPlatos
            // 
            this.pbPlatos.Image = global::LP2Rest.Properties.Resources.imgPlatosIcon_medium;
            this.pbPlatos.Location = new System.Drawing.Point(149, 240);
            this.pbPlatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbPlatos.Name = "pbPlatos";
            this.pbPlatos.Size = new System.Drawing.Size(156, 119);
            this.pbPlatos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlatos.TabIndex = 3;
            this.pbPlatos.TabStop = false;
            this.pbPlatos.Click += new System.EventHandler(this.pbPlatos_Click);
            // 
            // pbAsistencia
            // 
            this.pbAsistencia.Image = global::LP2Rest.Properties.Resources.imgAsistenciaIcon_medium;
            this.pbAsistencia.Location = new System.Drawing.Point(568, 53);
            this.pbAsistencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbAsistencia.Name = "pbAsistencia";
            this.pbAsistencia.Size = new System.Drawing.Size(112, 94);
            this.pbAsistencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAsistencia.TabIndex = 9;
            this.pbAsistencia.TabStop = false;
            this.pbAsistencia.Click += new System.EventHandler(this.pbAsistencia_Click);
            // 
            // lblAsistencia
            // 
            this.lblAsistencia.AutoSize = true;
            this.lblAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistencia.Location = new System.Drawing.Point(520, 150);
            this.lblAsistencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsistencia.Name = "lblAsistencia";
            this.lblAsistencia.Size = new System.Drawing.Size(183, 39);
            this.lblAsistencia.TabIndex = 10;
            this.lblAsistencia.Text = "Asistencia";
            this.lblAsistencia.Click += new System.EventHandler(this.lblAsistencia_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::LP2Rest.Properties.Resources.imgRestauranteLogo_big_strongerColor;
            this.pbLogo.Location = new System.Drawing.Point(149, 32);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(153, 135);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 11;
            this.pbLogo.TabStop = false;
            // 
            // pbVolver
            // 
            this.pbVolver.Image = global::LP2Rest.Properties.Resources.retroceder_salir;
            this.pbVolver.Location = new System.Drawing.Point(879, 64);
            this.pbVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbVolver.Name = "pbVolver";
            this.pbVolver.Size = new System.Drawing.Size(133, 103);
            this.pbVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVolver.TabIndex = 12;
            this.pbVolver.TabStop = false;
            this.pbVolver.Click += new System.EventHandler(this.pbVolver_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Olive;
            this.lblTitulo.Location = new System.Drawing.Point(332, 80);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(108, 46);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Chef";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalida.Location = new System.Drawing.Point(711, 150);
            this.lblSalida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(119, 39);
            this.lblSalida.TabIndex = 15;
            this.lblSalida.Text = "Salida";
            this.lblSalida.Click += new System.EventHandler(this.lblSalida_Click);
            // 
            // pbSalida
            // 
            this.pbSalida.Image = global::LP2Rest.Properties.Resources.imgAsistenciaIcon_medium;
            this.pbSalida.Location = new System.Drawing.Point(718, 51);
            this.pbSalida.Margin = new System.Windows.Forms.Padding(4);
            this.pbSalida.Name = "pbSalida";
            this.pbSalida.Size = new System.Drawing.Size(112, 94);
            this.pbSalida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSalida.TabIndex = 14;
            this.pbSalida.TabStop = false;
            // 
            // frmInicioChef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.pbSalida);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pbVolver);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblSolicitudCompras);
            this.Controls.Add(this.lblAsistencia);
            this.Controls.Add(this.pbSolicitudCompras);
            this.Controls.Add(this.pbAsistencia);
            this.Controls.Add(this.pbPlatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInsumos);
            this.Controls.Add(this.pbInsumos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInicioChef";
            this.Text = "Inicio Chef";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSolicitudCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInsumos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAsistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbInsumos;
        private System.Windows.Forms.PictureBox pbSolicitudCompras;
        private System.Windows.Forms.Label lblInsumos;
        private System.Windows.Forms.Label lblSolicitudCompras;
        private System.Windows.Forms.PictureBox pbAsistencia;
        private System.Windows.Forms.Label lblAsistencia;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbVolver;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.PictureBox pbSalida;
    }
}