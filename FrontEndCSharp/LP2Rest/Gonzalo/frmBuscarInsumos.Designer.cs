namespace LP2Rest
{
    partial class frmBuscarInsumos
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
            this.btnSeleccionarInsumo = new System.Windows.Forms.Button();
            this.dgvInsumos = new System.Windows.Forms.DataGridView();
            this.sku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarInsumo = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDNINombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionarInsumo
            // 
            this.btnSeleccionarInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionarInsumo.Location = new System.Drawing.Point(580, 54);
            this.btnSeleccionarInsumo.Name = "btnSeleccionarInsumo";
            this.btnSeleccionarInsumo.Size = new System.Drawing.Size(106, 23);
            this.btnSeleccionarInsumo.TabIndex = 102;
            this.btnSeleccionarInsumo.Text = "Seleccionar";
            this.btnSeleccionarInsumo.UseVisualStyleBackColor = true;
            this.btnSeleccionarInsumo.Click += new System.EventHandler(this.btnSeleccionarInsumo_Click);
            // 
            // dgvInsumos
            // 
            this.dgvInsumos.AllowUserToAddRows = false;
            this.dgvInsumos.AllowUserToDeleteRows = false;
            this.dgvInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sku,
            this.Nombre,
            this.PrecioCompra});
            this.dgvInsumos.Location = new System.Drawing.Point(24, 97);
            this.dgvInsumos.Name = "dgvInsumos";
            this.dgvInsumos.ReadOnly = true;
            this.dgvInsumos.RowHeadersWidth = 51;
            this.dgvInsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInsumos.Size = new System.Drawing.Size(662, 245);
            this.dgvInsumos.TabIndex = 101;
            this.dgvInsumos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEmpleados_CellFormatting);
            // 
            // sku
            // 
            this.sku.HeaderText = "SKU";
            this.sku.MinimumWidth = 6;
            this.sku.Name = "sku";
            this.sku.ReadOnly = true;
            this.sku.Width = 120;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 233;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.MinimumWidth = 6;
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Width = 240;
            // 
            // btnBuscarInsumo
            // 
            this.btnBuscarInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBuscarInsumo.Location = new System.Drawing.Point(468, 54);
            this.btnBuscarInsumo.Name = "btnBuscarInsumo";
            this.btnBuscarInsumo.Size = new System.Drawing.Size(106, 23);
            this.btnBuscarInsumo.TabIndex = 100;
            this.btnBuscarInsumo.Text = "Buscar";
            this.btnBuscarInsumo.UseVisualStyleBackColor = true;
            this.btnBuscarInsumo.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(133, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(260, 20);
            this.txtNombre.TabIndex = 99;
            // 
            // lblDNINombre
            // 
            this.lblDNINombre.AutoSize = true;
            this.lblDNINombre.Location = new System.Drawing.Point(22, 60);
            this.lblDNINombre.Name = "lblDNINombre";
            this.lblDNINombre.Size = new System.Drawing.Size(100, 13);
            this.lblDNINombre.TabIndex = 98;
            this.lblDNINombre.Text = "Nombre del insumo:";
            this.lblDNINombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(286, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(160, 16);
            this.lblTitulo.TabIndex = 97;
            this.lblTitulo.Text = "Búsqueda de Insumos";
            // 
            // frmBuscarInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 366);
            this.Controls.Add(this.btnSeleccionarInsumo);
            this.Controls.Add(this.dgvInsumos);
            this.Controls.Add(this.btnBuscarInsumo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDNINombre);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmBuscarInsumos";
            this.Text = "frmBuscarInsumos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionarInsumo;
        private System.Windows.Forms.DataGridView dgvInsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn sku;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.Button btnBuscarInsumo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDNINombre;
        private System.Windows.Forms.Label lblTitulo;
    }
}