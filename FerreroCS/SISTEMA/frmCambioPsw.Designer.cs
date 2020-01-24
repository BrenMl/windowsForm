namespace FerreroCS
{
    partial class frmCambioPsw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambioPsw));
            this.txtPwsNueva = new System.Windows.Forms.TextBox();
            this.txtPswActual = new System.Windows.Forms.TextBox();
            this.txtPswConfirmacion = new System.Windows.Forms.TextBox();
            this.gpbPwsNueva = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.lblPswConfirmacion = new System.Windows.Forms.Label();
            this.lblPswNueva = new System.Windows.Forms.Label();
            this.lblPswActual = new System.Windows.Forms.Label();
            this.gpbPwsNueva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPwsNueva
            // 
            this.txtPwsNueva.Location = new System.Drawing.Point(264, 68);
            this.txtPwsNueva.Name = "txtPwsNueva";
            this.txtPwsNueva.PasswordChar = '*';
            this.txtPwsNueva.Size = new System.Drawing.Size(147, 20);
            this.txtPwsNueva.TabIndex = 2;
            // 
            // txtPswActual
            // 
            this.txtPswActual.Location = new System.Drawing.Point(264, 32);
            this.txtPswActual.Name = "txtPswActual";
            this.txtPswActual.PasswordChar = '*';
            this.txtPswActual.Size = new System.Drawing.Size(147, 20);
            this.txtPswActual.TabIndex = 1;
            // 
            // txtPswConfirmacion
            // 
            this.txtPswConfirmacion.Location = new System.Drawing.Point(264, 105);
            this.txtPswConfirmacion.Name = "txtPswConfirmacion";
            this.txtPswConfirmacion.PasswordChar = '*';
            this.txtPswConfirmacion.Size = new System.Drawing.Size(147, 20);
            this.txtPswConfirmacion.TabIndex = 3;
            // 
            // gpbPwsNueva
            // 
            this.gpbPwsNueva.Controls.Add(this.btnCancelar);
            this.gpbPwsNueva.Controls.Add(this.pbImagen);
            this.gpbPwsNueva.Controls.Add(this.btnAceptar);
            this.gpbPwsNueva.Controls.Add(this.lblPswConfirmacion);
            this.gpbPwsNueva.Controls.Add(this.lblPswNueva);
            this.gpbPwsNueva.Controls.Add(this.lblPswActual);
            this.gpbPwsNueva.Controls.Add(this.txtPwsNueva);
            this.gpbPwsNueva.Controls.Add(this.txtPswActual);
            this.gpbPwsNueva.Controls.Add(this.txtPswConfirmacion);
            this.gpbPwsNueva.Location = new System.Drawing.Point(35, 12);
            this.gpbPwsNueva.Name = "gpbPwsNueva";
            this.gpbPwsNueva.Size = new System.Drawing.Size(427, 186);
            this.gpbPwsNueva.TabIndex = 6;
            this.gpbPwsNueva.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(236, 147);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Image = ((System.Drawing.Image)(resources.GetObject("pbImagen.Image")));
            this.pbImagen.Location = new System.Drawing.Point(16, 35);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(100, 90);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 6;
            this.pbImagen.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(100, 147);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblPswConfirmacion
            // 
            this.lblPswConfirmacion.AutoSize = true;
            this.lblPswConfirmacion.Location = new System.Drawing.Point(136, 112);
            this.lblPswConfirmacion.Name = "lblPswConfirmacion";
            this.lblPswConfirmacion.Size = new System.Drawing.Size(111, 13);
            this.lblPswConfirmacion.TabIndex = 6;
            this.lblPswConfirmacion.Text = "Confirmar Contraseña:";
            // 
            // lblPswNueva
            // 
            this.lblPswNueva.AutoSize = true;
            this.lblPswNueva.Location = new System.Drawing.Point(150, 71);
            this.lblPswNueva.Name = "lblPswNueva";
            this.lblPswNueva.Size = new System.Drawing.Size(99, 13);
            this.lblPswNueva.TabIndex = 5;
            this.lblPswNueva.Text = "Nueva Contraseña:";
            // 
            // lblPswActual
            // 
            this.lblPswActual.AutoSize = true;
            this.lblPswActual.Location = new System.Drawing.Point(150, 35);
            this.lblPswActual.Name = "lblPswActual";
            this.lblPswActual.Size = new System.Drawing.Size(97, 13);
            this.lblPswActual.TabIndex = 4;
            this.lblPswActual.Text = "Contraseña Actual:";
            // 
            // frmCambioPsw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 212);
            this.Controls.Add(this.gpbPwsNueva);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(507, 251);
            this.MinimumSize = new System.Drawing.Size(507, 251);
            this.Name = "frmCambioPsw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Contraseña";
            this.Load += new System.EventHandler(this.frmCambioPsw_Load);
            this.gpbPwsNueva.ResumeLayout(false);
            this.gpbPwsNueva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TextBox txtPwsNueva;
        internal System.Windows.Forms.TextBox txtPswActual;
        internal System.Windows.Forms.TextBox txtPswConfirmacion;
        internal System.Windows.Forms.GroupBox gpbPwsNueva;
        internal System.Windows.Forms.PictureBox pbImagen;
        internal System.Windows.Forms.Label lblPswConfirmacion;
        internal System.Windows.Forms.Label lblPswNueva;
        internal System.Windows.Forms.Label lblPswActual;
        private DevExpress.XtraEditors.SimpleButton btnAceptar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
    }
}