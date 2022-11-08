namespace LP2Rest.Gonzalo
{
    partial class frmGestionarCombos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarPlato = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtNombrePlato = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnEliminarPlato = new System.Windows.Forms.Button();
            this.btnAgregarPlato = new System.Windows.Forms.Button();
            this.txtIDPlato = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblDNINombre = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbPedido = new System.Windows.Forms.GroupBox();
            this.txtIdCombo = new System.Windows.Forms.TextBox();
            this.txtGanancia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.IDPlato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbPedido.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1196, 41);
            this.panel1.TabIndex = 145;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(461, 10);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(209, 20);
            this.lblTitulo.TabIndex = 140;
            this.lblTitulo.Text = "GESTIÓN DE COMBOS";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(246)))), ((int)(((byte)(238)))));
            this.groupBox1.Controls.Add(this.btnBuscarPlato);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.txtNombrePlato);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnEliminarPlato);
            this.groupBox1.Controls.Add(this.btnAgregarPlato);
            this.groupBox1.Controls.Add(this.txtIDPlato);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.lblDNINombre);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(359, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(862, 361);
            this.groupBox1.TabIndex = 144;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Platos:";
            // 
            // btnBuscarPlato
            // 
            this.btnBuscarPlato.Location = new System.Drawing.Point(307, 34);
            this.btnBuscarPlato.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarPlato.Name = "btnBuscarPlato";
            this.btnBuscarPlato.Size = new System.Drawing.Size(43, 28);
            this.btnBuscarPlato.TabIndex = 148;
            this.btnBuscarPlato.Text = "...";
            this.btnBuscarPlato.UseVisualStyleBackColor = true;
            this.btnBuscarPlato.Click += new System.EventHandler(this.btnBuscarPlato_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(594, 47);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 16);
            this.label12.TabIndex = 147;
            this.label12.Text = "Cantidad:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(666, 44);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(44, 22);
            this.txtCantidad.TabIndex = 146;
            // 
            // txtNombrePlato
            // 
            this.txtNombrePlato.Location = new System.Drawing.Point(136, 67);
            this.txtNombrePlato.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombrePlato.Name = "txtNombrePlato";
            this.txtNombrePlato.ReadOnly = true;
            this.txtNombrePlato.Size = new System.Drawing.Size(148, 22);
            this.txtNombrePlato.TabIndex = 144;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 72);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 16);
            this.label11.TabIndex = 143;
            this.label11.Text = "Nombre Plato:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEliminarPlato
            // 
            this.btnEliminarPlato.Location = new System.Drawing.Point(793, 41);
            this.btnEliminarPlato.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarPlato.Name = "btnEliminarPlato";
            this.btnEliminarPlato.Size = new System.Drawing.Size(45, 28);
            this.btnEliminarPlato.TabIndex = 142;
            this.btnEliminarPlato.Text = "-";
            this.btnEliminarPlato.UseVisualStyleBackColor = true;
            // 
            // btnAgregarPlato
            // 
            this.btnAgregarPlato.Location = new System.Drawing.Point(740, 41);
            this.btnAgregarPlato.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarPlato.Name = "btnAgregarPlato";
            this.btnAgregarPlato.Size = new System.Drawing.Size(45, 28);
            this.btnAgregarPlato.TabIndex = 141;
            this.btnAgregarPlato.Text = "+";
            this.btnAgregarPlato.UseVisualStyleBackColor = true;
            // 
            // txtIDPlato
            // 
            this.txtIDPlato.Location = new System.Drawing.Point(136, 37);
            this.txtIDPlato.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDPlato.Name = "txtIDPlato";
            this.txtIDPlato.ReadOnly = true;
            this.txtIDPlato.Size = new System.Drawing.Size(148, 22);
            this.txtIDPlato.TabIndex = 142;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(563, 338);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 65;
            this.label5.Text = "Costo Total (S/.):";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(710, 335);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(126, 23);
            this.txtTotal.TabIndex = 64;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDNINombre
            // 
            this.lblDNINombre.AutoSize = true;
            this.lblDNINombre.Location = new System.Drawing.Point(71, 40);
            this.lblDNINombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNINombre.Name = "lblDNINombre";
            this.lblDNINombre.Size = new System.Drawing.Size(57, 16);
            this.lblDNINombre.TabIndex = 141;
            this.lblDNINombre.Text = "ID Plato:";
            this.lblDNINombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 98);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPlato,
            this.NombreInsumo,
            this.Cantidad,
            this.Costo,
            this.Subtotal});
            this.dataGridView1.Location = new System.Drawing.Point(16, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(822, 216);
            this.dataGridView1.TabIndex = 61;
            // 
            // gbPedido
            // 
            this.gbPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
            this.gbPedido.Controls.Add(this.txtPrecioVenta);
            this.gbPedido.Controls.Add(this.txtIdCombo);
            this.gbPedido.Controls.Add(this.txtGanancia);
            this.gbPedido.Controls.Add(this.label7);
            this.gbPedido.Controls.Add(this.label6);
            this.gbPedido.Controls.Add(this.txtNombre);
            this.gbPedido.Controls.Add(this.label3);
            this.gbPedido.Controls.Add(this.label2);
            this.gbPedido.Controls.Add(this.label1);
            this.gbPedido.Location = new System.Drawing.Point(25, 71);
            this.gbPedido.Margin = new System.Windows.Forms.Padding(4);
            this.gbPedido.Name = "gbPedido";
            this.gbPedido.Padding = new System.Windows.Forms.Padding(4);
            this.gbPedido.Size = new System.Drawing.Size(314, 360);
            this.gbPedido.TabIndex = 143;
            this.gbPedido.TabStop = false;
            this.gbPedido.Text = "Datos de los combos";
            // 
            // txtIdCombo
            // 
            this.txtIdCombo.Location = new System.Drawing.Point(114, 52);
            this.txtIdCombo.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCombo.Name = "txtIdCombo";
            this.txtIdCombo.ReadOnly = true;
            this.txtIdCombo.Size = new System.Drawing.Size(163, 22);
            this.txtIdCombo.TabIndex = 145;
            // 
            // txtGanancia
            // 
            this.txtGanancia.Location = new System.Drawing.Point(114, 129);
            this.txtGanancia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGanancia.Name = "txtGanancia";
            this.txtGanancia.Size = new System.Drawing.Size(163, 22);
            this.txtGanancia.TabIndex = 142;
            this.txtGanancia.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 129);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 141;
            this.label7.Text = "Ganancia: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Precio Venta:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(114, 88);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(163, 22);
            this.txtNombre.TabIndex = 11;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Combo";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar,
            this.btnModificar,
            this.btnEliminar,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(447, 452);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(377, 27);
            this.toolStrip1.TabIndex = 142;
            this.toolStrip1.Text = "tsMenu";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(114, 167);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.ReadOnly = true;
            this.txtPrecioVenta.Size = new System.Drawing.Size(163, 22);
            this.txtPrecioVenta.TabIndex = 146;
            // 
            // IDPlato
            // 
            this.IDPlato.FillWeight = 75F;
            this.IDPlato.HeaderText = "ID Plato";
            this.IDPlato.MinimumWidth = 6;
            this.IDPlato.Name = "IDPlato";
            this.IDPlato.ReadOnly = true;
            this.IDPlato.Width = 75;
            // 
            // NombreInsumo
            // 
            this.NombreInsumo.FillWeight = 140F;
            this.NombreInsumo.HeaderText = "Nombre";
            this.NombreInsumo.MinimumWidth = 6;
            this.NombreInsumo.Name = "NombreInsumo";
            this.NombreInsumo.ReadOnly = true;
            this.NombreInsumo.Width = 140;
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
            this.Subtotal.Width = 125;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::LP2Rest.Properties.Resources.kisspng_computer_icons_iconfinder_desktop_wallpaper_floppy_save_icon_5ab07851d21f64_1935471015215145778607;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 28);
            this.btnGuardar.Text = "&Guardar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::LP2Rest.Properties.Resources.trash_40429;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 28);
            this.btnEliminar.Text = "&Eliminar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::LP2Rest.Properties.Resources.delete_file_40456;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 28);
            this.btnCancelar.Text = "&Cancelar";
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::LP2Rest.Properties.Resources.edit_validated_40458;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(101, 24);
            this.btnModificar.Text = "&Modificar ";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmGestionarCombos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 488);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbPedido);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmGestionarCombos";
            this.Text = "frmGestionarCombos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbPedido.ResumeLayout(false);
            this.gbPedido.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarPlato;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtNombrePlato;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnEliminarPlato;
        private System.Windows.Forms.Button btnAgregarPlato;
        private System.Windows.Forms.TextBox txtIDPlato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblDNINombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbPedido;
        private System.Windows.Forms.TextBox txtIdCombo;
        private System.Windows.Forms.TextBox txtGanancia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPlato;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.ToolStripButton btnModificar;
    }
}