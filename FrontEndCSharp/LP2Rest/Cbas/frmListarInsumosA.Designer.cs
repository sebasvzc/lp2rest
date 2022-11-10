namespace LP2Rest
{
    partial class frmListarInsumosA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStockMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStockMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvInsumos = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDNINombre = new System.Windows.Forms.Label();
            this.txtPrecioMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecioMin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboPlato = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoProducto = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSKU
            // 
            this.txtSKU.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtSKU.Location = new System.Drawing.Point(427, 67);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(309, 32);
            this.txtSKU.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label8.Location = new System.Drawing.Point(427, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 29);
            this.label8.TabIndex = 74;
            this.label8.Text = "SKU:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStockMax
            // 
            this.txtStockMax.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtStockMax.Location = new System.Drawing.Point(427, 262);
            this.txtStockMax.Name = "txtStockMax";
            this.txtStockMax.Size = new System.Drawing.Size(309, 32);
            this.txtStockMax.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label5.Location = new System.Drawing.Point(427, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 29);
            this.label5.TabIndex = 70;
            this.label5.Text = "Hasta:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label6.Location = new System.Drawing.Point(427, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 29);
            this.label6.TabIndex = 69;
            this.label6.Text = "Desde:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStockMin
            // 
            this.txtStockMin.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtStockMin.Location = new System.Drawing.Point(427, 192);
            this.txtStockMin.Name = "txtStockMin";
            this.txtStockMin.Size = new System.Drawing.Size(309, 32);
            this.txtStockMin.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label4.Location = new System.Drawing.Point(423, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 30);
            this.label4.TabIndex = 67;
            this.label4.Text = "Stock";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvInsumos
            // 
            this.dgvInsumos.AllowUserToAddRows = false;
            this.dgvInsumos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInsumos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SKU,
            this.Nombre,
            this.Precio,
            this.Stock,
            this.TipoProducto});
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInsumos.DefaultCellStyle = dataGridViewCellStyle32;
            this.dgvInsumos.Location = new System.Drawing.Point(37, 331);
            this.dgvInsumos.Name = "dgvInsumos";
            this.dgvInsumos.ReadOnly = true;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInsumos.RowHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dgvInsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInsumos.Size = new System.Drawing.Size(1027, 346);
            this.dgvInsumos.TabIndex = 58;
            this.dgvInsumos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvInsumos_CellFormatting);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtNombre.Location = new System.Drawing.Point(83, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(313, 32);
            this.txtNombre.TabIndex = 56;
            // 
            // lblDNINombre
            // 
            this.lblDNINombre.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.lblDNINombre.Location = new System.Drawing.Point(83, 35);
            this.lblDNINombre.Name = "lblDNINombre";
            this.lblDNINombre.Size = new System.Drawing.Size(232, 29);
            this.lblDNINombre.TabIndex = 55;
            this.lblDNINombre.Text = "Nombre:";
            this.lblDNINombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPrecioMax
            // 
            this.txtPrecioMax.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtPrecioMax.Location = new System.Drawing.Point(87, 262);
            this.txtPrecioMax.Name = "txtPrecioMax";
            this.txtPrecioMax.Size = new System.Drawing.Size(309, 32);
            this.txtPrecioMax.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label3.Location = new System.Drawing.Point(87, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 29);
            this.label3.TabIndex = 80;
            this.label3.Text = "Hasta:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label7.Location = new System.Drawing.Point(87, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 29);
            this.label7.TabIndex = 79;
            this.label7.Text = "Desde:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPrecioMin
            // 
            this.txtPrecioMin.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtPrecioMin.Location = new System.Drawing.Point(87, 192);
            this.txtPrecioMin.Name = "txtPrecioMin";
            this.txtPrecioMin.Size = new System.Drawing.Size(309, 32);
            this.txtPrecioMin.TabIndex = 78;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label9.Location = new System.Drawing.Point(87, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(309, 30);
            this.label9.TabIndex = 77;
            this.label9.Text = "Precio";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboPlato
            // 
            this.cboPlato.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cboPlato.FormattingEnabled = true;
            this.cboPlato.Location = new System.Drawing.Point(764, 67);
            this.cboPlato.Name = "cboPlato";
            this.cboPlato.Size = new System.Drawing.Size(244, 33);
            this.cboPlato.TabIndex = 90;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label10.Location = new System.Drawing.Point(764, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 29);
            this.label10.TabIndex = 91;
            this.label10.Text = "Plato:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label1.Location = new System.Drawing.Point(764, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 29);
            this.label1.TabIndex = 93;
            this.label1.Text = "Tipo Producto:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboTipoProducto
            // 
            this.cboTipoProducto.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cboTipoProducto.FormattingEnabled = true;
            this.cboTipoProducto.Location = new System.Drawing.Point(764, 192);
            this.cboTipoProducto.Name = "cboTipoProducto";
            this.cboTipoProducto.Size = new System.Drawing.Size(244, 33);
            this.cboTipoProducto.TabIndex = 92;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(153)))), ((int)(((byte)(96)))));
            this.btnCancelar.Location = new System.Drawing.Point(957, 708);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 41);
            this.btnCancelar.TabIndex = 96;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(153)))), ((int)(((byte)(96)))));
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(832, 708);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(122, 41);
            this.btnSeleccionar.TabIndex = 95;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Sienna;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.NavajoWhite;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(37, 708);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(234, 41);
            this.btnBuscar.TabIndex = 94;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(618, 708);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 41);
            this.btnEliminar.TabIndex = 99;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(497, 708);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(115, 41);
            this.btnModificar.TabIndex = 98;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(376, 708);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(115, 41);
            this.btnNuevo.TabIndex = 97;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // SKU
            // 
            this.SKU.HeaderText = "SKU";
            this.SKU.Name = "SKU";
            this.SKU.ReadOnly = true;
            this.SKU.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 376;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // TipoProducto
            // 
            this.TipoProducto.HeaderText = "TipoProducto";
            this.TipoProducto.Name = "TipoProducto";
            this.TipoProducto.ReadOnly = true;
            this.TipoProducto.Width = 258;
            // 
            // frmListarInsumosA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 774);
            this.Controls.Add(this.cboTipoProducto);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboPlato);
            this.Controls.Add(this.txtPrecioMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrecioMin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSKU);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtStockMax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStockMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvInsumos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDNINombre);
            this.Name = "frmListarInsumosA";
            this.Text = "Listado de Insumos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStockMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStockMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvInsumos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDNINombre;
        private System.Windows.Forms.TextBox txtPrecioMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecioMin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboPlato;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipoProducto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoProducto;
    }
}