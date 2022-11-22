namespace LP2Rest
{
    partial class frmListarPlatos
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
            this.dgvItemsVenta = new System.Windows.Forms.DataGridView();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teléfono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoría = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboDisponible = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbPedido = new System.Windows.Forms.GroupBox();
            this.txtPrecioMax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecioMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarPlatoCombo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNuevoCombo = new System.Windows.Forms.Button();
            this.btnNuevoPlato = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsVenta)).BeginInit();
            this.gbPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvItemsVenta
            // 
            this.dgvItemsVenta.AllowUserToAddRows = false;
            this.dgvItemsVenta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemsVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItemsVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCompleto,
            this.Teléfono,
            this.Categoría,
            this.email,
            this.Stock});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItemsVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItemsVenta.Location = new System.Drawing.Point(37, 260);
            this.dgvItemsVenta.Margin = new System.Windows.Forms.Padding(5);
            this.dgvItemsVenta.Name = "dgvItemsVenta";
            this.dgvItemsVenta.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemsVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItemsVenta.RowHeadersWidth = 51;
            this.dgvItemsVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemsVenta.Size = new System.Drawing.Size(1015, 388);
            this.dgvItemsVenta.TabIndex = 131;
            this.dgvItemsVenta.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvItemsVenta_CellFormatting);
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
            this.Teléfono.Width = 344;
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
            // cboDisponible
            // 
            this.cboDisponible.FormattingEnabled = true;
            this.cboDisponible.Location = new System.Drawing.Point(167, 138);
            this.cboDisponible.Margin = new System.Windows.Forms.Padding(5);
            this.cboDisponible.Name = "cboDisponible";
            this.cboDisponible.Size = new System.Drawing.Size(376, 31);
            this.cboDisponible.TabIndex = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 135;
            this.label1.Text = "Disponible:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 43);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 23);
            this.label9.TabIndex = 129;
            this.label9.Text = "Nombre:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(167, 42);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(376, 30);
            this.txtNombre.TabIndex = 143;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 8;
            // 
            // gbPedido
            // 
            this.gbPedido.BackColor = System.Drawing.SystemColors.Control;
            this.gbPedido.Controls.Add(this.txtPrecioMax);
            this.gbPedido.Controls.Add(this.label7);
            this.gbPedido.Controls.Add(this.label6);
            this.gbPedido.Controls.Add(this.txtPrecioMin);
            this.gbPedido.Controls.Add(this.label5);
            this.gbPedido.Controls.Add(this.cboCategoria);
            this.gbPedido.Controls.Add(this.label4);
            this.gbPedido.Controls.Add(this.txtNombre);
            this.gbPedido.Controls.Add(this.label1);
            this.gbPedido.Controls.Add(this.label3);
            this.gbPedido.Controls.Add(this.label9);
            this.gbPedido.Controls.Add(this.cboDisponible);
            this.gbPedido.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.gbPedido.Location = new System.Drawing.Point(37, 29);
            this.gbPedido.Margin = new System.Windows.Forms.Padding(4);
            this.gbPedido.Name = "gbPedido";
            this.gbPedido.Padding = new System.Windows.Forms.Padding(4);
            this.gbPedido.Size = new System.Drawing.Size(1015, 197);
            this.gbPedido.TabIndex = 144;
            this.gbPedido.TabStop = false;
            this.gbPedido.Text = "Seleccione criterio de búsqueda";
            // 
            // txtPrecioMax
            // 
            this.txtPrecioMax.Location = new System.Drawing.Point(698, 139);
            this.txtPrecioMax.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioMax.Name = "txtPrecioMax";
            this.txtPrecioMax.Size = new System.Drawing.Size(208, 30);
            this.txtPrecioMax.TabIndex = 150;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(625, 143);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 23);
            this.label7.TabIndex = 149;
            this.label7.Text = "Hasta: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(620, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 148;
            this.label6.Text = "Desde:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrecioMin
            // 
            this.txtPrecioMin.Location = new System.Drawing.Point(699, 86);
            this.txtPrecioMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioMin.Name = "txtPrecioMin";
            this.txtPrecioMin.Size = new System.Drawing.Size(208, 30);
            this.txtPrecioMin.TabIndex = 147;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(712, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 23);
            this.label5.TabIndex = 146;
            this.label5.Text = "Rango de Precios";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(167, 89);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(5);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(376, 31);
            this.cboCategoria.TabIndex = 145;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 23);
            this.label4.TabIndex = 144;
            this.label4.Text = "Categoría:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBuscarPlatoCombo
            // 
            this.btnBuscarPlatoCombo.BackColor = System.Drawing.Color.Sienna;
            this.btnBuscarPlatoCombo.FlatAppearance.BorderColor = System.Drawing.Color.NavajoWhite;
            this.btnBuscarPlatoCombo.FlatAppearance.BorderSize = 0;
            this.btnBuscarPlatoCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPlatoCombo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnBuscarPlatoCombo.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPlatoCombo.Location = new System.Drawing.Point(37, 690);
            this.btnBuscarPlatoCombo.Name = "btnBuscarPlatoCombo";
            this.btnBuscarPlatoCombo.Size = new System.Drawing.Size(234, 41);
            this.btnBuscarPlatoCombo.TabIndex = 145;
            this.btnBuscarPlatoCombo.Text = "Buscar";
            this.btnBuscarPlatoCombo.UseVisualStyleBackColor = false;
            this.btnBuscarPlatoCombo.Click += new System.EventHandler(this.btnBuscarPlatoCombo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(937, 690);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 41);
            this.button1.TabIndex = 148;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(816, 690);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 41);
            this.button2.TabIndex = 147;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevoCombo
            // 
            this.btnNuevoCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnNuevoCombo.FlatAppearance.BorderSize = 0;
            this.btnNuevoCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCombo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnNuevoCombo.ForeColor = System.Drawing.Color.White;
            this.btnNuevoCombo.Location = new System.Drawing.Point(498, 690);
            this.btnNuevoCombo.Name = "btnNuevoCombo";
            this.btnNuevoCombo.Size = new System.Drawing.Size(154, 41);
            this.btnNuevoCombo.TabIndex = 146;
            this.btnNuevoCombo.Text = "Nuevo Combo";
            this.btnNuevoCombo.UseVisualStyleBackColor = false;
            this.btnNuevoCombo.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnNuevoPlato
            // 
            this.btnNuevoPlato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnNuevoPlato.FlatAppearance.BorderSize = 0;
            this.btnNuevoPlato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPlato.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnNuevoPlato.ForeColor = System.Drawing.Color.White;
            this.btnNuevoPlato.Location = new System.Drawing.Point(658, 690);
            this.btnNuevoPlato.Name = "btnNuevoPlato";
            this.btnNuevoPlato.Size = new System.Drawing.Size(152, 41);
            this.btnNuevoPlato.TabIndex = 149;
            this.btnNuevoPlato.Text = "Nuevo Plato";
            this.btnNuevoPlato.UseVisualStyleBackColor = false;
            this.btnNuevoPlato.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmListarPlatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 768);
            this.Controls.Add(this.btnNuevoPlato);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnNuevoCombo);
            this.Controls.Add(this.btnBuscarPlatoCombo);
            this.Controls.Add(this.dgvItemsVenta);
            this.Controls.Add(this.gbPedido);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListarPlatos";
            this.Text = "frmListarPlatos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsVenta)).EndInit();
            this.gbPedido.ResumeLayout(false);
            this.gbPedido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvItemsVenta;
        private System.Windows.Forms.ComboBox cboDisponible;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbPedido;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecioMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teléfono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoría;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.Button btnBuscarPlatoCombo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNuevoCombo;
        private System.Windows.Forms.Button btnNuevoPlato;
    }
}