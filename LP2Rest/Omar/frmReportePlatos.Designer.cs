namespace LP2Rest
{
    partial class frmReportePlatos
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
            this.cbPlatos = new System.Windows.Forms.CheckBox();
            this.cbBebidas = new System.Windows.Forms.CheckBox();
            this.cbCombos = new System.Windows.Forms.CheckBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.pbPDF = new System.Windows.Forms.PictureBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadVendida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNombreItemVenta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPlatos
            // 
            this.cbPlatos.AutoSize = true;
            this.cbPlatos.Location = new System.Drawing.Point(16, 85);
            this.cbPlatos.Name = "cbPlatos";
            this.cbPlatos.Size = new System.Drawing.Size(55, 17);
            this.cbPlatos.TabIndex = 0;
            this.cbPlatos.Text = "Platos";
            this.cbPlatos.UseVisualStyleBackColor = true;
            // 
            // cbBebidas
            // 
            this.cbBebidas.AutoSize = true;
            this.cbBebidas.Location = new System.Drawing.Point(77, 85);
            this.cbBebidas.Name = "cbBebidas";
            this.cbBebidas.Size = new System.Drawing.Size(64, 17);
            this.cbBebidas.TabIndex = 1;
            this.cbBebidas.Text = "Bebidas";
            this.cbBebidas.UseVisualStyleBackColor = true;
            // 
            // cbCombos
            // 
            this.cbCombos.AutoSize = true;
            this.cbCombos.Location = new System.Drawing.Point(152, 85);
            this.cbCombos.Name = "cbCombos";
            this.cbCombos.Size = new System.Drawing.Size(64, 17);
            this.cbCombos.TabIndex = 2;
            this.cbCombos.Text = "Combos";
            this.cbCombos.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(617, 85);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(64, 23);
            this.btnGenerar.TabIndex = 15;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // pbPDF
            // 
            this.pbPDF.Image = global::LP2Rest.Properties.Resources.pngegg__1_;
            this.pbPDF.Location = new System.Drawing.Point(618, 11);
            this.pbPDF.Margin = new System.Windows.Forms.Padding(2);
            this.pbPDF.Name = "pbPDF";
            this.pbPDF.Size = new System.Drawing.Size(64, 69);
            this.pbPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPDF.TabIndex = 16;
            this.pbPDF.TabStop = false;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.precio,
            this.categoria,
            this.stock,
            this.cantidadVendida});
            this.dgvProductos.Location = new System.Drawing.Point(16, 120);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(666, 182);
            this.dgvProductos.TabIndex = 17;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 160;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // cantidadVendida
            // 
            this.cantidadVendida.HeaderText = "Cantidad Vendida";
            this.cantidadVendida.Name = "cantidadVendida";
            this.cantidadVendida.ReadOnly = true;
            this.cantidadVendida.Width = 150;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(232, 47);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(16, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 19;
            // 
            // lbNombreItemVenta
            // 
            this.lbNombreItemVenta.AutoSize = true;
            this.lbNombreItemVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreItemVenta.Location = new System.Drawing.Point(13, 21);
            this.lbNombreItemVenta.Name = "lbNombreItemVenta";
            this.lbNombreItemVenta.Size = new System.Drawing.Size(195, 15);
            this.lbNombreItemVenta.TabIndex = 18;
            this.lbNombreItemVenta.Text = "Ingrese el nombre de un producto:";
            // 
            // frmReportePlatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 314);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbNombreItemVenta);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.pbPDF);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.cbCombos);
            this.Controls.Add(this.cbBebidas);
            this.Controls.Add(this.cbPlatos);
            this.Name = "frmReportePlatos";
            this.Text = "Reporte de Platos";
            ((System.ComponentModel.ISupportInitialize)(this.pbPDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbPlatos;
        private System.Windows.Forms.CheckBox cbBebidas;
        private System.Windows.Forms.CheckBox cbCombos;
        private System.Windows.Forms.PictureBox pbPDF;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadVendida;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbNombreItemVenta;
    }
}