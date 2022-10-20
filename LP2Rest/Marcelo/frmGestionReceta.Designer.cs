namespace LP2Rest
{
    partial class frmGestionReceta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionReceta));
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Insumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadDeMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblVolver = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblDescripcionItem = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTipoItem = new System.Windows.Forms.Label();
            this.lblTipoItemItem = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tsbAgregarInsumo = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminarInsumo = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminarReceta = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.pbVolver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Location = new System.Drawing.Point(111, 106);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(47, 13);
            this.lblTitulo1.TabIndex = 0;
            this.lblTitulo1.Text = "Nombre:";
            this.lblTitulo1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.Location = new System.Drawing.Point(174, 106);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(86, 13);
            this.lblTitulo2.TabIndex = 1;
            this.lblTitulo2.Text = "Item de Venta";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Insumo,
            this.Cantidad,
            this.UnidadDeMedida});
            this.dataGridView1.Location = new System.Drawing.Point(114, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 202);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Insumo
            // 
            this.Insumo.HeaderText = "Insumo";
            this.Insumo.Name = "Insumo";
            this.Insumo.ReadOnly = true;
            this.Insumo.Width = 200;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // UnidadDeMedida
            // 
            this.UnidadDeMedida.HeaderText = "Unidad Medida";
            this.UnidadDeMedida.Name = "UnidadDeMedida";
            this.UnidadDeMedida.ReadOnly = true;
            // 
            // lblVolver
            // 
            this.lblVolver.AutoSize = true;
            this.lblVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolver.Location = new System.Drawing.Point(146, 75);
            this.lblVolver.Name = "lblVolver";
            this.lblVolver.Size = new System.Drawing.Size(48, 17);
            this.lblVolver.TabIndex = 11;
            this.lblVolver.Text = "Volver";
            this.lblVolver.Click += new System.EventHandler(this.lblVolver_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAgregarInsumo,
            this.tsbEliminarInsumo,
            this.tsbEliminarReceta,
            this.tsbGuardar});
            this.toolStrip1.Location = new System.Drawing.Point(114, 419);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(445, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblDescripcionItem
            // 
            this.lblDescripcionItem.AutoSize = true;
            this.lblDescripcionItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionItem.Location = new System.Drawing.Point(174, 134);
            this.lblDescripcionItem.Name = "lblDescripcionItem";
            this.lblDescripcionItem.Size = new System.Drawing.Size(74, 13);
            this.lblDescripcionItem.TabIndex = 14;
            this.lblDescripcionItem.Text = "Descripcion";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(111, 134);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 13;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblTipoItem
            // 
            this.lblTipoItem.AutoSize = true;
            this.lblTipoItem.Location = new System.Drawing.Point(111, 159);
            this.lblTipoItem.Name = "lblTipoItem";
            this.lblTipoItem.Size = new System.Drawing.Size(54, 13);
            this.lblTipoItem.TabIndex = 15;
            this.lblTipoItem.Text = "Tipo Item:";
            // 
            // lblTipoItemItem
            // 
            this.lblTipoItemItem.AutoSize = true;
            this.lblTipoItemItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoItemItem.Location = new System.Drawing.Point(174, 159);
            this.lblTipoItemItem.Name = "lblTipoItemItem";
            this.lblTipoItemItem.Size = new System.Drawing.Size(78, 13);
            this.lblTipoItemItem.TabIndex = 16;
            this.lblTipoItemItem.Text = "Tipo de Item";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(217, 36);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(191, 16);
            this.lblTitulo.TabIndex = 83;
            this.lblTitulo.Text = "Gestión de Receta de Item";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // tsbAgregarInsumo
            // 
            this.tsbAgregarInsumo.Image = ((System.Drawing.Image)(resources.GetObject("tsbAgregarInsumo.Image")));
            this.tsbAgregarInsumo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregarInsumo.Name = "tsbAgregarInsumo";
            this.tsbAgregarInsumo.Size = new System.Drawing.Size(112, 22);
            this.tsbAgregarInsumo.Text = "Agregar Insumo";
            this.tsbAgregarInsumo.Click += new System.EventHandler(this.tsbAgregarInsumo_Click);
            // 
            // tsbEliminarInsumo
            // 
            this.tsbEliminarInsumo.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminarInsumo.Image")));
            this.tsbEliminarInsumo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminarInsumo.Name = "tsbEliminarInsumo";
            this.tsbEliminarInsumo.Size = new System.Drawing.Size(113, 22);
            this.tsbEliminarInsumo.Text = "Eliminar Insumo";
            // 
            // tsbEliminarReceta
            // 
            this.tsbEliminarReceta.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminarReceta.Image")));
            this.tsbEliminarReceta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminarReceta.Name = "tsbEliminarReceta";
            this.tsbEliminarReceta.Size = new System.Drawing.Size(108, 22);
            this.tsbEliminarReceta.Text = "Eliminar Receta";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(69, 22);
            this.tsbGuardar.Text = "Guardar";
            // 
            // pbVolver
            // 
            this.pbVolver.Image = ((System.Drawing.Image)(resources.GetObject("pbVolver.Image")));
            this.pbVolver.Location = new System.Drawing.Point(114, 72);
            this.pbVolver.Name = "pbVolver";
            this.pbVolver.Size = new System.Drawing.Size(26, 20);
            this.pbVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVolver.TabIndex = 10;
            this.pbVolver.TabStop = false;
            this.pbVolver.Click += new System.EventHandler(this.pbVolver_Click);
            // 
            // frmGestionReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 476);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblTipoItemItem);
            this.Controls.Add(this.lblTipoItem);
            this.Controls.Add(this.lblDescripcionItem);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblVolver);
            this.Controls.Add(this.pbVolver);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.lblTitulo1);
            this.Name = "frmGestionReceta";
            this.Text = "Vista de Receta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Insumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadDeMedida;
        private System.Windows.Forms.Label lblVolver;
        private System.Windows.Forms.PictureBox pbVolver;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAgregarInsumo;
        private System.Windows.Forms.ToolStripButton tsbEliminarInsumo;
        private System.Windows.Forms.Label lblDescripcionItem;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTipoItem;
        private System.Windows.Forms.Label lblTipoItemItem;
        private System.Windows.Forms.ToolStripButton tsbEliminarReceta;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.Label lblTitulo;
    }
}