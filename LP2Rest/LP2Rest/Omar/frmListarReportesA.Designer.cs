namespace LP2Rest
{
    partial class frmListarReportesA
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
            this.btnCrearReportePlatos = new System.Windows.Forms.Button();
            this.btnCrearReporteVentas = new System.Windows.Forms.Button();
            this.btnCrearReporteAsistencias = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCrearReportePlatos
            // 
            this.btnCrearReportePlatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCrearReportePlatos.Location = new System.Drawing.Point(215, 183);
            this.btnCrearReportePlatos.Name = "btnCrearReportePlatos";
            this.btnCrearReportePlatos.Size = new System.Drawing.Size(106, 23);
            this.btnCrearReportePlatos.TabIndex = 87;
            this.btnCrearReportePlatos.Text = "Crear";
            this.btnCrearReportePlatos.UseVisualStyleBackColor = true;
            this.btnCrearReportePlatos.Click += new System.EventHandler(this.btnCrearReportePlatos_Click);
            // 
            // btnCrearReporteVentas
            // 
            this.btnCrearReporteVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCrearReporteVentas.Location = new System.Drawing.Point(215, 136);
            this.btnCrearReporteVentas.Name = "btnCrearReporteVentas";
            this.btnCrearReporteVentas.Size = new System.Drawing.Size(106, 23);
            this.btnCrearReporteVentas.TabIndex = 86;
            this.btnCrearReporteVentas.Text = "Crear";
            this.btnCrearReporteVentas.UseVisualStyleBackColor = true;
            this.btnCrearReporteVentas.Click += new System.EventHandler(this.btnCrearReporteVentas_Click);
            // 
            // btnCrearReporteAsistencias
            // 
            this.btnCrearReporteAsistencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCrearReporteAsistencias.Location = new System.Drawing.Point(215, 82);
            this.btnCrearReporteAsistencias.Name = "btnCrearReporteAsistencias";
            this.btnCrearReporteAsistencias.Size = new System.Drawing.Size(106, 23);
            this.btnCrearReporteAsistencias.TabIndex = 85;
            this.btnCrearReporteAsistencias.Text = "Crear";
            this.btnCrearReporteAsistencias.UseVisualStyleBackColor = true;
            this.btnCrearReporteAsistencias.Click += new System.EventHandler(this.btnCrearReporteAsistencias_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 84;
            this.label3.Text = "Listado de Reportes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 83;
            this.label2.Text = "Reporte de Platos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 82;
            this.label1.Text = "Reporte de Ventas";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(27, 85);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(154, 15);
            this.lblTitulo.TabIndex = 81;
            this.lblTitulo.Text = "Reporte de Asistencias";
            // 
            // frmListarReportesA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 243);
            this.Controls.Add(this.btnCrearReportePlatos);
            this.Controls.Add(this.btnCrearReporteVentas);
            this.Controls.Add(this.btnCrearReporteAsistencias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmListarReportesA";
            this.Text = "Listado de Reportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearReportePlatos;
        private System.Windows.Forms.Button btnCrearReporteVentas;
        private System.Windows.Forms.Button btnCrearReporteAsistencias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
    }
}