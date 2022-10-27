namespace LP2Rest
{
    partial class frmPrincipalMesero
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
            this.sdbtnUsuarios = new System.Windows.Forms.Button();
            this.sdbtnReclamos = new System.Windows.Forms.Button();
            this.sdbtnMesas = new System.Windows.Forms.Button();
            this.sdbtnPlatos = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.sdbtnVentas = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnMarcarSalida = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnMarcarAsistencia = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelIzquierdo.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(153)))), ((int)(((byte)(96)))));
            this.panelIzquierdo.Controls.Add(this.panel4);
            this.panelIzquierdo.Controls.Add(this.sdbtnUsuarios);
            this.panelIzquierdo.Controls.Add(this.sdbtnReclamos);
            this.panelIzquierdo.Controls.Add(this.sdbtnMesas);
            this.panelIzquierdo.Controls.Add(this.sdbtnPlatos);
            this.panelIzquierdo.Controls.Add(this.pbLogo);
            this.panelIzquierdo.Controls.Add(this.sdbtnVentas);
            this.panelIzquierdo.Controls.Add(this.btnCerrarSesion);
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(341, 1078);
            this.panelIzquierdo.TabIndex = 39;
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
            // sdbtnUsuarios
            // 
            this.sdbtnUsuarios.FlatAppearance.BorderSize = 0;
            this.sdbtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sdbtnUsuarios.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.sdbtnUsuarios.Image = global::LP2Rest.Properties.Resources.imgUsuarioIcon_small;
            this.sdbtnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sdbtnUsuarios.Location = new System.Drawing.Point(1, 463);
            this.sdbtnUsuarios.Name = "sdbtnUsuarios";
            this.sdbtnUsuarios.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.sdbtnUsuarios.Size = new System.Drawing.Size(256, 59);
            this.sdbtnUsuarios.TabIndex = 52;
            this.sdbtnUsuarios.Text = "  Clientes";
            this.sdbtnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sdbtnUsuarios.UseVisualStyleBackColor = true;
            this.sdbtnUsuarios.Click += new System.EventHandler(this.sdbtnUsuarios_Click);
            // 
            // sdbtnReclamos
            // 
            this.sdbtnReclamos.FlatAppearance.BorderSize = 0;
            this.sdbtnReclamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sdbtnReclamos.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.sdbtnReclamos.Image = global::LP2Rest.Properties.Resources.imgReclamosIcon_small;
            this.sdbtnReclamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sdbtnReclamos.Location = new System.Drawing.Point(0, 384);
            this.sdbtnReclamos.Name = "sdbtnReclamos";
            this.sdbtnReclamos.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.sdbtnReclamos.Size = new System.Drawing.Size(256, 59);
            this.sdbtnReclamos.TabIndex = 51;
            this.sdbtnReclamos.Text = "  Reclamos";
            this.sdbtnReclamos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sdbtnReclamos.UseVisualStyleBackColor = true;
            this.sdbtnReclamos.Click += new System.EventHandler(this.sdbtnReclamos_Click);
            // 
            // sdbtnMesas
            // 
            this.sdbtnMesas.FlatAppearance.BorderSize = 0;
            this.sdbtnMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sdbtnMesas.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.sdbtnMesas.Image = global::LP2Rest.Properties.Resources.imgMesas42x42;
            this.sdbtnMesas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.sdbtnMesas.Location = new System.Drawing.Point(4, 279);
            this.sdbtnMesas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sdbtnMesas.Name = "sdbtnMesas";
            this.sdbtnMesas.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.sdbtnMesas.Size = new System.Drawing.Size(343, 73);

            this.sdbtnMesas.TabIndex = 50;
            this.sdbtnMesas.Text = "  Mesas";
            this.sdbtnMesas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sdbtnMesas.UseVisualStyleBackColor = true;
            this.sdbtnMesas.Click += new System.EventHandler(this.sdbtnMesas_Click);
            // 
            // sdbtnPlatos
            // 
            this.sdbtnPlatos.FlatAppearance.BorderSize = 0;
            this.sdbtnPlatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sdbtnPlatos.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.sdbtnPlatos.Image = global::LP2Rest.Properties.Resources.imgPlatosIcon_small;
            this.sdbtnPlatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sdbtnPlatos.Location = new System.Drawing.Point(0, 175);
            this.sdbtnPlatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sdbtnPlatos.Name = "sdbtnPlatos";

            this.sdbtnPlatos.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.sdbtnPlatos.Size = new System.Drawing.Size(392, 73);

            this.sdbtnPlatos.TabIndex = 33;
            this.sdbtnPlatos.Text = "  Platos";
            this.sdbtnPlatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sdbtnPlatos.UseVisualStyleBackColor = true;
            this.sdbtnPlatos.Click += new System.EventHandler(this.sdbtnPlatos_Click);
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
            // sdbtnVentas
            // 
            this.sdbtnVentas.FlatAppearance.BorderSize = 0;
            this.sdbtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sdbtnVentas.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.sdbtnVentas.Image = global::LP2Rest.Properties.Resources.imgVentasIcon_small;
            this.sdbtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sdbtnVentas.Location = new System.Drawing.Point(0, 375);
            this.sdbtnVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sdbtnVentas.Name = "sdbtnVentas";

            this.sdbtnVentas.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.sdbtnVentas.Size = new System.Drawing.Size(392, 73);

            this.sdbtnVentas.TabIndex = 26;
            this.sdbtnVentas.Text = "  Ventas";
            this.sdbtnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sdbtnVentas.UseVisualStyleBackColor = true;
            this.sdbtnVentas.Click += new System.EventHandler(this.sdbtnVentas_Click);
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
            this.panelSuperior.TabIndex = 40;
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
            this.btnMarcarSalida.Location = new System.Drawing.Point(242, 18);
            this.btnMarcarSalida.Name = "btnMarcarSalida";
            this.btnMarcarSalida.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMarcarSalida.Size = new System.Drawing.Size(201, 65);
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
            this.lblID.Size = new System.Drawing.Size(151, 30);
            this.lblID.TabIndex = 27;
            this.lblID.Text = "Mesero #x";
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
            this.btnMarcarAsistencia.Location = new System.Drawing.Point(599, 22);
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

            // btnVentas
            // 
            this.btnVentas.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.btnVentas.Image = global::LP2Rest.Properties.Resources.imgVentasIcon_medium;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVentas.Location = new System.Drawing.Point(1115, 156);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(221, 254);
            this.btnVentas.TabIndex = 46;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVentas.UseVisualStyleBackColor = true;
            // 
            // btnPlatos
            // 
            this.btnPlatos.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.btnPlatos.FlatAppearance.BorderSize = 0;
            this.btnPlatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlatos.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.btnPlatos.Image = global::LP2Rest.Properties.Resources.imgPlatosIcon_medium;
            this.btnPlatos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlatos.Location = new System.Drawing.Point(196, 156);
            this.btnPlatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlatos.Name = "btnPlatos";
            this.btnPlatos.Size = new System.Drawing.Size(221, 254);
            this.btnPlatos.TabIndex = 44;
            this.btnPlatos.Text = "Platos";
            this.btnPlatos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlatos.UseVisualStyleBackColor = true;
            this.btnPlatos.Click += new System.EventHandler(this.btnPlatos_Click);
            // 
            // btnMesas
            // 
            this.btnMesas.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMesas.FlatAppearance.BorderSize = 0;
            this.btnMesas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesas.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.btnMesas.ForeColor = System.Drawing.Color.Black;
            this.btnMesas.Image = global::LP2Rest.Properties.Resources.imgMesas150x150;
            this.btnMesas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMesas.Location = new System.Drawing.Point(635, 156);
            this.btnMesas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMesas.Name = "btnMesas";
            this.btnMesas.Size = new System.Drawing.Size(232, 238);
            this.btnMesas.TabIndex = 49;
            this.btnMesas.Text = "Mesas";
            this.btnMesas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMesas.UseVisualStyleBackColor = true;
            // 

            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.Window;
            this.panelContenedor.Controls.Add(this.label1);
            this.panelContenedor.Controls.Add(this.panel5);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(341, 123);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1467, 955);
            this.panelContenedor.TabIndex = 53;
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
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 45F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(172, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(756, 247);
            this.label1.TabIndex = 28;
            this.label1.Text = "insertar mensaje de bienvenida";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPrincipalMesero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1808, 1078);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrincipalMesero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMesero";
            this.panelIzquierdo.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button sdbtnPlatos;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button sdbtnVentas;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btnMarcarAsistencia;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button sdbtnMesas;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnMarcarSalida;
        private System.Windows.Forms.Button sdbtnReclamos;
        private System.Windows.Forms.Button sdbtnUsuarios;
        private System.Windows.Forms.Label label1;
    }
}