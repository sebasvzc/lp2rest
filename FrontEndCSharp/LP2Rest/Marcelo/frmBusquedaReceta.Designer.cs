namespace LP2Rest
{
    partial class frmBusquedaReceta
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
            this.txtItem = new System.Windows.Forms.TextBox();
            this.lblIten = new System.Windows.Forms.Label();
            this.lblInsumo = new System.Windows.Forms.Label();
            this.txtInsumos = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.lblVolver = new System.Windows.Forms.Label();
            this.pbVolver = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbBorrar = new System.Windows.Forms.ToolStripButton();
            this.tsbVer = new System.Windows.Forms.ToolStripButton();
            this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolver)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(108, 21);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(237, 20);
            this.txtItem.TabIndex = 0;
            // 
            // lblIten
            // 
            this.lblIten.AutoSize = true;
            this.lblIten.Location = new System.Drawing.Point(17, 24);
            this.lblIten.Name = "lblIten";
            this.lblIten.Size = new System.Drawing.Size(76, 13);
            this.lblIten.TabIndex = 1;
            this.lblIten.Text = "Item de Venta:";
            this.lblIten.Click += new System.EventHandler(this.lblIten_Click);
            // 
            // lblInsumo
            // 
            this.lblInsumo.AutoSize = true;
            this.lblInsumo.Location = new System.Drawing.Point(17, 52);
            this.lblInsumo.Name = "lblInsumo";
            this.lblInsumo.Size = new System.Drawing.Size(49, 13);
            this.lblInsumo.TabIndex = 2;
            this.lblInsumo.Text = "Insumos:";
            // 
            // txtInsumos
            // 
            this.txtInsumos.Location = new System.Drawing.Point(108, 52);
            this.txtInsumos.Name = "txtInsumos";
            this.txtInsumos.Size = new System.Drawing.Size(237, 20);
            this.txtInsumos.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(108, 108);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Descripcion});
            this.dataGridView1.Location = new System.Drawing.Point(33, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 183);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 250;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 500;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lblTipoProducto);
            this.groupBox1.Controls.Add(this.lblIten);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.lblInsumo);
            this.groupBox1.Controls.Add(this.txtInsumos);
            this.groupBox1.Controls.Add(this.txtItem);
            this.groupBox1.Location = new System.Drawing.Point(33, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 137);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 101;
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Location = new System.Drawing.Point(6, 86);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(92, 13);
            this.lblTipoProducto.TabIndex = 100;
            this.lblTipoProducto.Text = "Tipo de Producto:";
            // 
            // lblVolver
            // 
            this.lblVolver.AutoSize = true;
            this.lblVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolver.Location = new System.Drawing.Point(65, 15);
            this.lblVolver.Name = "lblVolver";
            this.lblVolver.Size = new System.Drawing.Size(48, 17);
            this.lblVolver.TabIndex = 9;
            this.lblVolver.Text = "Volver";
            this.lblVolver.Click += new System.EventHandler(this.lblVolver_Click);
            // 
            // pbVolver
            // 
            this.pbVolver.Image = global::LP2Rest.Properties.Resources.retroceder_salir;
            this.pbVolver.Location = new System.Drawing.Point(33, 12);
            this.pbVolver.Name = "pbVolver";
            this.pbVolver.Size = new System.Drawing.Size(26, 20);
            this.pbVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVolver.TabIndex = 8;
            this.pbVolver.TabStop = false;
            this.pbVolver.Click += new System.EventHandler(this.pbVolver_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBorrar,
            this.tsbVer,
            this.tsbAgregar});
            this.toolStrip1.Location = new System.Drawing.Point(258, 391);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(214, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsbBorrar
            // 
            this.tsbBorrar.Image = global::LP2Rest.Properties.Resources.trash_40429;
            this.tsbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBorrar.Name = "tsbBorrar";
            this.tsbBorrar.Size = new System.Drawing.Size(59, 22);
            this.tsbBorrar.Text = "Borrar";
            this.tsbBorrar.Click += new System.EventHandler(this.tsbBorrar_Click);
            // 
            // tsbVer
            // 
            this.tsbVer.Image = global::LP2Rest.Properties.Resources.file_info_40446;
            this.tsbVer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVer.Name = "tsbVer";
            this.tsbVer.Size = new System.Drawing.Size(43, 22);
            this.tsbVer.Text = "Ver";
            this.tsbVer.ToolTipText = "Ver";
            this.tsbVer.Click += new System.EventHandler(this.tsbVer_Click);
            // 
            // tsbAgregar
            // 
            this.tsbAgregar.Image = global::LP2Rest.Properties.Resources.add_file_color;
            this.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregar.Name = "tsbAgregar";
            this.tsbAgregar.Size = new System.Drawing.Size(69, 22);
            this.tsbAgregar.Text = "Agregar";
            this.tsbAgregar.ToolTipText = "Agregar";
            this.tsbAgregar.Click += new System.EventHandler(this.tsbAgregar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(320, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(207, 16);
            this.lblTitulo.TabIndex = 83;
            this.lblTitulo.Text = "Gestión de Recetas de Items";
            // 
            // frmBusquedaReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 453);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblVolver);
            this.Controls.Add(this.pbVolver);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBusquedaReceta";
            this.Text = "Busqueda de Item";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolver)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label lblIten;
        private System.Windows.Forms.Label lblInsumo;
        private System.Windows.Forms.TextBox txtInsumos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblVolver;
        private System.Windows.Forms.PictureBox pbVolver;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbBorrar;
        private System.Windows.Forms.ToolStripButton tsbVer;
        private System.Windows.Forms.ToolStripButton tsbAgregar;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}