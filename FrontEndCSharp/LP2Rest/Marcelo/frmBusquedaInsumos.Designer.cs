namespace LP2Rest
{
    partial class frmBusquedaInsumos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.lblPlato = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbInsumoBuscado = new System.Windows.Forms.TextBox();
            this.lblBusquedaInsumo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Insumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadDeMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbSolicitud = new System.Windows.Forms.ToolStripButton();
            this.lblVolver = new System.Windows.Forms.Label();
            this.pbVolver = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.cboArea);
            this.groupBox1.Controls.Add(this.lblPlato);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtbInsumoBuscado);
            this.groupBox1.Controls.Add(this.lblBusquedaInsumo);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(37, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de Insumo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Location = new System.Drawing.Point(600, 36);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 23);
            this.btnBuscar.TabIndex = 101;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(460, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(34, 21);
            this.comboBox1.TabIndex = 100;
            // 
            // cboArea
            // 
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Location = new System.Drawing.Point(672, 70);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(34, 21);
            this.cboArea.TabIndex = 99;
            // 
            // lblPlato
            // 
            this.lblPlato.AutoSize = true;
            this.lblPlato.Location = new System.Drawing.Point(18, 70);
            this.lblPlato.Name = "lblPlato";
            this.lblPlato.Size = new System.Drawing.Size(34, 13);
            this.lblPlato.TabIndex = 93;
            this.lblPlato.Text = "Plato:";
            this.lblPlato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(58, 66);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(159, 21);
            this.comboBox2.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 94;
            this.label4.Text = "Stock:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(555, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(111, 20);
            this.textBox2.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 97;
            this.label5.Text = "Hasta:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(59, 97);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 20);
            this.textBox4.TabIndex = 77;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 76;
            this.label8.Text = "SKU:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbInsumoBuscado
            // 
            this.txtbInsumoBuscado.Location = new System.Drawing.Point(224, 36);
            this.txtbInsumoBuscado.Name = "txtbInsumoBuscado";
            this.txtbInsumoBuscado.Size = new System.Drawing.Size(312, 20);
            this.txtbInsumoBuscado.TabIndex = 1;
            // 
            // lblBusquedaInsumo
            // 
            this.lblBusquedaInsumo.AutoSize = true;
            this.lblBusquedaInsumo.Location = new System.Drawing.Point(18, 36);
            this.lblBusquedaInsumo.Name = "lblBusquedaInsumo";
            this.lblBusquedaInsumo.Size = new System.Drawing.Size(200, 13);
            this.lblBusquedaInsumo.TabIndex = 0;
            this.lblBusquedaInsumo.Text = "Ingrese nombre o descripcion de insumo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(343, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 20);
            this.textBox1.TabIndex = 95;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 96;
            this.label6.Text = "Desde:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Insumo,
            this.Descripcion,
            this.Stock,
            this.UnidadDeMedida});
            this.dataGridView1.Location = new System.Drawing.Point(73, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(724, 205);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Insumo
            // 
            this.Insumo.HeaderText = "Insumo";
            this.Insumo.Name = "Insumo";
            this.Insumo.Width = 180;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 300;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            // 
            // UnidadDeMedida
            // 
            this.UnidadDeMedida.HeaderText = "Unidad Medida";
            this.UnidadDeMedida.Name = "UnidadDeMedida";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbModificar,
            this.tsbEliminar,
            this.tsbNuevo,
            this.tsbSolicitud});
            this.toolStrip1.Location = new System.Drawing.Point(246, 442);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(326, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked_1);
            // 
            // tsbModificar
            // 
            this.tsbModificar.Image = global::LP2Rest.Properties.Resources.edit_validated_40458;
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(78, 22);
            this.tsbModificar.Text = "Modificar";
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Image = global::LP2Rest.Properties.Resources.trash_40429;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(70, 22);
            this.tsbEliminar.Text = "Eliminar";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = global::LP2Rest.Properties.Resources.new_file_40454;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(62, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbSolicitud
            // 
            this.tsbSolicitud.Image = global::LP2Rest.Properties.Resources.imgReportesIcon_small;
            this.tsbSolicitud.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSolicitud.Name = "tsbSolicitud";
            this.tsbSolicitud.Size = new System.Drawing.Size(73, 22);
            this.tsbSolicitud.Text = "Solicitud";
            this.tsbSolicitud.ToolTipText = "Solicitud";
            this.tsbSolicitud.Click += new System.EventHandler(this.tsbSolicitud_Click);
            // 
            // lblVolver
            // 
            this.lblVolver.AutoSize = true;
            this.lblVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolver.Location = new System.Drawing.Point(69, 32);
            this.lblVolver.Name = "lblVolver";
            this.lblVolver.Size = new System.Drawing.Size(53, 20);
            this.lblVolver.TabIndex = 6;
            this.lblVolver.Text = "Volver";
            this.lblVolver.Click += new System.EventHandler(this.lblVolver_Click);
            // 
            // pbVolver
            // 
            this.pbVolver.Image = global::LP2Rest.Properties.Resources.retroceder_salir;
            this.pbVolver.Location = new System.Drawing.Point(37, 32);
            this.pbVolver.Name = "pbVolver";
            this.pbVolver.Size = new System.Drawing.Size(26, 20);
            this.pbVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVolver.TabIndex = 2;
            this.pbVolver.TabStop = false;
            this.pbVolver.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(321, 36);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(143, 16);
            this.lblTitulo.TabIndex = 83;
            this.lblTitulo.Text = "Gestión de Insumos";
            // 
            // frmBusquedaInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 511);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblVolver);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pbVolver);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBusquedaInsumos";
            this.Text = "Busqueda de Insumos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbInsumoBuscado;
        private System.Windows.Forms.Label lblBusquedaInsumo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Insumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadDeMedida;
        private System.Windows.Forms.PictureBox pbVolver;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.Label lblVolver;
        private System.Windows.Forms.ToolStripButton tsbSolicitud;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.Label lblPlato;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTitulo;
    }
}