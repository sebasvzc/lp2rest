namespace LP2Rest
{
    partial class frmGestionarPlatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarPlatos));
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.dgvInsumos = new System.Windows.Forms.DataGridView();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPedido = new System.Windows.Forms.GroupBox();
            this.txtIdPlato = new System.Windows.Forms.TextBox();
            this.txtGanancia = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombrePlato = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tlsBuscar = new System.Windows.Forms.ToolStrip();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtNombreInsumo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).BeginInit();
            this.gbPedido.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tlsBuscar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(554, 48);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(34, 23);
            this.btnAgregarProducto.TabIndex = 141;
            this.btnAgregarProducto.Text = "+";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(594, 48);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(34, 23);
            this.btnEliminarProducto.TabIndex = 142;
            this.btnEliminarProducto.Text = "-";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(93, 98);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(123, 21);
            this.cbCategoria.TabIndex = 13;
            // 
            // dgvInsumos
            // 
            this.dgvInsumos.AllowUserToAddRows = false;
            this.dgvInsumos.AllowUserToDeleteRows = false;
            this.dgvInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SKU,
            this.NombreInsumo,
            this.Cantidad,
            this.Costo,
            this.Subtotal});
            this.dgvInsumos.Location = new System.Drawing.Point(12, 81);
            this.dgvInsumos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInsumos.Name = "dgvInsumos";
            this.dgvInsumos.ReadOnly = true;
            this.dgvInsumos.RowHeadersWidth = 51;
            this.dgvInsumos.RowTemplate.Height = 24;
            this.dgvInsumos.Size = new System.Drawing.Size(616, 176);
            this.dgvInsumos.TabIndex = 61;
            this.dgvInsumos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvInsumos_CellFormatting);
            // 
            // SKU
            // 
            this.SKU.FillWeight = 75F;
            this.SKU.HeaderText = "SKU";
            this.SKU.MinimumWidth = 6;
            this.SKU.Name = "SKU";
            this.SKU.ReadOnly = true;
            this.SKU.Width = 75;
            // 
            // NombreInsumo
            // 
            this.NombreInsumo.HeaderText = "Nombre";
            this.NombreInsumo.MinimumWidth = 6;
            this.NombreInsumo.Name = "NombreInsumo";
            this.NombreInsumo.ReadOnly = true;
            this.NombreInsumo.Width = 210;
            // 
            // Cantidad
            // 
            this.Cantidad.FillWeight = 70F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 70;
            // 
            // Costo
            // 
            this.Costo.FillWeight = 105F;
            this.Costo.HeaderText = "Costo Unitario";
            this.Costo.MinimumWidth = 6;
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            this.Costo.Width = 105;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 6;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // gbPedido
            // 
            this.gbPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(246)))), ((int)(((byte)(238)))));
            this.gbPedido.Controls.Add(this.txtIdPlato);
            this.gbPedido.Controls.Add(this.txtGanancia);
            this.gbPedido.Controls.Add(this.txtPrecioVenta);
            this.gbPedido.Controls.Add(this.label7);
            this.gbPedido.Controls.Add(this.label6);
            this.gbPedido.Controls.Add(this.cbCategoria);
            this.gbPedido.Controls.Add(this.label8);
            this.gbPedido.Controls.Add(this.txtNombrePlato);
            this.gbPedido.Controls.Add(this.label3);
            this.gbPedido.Controls.Add(this.label2);
            this.gbPedido.Controls.Add(this.label1);
            this.gbPedido.Location = new System.Drawing.Point(10, 46);
            this.gbPedido.Name = "gbPedido";
            this.gbPedido.Size = new System.Drawing.Size(236, 297);
            this.gbPedido.TabIndex = 136;
            this.gbPedido.TabStop = false;
            this.gbPedido.Text = "Datos de los platos";
            // 
            // txtIdPlato
            // 
            this.txtIdPlato.Location = new System.Drawing.Point(93, 37);
            this.txtIdPlato.Name = "txtIdPlato";
            this.txtIdPlato.ReadOnly = true;
            this.txtIdPlato.Size = new System.Drawing.Size(123, 20);
            this.txtIdPlato.TabIndex = 145;
            // 
            // txtGanancia
            // 
            this.txtGanancia.Location = new System.Drawing.Point(93, 129);
            this.txtGanancia.Name = "txtGanancia";
            this.txtGanancia.Size = new System.Drawing.Size(123, 20);
            this.txtGanancia.TabIndex = 142;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(93, 160);
            this.txtPrecioVenta.Multiline = true;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.ReadOnly = true;
            this.txtPrecioVenta.Size = new System.Drawing.Size(123, 20);
            this.txtPrecioVenta.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 141;
            this.label7.Text = "Ganancia (%): ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Precio Venta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Categoria:";
            // 
            // txtNombrePlato
            // 
            this.txtNombrePlato.Location = new System.Drawing.Point(93, 67);
            this.txtNombrePlato.Name = "txtNombrePlato";
            this.txtNombrePlato.Size = new System.Drawing.Size(123, 20);
            this.txtNombrePlato.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Plato";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(246)))), ((int)(((byte)(238)))));
            this.groupBox1.Controls.Add(this.tlsBuscar);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.txtNombreInsumo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnEliminarProducto);
            this.groupBox1.Controls.Add(this.btnAgregarProducto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dgvInsumos);
            this.groupBox1.Location = new System.Drawing.Point(262, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 307);
            this.groupBox1.TabIndex = 137;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Insumos:";
            // 
            // tlsBuscar
            // 
            this.tlsBuscar.Dock = System.Windows.Forms.DockStyle.None;
            this.tlsBuscar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tlsBuscar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBuscar});
            this.tlsBuscar.Location = new System.Drawing.Point(406, 23);
            this.tlsBuscar.Name = "tlsBuscar";
            this.tlsBuscar.Size = new System.Drawing.Size(26, 25);
            this.tlsBuscar.TabIndex = 151;
            this.tlsBuscar.Text = "toolStrip2";
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(23, 22);
            this.btnBuscar.Text = "btnBuscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 147;
            this.label12.Text = "Cantidad:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(99, 55);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(34, 20);
            this.txtCantidad.TabIndex = 146;
            // 
            // txtNombreInsumo
            // 
            this.txtNombreInsumo.Location = new System.Drawing.Point(99, 25);
            this.txtNombreInsumo.Name = "txtNombreInsumo";
            this.txtNombreInsumo.ReadOnly = true;
            this.txtNombreInsumo.Size = new System.Drawing.Size(301, 20);
            this.txtNombreInsumo.TabIndex = 144;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 143;
            this.label11.Text = "Nombre Insumo:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(422, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Costo Total (S/.):";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(532, 272);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(96, 20);
            this.txtTotal.TabIndex = 64;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(484, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 139;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(346, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(162, 16);
            this.lblTitulo.TabIndex = 140;
            this.lblTitulo.Text = "GESTIÓN DE PLATOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(10, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 33);
            this.panel1.TabIndex = 141;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(369, 360);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 34);
            this.btnCancelar.TabIndex = 153;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(262, 360);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 34);
            this.btnGuardar.TabIndex = 152;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // frmGestionarPlatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 400);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbPedido);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmGestionarPlatos";
            this.Text = "frmGestionarPlatos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).EndInit();
            this.gbPedido.ResumeLayout(false);
            this.gbPedido.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tlsBuscar.ResumeLayout(false);
            this.tlsBuscar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombrePlato;
        private System.Windows.Forms.DataGridView dgvInsumos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtGanancia;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.TextBox txtNombreInsumo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIdPlato;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.ToolStrip tlsBuscar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}