﻿namespace LP2Rest
{
    partial class frmReportePlatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportePlatos));
            this.btnGenerar = new System.Windows.Forms.Button();
            this.pbPDF = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.VisorPDFPlatos = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.pbPDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisorPDFPlatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.Chocolate;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(570, 93);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(86, 40);
            this.btnGenerar.TabIndex = 15;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // pbPDF
            // 
            this.pbPDF.Image = global::LP2Rest.Properties.Resources.pngegg__1_;
            this.pbPDF.Location = new System.Drawing.Point(571, 2);
            this.pbPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPDF.Name = "pbPDF";
            this.pbPDF.Size = new System.Drawing.Size(85, 85);
            this.pbPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPDF.TabIndex = 16;
            this.pbPDF.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Fecha de fin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Fecha de inicio:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(184, 65);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaFin.TabIndex = 24;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(184, 21);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaInicio.TabIndex = 23;
            // 
            // VisorPDFPlatos
            // 
            this.VisorPDFPlatos.Enabled = true;
            this.VisorPDFPlatos.Location = new System.Drawing.Point(62, 132);
            this.VisorPDFPlatos.Name = "VisorPDFPlatos";
            this.VisorPDFPlatos.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VisorPDFPlatos.OcxState")));
            this.VisorPDFPlatos.Size = new System.Drawing.Size(446, 282);
            this.VisorPDFPlatos.TabIndex = 27;
            // 
            // frmReportePlatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 543);
            this.Controls.Add(this.VisorPDFPlatos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.pbPDF);
            this.Controls.Add(this.btnGenerar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReportePlatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Platos";
            ((System.ComponentModel.ISupportInitialize)(this.pbPDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisorPDFPlatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbPDF;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private AxAcroPDFLib.AxAcroPDF VisorPDFPlatos;
    }
}