namespace FerreroCS.SISTEMA
{
    partial class FrmFiltrarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFiltrarUsuarios));
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.gbTipoFiltro = new System.Windows.Forms.GroupBox();
            this.cbBuscar = new ControlesPersonalizados.AutocompleteComboBox();
            this.lblNombreFiltro = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbBuscarUsuario = new System.Windows.Forms.CheckBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.gbTipoFiltro.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.Image")));
            this.BtnCancel.Location = new System.Drawing.Point(192, 168);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 45);
            this.BtnCancel.TabIndex = 13;
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.Image = ((System.Drawing.Image)(resources.GetObject("BtnOk.Image")));
            this.BtnOk.Location = new System.Drawing.Point(41, 168);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 45);
            this.BtnOk.TabIndex = 12;
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // gbTipoFiltro
            // 
            this.gbTipoFiltro.Controls.Add(this.cbBuscar);
            this.gbTipoFiltro.Controls.Add(this.lblNombreFiltro);
            this.gbTipoFiltro.Location = new System.Drawing.Point(10, 11);
            this.gbTipoFiltro.Name = "gbTipoFiltro";
            this.gbTipoFiltro.Size = new System.Drawing.Size(281, 52);
            this.gbTipoFiltro.TabIndex = 11;
            this.gbTipoFiltro.TabStop = false;
            this.gbTipoFiltro.Text = "Filtrar por:";
            // 
            // cbBuscar
            // 
            this.cbBuscar.FormattingEnabled = true;
            this.cbBuscar.Location = new System.Drawing.Point(56, 16);
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(203, 21);
            this.cbBuscar.TabIndex = 10;
            // 
            // lblNombreFiltro
            // 
            this.lblNombreFiltro.AutoSize = true;
            this.lblNombreFiltro.Location = new System.Drawing.Point(16, 22);
            this.lblNombreFiltro.Name = "lblNombreFiltro";
            this.lblNombreFiltro.Size = new System.Drawing.Size(33, 13);
            this.lblNombreFiltro.TabIndex = 8;
            this.lblNombreFiltro.Text = "Perfil:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ckbBuscarUsuario);
            this.GroupBox1.Controls.Add(this.txtNombreUsuario);
            this.GroupBox1.Location = new System.Drawing.Point(10, 70);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(281, 92);
            this.GroupBox1.TabIndex = 14;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Buscar por:";
            // 
            // ckbBuscarUsuario
            // 
            this.ckbBuscarUsuario.AutoSize = true;
            this.ckbBuscarUsuario.Location = new System.Drawing.Point(6, 31);
            this.ckbBuscarUsuario.Name = "ckbBuscarUsuario";
            this.ckbBuscarUsuario.Size = new System.Drawing.Size(115, 17);
            this.ckbBuscarUsuario.TabIndex = 11;
            this.ckbBuscarUsuario.Text = "Nombre de usuario";
            this.ckbBuscarUsuario.UseVisualStyleBackColor = true;
            this.ckbBuscarUsuario.CheckedChanged += new System.EventHandler(this.ckbBuscarUsuario_CheckedChanged);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Enabled = false;
            this.txtNombreUsuario.Location = new System.Drawing.Point(125, 31);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(133, 20);
            this.txtNombreUsuario.TabIndex = 7;
            // 
            // FrmFiltrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 232);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.gbTipoFiltro);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(318, 271);
            this.MinimumSize = new System.Drawing.Size(318, 271);
            this.Name = "FrmFiltrarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtrar Usuarios";
            this.Load += new System.EventHandler(this.FrmFiltrarUsuarios_Load);
            this.gbTipoFiltro.ResumeLayout(false);
            this.gbTipoFiltro.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnCancel;
        internal System.Windows.Forms.Button BtnOk;
        internal System.Windows.Forms.GroupBox gbTipoFiltro;
        internal System.Windows.Forms.Label lblNombreFiltro;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.CheckBox ckbBuscarUsuario;
        internal System.Windows.Forms.TextBox txtNombreUsuario;
        private ControlesPersonalizados.AutocompleteComboBox cbBuscar;
    }
}