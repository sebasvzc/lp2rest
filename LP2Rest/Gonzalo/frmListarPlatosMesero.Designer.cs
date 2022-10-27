namespace LP2Rest.Gonzalo
{
    partial class frmListarPlatosMesero
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
            this.dgvItemsVenta = new System.Windows.Forms.DataGridView();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teléfono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoría = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPedido = new System.Windows.Forms.GroupBox();
            this.txtPrecioMax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecioMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarPlatoCombo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboDisponible = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsVenta)).BeginInit();
            this.gbPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(17, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 50);
            this.panel1.TabIndex = 146;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(489, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 20);
            this.label2.TabIndex = 140;
            this.label2.Text = "LISTADO DE PLATOS Y COMBOS";
            // 
            // dgvItemsVenta
            // 
            this.dgvItemsVenta.AllowUserToAddRows = false;
            this.dgvItemsVenta.AllowUserToDeleteRows = false;
            this.dgvItemsVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCompleto,
            this.Teléfono,
            this.Categoría,
            this.email,
            this.Stock});
            this.dgvItemsVenta.Location = new System.Drawing.Point(17, 301);
            this.dgvItemsVenta.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dgvItemsVenta.Name = "dgvItemsVenta";
            this.dgvItemsVenta.ReadOnly = true;
            this.dgvItemsVenta.RowHeadersWidth = 51;
            this.dgvItemsVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemsVenta.Size = new System.Drawing.Size(1265, 368);
            this.dgvItemsVenta.TabIndex = 145;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "ID ItemVenta";
            this.NombreCompleto.MinimumWidth = 6;
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 233;
            // 
            // Teléfono
            // 
            this.Teléfono.HeaderText = "Nombre";
            this.Teléfono.MinimumWidth = 6;
            this.Teléfono.Name = "Teléfono";
            this.Teléfono.ReadOnly = true;
            this.Teléfono.Width = 90;
            // 
            // Categoría
            // 
            this.Categoría.HeaderText = "Categoría";
            this.Categoría.MinimumWidth = 6;
            this.Categoría.Name = "Categoría";
            this.Categoría.ReadOnly = true;
            this.Categoría.Width = 120;
            // 
            // email
            // 
            this.email.HeaderText = "Precio";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 140;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 125;
            // 
            // gbPedido
            // 
            this.gbPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(246)))), ((int)(((byte)(238)))));
            this.gbPedido.Controls.Add(this.txtPrecioMax);
            this.gbPedido.Controls.Add(this.label7);
            this.gbPedido.Controls.Add(this.label6);
            this.gbPedido.Controls.Add(this.txtPrecioMin);
            this.gbPedido.Controls.Add(this.label5);
            this.gbPedido.Controls.Add(this.cboCategoria);
            this.gbPedido.Controls.Add(this.label4);
            this.gbPedido.Controls.Add(this.txtNombre);
            this.gbPedido.Controls.Add(this.label1);
            this.gbPedido.Controls.Add(this.btnBuscarPlatoCombo);
            this.gbPedido.Controls.Add(this.label3);
            this.gbPedido.Controls.Add(this.label9);
            this.gbPedido.Controls.Add(this.cboDisponible);
            this.gbPedido.Location = new System.Drawing.Point(17, 82);
            this.gbPedido.Margin = new System.Windows.Forms.Padding(5);
            this.gbPedido.Name = "gbPedido";
            this.gbPedido.Padding = new System.Windows.Forms.Padding(5);
            this.gbPedido.Size = new System.Drawing.Size(1265, 191);
            this.gbPedido.TabIndex = 147;
            this.gbPedido.TabStop = false;
            this.gbPedido.Text = "Seleccione criterio de búsqueda";
            // 
            // txtPrecioMax
            // 
            this.txtPrecioMax.Location = new System.Drawing.Point(612, 142);
            this.txtPrecioMax.Margin = new System.Windows.Forms.Padding(5);
            this.txtPrecioMax.Name = "txtPrecioMax";
            this.txtPrecioMax.Size = new System.Drawing.Size(276, 22);
            this.txtPrecioMax.TabIndex = 150;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(532, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 149;
            this.label7.Text = "Hasta: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(532, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 148;
            this.label6.Text = "Desde:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrecioMin
            // 
            this.txtPrecioMin.Location = new System.Drawing.Point(612, 100);
            this.txtPrecioMin.Margin = new System.Windows.Forms.Padding(5);
            this.txtPrecioMin.Name = "txtPrecioMin";
            this.txtPrecioMin.Size = new System.Drawing.Size(276, 22);
            this.txtPrecioMin.TabIndex = 147;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(701, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 146;
            this.label5.Text = "Rango de Precios:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(139, 96);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(281, 24);
            this.cboCategoria.TabIndex = 145;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 144;
            this.label4.Text = "Categoría:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(139, 52);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(281, 22);
            this.txtNombre.TabIndex = 143;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 135;
            this.label1.Text = "Disponible:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBuscarPlatoCombo
            // 
            this.btnBuscarPlatoCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBuscarPlatoCombo.Location = new System.Drawing.Point(971, 107);
            this.btnBuscarPlatoCombo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnBuscarPlatoCombo.Name = "btnBuscarPlatoCombo";
            this.btnBuscarPlatoCombo.Size = new System.Drawing.Size(251, 42);
            this.btnBuscarPlatoCombo.TabIndex = 132;
            this.btnBuscarPlatoCombo.Text = "Buscar";
            this.btnBuscarPlatoCombo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 53);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 129;
            this.label9.Text = "Nombre:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboDisponible
            // 
            this.cboDisponible.FormattingEnabled = true;
            this.cboDisponible.Location = new System.Drawing.Point(139, 138);
            this.cboDisponible.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cboDisponible.Name = "cboDisponible";
            this.cboDisponible.Size = new System.Drawing.Size(281, 24);
            this.cboDisponible.TabIndex = 130;
            // 
            // frmListarPlatosMesero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvItemsVenta);
            this.Controls.Add(this.gbPedido);
            this.Name = "frmListarPlatosMesero";
            this.Text = "frmListarPlatosMesero";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsVenta)).EndInit();
            this.gbPedido.ResumeLayout(false);
            this.gbPedido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvItemsVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teléfono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoría;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.GroupBox gbPedido;
        private System.Windows.Forms.TextBox txtPrecioMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecioMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarPlatoCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboDisponible;
    }
}