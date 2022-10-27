namespace LP2Rest
{
    partial class frmGestionReservas
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.textDNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dtpFechaOrdenVenta = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtID.Location = new System.Drawing.Point(143, 88);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(69, 32);
            this.txtID.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label1.Location = new System.Drawing.Point(16, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 58;
            this.label1.Text = "ID Reserva:";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Font = new System.Drawing.Font("MS UI Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.btnBuscarCliente.Location = new System.Drawing.Point(836, 81);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(238, 42);
            this.btnBuscarCliente.TabIndex = 57;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.NombreCompleto,
            this.Mesa,
            this.Fecha,
            this.Hora});
            this.dgvClientes.Location = new System.Drawing.Point(20, 300);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 62;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(1072, 353);
            this.dgvClientes.TabIndex = 56;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 8;
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Width = 150;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Nombre y Apellido";
            this.NombreCompleto.MinimumWidth = 8;
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 407;
            // 
            // Mesa
            // 
            this.Mesa.HeaderText = "Mesa";
            this.Mesa.MinimumWidth = 8;
            this.Mesa.Name = "Mesa";
            this.Mesa.ReadOnly = true;
            this.Mesa.Width = 150;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha de Reserva";
            this.Fecha.MinimumWidth = 8;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 150;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora Reserva";
            this.Hora.MinimumWidth = 8;
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.Width = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label5.Location = new System.Drawing.Point(16, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 67;
            this.label5.Text = "DNI:";
            // 
            // textDNI
            // 
            this.textDNI.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textDNI.Location = new System.Drawing.Point(143, 139);
            this.textDNI.Name = "textDNI";
            this.textDNI.Size = new System.Drawing.Size(180, 32);
            this.textDNI.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label2.Location = new System.Drawing.Point(16, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 60;
            this.label2.Text = "Nombres:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtApellidos.Location = new System.Drawing.Point(143, 183);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(460, 32);
            this.txtApellidos.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label4.Location = new System.Drawing.Point(16, 227);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 23);
            this.label4.TabIndex = 65;
            this.label4.Text = "Apellidos:";
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtNombres.Location = new System.Drawing.Point(143, 224);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(460, 32);
            this.txtNombres.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label3.Location = new System.Drawing.Point(642, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 75;
            this.label3.Text = "Mesa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label6.Location = new System.Drawing.Point(642, 227);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 23);
            this.label6.TabIndex = 73;
            this.label6.Text = "Hora:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label7.Location = new System.Drawing.Point(642, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 71;
            this.label7.Text = "Fecha:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBox3.Location = new System.Drawing.Point(728, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(346, 32);
            this.textBox3.TabIndex = 70;
            // 
            // dtpFechaOrdenVenta
            // 
            this.dtpFechaOrdenVenta.Enabled = false;
            this.dtpFechaOrdenVenta.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dtpFechaOrdenVenta.Location = new System.Drawing.Point(728, 183);
            this.dtpFechaOrdenVenta.Name = "dtpFechaOrdenVenta";
            this.dtpFechaOrdenVenta.Size = new System.Drawing.Size(346, 32);
            this.dtpFechaOrdenVenta.TabIndex = 76;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(728, 224);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 33);
            this.comboBox1.TabIndex = 77;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnModificar,
            this.btnEliminar});
            this.toolStrip2.Location = new System.Drawing.Point(423, 695);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(328, 30);
            this.toolStrip2.TabIndex = 78;
            this.toolStrip2.Text = "tsMenu";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.btnNuevo.Image = global::LP2Rest.Properties.Resources.new_file_40454;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(92, 27);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.btnModificar.Image = global::LP2Rest.Properties.Resources.edit_validated_40458;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(118, 27);
            this.btnModificar.Text = "&Modificar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.btnEliminar.Image = global::LP2Rest.Properties.Resources.trash_40429;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 27);
            this.btnEliminar.Text = "&Eliminar";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("MS UI Gothic", 22.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(14, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(332, 41);
            this.lblTitulo.TabIndex = 79;
            this.lblTitulo.Text = "Gestión de Reservas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmGestionReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 774);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dtpFechaOrdenVenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textDNI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.dgvClientes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmGestionReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGestionReservas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dtpFechaOrdenVenta;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.Label lblTitulo;
    }
}