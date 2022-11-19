namespace LP2Rest
{
    partial class frmAsistencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsistencias));
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbPDF = new System.Windows.Forms.PictureBox();
            this.visorPDF = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.pbPDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visorPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.Sienna;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(519, 78);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(63, 26);
            this.btnGenerar.TabIndex = 9;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Chocolate;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(406, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(55, 24);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(160, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(231, 19);
            this.txtNombre.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre del empleado: ";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(160, 54);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(231, 20);
            this.dtpFechaInicio.TabIndex = 10;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(160, 85);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(231, 20);
            this.dtpFechaFin.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha de inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 14);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fecha de fin:";
            // 
            // pbPDF
            // 
            this.pbPDF.Image = global::LP2Rest.Properties.Resources.pngegg__1_;
            this.pbPDF.Location = new System.Drawing.Point(519, 12);
            this.pbPDF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbPDF.Name = "pbPDF";
            this.pbPDF.Size = new System.Drawing.Size(64, 61);
            this.pbPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPDF.TabIndex = 14;
            this.pbPDF.TabStop = false;
            // 
            // visorPDF
            // 
            this.visorPDF.Enabled = true;
            this.visorPDF.Location = new System.Drawing.Point(41, 126);
            this.visorPDF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.visorPDF.Name = "visorPDF";
            this.visorPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("visorPDF.OcxState")));
            this.visorPDF.Size = new System.Drawing.Size(542, 393);
            this.visorPDF.TabIndex = 15;
            // 
            // frmAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(684, 538);
            this.Controls.Add(this.visorPDF);
            this.Controls.Add(this.pbPDF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAsistencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de asistencias";
            ((System.ComponentModel.ISupportInitialize)(this.pbPDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visorPDF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbPDF;
        private AxAcroPDFLib.AxAcroPDF visorPDF;
    }
}