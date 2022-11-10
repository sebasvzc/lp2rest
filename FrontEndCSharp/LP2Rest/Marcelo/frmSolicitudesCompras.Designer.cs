namespace LP2Rest
{
    partial class frmSolicitudesCompras
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMontoMax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarInsumo = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMontoMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumOrden = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaMaxRegistro = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaMinRegistro = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvOrdenCompras = new System.Windows.Forms.DataGridView();
            this.OrdenDeCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCumplimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnVerOC = new System.Windows.Forms.ToolStripButton();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenCompras)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(72, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 33);
            this.panel1.TabIndex = 147;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 8);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(234, 16);
            this.label2.TabIndex = 140;
            this.label2.Text = "Gestión de Solicitud de Compras";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMontoMax);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.txtMontoMin);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtNumOrden);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dtpFechaMaxRegistro);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblFechaNacimiento);
            this.groupBox3.Controls.Add(this.dtpFechaMinRegistro);
            this.groupBox3.Location = new System.Drawing.Point(73, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(638, 203);
            this.groupBox3.TabIndex = 148;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parametros Busqueda";
            // 
            // txtMontoMax
            // 
            this.txtMontoMax.Location = new System.Drawing.Point(93, 172);
            this.txtMontoMax.Name = "txtMontoMax";
            this.txtMontoMax.Size = new System.Drawing.Size(97, 20);
            this.txtMontoMax.TabIndex = 116;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 115;
            this.label9.Text = "Hasta:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 114;
            this.label8.Text = "Desde:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarInsumo);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSKU);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(15, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 85);
            this.groupBox2.TabIndex = 113;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insumo";
            // 
            // btnBuscarInsumo
            // 
            this.btnBuscarInsumo.Location = new System.Drawing.Point(186, 20);
            this.btnBuscarInsumo.Name = "btnBuscarInsumo";
            this.btnBuscarInsumo.Size = new System.Drawing.Size(93, 21);
            this.btnBuscarInsumo.TabIndex = 114;
            this.btnBuscarInsumo.Text = "Buscar Insumo";
            this.btnBuscarInsumo.UseVisualStyleBackColor = true;
            this.btnBuscarInsumo.Click += new System.EventHandler(this.btnBuscarInsumo_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(78, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(97, 20);
            this.txtNombre.TabIndex = 116;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 117;
            this.label7.Text = "Nombre:";
            // 
            // txtSKU
            // 
            this.txtSKU.Location = new System.Drawing.Point(78, 20);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(97, 20);
            this.txtSKU.TabIndex = 114;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 115;
            this.label4.Text = "SKU:";
            // 
            // txtMontoMin
            // 
            this.txtMontoMin.Location = new System.Drawing.Point(93, 142);
            this.txtMontoMin.Name = "txtMontoMin";
            this.txtMontoMin.Size = new System.Drawing.Size(97, 20);
            this.txtMontoMin.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 112;
            this.label3.Text = "Monto Total:";
            // 
            // txtNumOrden
            // 
            this.txtNumOrden.Location = new System.Drawing.Point(425, 48);
            this.txtNumOrden.Name = "txtNumOrden";
            this.txtNumOrden.Size = new System.Drawing.Size(121, 20);
            this.txtNumOrden.TabIndex = 109;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 109;
            this.label6.Text = "Numero Orden:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(557, 165);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 92;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(97, 243);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(79, 20);
            this.textBox3.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 91;
            this.label1.Text = "Hasta:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFechaMaxRegistro
            // 
            this.dtpFechaMaxRegistro.Location = new System.Drawing.Point(424, 139);
            this.dtpFechaMaxRegistro.Name = "dtpFechaMaxRegistro";
            this.dtpFechaMaxRegistro.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaMaxRegistro.TabIndex = 90;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 89;
            this.label5.Text = "Desde:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(333, 83);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(149, 13);
            this.lblFechaNacimiento.TabIndex = 88;
            this.lblFechaNacimiento.Text = "Rango de Fechas de Registro";
            // 
            // dtpFechaMinRegistro
            // 
            this.dtpFechaMinRegistro.Location = new System.Drawing.Point(424, 108);
            this.dtpFechaMinRegistro.Name = "dtpFechaMinRegistro";
            this.dtpFechaMinRegistro.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaMinRegistro.TabIndex = 110;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOrdenCompras);
            this.groupBox1.Location = new System.Drawing.Point(73, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 275);
            this.groupBox1.TabIndex = 149;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Órdenes del insumo";
            // 
            // dgvOrdenCompras
            // 
            this.dgvOrdenCompras.AllowUserToAddRows = false;
            this.dgvOrdenCompras.AllowUserToDeleteRows = false;
            this.dgvOrdenCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrdenDeCompra,
            this.Proveedor,
            this.fechaRegistro,
            this.FechaCumplimiento,
            this.subtotal,
            this.Estado});
            this.dgvOrdenCompras.Location = new System.Drawing.Point(24, 34);
            this.dgvOrdenCompras.Name = "dgvOrdenCompras";
            this.dgvOrdenCompras.ReadOnly = true;
            this.dgvOrdenCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdenCompras.Size = new System.Drawing.Size(609, 220);
            this.dgvOrdenCompras.TabIndex = 78;
            this.dgvOrdenCompras.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOrdenCompras_CellFormatting);
            // 
            // OrdenDeCompra
            // 
            this.OrdenDeCompra.HeaderText = "Orden de Compra";
            this.OrdenDeCompra.Name = "OrdenDeCompra";
            this.OrdenDeCompra.ReadOnly = true;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            // 
            // fechaRegistro
            // 
            this.fechaRegistro.HeaderText = "Fecha de Registro";
            this.fechaRegistro.Name = "fechaRegistro";
            this.fechaRegistro.ReadOnly = true;
            this.fechaRegistro.Width = 130;
            // 
            // FechaCumplimiento
            // 
            this.FechaCumplimiento.HeaderText = "Fecha de Cumplimiento";
            this.FechaCumplimiento.Name = "FechaCumplimiento";
            this.FechaCumplimiento.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Monto Total";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            this.subtotal.Width = 80;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVerOC,
            this.btnNuevo,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(227, 579);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(351, 31);
            this.toolStrip1.TabIndex = 150;
            this.toolStrip1.Text = "tsMenu";
            // 
            // btnVerOC
            // 
            this.btnVerOC.Font = new System.Drawing.Font("MS UI Gothic", 8F);
            this.btnVerOC.Image = global::LP2Rest.Properties.Resources._1263922;
            this.btnVerOC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVerOC.Name = "btnVerOC";
            this.btnVerOC.Size = new System.Drawing.Size(134, 28);
            this.btnVerOC.Text = "&Ver Orden de Compra";
            this.btnVerOC.Click += new System.EventHandler(this.btnVerOC_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("MS UI Gothic", 8F);
            this.btnNuevo.Image = global::LP2Rest.Properties.Resources.new_file_40454;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(63, 28);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = global::LP2Rest.Properties.Resources.trash_40429;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(68, 28);
            this.toolStripButton1.Text = "&Eliminar";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("MS UI Gothic", 8F);
            this.toolStripButton2.Image = global::LP2Rest.Properties.Resources.edit_validated_40458;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(74, 28);
            this.toolStripButton2.Text = "&Modificar";
            // 
            // frmSolicitudesCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 631);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Name = "frmSolicitudesCompras";
            this.Text = "frmSolicitudesCompras";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenCompras)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMontoMax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarInsumo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMontoMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumOrden;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaMaxRegistro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaMinRegistro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOrdenCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdenDeCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCumplimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnVerOC;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}