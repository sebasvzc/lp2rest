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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sdbtnPlatos = new System.Windows.Forms.Button();
            this.sdbtnReportes = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.sdbtnUsuarios = new System.Windows.Forms.Button();
            this.sdbtnEventos = new System.Windows.Forms.Button();
            this.sdbtnReclamos = new System.Windows.Forms.Button();
            this.sdbtnCompras = new System.Windows.Forms.Button();
            this.sdbtnInsumos = new System.Windows.Forms.Button();
            this.sdbtnVentas = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnMarcarAsistencia = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltimer = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnRegistrarSalida = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.panelIzquierdo.Controls.Add(this.sdbtnPlatos);
            this.panelIzquierdo.Controls.Add(this.sdbtnReportes);
            this.panelIzquierdo.Controls.Add(this.pbLogo);
            this.panelIzquierdo.Controls.Add(this.sdbtnUsuarios);
            this.panelIzquierdo.Controls.Add(this.sdbtnEventos);
            this.panelIzquierdo.Controls.Add(this.sdbtnReclamos);
            this.panelIzquierdo.Controls.Add(this.sdbtnCompras);
            this.panelIzquierdo.Controls.Add(this.sdbtnInsumos);
            this.panelIzquierdo.Controls.Add(this.sdbtnVentas);
            this.panelIzquierdo.Controls.Add(this.btnCerrarSesion);
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(256, 876);
            this.panelIzquierdo.TabIndex = 20;
            this.panelIzquierdo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelIzquierdo_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 807);
            this.panel4.TabIndex = 17;
            // 
            // sdbtnPlatos
            // 
            this.sdbtnPlatos.FlatAppearance.BorderSize = 0;
            this.sdbtnPlatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sdbtnPlatos.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.sdbtnPlatos.Image = global::LP2Rest.Properties.Resources.imgPlatosIcon_small;
            this.sdbtnPlatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sdbtnPlatos.Location = new System.Drawing.Point(0, 142);
            this.sdbtnPlatos.Name = "sdbtnPlatos";
            this.sdbtnPlatos.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.sdbtnPlatos.Size = new System.Drawing.Size(256, 59);
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
            this.sdbtnReportes.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.sdbtnReportes.Image = global::LP2Rest.Properties.Resources.imgReportesIcon_small;
            this.sdbtnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sdbtnReportes.Location = new System.Drawing.Point(0, 229);
            this.sdbtnReportes.Name = "sdbtnReportes";
            this.sdbtnReportes.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.sdbtnReportes.Size = new System.Drawing.Size(256, 59);
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
            // sdbtnUsuarios
            // 
            this.sdbtnUsuarios.FlatAppearance.BorderSize = 0;
            this.sdbtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sdbtnUsuarios.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.sdbtnUsuarios.Image = global::LP2Rest.Properties.Resources.imgUsuarioIcon_small;
            this.sdbtnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sdbtnUsuarios.Location = new System.Drawing.Point(0, 312);
            this.sdbtnUsuarios.Name = "sdbtnUsuarios";
            this.sdbtnUsuarios.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.sdbtnUsuarios.Size = new System.Drawing.Size(268, 59);
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
            this.sdbtnEventos.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.sdbtnEventos.Image = global::LP2Rest.Properties.Resources.imgEventosIcon_small;
            this.sdbtnEventos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sdbtnEventos.Location = new System.Drawing.Point(0, 638);
            this.sdbtnEventos.Name = "sdbtnEventos";
            this.sdbtnEventos.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.sdbtnEventos.Size = new System.Drawing.Size(253, 59);
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
            this.sdbtnReclamos.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.sdbtnReclamos.Image = global::LP2Rest.Properties.Resources.imgReclamosIcon_small;
            this.sdbtnReclamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sdbtnReclamos.Location = new System.Drawing.Point(0, 392);
            this.sdbtnReclamos.Name = "sdbtnReclamos";
            this.sdbtnReclamos.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.sdbtnReclamos.Size = new System.Drawing.Size(265, 59);
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
            this.sdbtnCompras.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.sdbtnCompras.Image = global::LP2Rest.Properties.Resources.imgComprasIcon_small;
            this.sdbtnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sdbtnCompras.Location = new System.Drawing.Point(0, 475);
            this.sdbtnCompras.Name = "sdbtnCompras";
            this.sdbtnCompras.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.sdbtnCompras.Size = new System.Drawing.Size(259, 59);
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
            this.sdbtnInsumos.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.sdbtnInsumos.Image = global::LP2Rest.Properties.Resources.imgInsumosIcon_small;
            this.sdbtnInsumos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sdbtnInsumos.Location = new System.Drawing.Point(0, 557);
            this.sdbtnInsumos.Name = "sdbtnInsumos";
            this.sdbtnInsumos.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.sdbtnInsumos.Size = new System.Drawing.Size(256, 59);
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
            this.sdbtnVentas.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.sdbtnVentas.Image = global::LP2Rest.Properties.Resources.imgVentasIcon_small;
            this.sdbtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sdbtnVentas.Location = new System.Drawing.Point(0, 722);
            this.sdbtnVentas.Name = "sdbtnVentas";
            this.sdbtnVentas.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.sdbtnVentas.Size = new System.Drawing.Size(294, 59);
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
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 807);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(256, 69);
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
            this.panelSuperior.Controls.Add(this.btnMarcarAsistencia);
            this.panelSuperior.Controls.Add(this.label2);
            this.panelSuperior.Controls.Add(this.lbltimer);
            this.panelSuperior.Controls.Add(this.lblID);
            this.panelSuperior.Controls.Add(this.btnRegistrarSalida);
            this.panelSuperior.Controls.Add(this.lbltitulo);
            this.panelSuperior.Controls.Add(this.btnCerrar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(256, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1100, 100);
            this.panelSuperior.TabIndex = 21;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // btnMarcarAsistencia
            // 
            this.btnMarcarAsistencia.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.btnMarcarAsistencia.FlatAppearance.BorderSize = 0;
            this.btnMarcarAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcarAsistencia.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcarAsistencia.Image = global::LP2Rest.Properties.Resources.imgAsistenciaIcon_small;
            this.btnMarcarAsistencia.Location = new System.Drawing.Point(246, 19);
            this.btnMarcarAsistencia.Name = "btnMarcarAsistencia";
            this.btnMarcarAsistencia.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMarcarAsistencia.Size = new System.Drawing.Size(179, 68);
            this.btnMarcarAsistencia.TabIndex = 26;
            this.btnMarcarAsistencia.Text = "  Marcar\r\n  Asistencia";
            this.btnMarcarAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarcarAsistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMarcarAsistencia.UseVisualStyleBackColor = true;
            this.btnMarcarAsistencia.Click += new System.EventHandler(this.btnMarcarAsistencia_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(643, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 19);
            this.label2.TabIndex = 48;
            this.label2.Text = "Tiempo de Asistencia";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltimer
            // 
            this.lbltimer.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimer.Location = new System.Drawing.Point(646, 33);
            this.lbltimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(140, 55);
            this.lbltimer.TabIndex = 47;
            this.lbltimer.Text = "00:00:00";
            this.lbltimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lblID.ForeColor = System.Drawing.Color.Coral;
            this.lblID.Location = new System.Drawing.Point(830, 44);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(113, 24);
            this.lblID.TabIndex = 46;
            this.lblID.Text = "Cajero #x";
            // 
            // btnRegistrarSalida
            // 
            this.btnRegistrarSalida.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.btnRegistrarSalida.FlatAppearance.BorderSize = 0;
            this.btnRegistrarSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarSalida.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarSalida.Image = global::LP2Rest.Properties.Resources.imgAsistenciaIcon_small;
            this.btnRegistrarSalida.Location = new System.Drawing.Point(431, 21);
            this.btnRegistrarSalida.Name = "btnRegistrarSalida";
            this.btnRegistrarSalida.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnRegistrarSalida.Size = new System.Drawing.Size(164, 65);
            this.btnRegistrarSalida.TabIndex = 27;
            this.btnRegistrarSalida.Text = "  Registrar\r\n  Salida";
            this.btnRegistrarSalida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarSalida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarSalida.UseVisualStyleBackColor = true;
            this.btnRegistrarSalida.Click += new System.EventHandler(this.btnRegistrarSalida_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltitulo.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(103)))), ((int)(((byte)(66)))));
            this.lbltitulo.Location = new System.Drawing.Point(20, 27);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(159, 48);
            this.lbltitulo.TabIndex = 26;
            this.lbltitulo.Text = "INICIO";
            this.lbltitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbltitulo_MouseDown);
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
            this.panelContenedor.Controls.Add(this.label1);
            this.panelContenedor.Controls.Add(this.panel5);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(256, 100);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1100, 776);
            this.panelContenedor.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(149, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(807, 123);
            this.label1.TabIndex = 27;
            this.label1.Text = "insertar mensaje de bienvenida";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPrincipalA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 876);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipalA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración";
            this.panelIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lbltitulo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCerrarSesion;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarSalida;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltimer;
    }
}