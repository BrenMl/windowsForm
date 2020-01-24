namespace FerreroCS
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lklCamiarUsuario = new System.Windows.Forms.LinkLabel();
            this.lblInfoUsuario = new System.Windows.Forms.Label();
            this.lklCambiarPsw = new System.Windows.Forms.LinkLabel();
            this.gbModulos = new System.Windows.Forms.GroupBox();
            this.btnReparaciones = new System.Windows.Forms.Button();
            this.stsBarraEstado = new System.Windows.Forms.StatusStrip();
            this.lblServidor = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPServidor = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBD = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPBD = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnSistema = new System.Windows.Forms.Button();
            this.btnCatálogos = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.gbModulos.SuspendLayout();
            this.stsBarraEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lblUsuario);
            this.GroupBox1.Controls.Add(this.lklCamiarUsuario);
            this.GroupBox1.Controls.Add(this.lblInfoUsuario);
            this.GroupBox1.Controls.Add(this.lklCambiarPsw);
            this.GroupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(391, 72);
            this.GroupBox1.TabIndex = 22;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = " DATOS DEL USUARIO";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUsuario.Location = new System.Drawing.Point(60, 21);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(63, 14);
            this.lblUsuario.TabIndex = 15;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lklCamiarUsuario
            // 
            this.lklCamiarUsuario.AutoSize = true;
            this.lklCamiarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lklCamiarUsuario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklCamiarUsuario.LinkColor = System.Drawing.Color.Indigo;
            this.lklCamiarUsuario.Location = new System.Drawing.Point(250, 45);
            this.lklCamiarUsuario.Name = "lklCamiarUsuario";
            this.lklCamiarUsuario.Size = new System.Drawing.Size(135, 13);
            this.lklCamiarUsuario.TabIndex = 14;
            this.lklCamiarUsuario.TabStop = true;
            this.lklCamiarUsuario.Text = "Cambiar de Usuario";
            this.lklCamiarUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklCamiarUsuario_LinkClicked);
            // 
            // lblInfoUsuario
            // 
            this.lblInfoUsuario.Font = new System.Drawing.Font("Verdana", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoUsuario.ForeColor = System.Drawing.Color.Maroon;
            this.lblInfoUsuario.Location = new System.Drawing.Point(129, 19);
            this.lblInfoUsuario.Name = "lblInfoUsuario";
            this.lblInfoUsuario.Size = new System.Drawing.Size(164, 21);
            this.lblInfoUsuario.TabIndex = 1;
            this.lblInfoUsuario.Text = "Usuario del sistema";
            this.lblInfoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lklCambiarPsw
            // 
            this.lklCambiarPsw.AutoSize = true;
            this.lklCambiarPsw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lklCambiarPsw.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklCambiarPsw.LinkColor = System.Drawing.Color.Indigo;
            this.lklCambiarPsw.Location = new System.Drawing.Point(6, 45);
            this.lklCambiarPsw.Name = "lklCambiarPsw";
            this.lklCambiarPsw.Size = new System.Drawing.Size(138, 13);
            this.lklCambiarPsw.TabIndex = 13;
            this.lklCambiarPsw.TabStop = true;
            this.lklCambiarPsw.Text = "Cambiar contraseña";
            this.lklCambiarPsw.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklCambiarPsw_LinkClicked);
            // 
            // gbModulos
            // 
            this.gbModulos.Controls.Add(this.btnVentas);
            this.gbModulos.Controls.Add(this.btnSistema);
            this.gbModulos.Controls.Add(this.btnCatálogos);
            this.gbModulos.Controls.Add(this.btnReparaciones);
            this.gbModulos.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbModulos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbModulos.Location = new System.Drawing.Point(12, 96);
            this.gbModulos.Name = "gbModulos";
            this.gbModulos.Size = new System.Drawing.Size(391, 157);
            this.gbModulos.TabIndex = 23;
            this.gbModulos.TabStop = false;
            this.gbModulos.Text = "MODULOS";
            // 
            // btnReparaciones
            // 
            this.btnReparaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReparaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReparaciones.Location = new System.Drawing.Point(489, 39);
            this.btnReparaciones.Name = "btnReparaciones";
            this.btnReparaciones.Size = new System.Drawing.Size(104, 98);
            this.btnReparaciones.TabIndex = 25;
            this.btnReparaciones.UseVisualStyleBackColor = true;
            this.btnReparaciones.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // stsBarraEstado
            // 
            this.stsBarraEstado.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsBarraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblServidor,
            this.lblPServidor,
            this.lblBD,
            this.lblPBD});
            this.stsBarraEstado.Location = new System.Drawing.Point(0, 254);
            this.stsBarraEstado.Name = "stsBarraEstado";
            this.stsBarraEstado.Size = new System.Drawing.Size(411, 22);
            this.stsBarraEstado.TabIndex = 24;
            this.stsBarraEstado.Text = "StatusStrip1";
            // 
            // lblServidor
            // 
            this.lblServidor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(58, 17);
            this.lblServidor.Text = "Servidor:";
            // 
            // lblPServidor
            // 
            this.lblPServidor.Name = "lblPServidor";
            this.lblPServidor.Size = new System.Drawing.Size(54, 17);
            this.lblPServidor.Text = "Ninguno";
            // 
            // lblBD
            // 
            this.lblBD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(79, 17);
            this.lblBD.Text = "Instancia BD:";
            // 
            // lblPBD
            // 
            this.lblPBD.Name = "lblPBD";
            this.lblPBD.Size = new System.Drawing.Size(54, 17);
            this.lblPBD.Text = "Ninguno";
            // 
            // btnVentas
            // 
            this.btnVentas.BackgroundImage = global::FerreroCS.Properties.Resources.tienda_de_comestibles;
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.Location = new System.Drawing.Point(272, 38);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(104, 98);
            this.btnVentas.TabIndex = 21;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnSistema
            // 
            this.btnSistema.BackgroundImage = global::FerreroCS.Properties.Resources.ajustes;
            this.btnSistema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSistema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSistema.Location = new System.Drawing.Point(14, 38);
            this.btnSistema.Name = "btnSistema";
            this.btnSistema.Size = new System.Drawing.Size(104, 98);
            this.btnSistema.TabIndex = 17;
            this.btnSistema.UseVisualStyleBackColor = true;
            this.btnSistema.Click += new System.EventHandler(this.btnSistema_Click);
            // 
            // btnCatálogos
            // 
            this.btnCatálogos.BackgroundImage = global::FerreroCS.Properties.Resources.Catalog_36769;
            this.btnCatálogos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCatálogos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatálogos.Location = new System.Drawing.Point(143, 38);
            this.btnCatálogos.Name = "btnCatálogos";
            this.btnCatálogos.Size = new System.Drawing.Size(104, 98);
            this.btnCatálogos.TabIndex = 18;
            this.btnCatálogos.UseVisualStyleBackColor = true;
            this.btnCatálogos.Click += new System.EventHandler(this.btnCatálogos_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 276);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.gbModulos);
            this.Controls.Add(this.stsBarraEstado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 319);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmInicio_FormClosed);
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.Shown += new System.EventHandler(this.frmInicio_Shown);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.gbModulos.ResumeLayout(false);
            this.stsBarraEstado.ResumeLayout(false);
            this.stsBarraEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lblUsuario;
        internal System.Windows.Forms.LinkLabel lklCamiarUsuario;
        internal System.Windows.Forms.Label lblInfoUsuario;
        internal System.Windows.Forms.LinkLabel lklCambiarPsw;
        internal System.Windows.Forms.GroupBox gbModulos;
        internal System.Windows.Forms.Button btnVentas;
        internal System.Windows.Forms.Button btnSistema;
        internal System.Windows.Forms.Button btnCatálogos;
        internal System.Windows.Forms.StatusStrip stsBarraEstado;
        internal System.Windows.Forms.ToolStripStatusLabel lblServidor;
        internal System.Windows.Forms.ToolStripStatusLabel lblPServidor;
        internal System.Windows.Forms.ToolStripStatusLabel lblBD;
        internal System.Windows.Forms.ToolStripStatusLabel lblPBD;
        internal System.Windows.Forms.Button btnReparaciones;
    }
}

