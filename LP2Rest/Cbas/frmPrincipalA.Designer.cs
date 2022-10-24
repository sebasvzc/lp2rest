namespace LP2Rest
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
            this.Titulo = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnReclamos = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnInsumos = new System.Windows.Forms.Button();
            this.btnPlatos = new System.Windows.Forms.Button();
            this.btnEventos = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnMarcarAsistencia = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.sdbtnPlatos = new System.Windows.Forms.Button();
            this.sdbtnReportes = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.sdbtnUsuarios = new System.Windows.Forms.Button();
            this.sdbtnEventos = new System.Windows.Forms.Button();
            this.sdbtnReclamos = new System.Windows.Forms.Button();
            this.sdbtnCompras = new System.Windows.Forms.Button();
            this.sdbtnInsumos = new System.Windows.Forms.Button();
            this.sdbtnVentas = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelIzquierdo.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Titulo.FlatAppearance.BorderSize = 0;
            this.Titulo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titulo.Font = new System.Drawing.Font("MS UI Gothic", 45F, System.Drawing.FontStyle.Bold);
            this.Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(103)))), ((int)(((byte)(66)))));
            this.Titulo.Location = new System.Drawing.Point(11, 17);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(268, 66);
            this.Titulo.TabIndex = 17;
            this.Titulo.Text = "INICIO";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Titulo.UseVisualStyleBackColor = true;
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(153)))), ((int)(((byte)(96)))));
            this.panelIzquierdo.Controls.Add(this.panel4);
            this.panelIzquierdo.Controls.Add(this.sdbtnPlatos);
            this.panelIzquierdo.Controls.Add(this.sdbtnReportes);
            this.panelIzquierdo.Controls.Add(this.pictureBox9);
            this.panelIzquierdo.Controls.Add(this.sdbtnUsuarios);
            this.panelIzquierdo.Controls.Add(this.sdbtnEventos);
            this.panelIzquierdo.Controls.Add(this.sdbtnReclamos);
            this.panelIzquierdo.Controls.Add(this.sdbtnCompras);
            this.panelIzquierdo.Controls.Add(this.sdbtnInsumos);
            this.panelIzquierdo.Controls.Add(this.sdbtnVentas);
            this.panelIzquierdo.Controls.Add(this.button2);
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(191, 668);
            this.panelIzquierdo.TabIndex = 20;
            this.panelIzquierdo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelIzquierdo_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 611);
            this.panel4.TabIndex = 17;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(153)))));
            this.panelSuperior.Controls.Add(this.btnMarcarAsistencia);
            this.panelSuperior.Controls.Add(this.btnCerrar);
            this.panelSuperior.Controls.Add(this.Titulo);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(191, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1020, 100);
            this.panelSuperior.TabIndex = 21;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(204)))));
            this.panelContenedor.Controls.Add(this.panel5);
            this.panelContenedor.Controls.Add(this.btnReportes);
            this.panelContenedor.Controls.Add(this.btnReclamos);
            this.panelContenedor.Controls.Add(this.btnVentas);
            this.panelContenedor.Controls.Add(this.btnInsumos);
            this.panelContenedor.Controls.Add(this.btnPlatos);
            this.panelContenedor.Controls.Add(this.btnEventos);
            this.panelContenedor.Controls.Add(this.btnCompras);
            this.panelContenedor.Controls.Add(this.btnUsuarios);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.panelContenedor.Location = new System.Drawing.Point(191, 100);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1020, 568);
            this.panelContenedor.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(153)))), ((int)(((byte)(96)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1020, 4);
            this.panel5.TabIndex = 25;
            // 
            // btnReportes
            // 
            this.btnReportes.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.btnReportes.Image = global::LP2Rest.Properties.Resources.imgReportesIcon_medium;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReportes.Location = new System.Drawing.Point(703, 68);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(150, 184);
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
            this.btnReclamos.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.btnReclamos.Image = global::LP2Rest.Properties.Resources.imgReclamosIcon_medium;
            this.btnReclamos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReclamos.Location = new System.Drawing.Point(515, 295);
            this.btnReclamos.Name = "btnReclamos";
            this.btnReclamos.Size = new System.Drawing.Size(150, 184);
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
            this.btnVentas.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.btnVentas.Image = global::LP2Rest.Properties.Resources.imgVentasIcon_medium;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVentas.Location = new System.Drawing.Point(327, 68);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(150, 184);
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
            this.btnInsumos.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.btnInsumos.Image = global::LP2Rest.Properties.Resources.imgInsumosIcon_medium;
            this.btnInsumos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInsumos.Location = new System.Drawing.Point(138, 295);
            this.btnInsumos.Name = "btnInsumos";
            this.btnInsumos.Size = new System.Drawing.Size(150, 184);
            this.btnInsumos.TabIndex = 21;
            this.btnInsumos.Text = "Insumos";
            this.btnInsumos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInsumos.UseVisualStyleBackColor = true;
            this.btnInsumos.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPlatos
            // 
            this.btnPlatos.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.btnPlatos.FlatAppearance.BorderSize = 0;
            this.btnPlatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlatos.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.btnPlatos.Image = global::LP2Rest.Properties.Resources.imgPlatosIcon_medium;
            this.btnPlatos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlatos.Location = new System.Drawing.Point(703, 295);
            this.btnPlatos.Name = "btnPlatos";
            this.btnPlatos.Size = new System.Drawing.Size(150, 184);
            this.btnPlatos.TabIndex = 20;
            this.btnPlatos.Text = "Platos";
            this.btnPlatos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlatos.UseVisualStyleBackColor = true;
            this.btnPlatos.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnEventos
            // 
            this.btnEventos.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.btnEventos.FlatAppearance.BorderSize = 0;
            this.btnEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventos.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.btnEventos.Image = global::LP2Rest.Properties.Resources.imgEventosIcon_medium;
            this.btnEventos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEventos.Location = new System.Drawing.Point(515, 68);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(150, 184);
            this.btnEventos.TabIndex = 19;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEventos.UseVisualStyleBackColor = true;
            this.btnEventos.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnCompras
            // 
            this.btnCompras.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.btnCompras.Image = global::LP2Rest.Properties.Resources.imgComprasIcon_medium;
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompras.Location = new System.Drawing.Point(326, 295);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(150, 184);
            this.btnCompras.TabIndex = 18;
            this.btnCompras.Text = " Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.btnUsuarios.Image = global::LP2Rest.Properties.Resources.imgUsuarioIcon_medium;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsuarios.Location = new System.Drawing.Point(138, 68);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(150, 184);
            this.btnUsuarios.TabIndex = 17;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMarcarAsistencia
            // 
            this.btnMarcarAsistencia.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.btnMarcarAsistencia.FlatAppearance.BorderSize = 0;
            this.btnMarcarAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcarAsistencia.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.btnMarcarAsistencia.Image = global::LP2Rest.Properties.Resources.imgAsistenciaIcon_small;
            this.btnMarcarAsistencia.Location = new System.Drawing.Point(409, 18);
            this.btnMarcarAsistencia.Name = "btnMarcarAsistencia";
            this.btnMarcarAsistencia.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMarcarAsistencia.Size = new System.Drawing.Size(201, 65);
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
            this.btnCerrar.Location = new System.Drawing.Point(981, 15);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.TabIndex = 26;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // sdbtnPlatos
            // 
            this.sdbtnPlatos.FlatAppearance.BorderSize = 0;
            this.sdbtnPlatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sdbtnPlatos.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.sdbtnPlatos.Image = global::LP2Rest.Properties.Resources.imgPlatosIcon_small;
            this.sdbtnPlatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sdbtnPlatos.Location = new System.Drawing.Point(2, 104);
            this.sdbtnPlatos.Name = "sdbtnPlatos";
            this.sdbtnPlatos.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.sdbtnPlatos.Size = new System.Drawing.Size(237, 59);
            this.sdbtnPlatos.TabIndex = 33;
            this.sdbtnPlatos.Text = "  Platos";
            this.sdbtnPlatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sdbtnPlatos.UseVisualStyleBackColor = true;
            this.sdbtnPlatos.Click += new System.EventHandler(this.sdbtnPlatos_Click);
            // 
            // sdbtnReportes
            // 
            this.sdbtnReportes.FlatAppearance.BorderSize = 0;
            this.sdbtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sdbtnReportes.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.sdbtnReportes.Image = global::LP2Rest.Properties.Resources.imgReportesIcon_small;
            this.sdbtnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sdbtnReportes.Location = new System.Drawing.Point(2, 169);
            this.sdbtnReportes.Name = "sdbtnReportes";
            this.sdbtnReportes.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.sdbtnReportes.Size = new System.Drawing.Size(237, 59);
            this.sdbtnReportes.TabIndex = 39;
            this.sdbtnReportes.Text = "  Reportes";
            this.sdbtnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sdbtnReportes.UseVisualStyleBackColor = true;
            this.sdbtnReportes.Click += new System.EventHandler(this.sdbtnReportes_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::LP2Rest.Properties.Resources.imgRestauranteLogo_medium;
            this.pictureBox9.Location = new System.Drawing.Point(49, 11);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(86, 86);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            // 
            // sdbtnUsuarios
            // 
            this.sdbtnUsuarios.FlatAppearance.BorderSize = 0;
            this.sdbtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sdbtnUsuarios.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.sdbtnUsuarios.Image = global::LP2Rest.Properties.Resources.imgUsuarioIcon_small;
            this.sdbtnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sdbtnUsuarios.Location = new System.Drawing.Point(2, 228);
            this.sdbtnUsuarios.Name = "sdbtnUsuarios";
            this.sdbtnUsuarios.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.sdbtnUsuarios.Size = new System.Drawing.Size(237, 59);
            this.sdbtnUsuarios.TabIndex = 37;
            this.sdbtnUsuarios.Text = "  Usuarios";
            this.sdbtnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sdbtnUsuarios.UseVisualStyleBackColor = true;
            this.sdbtnUsuarios.Click += new System.EventHandler(this.sdbtnUsuarios_Click);
            // 
            // sdbtnEventos
            // 
            this.sdbtnEventos.FlatAppearance.BorderSize = 0;
            this.sdbtnEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sdbtnEventos.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.sdbtnEventos.Image = global::LP2Rest.Properties.Resources.imgEventosIcon_small;
            this.sdbtnEventos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sdbtnEventos.Location = new System.Drawing.Point(2, 482);
            this.sdbtnEventos.Name = "sdbtnEventos";
            this.sdbtnEventos.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.sdbtnEventos.Size = new System.Drawing.Size(237, 59);
            this.sdbtnEventos.TabIndex = 38;
            this.sdbtnEventos.Text = "  Eventos";
            this.sdbtnEventos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sdbtnEventos.UseVisualStyleBackColor = true;
            this.sdbtnEventos.Click += new System.EventHandler(this.sdbtnEventos_Click);
            // 
            // sdbtnReclamos
            // 
            this.sdbtnReclamos.FlatAppearance.BorderSize = 0;
            this.sdbtnReclamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sdbtnReclamos.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.sdbtnReclamos.Image = global::LP2Rest.Properties.Resources.imgReclamosIcon_small;
            this.sdbtnReclamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sdbtnReclamos.Location = new System.Drawing.Point(2, 287);
            this.sdbtnReclamos.Name = "sdbtnReclamos";
            this.sdbtnReclamos.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.sdbtnReclamos.Size = new System.Drawing.Size(237, 59);
            this.sdbtnReclamos.TabIndex = 34;
            this.sdbtnReclamos.Text = "  Reclamos";
            this.sdbtnReclamos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sdbtnReclamos.UseVisualStyleBackColor = true;
            this.sdbtnReclamos.Click += new System.EventHandler(this.sdbtnReclamos_Click);
            // 
            // sdbtnCompras
            // 
            this.sdbtnCompras.FlatAppearance.BorderSize = 0;
            this.sdbtnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sdbtnCompras.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.sdbtnCompras.Image = global::LP2Rest.Properties.Resources.imgComprasIcon_small;
            this.sdbtnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sdbtnCompras.Location = new System.Drawing.Point(2, 352);
            this.sdbtnCompras.Name = "sdbtnCompras";
            this.sdbtnCompras.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.sdbtnCompras.Size = new System.Drawing.Size(237, 59);
            this.sdbtnCompras.TabIndex = 35;
            this.sdbtnCompras.Text = "  Compras";
            this.sdbtnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sdbtnCompras.UseVisualStyleBackColor = true;
            this.sdbtnCompras.Click += new System.EventHandler(this.sdbtnCompras_Click);
            // 
            // sdbtnInsumos
            // 
            this.sdbtnInsumos.FlatAppearance.BorderSize = 0;
            this.sdbtnInsumos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sdbtnInsumos.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.sdbtnInsumos.Image = global::LP2Rest.Properties.Resources.imgInsumosIcon_small;
            this.sdbtnInsumos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sdbtnInsumos.Location = new System.Drawing.Point(2, 417);
            this.sdbtnInsumos.Name = "sdbtnInsumos";
            this.sdbtnInsumos.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.sdbtnInsumos.Size = new System.Drawing.Size(237, 59);
            this.sdbtnInsumos.TabIndex = 36;
            this.sdbtnInsumos.Text = "  Insumos";
            this.sdbtnInsumos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sdbtnInsumos.UseVisualStyleBackColor = true;
            this.sdbtnInsumos.Click += new System.EventHandler(this.sdbtnInsumos_Click);
            // 
            // sdbtnVentas
            // 
            this.sdbtnVentas.FlatAppearance.BorderSize = 0;
            this.sdbtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sdbtnVentas.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.sdbtnVentas.Image = global::LP2Rest.Properties.Resources.imgVentasIcon_small;
            this.sdbtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sdbtnVentas.Location = new System.Drawing.Point(2, 547);
            this.sdbtnVentas.Name = "sdbtnVentas";
            this.sdbtnVentas.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.sdbtnVentas.Size = new System.Drawing.Size(237, 59);
            this.sdbtnVentas.TabIndex = 26;
            this.sdbtnVentas.Text = "  Ventas";
            this.sdbtnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sdbtnVentas.UseVisualStyleBackColor = true;
            this.sdbtnVentas.Click += new System.EventHandler(this.sdbtnVentas_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Image = global::LP2Rest.Properties.Resources._429524_200;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 611);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(191, 57);
            this.button2.TabIndex = 32;
            this.button2.Text = "  Cerrar\r\n  Sesión";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // frmPrincipalA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 668);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipalA";
            this.Text = "Administración";
            this.panelIzquierdo.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button Titulo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Button btnPlatos;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnReclamos;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnInsumos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button sdbtnVentas;
        private System.Windows.Forms.Button sdbtnPlatos;
        private System.Windows.Forms.Button sdbtnReclamos;
        private System.Windows.Forms.Button sdbtnCompras;
        private System.Windows.Forms.Button sdbtnInsumos;
        private System.Windows.Forms.Button sdbtnUsuarios;
        private System.Windows.Forms.Button sdbtnEventos;
        private System.Windows.Forms.Button sdbtnReportes;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMarcarAsistencia;
    }
}