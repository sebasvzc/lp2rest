namespace LP2Rest
{
    partial class frmOrdenVenta
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvDetalleOrdenVenta = new System.Windows.Forms.DataGridView();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.btnPreparar = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.lblDNICliente = new System.Windows.Forms.Label();
            this.gbPedido = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnDocPago = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDOrdenVenta = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.lblCodProducto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregarPlato = new System.Windows.Forms.Button();
            this.btnQuitarPlato = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.gbLineasVenta = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleOrdenVenta)).BeginInit();
            this.gbCliente.SuspendLayout();
            this.gbPedido.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.gbLineasVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS UI Gothic", 22.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(43, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(235, 31);
            this.lblTitulo.TabIndex = 64;
            this.lblTitulo.Text = "Orden de Venta";
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
            this.Subtotal});
            this.dgvDetalleOrdenVenta.Location = new System.Drawing.Point(46, 497);
            this.dgvDetalleOrdenVenta.Name = "dgvDetalleOrdenVenta";
            this.dgvDetalleOrdenVenta.ReadOnly = true;
            this.dgvDetalleOrdenVenta.RowHeadersWidth = 51;
            this.dgvDetalleOrdenVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleOrdenVenta.Size = new System.Drawing.Size(1043, 163);
            this.dgvDetalleOrdenVenta.TabIndex = 62;
            this.dgvDetalleOrdenVenta.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDetalleOrdenVenta_CellFormatting);
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre";
            this.NombreProducto.MinimumWidth = 6;
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            this.NombreProducto.Width = 490;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cant";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // PrecioUnitario
            // 
            dataGridViewCellStyle2.Format = "N2";
            this.PrecioUnitario.DefaultCellStyle = dataGridViewCellStyle2;
            this.PrecioUnitario.HeaderText = "Precio Unit";
            this.PrecioUnitario.MinimumWidth = 6;
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            this.PrecioUnitario.Width = 200;
            // 
            // Subtotal
            // 
            dataGridViewCellStyle3.Format = "N2";
            this.Subtotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 6;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 200;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(796, 676);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 61;
            this.label5.Text = "TOTAL:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtTotal.Location = new System.Drawing.Point(894, 667);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(132, 32);
            this.txtTotal.TabIndex = 60;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.btnPreparar);
            this.gbCliente.Controls.Add(this.btnBuscarCliente);
            this.gbCliente.Controls.Add(this.lblNombreCliente);
            this.gbCliente.Controls.Add(this.txtNombreCliente);
            this.gbCliente.Controls.Add(this.txtDNICliente);
            this.gbCliente.Controls.Add(this.lblDNICliente);
            this.gbCliente.Font = new System.Drawing.Font("MS UI Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.gbCliente.Location = new System.Drawing.Point(46, 162);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(1043, 150);
            this.gbCliente.TabIndex = 58;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Datos del Cliente";
            // 
            // btnPreparar
            // 
            this.btnPreparar.Location = new System.Drawing.Point(848, 47);
            this.btnPreparar.Name = "btnPreparar";
            this.btnPreparar.Size = new System.Drawing.Size(133, 70);
            this.btnPreparar.TabIndex = 5;
            this.btnPreparar.Text = "Preparar Pedido";
            this.btnPreparar.UseVisualStyleBackColor = true;
            this.btnPreparar.Click += new System.EventHandler(this.btnPreparar_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.btnBuscarCliente.Location = new System.Drawing.Point(393, 33);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(49, 32);
            this.btnBuscarCliente.TabIndex = 4;
            this.btnBuscarCliente.Text = "...";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.lblNombreCliente.Location = new System.Drawing.Point(21, 88);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(201, 23);
            this.lblNombreCliente.TabIndex = 3;
            this.lblNombreCliente.Text = "Nombre del Cliente:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtNombreCliente.Location = new System.Drawing.Point(238, 85);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(374, 32);
            this.txtNombreCliente.TabIndex = 2;
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Enabled = false;
            this.txtDNICliente.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtDNICliente.Location = new System.Drawing.Point(238, 33);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.ReadOnly = true;
            this.txtDNICliente.Size = new System.Drawing.Size(130, 32);
            this.txtDNICliente.TabIndex = 1;
            // 
            // lblDNICliente
            // 
            this.lblDNICliente.AutoSize = true;
            this.lblDNICliente.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.lblDNICliente.Location = new System.Drawing.Point(21, 42);
            this.lblDNICliente.Name = "lblDNICliente";
            this.lblDNICliente.Size = new System.Drawing.Size(162, 23);
            this.lblDNICliente.TabIndex = 0;
            this.lblDNICliente.Text = "DNI del Cliente:";
            // 
            // gbPedido
            // 
            this.gbPedido.Controls.Add(this.textBox3);
            this.gbPedido.Controls.Add(this.btnDocPago);
            this.gbPedido.Controls.Add(this.label6);
            this.gbPedido.Controls.Add(this.label1);
            this.gbPedido.Controls.Add(this.txtIDOrdenVenta);
            this.gbPedido.Font = new System.Drawing.Font("MS UI Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.gbPedido.Location = new System.Drawing.Point(46, 72);
            this.gbPedido.Name = "gbPedido";
            this.gbPedido.Size = new System.Drawing.Size(1043, 84);
            this.gbPedido.TabIndex = 57;
            this.gbPedido.TabStop = false;
            this.gbPedido.Text = "Datos de la Orden de Venta";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBox3.Location = new System.Drawing.Point(513, 34);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(56, 32);
            this.textBox3.TabIndex = 65;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnDocPago
            // 
            this.btnDocPago.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.btnDocPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocPago.Location = new System.Drawing.Point(656, 30);
            this.btnDocPago.Name = "btnDocPago";
            this.btnDocPago.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDocPago.Size = new System.Drawing.Size(381, 36);
            this.btnDocPago.TabIndex = 1;
            this.btnDocPago.Text = "Generar documento de Pago";
            this.btnDocPago.UseVisualStyleBackColor = true;
            this.btnDocPago.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label6.Location = new System.Drawing.Point(438, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mesa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Orden Venta:";
            // 
            // txtIDOrdenVenta
            // 
            this.txtIDOrdenVenta.Enabled = false;
            this.txtIDOrdenVenta.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtIDOrdenVenta.Location = new System.Drawing.Point(201, 34);
            this.txtIDOrdenVenta.Name = "txtIDOrdenVenta";
            this.txtIDOrdenVenta.ReadOnly = true;
            this.txtIDOrdenVenta.Size = new System.Drawing.Size(124, 32);
            this.txtIDOrdenVenta.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnModificar,
            this.btnEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(439, 726);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(328, 30);
            this.toolStrip1.TabIndex = 65;
            this.toolStrip1.Text = "tsMenu";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("MS UI Gothic", 17.25F);
            this.btnNuevo.Image = global::LP2Rest.Properties.Resources.new_file_40454;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(92, 27);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("MS UI Gothic", 17.25F);
            this.btnModificar.Image = global::LP2Rest.Properties.Resources.edit_validated_40458;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(118, 27);
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("MS UI Gothic", 17.25F);
            this.btnEliminar.Image = global::LP2Rest.Properties.Resources.trash_40429;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 27);
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Enabled = false;
            this.txtCodigoProducto.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtCodigoProducto.Location = new System.Drawing.Point(219, 36);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.ReadOnly = true;
            this.txtCodigoProducto.Size = new System.Drawing.Size(106, 32);
            this.txtCodigoProducto.TabIndex = 0;
            // 
            // lblCodProducto
            // 
            this.lblCodProducto.AutoSize = true;
            this.lblCodProducto.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.lblCodProducto.Location = new System.Drawing.Point(21, 39);
            this.lblCodProducto.Name = "lblCodProducto";
            this.lblCodProducto.Size = new System.Drawing.Size(173, 23);
            this.lblCodProducto.TabIndex = 1;
            this.lblCodProducto.Text = "Código del Plato:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label3.Location = new System.Drawing.Point(21, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre del Plato:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Enabled = false;
            this.txtNombreProducto.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtNombreProducto.Location = new System.Drawing.Point(219, 74);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.ReadOnly = true;
            this.txtNombreProducto.Size = new System.Drawing.Size(719, 32);
            this.txtNombreProducto.TabIndex = 5;
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.lblPrecioUnitario.Location = new System.Drawing.Point(21, 121);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(161, 23);
            this.lblPrecioUnitario.TabIndex = 6;
            this.lblPrecioUnitario.Text = "Precio Unitario:";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Enabled = false;
            this.txtPrecioUnitario.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtPrecioUnitario.Location = new System.Drawing.Point(219, 113);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.ReadOnly = true;
            this.txtPrecioUnitario.Size = new System.Drawing.Size(97, 32);
            this.txtPrecioUnitario.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label4.Location = new System.Drawing.Point(381, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad:";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(347, 36);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(49, 32);
            this.btnBuscarProducto.TabIndex = 3;
            this.btnBuscarProducto.Text = "...";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtCantidad.Location = new System.Drawing.Point(486, 118);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(49, 32);
            this.txtCantidad.TabIndex = 9;
            // 
            // btnAgregarPlato
            // 
            this.btnAgregarPlato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarPlato.Location = new System.Drawing.Point(845, 120);
            this.btnAgregarPlato.Name = "btnAgregarPlato";
            this.btnAgregarPlato.Size = new System.Drawing.Size(30, 30);
            this.btnAgregarPlato.TabIndex = 85;
            this.btnAgregarPlato.Text = "+";
            this.btnAgregarPlato.UseVisualStyleBackColor = true;
            this.btnAgregarPlato.Click += new System.EventHandler(this.btnAgregarPlato_Click);
            // 
            // btnQuitarPlato
            // 
            this.btnQuitarPlato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuitarPlato.Location = new System.Drawing.Point(881, 120);
            this.btnQuitarPlato.Name = "btnQuitarPlato";
            this.btnQuitarPlato.Size = new System.Drawing.Size(30, 30);
            this.btnQuitarPlato.TabIndex = 86;
            this.btnQuitarPlato.Text = "-";
            this.btnQuitarPlato.UseVisualStyleBackColor = true;
            this.btnQuitarPlato.Click += new System.EventHandler(this.btnQuitarPlato_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label7.Location = new System.Drawing.Point(617, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 23);
            this.label7.TabIndex = 87;
            this.label7.Text = "Descuento:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtDescuento.Location = new System.Drawing.Point(744, 118);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(49, 32);
            this.txtDescuento.TabIndex = 88;
            // 
            // gbLineasVenta
            // 
            this.gbLineasVenta.Controls.Add(this.txtDescuento);
            this.gbLineasVenta.Controls.Add(this.label7);
            this.gbLineasVenta.Controls.Add(this.btnQuitarPlato);
            this.gbLineasVenta.Controls.Add(this.btnAgregarPlato);
            this.gbLineasVenta.Controls.Add(this.txtCantidad);
            this.gbLineasVenta.Controls.Add(this.btnBuscarProducto);
            this.gbLineasVenta.Controls.Add(this.label4);
            this.gbLineasVenta.Controls.Add(this.txtPrecioUnitario);
            this.gbLineasVenta.Controls.Add(this.lblPrecioUnitario);
            this.gbLineasVenta.Controls.Add(this.txtNombreProducto);
            this.gbLineasVenta.Controls.Add(this.label3);
            this.gbLineasVenta.Controls.Add(this.lblCodProducto);
            this.gbLineasVenta.Controls.Add(this.txtCodigoProducto);
            this.gbLineasVenta.Font = new System.Drawing.Font("MS UI Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.gbLineasVenta.Location = new System.Drawing.Point(46, 318);
            this.gbLineasVenta.Name = "gbLineasVenta";
            this.gbLineasVenta.Size = new System.Drawing.Size(1043, 173);
            this.gbLineasVenta.TabIndex = 59;
            this.gbLineasVenta.TabStop = false;
            this.gbLineasVenta.Text = "Líneas de Orden de Venta";
            // 
            // frmOrdenVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 774);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvDetalleOrdenVenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.gbLineasVenta);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.gbPedido);
            this.Name = "frmOrdenVenta";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmOrdenVenta_Load);
            this.ClientSizeChanged += new System.EventHandler(this.frmOrdenVenta_ClientSizeChanged);
            this.Click += new System.EventHandler(this.frmOrdenVenta_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleOrdenVenta)).EndInit();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbPedido.ResumeLayout(false);
            this.gbPedido.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbLineasVenta.ResumeLayout(false);
            this.gbLineasVenta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvDetalleOrdenVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtDNICliente;
        private System.Windows.Forms.Label lblDNICliente;
        private System.Windows.Forms.GroupBox gbPedido;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnDocPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDOrdenVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.Button btnPreparar;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label lblCodProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAgregarPlato;
        private System.Windows.Forms.Button btnQuitarPlato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.GroupBox gbLineasVenta;
    }
}