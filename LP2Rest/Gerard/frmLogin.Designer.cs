namespace LP2Rest
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btIngresar = new System.Windows.Forms.Button();
            this.lbOlvideContrasena = new System.Windows.Forms.Label();
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.txtIniciarSesion = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linea = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.panelIzquierdo.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btIngresar
            // 
            this.btIngresar.BackColor = System.Drawing.Color.Sienna;
            this.btIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btIngresar.FlatAppearance.BorderSize = 0;
            this.btIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIngresar.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btIngresar.ForeColor = System.Drawing.Color.White;
            this.btIngresar.Location = new System.Drawing.Point(28, 475);
            this.btIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.btIngresar.Name = "btIngresar";
            this.btIngresar.Size = new System.Drawing.Size(301, 43);
            this.btIngresar.TabIndex = 14;
            this.btIngresar.Text = "Ingresar";
            this.btIngresar.UseVisualStyleBackColor = false;
            this.btIngresar.Click += new System.EventHandler(this.btIngresar_Click);
            // 
            // lbOlvideContrasena
            // 
            this.lbOlvideContrasena.AutoSize = true;
            this.lbOlvideContrasena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbOlvideContrasena.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Underline);
            this.lbOlvideContrasena.ForeColor = System.Drawing.Color.Sienna;
            this.lbOlvideContrasena.Location = new System.Drawing.Point(86, 544);
            this.lbOlvideContrasena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOlvideContrasena.Name = "lbOlvideContrasena";
            this.lbOlvideContrasena.Size = new System.Drawing.Size(173, 15);
            this.lbOlvideContrasena.TabIndex = 8;
            this.lbOlvideContrasena.Text = "¿Olvidaste tu contraseña?";
            this.lbOlvideContrasena.Click += new System.EventHandler(this.lbOlvideContrasena_Click);
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(153)))), ((int)(((byte)(96)))));
            this.panelIzquierdo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelIzquierdo.Controls.Add(this.panel3);
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(65, 617);
            this.panelIzquierdo.TabIndex = 15;
            this.panelIzquierdo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelIzquierdo_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 617);
            this.panel3.TabIndex = 0;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(204)))));
            this.panelSuperior.Controls.Add(this.txtIniciarSesion);
            this.panelSuperior.Controls.Add(this.pictureBox2);
            this.panelSuperior.Controls.Add(this.linea);
            this.panelSuperior.Controls.Add(this.btnCerrar);
            this.panelSuperior.Controls.Add(this.txtContrasena);
            this.panelSuperior.Controls.Add(this.txtUsuario);
            this.panelSuperior.Controls.Add(this.btIngresar);
            this.panelSuperior.Controls.Add(this.pictureBox1);
            this.panelSuperior.Controls.Add(this.lbOlvideContrasena);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSuperior.Location = new System.Drawing.Point(65, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(358, 617);
            this.panelSuperior.TabIndex = 16;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // txtIniciarSesion
            // 
            this.txtIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(204)))));
            this.txtIniciarSesion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIniciarSesion.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtIniciarSesion.Font = new System.Drawing.Font("MS UI Gothic", 28F, System.Drawing.FontStyle.Bold);
            this.txtIniciarSesion.ForeColor = System.Drawing.Color.Sienna;
            this.txtIniciarSesion.Location = new System.Drawing.Point(28, 279);
            this.txtIniciarSesion.Name = "txtIniciarSesion";
            this.txtIniciarSesion.Size = new System.Drawing.Size(301, 38);
            this.txtIniciarSesion.TabIndex = 21;
            this.txtIniciarSesion.Text = "Iniciar Sesión";
            this.txtIniciarSesion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Peru;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Location = new System.Drawing.Point(36, 430);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(284, 2);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // linea
            // 
            this.linea.BackColor = System.Drawing.Color.Peru;
            this.linea.Cursor = System.Windows.Forms.Cursors.Default;
            this.linea.Location = new System.Drawing.Point(36, 388);
            this.linea.Name = "linea";
            this.linea.Size = new System.Drawing.Size(284, 2);
            this.linea.TabIndex = 19;
            this.linea.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = global::LP2Rest.Properties.Resources.imgCerrarIcon_Medium;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(318, 16);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.TabIndex = 18;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(204)))));
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.txtContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtContrasena.Location = new System.Drawing.Point(36, 405);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(284, 23);
            this.txtContrasena.TabIndex = 17;
            this.txtContrasena.Text = "Contraseña";
            this.txtContrasena.Enter += new System.EventHandler(this.txtContrasena_Enter);
            this.txtContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContrasena_KeyPress);
            this.txtContrasena.Leave += new System.EventHandler(this.txtContrasena_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(204)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtUsuario.Location = new System.Drawing.Point(36, 364);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(284, 23);
            this.txtUsuario.TabIndex = 16;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LP2Rest.Properties.Resources.imgRestauranteLogo_big_strongerColor;
            this.pictureBox1.Location = new System.Drawing.Point(28, 47);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // frmLogin
            // 
            this.ClientSize = new System.Drawing.Size(423, 617);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in";
            this.panelIzquierdo.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btIngresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbOlvideContrasena;
        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.PictureBox linea;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtIniciarSesion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCerrar;
    }
}