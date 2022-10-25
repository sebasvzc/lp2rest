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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdenVenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dgvDetalleOrdenVenta = new System.Windows.Forms.DataGridView();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.gbLineasVenta = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.lblCodProducto = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.lblDNICliente = new System.Windows.Forms.Label();
            this.gbPedido = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDOrdenVenta = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleOrdenVenta)).BeginInit();
            this.gbLineasVenta.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.gbPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(220, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(115, 16);
            this.lblTitulo.TabIndex = 64;
            this.lblTitulo.Text = "Orden de Venta";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar,
            this.btnEliminar,
            this.btnCancelar,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(181, 478);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(222, 25);
            this.toolStrip1.TabIndex = 63;
            this.toolStrip1.Text = "tsMenu";
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(46, 22);
            this.btnGuardar.Text = "&Añadir";
            // 
            // btnEliminar
            // 
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(54, 22);
            this.btnEliminar.Text = "&Eliminar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(57, 22);
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1.Text = "Aceptar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            this.Subtotal});
            this.dgvDetalleOrdenVenta.Location = new System.Drawing.Point(28, 340);
            this.dgvDetalleOrdenVenta.Name = "dgvDetalleOrdenVenta";
            this.dgvDetalleOrdenVenta.ReadOnly = true;
            this.dgvDetalleOrdenVenta.RowHeadersWidth = 51;
            this.dgvDetalleOrdenVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleOrdenVenta.Size = new System.Drawing.Size(524, 106);
            this.dgvDetalleOrdenVenta.TabIndex = 62;
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
            this.label5.Location = new System.Drawing.Point(420, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "TOTAL:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(473, 452);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(78, 20);
            this.txtTotal.TabIndex = 60;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbLineasVenta
            // 
            this.gbLineasVenta.Controls.Add(this.textBox2);
            this.gbLineasVenta.Controls.Add(this.label7);
            this.gbLineasVenta.Controls.Add(this.button1);
            this.gbLineasVenta.Controls.Add(this.button3);
            this.gbLineasVenta.Controls.Add(this.txtCantidad);
            this.gbLineasVenta.Controls.Add(this.label4);
            this.gbLineasVenta.Controls.Add(this.txtPrecioUnitario);
            this.gbLineasVenta.Controls.Add(this.lblPrecioUnitario);
            this.gbLineasVenta.Controls.Add(this.txtNombreProducto);
            this.gbLineasVenta.Controls.Add(this.label3);
            this.gbLineasVenta.Controls.Add(this.btnBuscarProducto);
            this.gbLineasVenta.Controls.Add(this.lblCodProducto);
            this.gbLineasVenta.Controls.Add(this.txtCodigoProducto);
            this.gbLineasVenta.Location = new System.Drawing.Point(29, 220);
            this.gbLineasVenta.Name = "gbLineasVenta";
            this.gbLineasVenta.Size = new System.Drawing.Size(523, 113);
            this.gbLineasVenta.TabIndex = 59;
            this.gbLineasVenta.TabStop = false;
            this.gbLineasVenta.Text = "Líneas de Orden de Venta";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(393, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(49, 20);
            this.textBox2.TabIndex = 88;
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
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(470, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 86;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(448, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 23);
            this.button3.TabIndex = 85;
            this.button3.UseVisualStyleBackColor = true;
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
            this.txtPrecioUnitario.Location = new System.Drawing.Point(119, 79);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.ReadOnly = true;
            this.txtPrecioUnitario.Size = new System.Drawing.Size(76, 20);
            this.txtPrecioUnitario.TabIndex = 7;
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(37, 82);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(79, 13);
            this.lblPrecioUnitario.TabIndex = 6;
            this.lblPrecioUnitario.Text = "Precio Unitario:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Enabled = false;
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(119, 51);
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
            this.txtCodigoProducto.Location = new System.Drawing.Point(119, 23);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.ReadOnly = true;
            this.txtCodigoProducto.Size = new System.Drawing.Size(76, 20);
            this.txtCodigoProducto.TabIndex = 0;
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.btnBuscarCliente);
            this.gbCliente.Controls.Add(this.lblNombreCliente);
            this.gbCliente.Controls.Add(this.txtNombreCliente);
            this.gbCliente.Controls.Add(this.txtDNICliente);
            this.gbCliente.Controls.Add(this.lblDNICliente);
            this.gbCliente.Location = new System.Drawing.Point(29, 132);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(523, 82);
            this.gbCliente.TabIndex = 58;
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
            this.lblNombreCliente.Location = new System.Drawing.Point(11, 51);
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
            this.lblDNICliente.Location = new System.Drawing.Point(29, 25);
            this.lblDNICliente.Name = "lblDNICliente";
            this.lblDNICliente.Size = new System.Drawing.Size(81, 13);
            this.lblDNICliente.TabIndex = 0;
            this.lblDNICliente.Text = "DNI del Cliente:";
            // 
            // gbPedido
            // 
            this.gbPedido.Controls.Add(this.textBox3);
            this.gbPedido.Controls.Add(this.button2);
            this.gbPedido.Controls.Add(this.label6);
            this.gbPedido.Controls.Add(this.label1);
            this.gbPedido.Controls.Add(this.txtIDOrdenVenta);
            this.gbPedido.Location = new System.Drawing.Point(29, 42);
            this.gbPedido.Name = "gbPedido";
            this.gbPedido.Size = new System.Drawing.Size(523, 84);
            this.gbPedido.TabIndex = 57;
            this.gbPedido.TabStop = false;
            this.gbPedido.Text = "Datos de la Orden de Venta";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(266, 36);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(56, 20);
            this.textBox3.TabIndex = 65;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(333, 33);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(178, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Generar documento de Pago";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mesa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Orden Venta:";
            // 
            // txtIDOrdenVenta
            // 
            this.txtIDOrdenVenta.Enabled = false;
            this.txtIDOrdenVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDOrdenVenta.Location = new System.Drawing.Point(110, 34);
            this.txtIDOrdenVenta.Name = "txtIDOrdenVenta";
            this.txtIDOrdenVenta.ReadOnly = true;
            this.txtIDOrdenVenta.Size = new System.Drawing.Size(100, 20);
            this.txtIDOrdenVenta.TabIndex = 0;
            // 
            // frmOrdenVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 527);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvDetalleOrdenVenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.gbLineasVenta);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.gbPedido);
            this.Name = "frmOrdenVenta";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmOrdenVenta_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleOrdenVenta)).EndInit();
            this.gbLineasVenta.ResumeLayout(false);
            this.gbLineasVenta.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbPedido.ResumeLayout(false);
            this.gbPedido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.DataGridView dgvDetalleOrdenVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox gbLineasVenta;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDOrdenVenta;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}