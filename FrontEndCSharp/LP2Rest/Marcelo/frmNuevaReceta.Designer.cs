namespace LP2Rest
{
    partial class frmNuevaReceta
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTipoItemItem = new System.Windows.Forms.Label();
            this.lblTipoItem = new System.Windows.Forms.Label();
            this.lblDescripcionItem = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAgregarInsumo = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminarInsumo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Insumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadDeMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(284, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(195, 16);
            this.lblTitulo.TabIndex = 83;
            this.lblTitulo.Text = "Inserción de Nueva Receta";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lblTipoItemItem
            // 
            this.lblTipoItemItem.AutoSize = true;
            this.lblTipoItemItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoItemItem.Location = new System.Drawing.Point(231, 120);
            this.lblTipoItemItem.Name = "lblTipoItemItem";
            this.lblTipoItemItem.Size = new System.Drawing.Size(78, 13);
            this.lblTipoItemItem.TabIndex = 93;
            this.lblTipoItemItem.Text = "Tipo de Item";
            // 
            // lblTipoItem
            // 
            this.lblTipoItem.AutoSize = true;
            this.lblTipoItem.Location = new System.Drawing.Point(168, 120);
            this.lblTipoItem.Name = "lblTipoItem";
            this.lblTipoItem.Size = new System.Drawing.Size(54, 13);
            this.lblTipoItem.TabIndex = 92;
            this.lblTipoItem.Text = "Tipo Item:";
            // 
            // lblDescripcionItem
            // 
            this.lblDescripcionItem.AutoSize = true;
            this.lblDescripcionItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionItem.Location = new System.Drawing.Point(231, 95);
            this.lblDescripcionItem.Name = "lblDescripcionItem";
            this.lblDescripcionItem.Size = new System.Drawing.Size(74, 13);
            this.lblDescripcionItem.TabIndex = 91;
            this.lblDescripcionItem.Text = "Descripcion";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(168, 95);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 90;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAgregarInsumo,
            this.tsbEliminarInsumo,
            this.tsbGuardar,
            this.tsbCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(188, 375);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(426, 27);
            this.toolStrip1.TabIndex = 89;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAgregarInsumo
            // 
            this.tsbAgregarInsumo.Image = global::LP2Rest.Properties.Resources.add_item_black_small;
            this.tsbAgregarInsumo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregarInsumo.Name = "tsbAgregarInsumo";
            this.tsbAgregarInsumo.Size = new System.Drawing.Size(116, 24);
            this.tsbAgregarInsumo.Text = "Agregar Insumo";
            this.tsbAgregarInsumo.Click += new System.EventHandler(this.tsbAgregarInsumo_Click);
            // 
            // tsbEliminarInsumo
            // 
            this.tsbEliminarInsumo.Image = global::LP2Rest.Properties.Resources.remove_item_black_small;
            this.tsbEliminarInsumo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminarInsumo.Name = "tsbEliminarInsumo";
            this.tsbEliminarInsumo.Size = new System.Drawing.Size(117, 24);
            this.tsbEliminarInsumo.Text = "Eliminar Insumo";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Image = global::LP2Rest.Properties.Resources.guardar;
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(73, 24);
            this.tsbGuardar.Text = "Guardar";
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.Image = global::LP2Rest.Properties.Resources.delete_file_40456;
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(77, 24);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Insumo,
            this.Cantidad,
            this.UnidadDeMedida});
            this.dataGridView1.Location = new System.Drawing.Point(171, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(444, 202);
            this.dataGridView1.TabIndex = 86;
            // 
            // Insumo
            // 
            this.Insumo.HeaderText = "Insumo";
            this.Insumo.MinimumWidth = 6;
            this.Insumo.Name = "Insumo";
            this.Insumo.ReadOnly = true;
            this.Insumo.Width = 200;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // UnidadDeMedida
            // 
            this.UnidadDeMedida.HeaderText = "Unidad Medida";
            this.UnidadDeMedida.MinimumWidth = 6;
            this.UnidadDeMedida.Name = "UnidadDeMedida";
            this.UnidadDeMedida.ReadOnly = true;
            this.UnidadDeMedida.Width = 125;
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.Location = new System.Drawing.Point(231, 67);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(86, 13);
            this.lblTitulo2.TabIndex = 85;
            this.lblTitulo2.Text = "Item de Venta";
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Location = new System.Drawing.Point(168, 67);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(47, 13);
            this.lblTitulo1.TabIndex = 84;
            this.lblTitulo1.Text = "Nombre:";
            // 
            // frmNuevaReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTipoItemItem);
            this.Controls.Add(this.lblTipoItem);
            this.Controls.Add(this.lblDescripcionItem);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.lblTitulo1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmNuevaReceta";
            this.Text = "frmNuevaReceta";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTipoItemItem;
        private System.Windows.Forms.Label lblTipoItem;
        private System.Windows.Forms.Label lblDescripcionItem;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAgregarInsumo;
        private System.Windows.Forms.ToolStripButton tsbEliminarInsumo;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Insumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadDeMedida;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Label lblTitulo1;
    }
}