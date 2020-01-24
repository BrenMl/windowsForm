namespace FerreroCS.CATALOGOS
{
    partial class FrmCapturarFoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCapturarFoto));
            this.dispositivos = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnIniciaDeten = new System.Windows.Forms.Button();
            this.pbWebCam = new System.Windows.Forms.PictureBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbWebCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dispositivos
            // 
            this.dispositivos.FormattingEnabled = true;
            this.dispositivos.Location = new System.Drawing.Point(11, 312);
            this.dispositivos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dispositivos.Name = "dispositivos";
            this.dispositivos.Size = new System.Drawing.Size(197, 21);
            this.dispositivos.TabIndex = 13;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::FerreroCS.Properties.Resources.disquete;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(467, 244);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(27, 26);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCapturar
            // 
            this.btnCapturar.BackgroundImage = global::FerreroCS.Properties.Resources.portatil_abierto;
            this.btnCapturar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCapturar.Enabled = false;
            this.btnCapturar.FlatAppearance.BorderSize = 0;
            this.btnCapturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapturar.Location = new System.Drawing.Point(413, 239);
            this.btnCapturar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(36, 31);
            this.btnCapturar.TabIndex = 16;
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnIniciaDeten
            // 
            this.btnIniciaDeten.BackgroundImage = global::FerreroCS.Properties.Resources.camara_web__1_;
            this.btnIniciaDeten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciaDeten.Enabled = false;
            this.btnIniciaDeten.FlatAppearance.BorderSize = 0;
            this.btnIniciaDeten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciaDeten.Location = new System.Drawing.Point(230, 307);
            this.btnIniciaDeten.Margin = new System.Windows.Forms.Padding(2);
            this.btnIniciaDeten.Name = "btnIniciaDeten";
            this.btnIniciaDeten.Size = new System.Drawing.Size(25, 26);
            this.btnIniciaDeten.TabIndex = 15;
            this.btnIniciaDeten.UseVisualStyleBackColor = true;
            this.btnIniciaDeten.Click += new System.EventHandler(this.btnIniciaDeten_Click);
            // 
            // pbWebCam
            // 
            this.pbWebCam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbWebCam.Location = new System.Drawing.Point(9, 10);
            this.pbWebCam.Margin = new System.Windows.Forms.Padding(2);
            this.pbWebCam.Name = "pbWebCam";
            this.pbWebCam.Size = new System.Drawing.Size(368, 277);
            this.pbWebCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWebCam.TabIndex = 12;
            this.pbWebCam.TabStop = false;
            this.pbWebCam.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbWebCam_MouseDown);
            this.pbWebCam.MouseLeave += new System.EventHandler(this.pbWebCam_MouseLeave);
            this.pbWebCam.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbWebCam_MouseMove);
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(389, 56);
            this.pbFoto.Margin = new System.Windows.Forms.Padding(2);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(133, 179);
            this.pbFoto.TabIndex = 14;
            this.pbFoto.TabStop = false;
            // 
            // FrmCapturarFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 351);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.btnIniciaDeten);
            this.Controls.Add(this.dispositivos);
            this.Controls.Add(this.pbWebCam);
            this.Controls.Add(this.pbFoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCapturarFoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capturar fotografía";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCapturarFoto_FormClosing);
            this.Shown += new System.EventHandler(this.FrmCapturarFoto_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbWebCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox dispositivos;
        private System.Windows.Forms.PictureBox pbWebCam;
        private System.Windows.Forms.Button btnIniciaDeten;
        public System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnGuardar;
    }
}