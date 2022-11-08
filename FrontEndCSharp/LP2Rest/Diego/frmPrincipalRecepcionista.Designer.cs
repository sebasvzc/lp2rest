namespace LP2Rest
{
    partial class frmPrincipalRecepcionista
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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnMarcarSalida = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnMarcarAsistencia = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sdbtnReclamos = new System.Windows.Forms.Button();
            this.sdbtnReservas = new System.Windows.Forms.Button();
            this.sdbtnClientes = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panelContenedor.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.panelIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.Window;
            this.panelContenedor.Controls.Add(this.panel5);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(341, 123);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1467, 955);
            this.panelContenedor.TabIndex = 56;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(153)))), ((int)(((byte)(96)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1467, 5);
            this.panel5.TabIndex = 25;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(153)))));
            this.panelSuperior.Controls.Add(this.btnMarcarSalida);
            this.panelSuperior.Controls.Add(this.lblID);
            this.panelSuperior.Controls.Add(this.lbltitulo);
            this.panelSuperior.Controls.Add(this.btnMarcarAsistencia);
            this.panelSuperior.Controls.Add(this.btnCerrar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(341, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1467, 123);
            this.panelSuperior.TabIndex = 55;
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
            this.btnMarcarSalida.Location = new System.Drawing.Point(634, 23);
            this.btnMarcarSalida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMarcarSalida.Name = "btnMarcarSalida";
            this.btnMarcarSalida.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnMarcarSalida.Size = new System.Drawing.Size(268, 80);
            this.btnMarcarSalida.TabIndex = 28;
            this.btnMarcarSalida.Text = "  Marcar\r\n  Salida";
            this.btnMarcarSalida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarcarSalida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMarcarSalida.UseVisualStyleBackColor = true;
            this.btnMarcarSalida.Click += new System.EventHandler(this.btnMarcarSalida_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lblID.ForeColor = System.Drawing.Color.Coral;
            this.lblID.Location = new System.Drawing.Point(1064, 54);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(242, 30);
            this.lblID.TabIndex = 27;
            this.lblID.Text = "Recepcionista #x";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltitulo.Font = new System.Drawing.Font("MS UI Gothic", 45F, System.Drawing.FontStyle.Bold);
            this.lbltitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(103)))), ((int)(((byte)(66)))));
            this.lbltitulo.Location = new System.Drawing.Point(31, 28);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(243, 75);
            this.lbltitulo.TabIndex = 26;
            this.lbltitulo.Text = "INICIO";
            // 
            // btnMarcarAsistencia
            // 
            this.btnMarcarAsistencia.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.btnMarcarAsistencia.FlatAppearance.BorderSize = 0;
            this.btnMarcarAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcarAsistencia.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.btnMarcarAsistencia.Image = global::LP2Rest.Properties.Resources.imgAsistenciaIcon_small;
            this.btnMarcarAsistencia.Location = new System.Drawing.Point(358, 23);
            this.btnMarcarAsistencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMarcarAsistencia.Name = "btnMarcarAsistencia";
            this.btnMarcarAsistencia.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnMarcarAsistencia.Size = new System.Drawing.Size(268, 80);
            this.btnMarcarAsistencia.TabIndex = 26;
            this.btnMarcarAsistencia.Text = "  Marcar\r\n  Asistencia";
            this.btnMarcarAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarcarAsistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMarcarAsistencia.UseVisualStyleBackColor = true;
            this.btnMarcarAsistencia.Click += new System.EventHandler(this.btnMarcarAsistencia_Click);
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
            this.btnCerrar.Location = new System.Drawing.Point(1411, 15);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 31);
            this.btnCerrar.TabIndex = 26;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(153)))), ((int)(((byte)(96)))));
            this.panelIzquierdo.Controls.Add(this.panel4);
            this.panelIzquierdo.Controls.Add(this.sdbtnReclamos);
            this.panelIzquierdo.Controls.Add(this.sdbtnReservas);
            this.panelIzquierdo.Controls.Add(this.sdbtnClientes);
            this.panelIzquierdo.Controls.Add(this.pbLogo);
            this.panelIzquierdo.Controls.Add(this.btnCerrarSesion);
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(341, 1078);
            this.panelIzquierdo.TabIndex = 54;
            this.panelIzquierdo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelIzquierdo_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(11, 1008);
            this.panel4.TabIndex = 17;
            // 
            // sdbtnReclamos
            // 
            this.sdbtnReclamos.FlatAppearance.BorderSize = 0;
            this.sdbtnReclamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sdbtnReclamos.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.sdbtnReclamos.Image = global::LP2Rest.Properties.Resources.imgReclamosIcon_small;
            this.sdbtnReclamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sdbtnReclamos.Location = new System.Drawing.Point(0, 374);
            this.sdbtnReclamos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sdbtnReclamos.Name = "sdbtnReclamos";
            this.sdbtnReclamos.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.sdbtnReclamos.Size = new System.Drawing.Size(392, 73);
            this.sdbtnReclamos.TabIndex = 51;
            this.sdbtnReclamos.Text = "  Reclamos";
            this.sdbtnReclamos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sdbtnReclamos.UseVisualStyleBackColor = true;
            this.sdbtnReclamos.Click += new System.EventHandler(this.sdbtnReclamos_Click);
            // 
            // sdbtnReservas
            // 
            this.sdbtnReservas.FlatAppearance.BorderSize = 0;
            this.sdbtnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sdbtnReservas.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.sdbtnReservas.Image = global::LP2Rest.Properties.Resources.imgReservaSmall42x42;
            this.sdbtnReservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sdbtnReservas.Location = new System.Drawing.Point(0, 278);
            this.sdbtnReservas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sdbtnReservas.Name = "sdbtnReservas";
            this.sdbtnReservas.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.sdbtnReservas.Size = new System.Drawing.Size(341, 73);
            this.sdbtnReservas.TabIndex = 50;
            this.sdbtnReservas.Text = "  Reservas";
            this.sdbtnReservas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sdbtnReservas.UseVisualStyleBackColor = true;
            this.sdbtnReservas.Click += new System.EventHandler(this.sdbtnReservas_Click);
            // 
            // sdbtnClientes
            // 
            this.sdbtnClientes.FlatAppearance.BorderSize = 0;
            this.sdbtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sdbtnClientes.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.sdbtnClientes.Image = global::LP2Rest.Properties.Resources.imgUsuarioIcon_small;
            this.sdbtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sdbtnClientes.Location = new System.Drawing.Point(0, 175);
            this.sdbtnClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sdbtnClientes.Name = "sdbtnClientes";
            this.sdbtnClientes.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.sdbtnClientes.Size = new System.Drawing.Size(341, 73);
            this.sdbtnClientes.TabIndex = 33;
            this.sdbtnClientes.Text = "  Clientes";
            this.sdbtnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sdbtnClientes.UseVisualStyleBackColor = true;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::LP2Rest.Properties.Resources.imgRestauranteLogo_medium;
            this.pbLogo.Location = new System.Drawing.Point(109, 15);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(115, 106);
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
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 1008);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(341, 70);
            this.btnCerrarSesion.TabIndex = 32;
            this.btnCerrarSesion.Text = "  Cerrar\r\n  Sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // frmPrincipalRecepcionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1808, 1078);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPrincipalRecepcionista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRecepcionista";
            this.panelContenedor.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Button btnMarcarSalida;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btnMarcarAsistencia;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button sdbtnReservas;
        private System.Windows.Forms.Button sdbtnClientes;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button sdbtnReclamos;
    }
}