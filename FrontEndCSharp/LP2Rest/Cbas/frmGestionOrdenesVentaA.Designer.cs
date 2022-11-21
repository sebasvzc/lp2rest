namespace LP2Rest
{
    partial class frmGestionOrdenesVentaA
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
            this.dgvDetalleOrdenVenta = new System.Windows.Forms.DataGridView();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentajeDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.gbLineasVenta = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregarItem = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.lblCodProducto = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.btnQuitarItem = new System.Windows.Forms.Button();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.lblDNICliente = new System.Windows.Forms.Label();
            this.gbPedido = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnSeleccionarMesa = new System.Windows.Forms.Button();
            this.btnDocumentoPago = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdMesa = new System.Windows.Forms.TextBox();
            this.dtpFechaOrdenVenta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDOrdenVenta = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarMesero = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreMesero = new System.Windows.Forms.TextBox();
            this.txtIdMesero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCajero = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombreCajero = new System.Windows.Forms.TextBox();
            this.txtIdCajero = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleOrdenVenta)).BeginInit();
            this.gbLineasVenta.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.gbPedido.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDetalleOrdenVenta
            // 
            this.dgvDetalleOrdenVenta.AllowUserToAddRows = false;
            this.dgvDetalleOrdenVenta.AllowUserToDeleteRows = false;
            this.dgvDetalleOrdenVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleOrdenVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreProducto,
            this.Cantidad,
            this.PrecioUnitario,
            this.PorcentajeDescuento,
            this.MontoDescuento,
            this.Subtotal});
            this.dgvDetalleOrdenVenta.Location = new System.Drawing.Point(215, 449);
            this.dgvDetalleOrdenVenta.Name = "dgvDetalleOrdenVenta";
            this.dgvDetalleOrdenVenta.ReadOnly = true;
            this.dgvDetalleOrdenVenta.RowHeadersWidth = 51;
            this.dgvDetalleOrdenVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleOrdenVenta.Size = new System.Drawing.Size(723, 125);
            this.dgvDetalleOrdenVenta.TabIndex = 14;
            this.dgvDetalleOrdenVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleOrdenVenta_CellContentClick);
            this.dgvDetalleOrdenVenta.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDetalleOrdenVenta_CellFormatting);
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre";
            this.NombreProducto.MinimumWidth = 6;
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            this.NombreProducto.Width = 200;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cant";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 60;
            // 
            // PrecioUnitario
            // 
            dataGridViewCellStyle1.Format = "N2";
            this.PrecioUnitario.DefaultCellStyle = dataGridViewCellStyle1;
            this.PrecioUnitario.HeaderText = "Precio Unit";
            this.PrecioUnitario.MinimumWidth = 6;
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            this.PrecioUnitario.Width = 120;
            // 
            // PorcentajeDescuento
            // 
            this.PorcentajeDescuento.HeaderText = "Porcentaje Descuento";
            this.PorcentajeDescuento.Name = "PorcentajeDescuento";
            this.PorcentajeDescuento.ReadOnly = true;
            // 
            // MontoDescuento
            // 
            this.MontoDescuento.HeaderText = "MontoDescuento";
            this.MontoDescuento.Name = "MontoDescuento";
            this.MontoDescuento.ReadOnly = true;
            // 
            // Subtotal
            // 
            dataGridViewCellStyle2.Format = "N2";
            this.Subtotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 6;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 90;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(788, 511);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "TOTAL:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(859, 508);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(78, 20);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbLineasVenta
            // 
            this.gbLineasVenta.Controls.Add(this.label12);
            this.gbLineasVenta.Controls.Add(this.txtDescuento);
            this.gbLineasVenta.Controls.Add(this.label7);
            this.gbLineasVenta.Controls.Add(this.btnAgregarItem);
            this.gbLineasVenta.Controls.Add(this.txtCantidad);
            this.gbLineasVenta.Controls.Add(this.label4);
            this.gbLineasVenta.Controls.Add(this.txtPrecioUnitario);
            this.gbLineasVenta.Controls.Add(this.lblPrecioUnitario);
            this.gbLineasVenta.Controls.Add(this.txtNombreProducto);
            this.gbLineasVenta.Controls.Add(this.label3);
            this.gbLineasVenta.Controls.Add(this.btnBuscarProducto);
            this.gbLineasVenta.Controls.Add(this.lblCodProducto);
            this.gbLineasVenta.Controls.Add(this.txtCodigoProducto);
            this.gbLineasVenta.Location = new System.Drawing.Point(25, 302);
            this.gbLineasVenta.Name = "gbLineasVenta";
            this.gbLineasVenta.Size = new System.Drawing.Size(523, 113);
            this.gbLineasVenta.TabIndex = 11;
            this.gbLineasVenta.TabStop = false;
            this.gbLineasVenta.Text = "Líneas de Orden de Venta";
            this.gbLineasVenta.Enter += new System.EventHandler(this.gbLineasVenta_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(445, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 13);
            this.label12.TabIndex = 89;
            this.label12.Text = "%";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(393, 81);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(49, 20);
            this.txtDescuento.TabIndex = 88;
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 87;
            this.label7.Text = "Descuento:";
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.BackgroundImage = global::LP2Rest.Properties.Resources._392024;
            this.btnAgregarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarItem.Location = new System.Drawing.Point(480, 79);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(22, 23);
            this.btnAgregarItem.TabIndex = 86;
            this.btnAgregarItem.UseVisualStyleBackColor = true;
            this.btnAgregarItem.Click += new System.EventHandler(this.btnAgregarItem_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(266, 80);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(49, 20);
            this.txtCantidad.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad:";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Enabled = false;
            this.txtPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioUnitario.Location = new System.Drawing.Point(118, 80);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.ReadOnly = true;
            this.txtPrecioUnitario.Size = new System.Drawing.Size(76, 20);
            this.txtPrecioUnitario.TabIndex = 7;
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(38, 82);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(79, 13);
            this.lblPrecioUnitario.TabIndex = 6;
            this.lblPrecioUnitario.Text = "Precio Unitario:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Enabled = false;
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(118, 50);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.ReadOnly = true;
            this.txtNombreProducto.Size = new System.Drawing.Size(374, 20);
            this.txtNombreProducto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre del Plato:";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(201, 21);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(32, 23);
            this.btnBuscarProducto.TabIndex = 3;
            this.btnBuscarProducto.Text = "...";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // lblCodProducto
            // 
            this.lblCodProducto.AutoSize = true;
            this.lblCodProducto.Location = new System.Drawing.Point(28, 26);
            this.lblCodProducto.Name = "lblCodProducto";
            this.lblCodProducto.Size = new System.Drawing.Size(87, 13);
            this.lblCodProducto.TabIndex = 1;
            this.lblCodProducto.Text = "Código del Plato:";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Enabled = false;
            this.txtCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProducto.Location = new System.Drawing.Point(118, 23);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.ReadOnly = true;
            this.txtCodigoProducto.Size = new System.Drawing.Size(76, 20);
            this.txtCodigoProducto.TabIndex = 0;
            // 
            // btnQuitarItem
            // 
            this.btnQuitarItem.BackgroundImage = global::LP2Rest.Properties.Resources._391892;
            this.btnQuitarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuitarItem.Location = new System.Drawing.Point(915, 409);
            this.btnQuitarItem.Name = "btnQuitarItem";
            this.btnQuitarItem.Size = new System.Drawing.Size(22, 23);
            this.btnQuitarItem.TabIndex = 85;
            this.btnQuitarItem.UseVisualStyleBackColor = true;
            this.btnQuitarItem.Click += new System.EventHandler(this.btnQuitarItem_Click);
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.btnBuscarCliente);
            this.gbCliente.Controls.Add(this.lblNombreCliente);
            this.gbCliente.Controls.Add(this.txtNombreCliente);
            this.gbCliente.Controls.Add(this.txtDNICliente);
            this.gbCliente.Controls.Add(this.lblDNICliente);
            this.gbCliente.Location = new System.Drawing.Point(25, 214);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(523, 82);
            this.gbCliente.TabIndex = 10;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Datos del Cliente";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(256, 20);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(30, 23);
            this.btnBuscarCliente.TabIndex = 4;
            this.btnBuscarCliente.Text = "...";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(10, 50);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(99, 13);
            this.lblNombreCliente.TabIndex = 3;
            this.lblNombreCliente.Text = "Nombre del Cliente:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(117, 48);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(374, 20);
            this.txtNombreCliente.TabIndex = 2;
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Enabled = false;
            this.txtDNICliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNICliente.Location = new System.Drawing.Point(117, 21);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.ReadOnly = true;
            this.txtDNICliente.Size = new System.Drawing.Size(130, 20);
            this.txtDNICliente.TabIndex = 1;
            // 
            // lblDNICliente
            // 
            this.lblDNICliente.AutoSize = true;
            this.lblDNICliente.Location = new System.Drawing.Point(29, 24);
            this.lblDNICliente.Name = "lblDNICliente";
            this.lblDNICliente.Size = new System.Drawing.Size(81, 13);
            this.lblDNICliente.TabIndex = 0;
            this.lblDNICliente.Text = "DNI del Cliente:";
            // 
            // gbPedido
            // 
            this.gbPedido.Controls.Add(this.label13);
            this.gbPedido.Controls.Add(this.txtEstado);
            this.gbPedido.Controls.Add(this.btnSeleccionarMesa);
            this.gbPedido.Controls.Add(this.btnDocumentoPago);
            this.gbPedido.Controls.Add(this.label6);
            this.gbPedido.Controls.Add(this.txtIdMesa);
            this.gbPedido.Controls.Add(this.dtpFechaOrdenVenta);
            this.gbPedido.Controls.Add(this.label2);
            this.gbPedido.Controls.Add(this.label1);
            this.gbPedido.Controls.Add(this.txtIDOrdenVenta);
            this.gbPedido.Location = new System.Drawing.Point(290, 63);
            this.gbPedido.Name = "gbPedido";
            this.gbPedido.Size = new System.Drawing.Size(582, 112);
            this.gbPedido.TabIndex = 9;
            this.gbPedido.TabStop = false;
            this.gbPedido.Text = "Datos de la Orden de Venta";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(65, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Estado:";
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(116, 80);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(110, 20);
            this.txtEstado.TabIndex = 6;
            // 
            // btnSeleccionarMesa
            // 
            this.btnSeleccionarMesa.Location = new System.Drawing.Point(301, 21);
            this.btnSeleccionarMesa.Name = "btnSeleccionarMesa";
            this.btnSeleccionarMesa.Size = new System.Drawing.Size(30, 23);
            this.btnSeleccionarMesa.TabIndex = 4;
            this.btnSeleccionarMesa.Text = "...";
            this.btnSeleccionarMesa.UseVisualStyleBackColor = true;
            // 
            // btnDocumentoPago
            // 
            this.btnDocumentoPago.Image = global::LP2Rest.Properties.Resources.file_info_40446_12x12;
            this.btnDocumentoPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocumentoPago.Location = new System.Drawing.Point(352, 20);
            this.btnDocumentoPago.Name = "btnDocumentoPago";
            this.btnDocumentoPago.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDocumentoPago.Size = new System.Drawing.Size(152, 23);
            this.btnDocumentoPago.TabIndex = 1;
            this.btnDocumentoPago.Text = "Documento de Pago";
            this.btnDocumentoPago.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mesa:";
            // 
            // txtIdMesa
            // 
            this.txtIdMesa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtIdMesa.Enabled = false;
            this.txtIdMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMesa.Location = new System.Drawing.Point(253, 23);
            this.txtIdMesa.Name = "txtIdMesa";
            this.txtIdMesa.Size = new System.Drawing.Size(42, 20);
            this.txtIdMesa.TabIndex = 4;
            // 
            // dtpFechaOrdenVenta
            // 
            this.dtpFechaOrdenVenta.Enabled = false;
            this.dtpFechaOrdenVenta.Location = new System.Drawing.Point(116, 50);
            this.dtpFechaOrdenVenta.Name = "dtpFechaOrdenVenta";
            this.dtpFechaOrdenVenta.Size = new System.Drawing.Size(374, 20);
            this.dtpFechaOrdenVenta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de la Venta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Orden Venta:";
            // 
            // txtIDOrdenVenta
            // 
            this.txtIDOrdenVenta.Enabled = false;
            this.txtIDOrdenVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDOrdenVenta.Location = new System.Drawing.Point(116, 22);
            this.txtIDOrdenVenta.Name = "txtIDOrdenVenta";
            this.txtIDOrdenVenta.ReadOnly = true;
            this.txtIDOrdenVenta.Size = new System.Drawing.Size(76, 20);
            this.txtIDOrdenVenta.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar,
            this.btnEliminar,
            this.btnModificar});
            this.toolStrip1.Location = new System.Drawing.Point(460, 604);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(254, 31);
            this.toolStrip1.TabIndex = 55;
            this.toolStrip1.Text = "tsMenu";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::LP2Rest.Properties.Resources.kisspng_computer_icons_iconfinder_desktop_wallpaper_floppy_save_icon_5ab07851d21f64_1935471015215145778607;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(77, 28);
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::LP2Rest.Properties.Resources.trash_40429;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(78, 28);
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::LP2Rest.Properties.Resources.edit_validated_40458;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 28);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS UI Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(480, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(209, 23);
            this.lblTitulo.TabIndex = 56;
            this.lblTitulo.Text = "Gestión de Ventas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarMesero);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNombreMesero);
            this.groupBox1.Controls.Add(this.txtIdMesero);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(554, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 82);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Mesero";
            // 
            // btnBuscarMesero
            // 
            this.btnBuscarMesero.Location = new System.Drawing.Point(256, 18);
            this.btnBuscarMesero.Name = "btnBuscarMesero";
            this.btnBuscarMesero.Size = new System.Drawing.Size(30, 23);
            this.btnBuscarMesero.TabIndex = 5;
            this.btnBuscarMesero.Text = "...";
            this.btnBuscarMesero.UseVisualStyleBackColor = true;
            this.btnBuscarMesero.Click += new System.EventHandler(this.btnBuscarMesero_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Nombre del Mesero:";
            // 
            // txtNombreMesero
            // 
            this.txtNombreMesero.Enabled = false;
            this.txtNombreMesero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMesero.Location = new System.Drawing.Point(117, 48);
            this.txtNombreMesero.Name = "txtNombreMesero";
            this.txtNombreMesero.ReadOnly = true;
            this.txtNombreMesero.Size = new System.Drawing.Size(374, 20);
            this.txtNombreMesero.TabIndex = 2;
            // 
            // txtIdMesero
            // 
            this.txtIdMesero.Enabled = false;
            this.txtIdMesero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMesero.Location = new System.Drawing.Point(117, 21);
            this.txtIdMesero.Name = "txtIdMesero";
            this.txtIdMesero.ReadOnly = true;
            this.txtIdMesero.Size = new System.Drawing.Size(130, 20);
            this.txtIdMesero.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "ID del Mesero:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarCajero);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtNombreCajero);
            this.groupBox2.Controls.Add(this.txtIdCajero);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(554, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 82);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Cajero";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnBuscarCajero
            // 
            this.btnBuscarCajero.Location = new System.Drawing.Point(256, 20);
            this.btnBuscarCajero.Name = "btnBuscarCajero";
            this.btnBuscarCajero.Size = new System.Drawing.Size(30, 23);
            this.btnBuscarCajero.TabIndex = 4;
            this.btnBuscarCajero.Text = "...";
            this.btnBuscarCajero.UseVisualStyleBackColor = true;
            this.btnBuscarCajero.Click += new System.EventHandler(this.btnBuscarCajero_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Nombre del Cajero:";
            // 
            // txtNombreCajero
            // 
            this.txtNombreCajero.Enabled = false;
            this.txtNombreCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCajero.Location = new System.Drawing.Point(117, 48);
            this.txtNombreCajero.Name = "txtNombreCajero";
            this.txtNombreCajero.ReadOnly = true;
            this.txtNombreCajero.Size = new System.Drawing.Size(374, 20);
            this.txtNombreCajero.TabIndex = 2;
            this.txtNombreCajero.TextChanged += new System.EventHandler(this.txtNombreCajero_TextChanged);
            // 
            // txtIdCajero
            // 
            this.txtIdCajero.Enabled = false;
            this.txtIdCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCajero.Location = new System.Drawing.Point(117, 21);
            this.txtIdCajero.Name = "txtIdCajero";
            this.txtIdCajero.ReadOnly = true;
            this.txtIdCajero.Size = new System.Drawing.Size(130, 20);
            this.txtIdCajero.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "ID del Cajero:";
            // 
            // frmGestionOrdenesVentaA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1218, 665);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnQuitarItem);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvDetalleOrdenVenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.gbLineasVenta);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.gbPedido);
            this.Name = "frmGestionOrdenesVentaA";
            this.Text = "Gestión de Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleOrdenVenta)).EndInit();
            this.gbLineasVenta.ResumeLayout(false);
            this.gbLineasVenta.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbPedido.ResumeLayout(false);
            this.gbPedido.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDetalleOrdenVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox gbLineasVenta;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label lblCodProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtDNICliente;
        private System.Windows.Forms.Label lblDNICliente;
        private System.Windows.Forms.GroupBox gbPedido;
        private System.Windows.Forms.DateTimePicker dtpFechaOrdenVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDOrdenVenta;
        private System.Windows.Forms.Button btnAgregarItem;
        private System.Windows.Forms.Button btnQuitarItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdMesa;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnDocumentoPago;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSeleccionarMesa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreMesero;
        private System.Windows.Forms.TextBox txtIdMesero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarCajero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombreCajero;
        private System.Windows.Forms.TextBox txtIdCajero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentajeDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBuscarMesero;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEstado;
    }
}