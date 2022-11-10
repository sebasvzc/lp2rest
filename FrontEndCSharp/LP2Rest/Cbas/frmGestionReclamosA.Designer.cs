namespace LP2Rest
{
    partial class frmGestionReclamosA
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
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btEmpleado = new System.Windows.Forms.Button();
            this.txtDNIEmpleado = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtTelefonoEmpleado = new System.Windows.Forms.TextBox();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btCliente = new System.Windows.Forms.Button();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdReclamo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbNombreAdmin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIdAdmin = new System.Windows.Forms.TextBox();
            this.rtbObs = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbDesc
            // 
            this.rtbDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtbDesc.Location = new System.Drawing.Point(636, 61);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Size = new System.Drawing.Size(591, 100);
            this.rtbDesc.TabIndex = 57;
            this.rtbDesc.Text = "";
            // 
            // cboEstado
            // 
            this.cboEstado.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(260, 128);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(143, 33);
            this.cboEstado.TabIndex = 56;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dtpFecha.Location = new System.Drawing.Point(260, 85);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(311, 32);
            this.dtpFecha.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(153)))), ((int)(((byte)(96)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(8, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1278, 5);
            this.panel5.TabIndex = 88;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel4.Controls.Add(this.btnCerrar);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(8, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1278, 100);
            this.panel4.TabIndex = 87;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
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
            this.btnCerrar.Location = new System.Drawing.Point(1241, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.TabIndex = 27;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 45F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(103)))), ((int)(((byte)(66)))));
            this.label12.Location = new System.Drawing.Point(21, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(697, 60);
            this.label12.TabIndex = 21;
            this.label12.Text = "GESTIÓN DE RECLAMOS";
            this.label12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label12_MouseDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btEmpleado);
            this.groupBox2.Controls.Add(this.txtDNIEmpleado);
            this.groupBox2.Controls.Add(this.lblDNI);
            this.groupBox2.Controls.Add(this.txtNombreEmpleado);
            this.groupBox2.Controls.Add(this.lblNombre);
            this.groupBox2.Controls.Add(this.txtTelefonoEmpleado);
            this.groupBox2.Controls.Add(this.lblApellidoPaterno);
            this.groupBox2.Font = new System.Drawing.Font("MS UI Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(31, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 177);
            this.groupBox2.TabIndex = 89;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Empleado";
            // 
            // btEmpleado
            // 
            this.btEmpleado.Location = new System.Drawing.Point(494, 44);
            this.btEmpleado.Name = "btEmpleado";
            this.btEmpleado.Size = new System.Drawing.Size(75, 31);
            this.btEmpleado.TabIndex = 31;
            this.btEmpleado.Text = "...";
            this.btEmpleado.UseVisualStyleBackColor = true;
            this.btEmpleado.Click += new System.EventHandler(this.btEmpleado_Click);
            // 
            // txtDNIEmpleado
            // 
            this.txtDNIEmpleado.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtDNIEmpleado.Location = new System.Drawing.Point(260, 43);
            this.txtDNIEmpleado.Name = "txtDNIEmpleado";
            this.txtDNIEmpleado.Size = new System.Drawing.Size(208, 32);
            this.txtDNIEmpleado.TabIndex = 23;
            this.txtDNIEmpleado.TextChanged += new System.EventHandler(this.txtDNIEmpleado_TextChanged);
            // 
            // lblDNI
            // 
            this.lblDNI.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.lblDNI.Location = new System.Drawing.Point(6, 43);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(248, 32);
            this.lblDNI.TabIndex = 24;
            this.lblDNI.Text = "DNI del Empleado:";
            this.lblDNI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtNombreEmpleado.Location = new System.Drawing.Point(260, 85);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(331, 32);
            this.txtNombreEmpleado.TabIndex = 27;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.lblNombre.Location = new System.Drawing.Point(6, 85);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(248, 32);
            this.lblNombre.TabIndex = 28;
            this.lblNombre.Text = "Nombre del Empleado:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTelefonoEmpleado
            // 
            this.txtTelefonoEmpleado.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtTelefonoEmpleado.Location = new System.Drawing.Point(260, 127);
            this.txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
            this.txtTelefonoEmpleado.Size = new System.Drawing.Size(331, 32);
            this.txtTelefonoEmpleado.TabIndex = 29;
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.lblApellidoPaterno.Location = new System.Drawing.Point(6, 130);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(248, 31);
            this.lblApellidoPaterno.TabIndex = 30;
            this.lblApellidoPaterno.Text = "Teléfono del Empleado:";
            this.lblApellidoPaterno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btCliente);
            this.groupBox3.Controls.Add(this.txtDNICliente);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtNombreCliente);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtTelefonoCliente);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Font = new System.Drawing.Font("MS UI Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(31, 506);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(603, 177);
            this.groupBox3.TabIndex = 90;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del Cliente";
            // 
            // btCliente
            // 
            this.btCliente.Location = new System.Drawing.Point(494, 42);
            this.btCliente.Name = "btCliente";
            this.btCliente.Size = new System.Drawing.Size(75, 31);
            this.btCliente.TabIndex = 32;
            this.btCliente.Text = "...";
            this.btCliente.UseVisualStyleBackColor = true;
            this.btCliente.Click += new System.EventHandler(this.btCliente_Click);
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtDNICliente.Location = new System.Drawing.Point(260, 43);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.Size = new System.Drawing.Size(208, 32);
            this.txtDNICliente.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label13.Location = new System.Drawing.Point(6, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(248, 32);
            this.label13.TabIndex = 24;
            this.label13.Text = "DNI del Cliente:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtNombreCliente.Location = new System.Drawing.Point(260, 85);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(331, 32);
            this.txtNombreCliente.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label14.Location = new System.Drawing.Point(6, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(248, 32);
            this.label14.TabIndex = 28;
            this.label14.Text = "Nombre del Cliente:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtTelefonoCliente.Location = new System.Drawing.Point(260, 127);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(331, 32);
            this.txtTelefonoCliente.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label15.Location = new System.Drawing.Point(6, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(248, 31);
            this.label15.TabIndex = 30;
            this.label15.Text = "Teléfono del Cliente:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtIdReclamo);
            this.groupBox1.Controls.Add(this.rtbDesc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboEstado);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(31, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1243, 177);
            this.groupBox1.TabIndex = 91;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Reclamo";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label10.Location = new System.Drawing.Point(633, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(579, 32);
            this.label10.TabIndex = 58;
            this.label10.Text = "Descripción del Reclamo:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIdReclamo
            // 
            this.txtIdReclamo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtIdReclamo.Location = new System.Drawing.Point(260, 43);
            this.txtIdReclamo.Name = "txtIdReclamo";
            this.txtIdReclamo.Size = new System.Drawing.Size(208, 32);
            this.txtIdReclamo.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 32);
            this.label6.TabIndex = 24;
            this.label6.Text = "ID del Reclamo:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label7.Location = new System.Drawing.Point(6, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 32);
            this.label7.TabIndex = 28;
            this.label7.Text = "Fecha del Reclamo:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label8.Location = new System.Drawing.Point(6, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(248, 31);
            this.label8.TabIndex = 30;
            this.label8.Text = "Estado:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbNombreAdmin);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.tbIdAdmin);
            this.groupBox4.Controls.Add(this.rtbObs);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Font = new System.Drawing.Font("MS UI Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(651, 314);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(623, 369);
            this.groupBox4.TabIndex = 92;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Atención del Reclamo";
            // 
            // tbNombreAdmin
            // 
            this.tbNombreAdmin.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tbNombreAdmin.Location = new System.Drawing.Point(289, 87);
            this.tbNombreAdmin.Name = "tbNombreAdmin";
            this.tbNombreAdmin.Size = new System.Drawing.Size(318, 32);
            this.tbNombreAdmin.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label1.Location = new System.Drawing.Point(16, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 32);
            this.label1.TabIndex = 58;
            this.label1.Text = "Reporte/Observaciones del Reclamo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbIdAdmin
            // 
            this.tbIdAdmin.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tbIdAdmin.Location = new System.Drawing.Point(289, 43);
            this.tbIdAdmin.Name = "tbIdAdmin";
            this.tbIdAdmin.Size = new System.Drawing.Size(165, 32);
            this.tbIdAdmin.TabIndex = 23;
            // 
            // rtbObs
            // 
            this.rtbObs.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtbObs.Location = new System.Drawing.Point(16, 180);
            this.rtbObs.Name = "rtbObs";
            this.rtbObs.Size = new System.Drawing.Size(591, 171);
            this.rtbObs.TabIndex = 57;
            this.rtbObs.Text = "";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "ID del Administrador:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label9.Location = new System.Drawing.Point(9, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(274, 32);
            this.label9.TabIndex = 28;
            this.label9.Text = "Nombre del Administrador:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackColor = System.Drawing.Color.Black;
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(8, 755);
            this.panelIzquierdo.TabIndex = 93;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(153)))), ((int)(((byte)(96)))));
            this.btnCancelar.Location = new System.Drawing.Point(646, 698);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(162, 41);
            this.btnCancelar.TabIndex = 95;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(153)))), ((int)(((byte)(96)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(478, 698);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(162, 41);
            this.btnGuardar.TabIndex = 94;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmGestionReclamosA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 755);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionReclamosA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Reclamos";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDNIEmpleado;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtTelefonoEmpleado;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDNICliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIdReclamo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIdAdmin;
        private System.Windows.Forms.RichTextBox rtbObs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbNombreAdmin;
        private System.Windows.Forms.Button btEmpleado;
        private System.Windows.Forms.Button btCliente;
        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}