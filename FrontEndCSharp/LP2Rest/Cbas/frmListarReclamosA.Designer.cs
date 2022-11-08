namespace LP2Rest
{
    partial class frmListarReclamosA
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbNomCli = new System.Windows.Forms.TextBox();
            this.lblDNINombre = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.dgvReclamos = new System.Windows.Forms.DataGridView();
            this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoReclamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbApeCli = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbApeEmp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNomEmp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbApeAdm = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNomAdm = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReclamos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS UI Gothic", 22.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(40, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(303, 31);
            this.lblTitulo.TabIndex = 95;
            this.lblTitulo.Text = "Listado de Reclamos";
            // 
            // cboEstado
            // 
            this.cboEstado.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(901, 274);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(150, 33);
            this.cboEstado.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(897, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 86;
            this.label3.Text = "Estado:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 85;
            this.label1.Text = "Desde:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dtpFechaInicial.Location = new System.Drawing.Point(94, 35);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(309, 32);
            this.dtpFechaInicial.TabIndex = 83;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("MS UI Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(832, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(219, 41);
            this.btnBuscar.TabIndex = 82;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbNomCli
            // 
            this.tbNomCli.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tbNomCli.Location = new System.Drawing.Point(46, 191);
            this.tbNomCli.Name = "tbNomCli";
            this.tbNomCli.Size = new System.Drawing.Size(317, 32);
            this.tbNomCli.TabIndex = 81;
            // 
            // lblDNINombre
            // 
            this.lblDNINombre.AutoSize = true;
            this.lblDNINombre.Font = new System.Drawing.Font("MS UI Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNINombre.Location = new System.Drawing.Point(42, 165);
            this.lblDNINombre.Name = "lblDNINombre";
            this.lblDNINombre.Size = new System.Drawing.Size(201, 23);
            this.lblDNINombre.TabIndex = 80;
            this.lblDNINombre.Text = "Nombre del Cliente:";
            this.lblDNINombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("MS UI Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnModificar,
            this.btnEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(388, 726);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(318, 30);
            this.toolStrip1.TabIndex = 79;
            this.toolStrip1.Text = "tsMenu";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::LP2Rest.Properties.Resources.new_file_40454;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(92, 27);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::LP2Rest.Properties.Resources.edit_validated_40458;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(108, 27);
            this.btnModificar.Text = "&Atender";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::LP2Rest.Properties.Resources.trash_40429;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 27);
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvReclamos
            // 
            this.dgvReclamos.AllowUserToAddRows = false;
            this.dgvReclamos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReclamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReclamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReclamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreCliente,
            this.nombreEmpleado,
            this.fechaEvento,
            this.estadoReclamo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReclamos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReclamos.Location = new System.Drawing.Point(46, 347);
            this.dgvReclamos.Name = "dgvReclamos";
            this.dgvReclamos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReclamos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReclamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReclamos.Size = new System.Drawing.Size(1005, 362);
            this.dgvReclamos.TabIndex = 78;
            this.dgvReclamos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvReclamos_CellFormatting);
            // 
            // nombreCliente
            // 
            this.nombreCliente.HeaderText = "Nombre del Cliente";
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.ReadOnly = true;
            this.nombreCliente.Width = 300;
            // 
            // nombreEmpleado
            // 
            this.nombreEmpleado.HeaderText = "Nombre del Empleado";
            this.nombreEmpleado.Name = "nombreEmpleado";
            this.nombreEmpleado.ReadOnly = true;
            this.nombreEmpleado.Width = 300;
            // 
            // fechaEvento
            // 
            this.fechaEvento.HeaderText = "Fecha";
            this.fechaEvento.Name = "fechaEvento";
            this.fechaEvento.ReadOnly = true;
            this.fechaEvento.Width = 272;
            // 
            // estadoReclamo
            // 
            this.estadoReclamo.HeaderText = "Estado";
            this.estadoReclamo.Name = "estadoReclamo";
            this.estadoReclamo.ReadOnly = true;
            this.estadoReclamo.Width = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 97;
            this.label2.Text = "Hasta:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dtpFechaFin.Location = new System.Drawing.Point(497, 35);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(310, 32);
            this.dtpFechaFin.TabIndex = 96;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechaFin);
            this.groupBox1.Controls.Add(this.dtpFechaInicial);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(46, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 85);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro del Reclamo";
            // 
            // tbApeCli
            // 
            this.tbApeCli.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tbApeCli.Location = new System.Drawing.Point(46, 114);
            this.tbApeCli.Name = "tbApeCli";
            this.tbApeCli.Size = new System.Drawing.Size(317, 32);
            this.tbApeCli.TabIndex = 104;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 23);
            this.label6.TabIndex = 103;
            this.label6.Text = "Apellido del Cliente:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbApeEmp
            // 
            this.tbApeEmp.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tbApeEmp.Location = new System.Drawing.Point(388, 114);
            this.tbApeEmp.Name = "tbApeEmp";
            this.tbApeEmp.Size = new System.Drawing.Size(317, 32);
            this.tbApeEmp.TabIndex = 108;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 23);
            this.label4.TabIndex = 107;
            this.label4.Text = "Apellido del Empleado:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbNomEmp
            // 
            this.tbNomEmp.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tbNomEmp.Location = new System.Drawing.Point(388, 191);
            this.tbNomEmp.Name = "tbNomEmp";
            this.tbNomEmp.Size = new System.Drawing.Size(317, 32);
            this.tbNomEmp.TabIndex = 106;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(384, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 23);
            this.label5.TabIndex = 105;
            this.label5.Text = "Nombre del Empleado:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbApeAdm
            // 
            this.tbApeAdm.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tbApeAdm.Location = new System.Drawing.Point(734, 114);
            this.tbApeAdm.Name = "tbApeAdm";
            this.tbApeAdm.Size = new System.Drawing.Size(317, 32);
            this.tbApeAdm.TabIndex = 112;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(730, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(267, 23);
            this.label9.TabIndex = 111;
            this.label9.Text = "Apellido del Administrador:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbNomAdm
            // 
            this.tbNomAdm.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tbNomAdm.Location = new System.Drawing.Point(734, 191);
            this.tbNomAdm.Name = "tbNomAdm";
            this.tbNomAdm.Size = new System.Drawing.Size(317, 32);
            this.tbNomAdm.TabIndex = 110;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(730, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(266, 23);
            this.label10.TabIndex = 109;
            this.label10.Text = "Nombre del Administrador:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmListarReclamosA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 774);
            this.Controls.Add(this.tbApeAdm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbNomAdm);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbApeEmp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNomEmp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbApeCli);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbNomCli);
            this.Controls.Add(this.lblDNINombre);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvReclamos);
            this.Name = "frmListarReclamosA";
            this.Text = "Listado de Reclamos";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReclamos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbNomCli;
        private System.Windows.Forms.Label lblDNINombre;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.DataGridView dgvReclamos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoReclamo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbApeCli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbApeEmp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNomEmp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbApeAdm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbNomAdm;
        private System.Windows.Forms.Label label10;
    }
}