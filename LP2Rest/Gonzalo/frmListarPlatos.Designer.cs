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
            this.btnBuscarPlatoCombo = new System.Windows.Forms.Button();
            this.dgvItemsVenta = new System.Windows.Forms.DataGridView();
            this.cboDisponible = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevoCombo = new System.Windows.Forms.ToolStripButton();
            this.btnNuevoPlato = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
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
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teléfono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoría = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsVenta)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscarPlatoCombo
            // 

            this.btnBuscarPlatoCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBuscarPlatoCombo.Location = new System.Drawing.Point(794, 78);
            this.btnBuscarPlatoCombo.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscarPlatoCombo.Name = "btnBuscarPlatoCombo";
            this.btnBuscarPlatoCombo.Size = new System.Drawing.Size(188, 34);
            this.btnBuscarPlatoCombo.TabIndex = 132;
            this.btnBuscarPlatoCombo.Text = "Buscar";
            this.btnBuscarPlatoCombo.UseVisualStyleBackColor = true;
            
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
            this.dgvItemsVenta.Location = new System.Drawing.Point(37, 261);
            this.dgvItemsVenta.Margin = new System.Windows.Forms.Padding(5);
            this.dgvItemsVenta.Name = "dgvItemsVenta";
            this.dgvItemsVenta.ReadOnly = true;
            this.dgvItemsVenta.RowHeadersWidth = 51;
            this.dgvItemsVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemsVenta.Size = new System.Drawing.Size(1015, 299);
            this.dgvItemsVenta.TabIndex = 131;
            // 
            // cboDisponible
            // 
            this.cboDisponible.FormattingEnabled = true;
            this.cboDisponible.Location = new System.Drawing.Point(104, 112);
            this.cboDisponible.Margin = new System.Windows.Forms.Padding(5);
            this.cboDisponible.Name = "cboDisponible";
            this.cboDisponible.Size = new System.Drawing.Size(270, 24);
            this.cboDisponible.TabIndex = 130;
            this.cboDisponible.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);

            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevoCombo,
            this.btnNuevoPlato,
            this.btnModificar,

            this.btnEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(294, 591);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(498, 27);

            this.toolStrip1.TabIndex = 133;
            this.toolStrip1.Text = "tsMenu";
            // 
            // btnNuevoCombo
            // 

            this.btnNuevoCombo.Image = global::LP2Rest.Properties.Resources.new_file_40454;
            this.btnNuevoCombo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevoCombo.Name = "btnNuevoCombo";
            this.btnNuevoCombo.Size = new System.Drawing.Size(129, 24);
            this.btnNuevoCombo.Text = "&Nuevo Combo";
            this.btnNuevoCombo.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnNuevoPlato
            // 
            this.btnNuevoPlato.Image = global::LP2Rest.Properties.Resources.new_file_40454;
            this.btnNuevoPlato.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevoPlato.Name = "btnNuevoPlato";
            this.btnNuevoPlato.Size = new System.Drawing.Size(114, 24);
            this.btnNuevoPlato.Text = "&Nuevo Plato";
            this.btnNuevoPlato.Click += new System.EventHandler(this.btnNuevo_Click);

            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::LP2Rest.Properties.Resources.edit_validated_40458;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";

            this.btnModificar.Size = new System.Drawing.Size(155, 24);
            this.btnModificar.Text = "&Detalle/Modificar ";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::LP2Rest.Properties.Resources.trash_40429;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(74, 24);
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            // 
            // label1
            // 
            this.label1.AutoSize = true;

            this.label1.Location = new System.Drawing.Point(19, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);

            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 135;
            this.label1.Text = "Disponible:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(37, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 41);
            this.panel1.TabIndex = 142;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 20);
            this.label2.TabIndex = 140;
            this.label2.Text = "LISTADO DE PLATOS Y COMBOS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 43);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 129;
            this.label9.Text = "Nombre:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 42);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(270, 22);
            this.txtNombre.TabIndex = 143;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 8;
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
            this.gbPedido.Location = new System.Drawing.Point(37, 83);
            this.gbPedido.Margin = new System.Windows.Forms.Padding(4);
            this.gbPedido.Name = "gbPedido";
            this.gbPedido.Padding = new System.Windows.Forms.Padding(4);
            this.gbPedido.Size = new System.Drawing.Size(1015, 155);
            this.gbPedido.TabIndex = 144;
            this.gbPedido.TabStop = false;
            this.gbPedido.Text = "Seleccione criterio de búsqueda";
            // 
            // txtPrecioMax
            // 
            this.txtPrecioMax.Location = new System.Drawing.Point(526, 109);
            this.txtPrecioMax.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioMax.Name = "txtPrecioMax";
            this.txtPrecioMax.Size = new System.Drawing.Size(208, 22);
            this.txtPrecioMax.TabIndex = 150;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 112);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 149;
            this.label7.Text = "Hasta: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 148;
            this.label6.Text = "Desde:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrecioMin
            // 
            this.txtPrecioMin.Location = new System.Drawing.Point(526, 75);
            this.txtPrecioMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioMin.Name = "txtPrecioMin";
            this.txtPrecioMin.Size = new System.Drawing.Size(208, 22);
            this.txtPrecioMin.TabIndex = 147;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(570, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 146;
            this.label5.Text = "Rango de Precios:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(104, 78);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(5);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(270, 24);
            this.cboCategoria.TabIndex = 145;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 144;
            this.label4.Text = "Categoría:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // frmListarPlatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 660);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvItemsVenta);
            this.Controls.Add(this.gbPedido);
            this.Margin = new System.Windows.Forms.Padding(4);

            this.Name = "frmListarPlatos";
            this.Text = "frmListarPlatos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsVenta)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbPedido.ResumeLayout(false);
            this.gbPedido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscarPlatoCombo;
        private System.Windows.Forms.DataGridView dgvItemsVenta;
        private System.Windows.Forms.ComboBox cboDisponible;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbPedido;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton btnNuevoCombo;
        private System.Windows.Forms.ToolStripButton btnNuevoPlato;
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
    }
}