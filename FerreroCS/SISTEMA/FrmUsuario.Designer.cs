namespace FerreroCS.SISTEMA
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.lblPerfil = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.gbDatosUsuario = new System.Windows.Forms.GroupBox();
            this.cbPerfiles = new ControlesPersonalizados.AutocompleteComboBox();
            this.lblApMaterno = new System.Windows.Forms.Label();
            this.txtApMaterno = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApPaterno = new System.Windows.Forms.Label();
            this.txtApPaterno = new System.Windows.Forms.TextBox();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.ttAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbDatosUsuario.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(149, 65);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(33, 13);
            this.lblPerfil.TabIndex = 8;
            this.lblPerfil.Text = "Perfil:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 65);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(46, 13);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(58, 63);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(84, 20);
            this.txtUsuario.TabIndex = 7;
            // 
            // gbDatosUsuario
            // 
            this.gbDatosUsuario.Controls.Add(this.cbPerfiles);
            this.gbDatosUsuario.Controls.Add(this.lblApMaterno);
            this.gbDatosUsuario.Controls.Add(this.txtApMaterno);
            this.gbDatosUsuario.Controls.Add(this.lblNombre);
            this.gbDatosUsuario.Controls.Add(this.lblPerfil);
            this.gbDatosUsuario.Controls.Add(this.Label2);
            this.gbDatosUsuario.Controls.Add(this.txtNombre);
            this.gbDatosUsuario.Controls.Add(this.txtUsuario);
            this.gbDatosUsuario.Controls.Add(this.lblApPaterno);
            this.gbDatosUsuario.Controls.Add(this.txtApPaterno);
            this.gbDatosUsuario.Location = new System.Drawing.Point(104, 29);
            this.gbDatosUsuario.Name = "gbDatosUsuario";
            this.gbDatosUsuario.Size = new System.Drawing.Size(477, 105);
            this.gbDatosUsuario.TabIndex = 39;
            this.gbDatosUsuario.TabStop = false;
            this.gbDatosUsuario.Text = "Datos usuario";
            // 
            // cbPerfiles
            // 
            this.cbPerfiles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbPerfiles.FormattingEnabled = true;
            this.cbPerfiles.Location = new System.Drawing.Point(188, 61);
            this.cbPerfiles.MatchingMethod = SergeUtils.StringMatchingMethod.UseRegexs;
            this.cbPerfiles.Name = "cbPerfiles";
            this.cbPerfiles.Size = new System.Drawing.Size(275, 23);
            this.cbPerfiles.TabIndex = 39;
            // 
            // lblApMaterno
            // 
            this.lblApMaterno.AutoSize = true;
            this.lblApMaterno.Location = new System.Drawing.Point(308, 25);
            this.lblApMaterno.Name = "lblApMaterno";
            this.lblApMaterno.Size = new System.Drawing.Size(65, 13);
            this.lblApMaterno.TabIndex = 4;
            this.lblApMaterno.Text = "Ap Materno:";
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.Location = new System.Drawing.Point(379, 22);
            this.txtApMaterno.MaxLength = 30;
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Size = new System.Drawing.Size(84, 20);
            this.txtApMaterno.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(59, 22);
            this.txtNombre.MaxLength = 40;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(84, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblApPaterno
            // 
            this.lblApPaterno.AutoSize = true;
            this.lblApPaterno.Location = new System.Drawing.Point(149, 25);
            this.lblApPaterno.Name = "lblApPaterno";
            this.lblApPaterno.Size = new System.Drawing.Size(63, 13);
            this.lblApPaterno.TabIndex = 2;
            this.lblApPaterno.Text = "Ap Paterno:";
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.Location = new System.Drawing.Point(218, 22);
            this.txtApPaterno.MaxLength = 30;
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Size = new System.Drawing.Size(84, 20);
            this.txtApPaterno.TabIndex = 3;
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbGuardar});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(594, 32);
            this.ToolStrip1.TabIndex = 38;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // TsbGuardar
            // 
            this.TsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("TsbGuardar.Image")));
            this.TsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbGuardar.Name = "TsbGuardar";
            this.TsbGuardar.Size = new System.Drawing.Size(29, 29);
            this.TsbGuardar.Text = "Guardar";
            this.TsbGuardar.Click += new System.EventHandler(this.TsbGuardar_Click);
            // 
            // ttAyuda
            // 
            this.ttAyuda.IsBalloon = true;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(10, 29);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(88, 88);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 40;
            this.PictureBox1.TabStop = false;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 147);
            this.Controls.Add(this.gbDatosUsuario);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(614, 190);
            this.MinimumSize = new System.Drawing.Size(614, 190);
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.gbDatosUsuario.ResumeLayout(false);
            this.gbDatosUsuario.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblPerfil;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtUsuario;
        internal System.Windows.Forms.GroupBox gbDatosUsuario;
        internal ControlesPersonalizados.AutocompleteComboBox cbPerfiles;
        internal System.Windows.Forms.Label lblApMaterno;
        internal System.Windows.Forms.TextBox txtApMaterno;
        internal System.Windows.Forms.Label lblNombre;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Label lblApPaterno;
        internal System.Windows.Forms.TextBox txtApPaterno;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton TsbGuardar;
        internal System.Windows.Forms.ToolTip ttAyuda;
        internal System.Windows.Forms.PictureBox PictureBox1;
    }
}