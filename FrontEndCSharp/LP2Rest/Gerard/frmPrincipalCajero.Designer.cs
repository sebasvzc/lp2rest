namespace LP2Rest
{
    partial class frmPrincipalCajero
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
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sdbtnMesas = new System.Windows.Forms.Button();
            this.sdbtnReportes = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnMarcarSalida = new System.Windows.Forms.Button();
            this.btnMarcarAsistencia = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(153)))), ((int)(((byte)(96)))));
            this.panelIzquierdo.Controls.Add(this.panel4);
            this.panelIzquierdo.Controls.Add(this.sdbtnMesas);
            this.panelIzquierdo.Controls.Add(this.sdbtnReportes);
            this.panelIzquierdo.Controls.Add(this.pbLogo);
            this.panelIzquierdo.Controls.Add(this.btnCerrarSesion);
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(256, 876);
            this.panelIzquierdo.TabIndex = 50;
            this.panelIzquierdo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelIzquierdo_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 819);
            this.panel4.TabIndex = 17;
            // 
            // sdbtnMesas
            // 
            this.sdbtnMesas.FlatAppearance.BorderSize = 0;
            this.sdbtnMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sdbtnMesas.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.sdbtnMesas.Image = global::LP2Rest.Properties.Resources.imgMesas42x42;
            this.sdbtnMesas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sdbtnMesas.Location = new System.Drawing.Point(9, 153);
            this.sdbtnMesas.Name = "sdbtnMesas";
            this.sdbtnMesas.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.sdbtnMesas.Size = new System.Drawing.Size(257, 59);
            this.sdbtnMesas.TabIndex = 44;
            this.sdbtnMesas.Text = "  Mesas";
            this.sdbtnMesas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sdbtnMesas.UseVisualStyleBackColor = true;
            this.sdbtnMesas.Click += new System.EventHandler(this.sdbtnMesas_Click);
            // 
            // sdbtnReportes
            // 
            this.sdbtnReportes.FlatAppearance.BorderSize = 0;
            this.sdbtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sdbtnReportes.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.sdbtnReportes.Image = global::LP2Rest.Properties.Resources.imgReportesIcon_small;
            this.sdbtnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sdbtnReportes.Location = new System.Drawing.Point(3, 232);
            this.sdbtnReportes.Name = "sdbtnReportes";
            this.sdbtnReportes.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.sdbtnReportes.Size = new System.Drawing.Size(294, 59);
            this.sdbtnReportes.TabIndex = 39;
            this.sdbtnReportes.Text = "  Reportes";
            this.sdbtnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sdbtnReportes.UseVisualStyleBackColor = true;
            this.sdbtnReportes.Click += new System.EventHandler(this.sdbtnReportes_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::LP2Rest.Properties.Resources.imgRestauranteLogo_medium;
            this.pbLogo.Location = new System.Drawing.Point(82, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(86, 86);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 8;
            this.pbLogo.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Black;
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCerrarSesion.Image = global::LP2Rest.Properties.Resources._429524_200;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 819);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(256, 57);
            this.btnCerrarSesion.TabIndex = 32;
            this.btnCerrarSesion.Text = "  Cerrar\r\n  Sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(153)))));
            this.panelSuperior.Controls.Add(this.btnMarcarSalida);
            this.panelSuperior.Controls.Add(this.btnMarcarAsistencia);
            this.panelSuperior.Controls.Add(this.lblID);
            this.panelSuperior.Controls.Add(this.label1);
            this.panelSuperior.Controls.Add(this.btnCerrar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(256, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1100, 100);
            this.panelSuperior.TabIndex = 51;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // btnMarcarSalida
            // 
            this.btnMarcarSalida.Enabled = false;
            this.btnMarcarSalida.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.btnMarcarSalida.FlatAppearance.BorderSize = 0;
            this.btnMarcarSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcarSalida.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.btnMarcarSalida.Image = global::LP2Rest.Properties.Resources.imgAsistenciaIcon_small;
            this.btnMarcarSalida.Location = new System.Drawing.Point(253, 18);
            this.btnMarcarSalida.Name = "btnMarcarSalida";
            this.btnMarcarSalida.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMarcarSalida.Size = new System.Drawing.Size(201, 65);
            this.btnMarcarSalida.TabIndex = 47;
            this.btnMarcarSalida.Text = "  Marcar\r\n  Salida";
            this.btnMarcarSalida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarcarSalida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMarcarSalida.UseVisualStyleBackColor = true;
            this.btnMarcarSalida.Click += new System.EventHandler(this.btnMarcarSalida_Click);
            // 
            // btnMarcarAsistencia
            // 
            this.btnMarcarAsistencia.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.btnMarcarAsistencia.FlatAppearance.BorderSize = 0;
            this.btnMarcarAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcarAsistencia.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.btnMarcarAsistencia.Image = global::LP2Rest.Properties.Resources.imgAsistenciaIcon_small;
            this.btnMarcarAsistencia.Location = new System.Drawing.Point(460, 18);
            this.btnMarcarAsistencia.Name = "btnMarcarAsistencia";
            this.btnMarcarAsistencia.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMarcarAsistencia.Size = new System.Drawing.Size(201, 65);
            this.btnMarcarAsistencia.TabIndex = 46;
            this.btnMarcarAsistencia.Text = "  Marcar\r\n  Asistencia";
            this.btnMarcarAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarcarAsistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMarcarAsistencia.UseVisualStyleBackColor = true;
            this.btnMarcarAsistencia.Click += new System.EventHandler(this.btnMarcarAsistencia_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lblID.ForeColor = System.Drawing.Color.Coral;
            this.lblID.Location = new System.Drawing.Point(827, 38);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(113, 24);
            this.lblID.TabIndex = 45;
            this.lblID.Text = "Cajero #x";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 45F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(103)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 60);
            this.label1.TabIndex = 26;
            this.label1.Text = "INICIO";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = global::LP2Rest.Properties.Resources.imgCerrarIcon_Medium;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(1058, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.TabIndex = 26;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.Window;
            this.panelContenedor.Controls.Add(this.panel5);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(256, 100);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1100, 776);
            this.panelContenedor.TabIndex = 52;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(153)))), ((int)(((byte)(96)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1100, 4);
            this.panel5.TabIndex = 25;
            // 
            // frmPrincipalCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 876);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPrincipalCajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCajero";
            this.panelIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button sdbtnReportes;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button sdbtnMesas;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnMarcarSalida;
        private System.Windows.Forms.Button btnMarcarAsistencia;
    }
}