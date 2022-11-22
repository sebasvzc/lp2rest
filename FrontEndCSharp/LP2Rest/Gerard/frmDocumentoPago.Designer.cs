namespace LP2Rest
{
    partial class frmDocumentoPago
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDetalleOrdenVenta = new System.Windows.Forms.DataGridView();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescuentoPorcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.lblDNICliente = new System.Windows.Forms.Label();
            this.gbPedido = new System.Windows.Forms.GroupBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDirFiscal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdDocPago = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreCajero = new System.Windows.Forms.TextBox();
            this.txtIdCajero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMontoTotal = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cboMetodoPago = new System.Windows.Forms.ComboBox();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMontoPagado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardarPago = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleOrdenVenta)).BeginInit();
            this.gbCliente.SuspendLayout();
            this.gbPedido.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDetalleOrdenVenta
            // 
            this.dgvDetalleOrdenVenta.AllowUserToAddRows = false;
            this.dgvDetalleOrdenVenta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(60)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleOrdenVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalleOrdenVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleOrdenVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreProducto,
            this.Cantidad,
            this.PrecioUnitario,
            this.DescuentoPorcentaje,
            this.Descuento,
            this.Subtotal});
            this.dgvDetalleOrdenVenta.Location = new System.Drawing.Point(39, 470);
            this.dgvDetalleOrdenVenta.Name = "dgvDetalleOrdenVenta";
            this.dgvDetalleOrdenVenta.ReadOnly = true;
            this.dgvDetalleOrdenVenta.RowHeadersWidth = 51;
            this.dgvDetalleOrdenVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleOrdenVenta.Size = new System.Drawing.Size(1043, 225);
            this.dgvDetalleOrdenVenta.TabIndex = 62;
            this.dgvDetalleOrdenVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleOrdenVenta_CellContentClick);
            this.dgvDetalleOrdenVenta.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDetalleOrdenVenta_CellFormatting);
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre";
            this.NombreProducto.MinimumWidth = 6;
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            this.NombreProducto.Width = 320;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 115;
            // 
            // PrecioUnitario
            // 
            dataGridViewCellStyle2.Format = "N2";
            this.PrecioUnitario.DefaultCellStyle = dataGridViewCellStyle2;
            this.PrecioUnitario.HeaderText = "P/U";
            this.PrecioUnitario.MinimumWidth = 6;
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            this.PrecioUnitario.Width = 110;
            // 
            // DescuentoPorcentaje
            // 
            this.DescuentoPorcentaje.HeaderText = "Descuento (%)";
            this.DescuentoPorcentaje.Name = "DescuentoPorcentaje";
            this.DescuentoPorcentaje.ReadOnly = true;
            this.DescuentoPorcentaje.Width = 165;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Rebaja";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            this.Descuento.Width = 130;
            // 
            // Subtotal
            // 
            dataGridViewCellStyle3.Format = "N2";
            this.Subtotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 6;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(737, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 61;
            this.label5.Text = "TOTAL:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtTotal.Location = new System.Drawing.Point(835, 26);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(156, 32);
            this.txtTotal.TabIndex = 60;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.lblNombreCliente);
            this.gbCliente.Controls.Add(this.txtNombreCliente);
            this.gbCliente.Controls.Add(this.txtDNICliente);
            this.gbCliente.Controls.Add(this.lblDNICliente);
            this.gbCliente.Font = new System.Drawing.Font("MS UI Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.gbCliente.Location = new System.Drawing.Point(39, 304);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(491, 150);
            this.gbCliente.TabIndex = 58;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Datos del Cliente";
            this.gbCliente.Enter += new System.EventHandler(this.gbCliente_Enter);
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.lblNombreCliente.Location = new System.Drawing.Point(6, 88);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(90, 23);
            this.lblNombreCliente.TabIndex = 3;
            this.lblNombreCliente.Text = "Nombre:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtNombreCliente.Location = new System.Drawing.Point(102, 85);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(375, 32);
            this.txtNombreCliente.TabIndex = 2;
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Enabled = false;
            this.txtDNICliente.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtDNICliente.Location = new System.Drawing.Point(102, 39);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.ReadOnly = true;
            this.txtDNICliente.Size = new System.Drawing.Size(171, 32);
            this.txtDNICliente.TabIndex = 1;
            // 
            // lblDNICliente
            // 
            this.lblDNICliente.AutoSize = true;
            this.lblDNICliente.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.lblDNICliente.Location = new System.Drawing.Point(45, 42);
            this.lblDNICliente.Name = "lblDNICliente";
            this.lblDNICliente.Size = new System.Drawing.Size(51, 23);
            this.lblDNICliente.TabIndex = 0;
            this.lblDNICliente.Text = "DNI:";
            // 
            // gbPedido
            // 
            this.gbPedido.Controls.Add(this.txtNumero);
            this.gbPedido.Controls.Add(this.label12);
            this.gbPedido.Controls.Add(this.txtSerie);
            this.gbPedido.Controls.Add(this.label13);
            this.gbPedido.Controls.Add(this.txtDirFiscal);
            this.gbPedido.Controls.Add(this.label11);
            this.gbPedido.Controls.Add(this.txtEstado);
            this.gbPedido.Controls.Add(this.label2);
            this.gbPedido.Controls.Add(this.txtRuc);
            this.gbPedido.Controls.Add(this.label6);
            this.gbPedido.Controls.Add(this.label1);
            this.gbPedido.Controls.Add(this.txtIdDocPago);
            this.gbPedido.Font = new System.Drawing.Font("MS UI Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.gbPedido.Location = new System.Drawing.Point(39, 124);
            this.gbPedido.Name = "gbPedido";
            this.gbPedido.Size = new System.Drawing.Size(1043, 174);
            this.gbPedido.TabIndex = 57;
            this.gbPedido.TabStop = false;
            this.gbPedido.Text = "Datos del Documento de Pago";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtNumero.Location = new System.Drawing.Point(520, 116);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(318, 32);
            this.txtNumero.TabIndex = 73;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label12.Location = new System.Drawing.Point(30, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 23);
            this.label12.TabIndex = 72;
            this.label12.Text = "Serie:";
            // 
            // txtSerie
            // 
            this.txtSerie.Enabled = false;
            this.txtSerie.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtSerie.Location = new System.Drawing.Point(102, 116);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.ReadOnly = true;
            this.txtSerie.Size = new System.Drawing.Size(222, 32);
            this.txtSerie.TabIndex = 71;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label13.Location = new System.Drawing.Point(429, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 23);
            this.label13.TabIndex = 70;
            this.label13.Text = "Numero:";
            // 
            // txtDirFiscal
            // 
            this.txtDirFiscal.Enabled = false;
            this.txtDirFiscal.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtDirFiscal.Location = new System.Drawing.Point(520, 78);
            this.txtDirFiscal.Name = "txtDirFiscal";
            this.txtDirFiscal.ReadOnly = true;
            this.txtDirFiscal.Size = new System.Drawing.Size(318, 32);
            this.txtDirFiscal.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label11.Location = new System.Drawing.Point(342, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 23);
            this.label11.TabIndex = 68;
            this.label11.Text = "Direccion Fiscal:";
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtEstado.Location = new System.Drawing.Point(102, 78);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(224, 32);
            this.txtEstado.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 66;
            this.label2.Text = "Estado:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtRuc
            // 
            this.txtRuc.Enabled = false;
            this.txtRuc.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtRuc.Location = new System.Drawing.Point(520, 40);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.ReadOnly = true;
            this.txtRuc.Size = new System.Drawing.Size(318, 32);
            this.txtRuc.TabIndex = 65;
            this.txtRuc.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label6.Location = new System.Drawing.Point(455, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "RUC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label1.Location = new System.Drawing.Point(60, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // txtIdDocPago
            // 
            this.txtIdDocPago.Enabled = false;
            this.txtIdDocPago.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtIdDocPago.Location = new System.Drawing.Point(102, 40);
            this.txtIdDocPago.Name = "txtIdDocPago";
            this.txtIdDocPago.ReadOnly = true;
            this.txtIdDocPago.Size = new System.Drawing.Size(224, 32);
            this.txtIdDocPago.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(153)))), ((int)(((byte)(96)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(8, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1102, 5);
            this.panel5.TabIndex = 98;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(8, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1102, 100);
            this.panel4.TabIndex = 97;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::LP2Rest.Properties.Resources.imgCerrarIcon_Medium;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1056, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 28;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 45F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(103)))), ((int)(((byte)(66)))));
            this.label9.Location = new System.Drawing.Point(21, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(662, 60);
            this.label9.TabIndex = 21;
            this.label9.Text = "DOCUMENTO DE PAGO";
            this.label9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown_1);
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackColor = System.Drawing.Color.Black;
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(8, 1031);
            this.panelIzquierdo.TabIndex = 96;
            this.panelIzquierdo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombreCajero);
            this.groupBox1.Controls.Add(this.txtIdCajero);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(536, 304);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 150);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cajero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre:";
            // 
            // txtNombreCajero
            // 
            this.txtNombreCajero.Enabled = false;
            this.txtNombreCajero.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtNombreCajero.Location = new System.Drawing.Point(102, 85);
            this.txtNombreCajero.Name = "txtNombreCajero";
            this.txtNombreCajero.ReadOnly = true;
            this.txtNombreCajero.Size = new System.Drawing.Size(247, 32);
            this.txtNombreCajero.TabIndex = 2;
            // 
            // txtIdCajero
            // 
            this.txtIdCajero.Enabled = false;
            this.txtIdCajero.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtIdCajero.Location = new System.Drawing.Point(102, 39);
            this.txtIdCajero.Name = "txtIdCajero";
            this.txtIdCajero.ReadOnly = true;
            this.txtIdCajero.Size = new System.Drawing.Size(161, 32);
            this.txtIdCajero.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label4.Location = new System.Drawing.Point(60, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMontoTotal);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cboMetodoPago);
            this.groupBox2.Controls.Add(this.dtpFechaPago);
            this.groupBox2.Controls.Add(this.dtpFechaEmision);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtMontoPagado);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Font = new System.Drawing.Font("MS UI Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(39, 713);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1043, 190);
            this.groupBox2.TabIndex = 103;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de Pago";
            // 
            // btnMontoTotal
            // 
            this.btnMontoTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnMontoTotal.FlatAppearance.BorderSize = 0;
            this.btnMontoTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMontoTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnMontoTotal.ForeColor = System.Drawing.Color.White;
            this.btnMontoTotal.Location = new System.Drawing.Point(835, 106);
            this.btnMontoTotal.Name = "btnMontoTotal";
            this.btnMontoTotal.Size = new System.Drawing.Size(154, 41);
            this.btnMontoTotal.TabIndex = 114;
            this.btnMontoTotal.Text = "Monto Total";
            this.btnMontoTotal.UseVisualStyleBackColor = false;
            this.btnMontoTotal.Click += new System.EventHandler(this.btnMontoTotal_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label14.Location = new System.Drawing.Point(21, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 23);
            this.label14.TabIndex = 71;
            this.label14.Text = "Metodo Pago:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // cboMetodoPago
            // 
            this.cboMetodoPago.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cboMetodoPago.FormattingEnabled = true;
            this.cboMetodoPago.Items.AddRange(new object[] {
            "Administrador",
            "Mesero",
            "Cajero",
            "Recepcionista",
            "Chef"});
            this.cboMetodoPago.Location = new System.Drawing.Point(169, 107);
            this.cboMetodoPago.Name = "cboMetodoPago";
            this.cboMetodoPago.Size = new System.Drawing.Size(246, 33);
            this.cboMetodoPago.TabIndex = 70;
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(169, 71);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(431, 30);
            this.dtpFechaPago.TabIndex = 69;
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.Location = new System.Drawing.Point(169, 32);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(431, 30);
            this.dtpFechaEmision.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label7.Location = new System.Drawing.Point(30, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 23);
            this.label7.TabIndex = 66;
            this.label7.Text = "Fecha Pago:";
            // 
            // txtMontoPagado
            // 
            this.txtMontoPagado.BackColor = System.Drawing.SystemColors.Window;
            this.txtMontoPagado.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtMontoPagado.Location = new System.Drawing.Point(835, 68);
            this.txtMontoPagado.Name = "txtMontoPagado";
            this.txtMontoPagado.ReadOnly = true;
            this.txtMontoPagado.Size = new System.Drawing.Size(156, 32);
            this.txtMontoPagado.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label8.Location = new System.Drawing.Point(676, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "Monto Pagado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label10.Location = new System.Drawing.Point(6, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "Fecha Emision:";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(585, 931);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(115, 41);
            this.btnModificar.TabIndex = 113;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnGuardarPago
            // 
            this.btnGuardarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnGuardarPago.FlatAppearance.BorderSize = 0;
            this.btnGuardarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPago.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnGuardarPago.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPago.Location = new System.Drawing.Point(385, 931);
            this.btnGuardarPago.Name = "btnGuardarPago";
            this.btnGuardarPago.Size = new System.Drawing.Size(174, 41);
            this.btnGuardarPago.TabIndex = 114;
            this.btnGuardarPago.Text = "Registrar Pago";
            this.btnGuardarPago.UseVisualStyleBackColor = false;
            this.btnGuardarPago.Click += new System.EventHandler(this.btnGuardarPago_Click);
            // 
            // frmDocumentoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 1031);
            this.Controls.Add(this.btnGuardarPago);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelIzquierdo);
            this.Controls.Add(this.dgvDetalleOrdenVenta);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.gbPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDocumentoPago";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmOrdenVenta_Load);
            this.ClientSizeChanged += new System.EventHandler(this.frmOrdenVenta_ClientSizeChanged);
            this.Click += new System.EventHandler(this.frmOrdenVenta_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleOrdenVenta)).EndInit();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbPedido.ResumeLayout(false);
            this.gbPedido.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDetalleOrdenVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtDNICliente;
        private System.Windows.Forms.Label lblDNICliente;
        private System.Windows.Forms.GroupBox gbPedido;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdDocPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescuentoPorcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreCajero;
        private System.Windows.Forms.TextBox txtIdCajero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMontoPagado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDirFiscal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnMontoTotal;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboMetodoPago;
        private System.Windows.Forms.Button btnGuardarPago;
    }
}