namespace LP2Rest
{
    partial class frmGestionEventosA
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregarArtista = new System.Windows.Forms.Button();
            this.cboArtista = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminarArtista = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.txtCostoTotal = new System.Windows.Forms.TextBox();
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dtpFecha.Location = new System.Drawing.Point(220, 131);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(331, 32);
            this.dtpFecha.TabIndex = 60;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(153)))), ((int)(((byte)(96)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(275, 435);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 38);
            this.btnGuardar.TabIndex = 89;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(153)))), ((int)(((byte)(96)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(418, 435);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 38);
            this.btnCancelar.TabIndex = 90;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackColor = System.Drawing.Color.Black;
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(8, 502);
            this.panelIzquierdo.TabIndex = 88;
            // 
            // btnAgregarArtista
            // 
            this.btnAgregarArtista.BackgroundImage = global::LP2Rest.Properties.Resources._392024;
            this.btnAgregarArtista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarArtista.Location = new System.Drawing.Point(391, 180);
            this.btnAgregarArtista.Name = "btnAgregarArtista";
            this.btnAgregarArtista.Size = new System.Drawing.Size(33, 33);
            this.btnAgregarArtista.TabIndex = 82;
            this.btnAgregarArtista.UseVisualStyleBackColor = true;
            this.btnAgregarArtista.Click += new System.EventHandler(this.btnAgregarArtista_Click);
            // 
            // cboArtista
            // 
            this.cboArtista.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cboArtista.FormattingEnabled = true;
            this.cboArtista.Location = new System.Drawing.Point(220, 180);
            this.cboArtista.Name = "cboArtista";
            this.cboArtista.Size = new System.Drawing.Size(165, 33);
            this.cboArtista.TabIndex = 83;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(153)))), ((int)(((byte)(96)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(8, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(833, 5);
            this.panel5.TabIndex = 86;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.btnCerrar);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(8, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(833, 100);
            this.panel4.TabIndex = 85;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::LP2Rest.Properties.Resources.imgCerrarIcon_Medium;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(796, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 28;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = global::LP2Rest.Properties.Resources.imgCerrarIcon_Medium;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(1119, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.TabIndex = 27;
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 45F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(103)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(21, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(648, 60);
            this.label3.TabIndex = 21;
            this.label3.Text = "GESTIÓN DE EVENTOS";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminarArtista);
            this.groupBox1.Controls.Add(this.cboArtista);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.lblDNI);
            this.groupBox1.Controls.Add(this.btnAgregarArtista);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblApellidoPaterno);
            this.groupBox1.Controls.Add(this.txtCostoTotal);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(109, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 276);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Del Evento";
            // 
            // btnEliminarArtista
            // 
            this.btnEliminarArtista.BackgroundImage = global::LP2Rest.Properties.Resources._391892;
            this.btnEliminarArtista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarArtista.Location = new System.Drawing.Point(430, 180);
            this.btnEliminarArtista.Name = "btnEliminarArtista";
            this.btnEliminarArtista.Size = new System.Drawing.Size(33, 33);
            this.btnEliminarArtista.TabIndex = 84;
            this.btnEliminarArtista.UseVisualStyleBackColor = true;
            this.btnEliminarArtista.Click += new System.EventHandler(this.btnEliminarArtista_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtID.Location = new System.Drawing.Point(220, 43);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(208, 32);
            this.txtID.TabIndex = 23;
            // 
            // lblDNI
            // 
            this.lblDNI.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.lblDNI.Location = new System.Drawing.Point(31, 43);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(183, 32);
            this.lblDNI.TabIndex = 24;
            this.lblDNI.Text = "ID:";
            this.lblDNI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtNombre.Location = new System.Drawing.Point(220, 85);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(331, 32);
            this.txtNombre.TabIndex = 27;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label5.Location = new System.Drawing.Point(31, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 32);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nombre:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label6.Location = new System.Drawing.Point(31, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 33);
            this.label6.TabIndex = 47;
            this.label6.Text = "Artista:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.label8.Location = new System.Drawing.Point(31, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 32);
            this.label8.TabIndex = 45;
            this.label8.Text = "Costo Total:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.lblApellidoPaterno.Location = new System.Drawing.Point(31, 130);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(183, 31);
            this.lblApellidoPaterno.TabIndex = 30;
            this.lblApellidoPaterno.Text = "Fecha:";
            this.lblApellidoPaterno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCostoTotal
            // 
            this.txtCostoTotal.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtCostoTotal.Location = new System.Drawing.Point(220, 222);
            this.txtCostoTotal.Name = "txtCostoTotal";
            this.txtCostoTotal.Size = new System.Drawing.Size(165, 32);
            this.txtCostoTotal.TabIndex = 44;
            // 
            // frmGestionEventosA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 502);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionEventosA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Eventos";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregarArtista;
        private System.Windows.Forms.ComboBox cboArtista;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCostoTotal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEliminarArtista;
    }
}