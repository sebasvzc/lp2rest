namespace LP2Rest.Gonzalo
{
    partial class frmGenerarBoletaVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerarBoletaVenta));
            this.VisorPDFBoleta = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.VisorPDFBoleta)).BeginInit();
            this.SuspendLayout();
            // 
            // VisorPDFBoleta
            // 
            this.VisorPDFBoleta.Enabled = true;
            this.VisorPDFBoleta.Location = new System.Drawing.Point(46, 20);
            this.VisorPDFBoleta.Name = "VisorPDFBoleta";
            this.VisorPDFBoleta.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VisorPDFBoleta.OcxState")));
            this.VisorPDFBoleta.Size = new System.Drawing.Size(678, 480);
            this.VisorPDFBoleta.TabIndex = 0;
            // 
            // frmGenerarBoletaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 512);
            this.Controls.Add(this.VisorPDFBoleta);
            this.Name = "frmGenerarBoletaVenta";
            this.Text = "frmGenerarBoletaVenta";
            ((System.ComponentModel.ISupportInitialize)(this.VisorPDFBoleta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF VisorPDFBoleta;
    }
}