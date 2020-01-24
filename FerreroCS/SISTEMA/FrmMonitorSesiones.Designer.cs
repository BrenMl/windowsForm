namespace FerreroCS.SISTEMA
{
    partial class FrmMonitorSesiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonitorSesiones));
            this.DgvSesiones = new System.Windows.Forms.DataGridView();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.cbUsuario = new ControlesPersonalizados.AutocompleteComboBox();
            this.gbSesiones = new System.Windows.Forms.GroupBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.lblInactivas = new System.Windows.Forms.Label();
            this.lblActivas = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.tblPnlPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tblPnlControles = new System.Windows.Forms.TableLayoutPanel();
            this.tblPnlDatos = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSesiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.gbUsuario.SuspendLayout();
            this.gbSesiones.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.tblPnlPrincipal.SuspendLayout();
            this.tblPnlControles.SuspendLayout();
            this.tblPnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvSesiones
            // 
            this.DgvSesiones.AllowUserToAddRows = false;
            this.DgvSesiones.AllowUserToDeleteRows = false;
            this.DgvSesiones.AllowUserToOrderColumns = true;
            this.DgvSesiones.AllowUserToResizeRows = false;
            this.DgvSesiones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvSesiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvSesiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSesiones.Location = new System.Drawing.Point(6, 19);
            this.DgvSesiones.MultiSelect = false;
            this.DgvSesiones.Name = "DgvSesiones";
            this.DgvSesiones.ReadOnly = true;
            this.DgvSesiones.RowHeadersVisible = false;
            this.DgvSesiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSesiones.Size = new System.Drawing.Size(460, 182);
            this.DgvSesiones.TabIndex = 4;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(3, 3);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(130, 70);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 9;
            this.PictureBox1.TabStop = false;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.Location = new System.Drawing.Point(541, 13);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(54, 50);
            this.btnRefrescar.TabIndex = 5;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // gbUsuario
            // 
            this.gbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUsuario.Controls.Add(this.cbUsuario);
            this.gbUsuario.Location = new System.Drawing.Point(139, 3);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(396, 70);
            this.gbUsuario.TabIndex = 10;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Text = "Usuario.";
            // 
            // cbUsuario
            // 
            this.cbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(6, 27);
            this.cbUsuario.MatchingMethod = SergeUtils.StringMatchingMethod.UseRegexs;
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(384, 23);
            this.cbUsuario.TabIndex = 13;
            // 
            // gbSesiones
            // 
            this.gbSesiones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSesiones.Controls.Add(this.DgvSesiones);
            this.gbSesiones.Location = new System.Drawing.Point(123, 3);
            this.gbSesiones.Name = "gbSesiones";
            this.gbSesiones.Size = new System.Drawing.Size(472, 207);
            this.gbSesiones.TabIndex = 11;
            this.gbSesiones.TabStop = false;
            this.gbSesiones.Text = "Sesiones.";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox3.Controls.Add(this.lblInactivas);
            this.GroupBox3.Controls.Add(this.lblActivas);
            this.GroupBox3.Controls.Add(this.Label2);
            this.GroupBox3.Controls.Add(this.Label1);
            this.GroupBox3.Location = new System.Drawing.Point(3, 3);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(114, 207);
            this.GroupBox3.TabIndex = 12;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Info.";
            // 
            // lblInactivas
            // 
            this.lblInactivas.AutoSize = true;
            this.lblInactivas.Location = new System.Drawing.Point(54, 128);
            this.lblInactivas.Name = "lblInactivas";
            this.lblInactivas.Size = new System.Drawing.Size(39, 13);
            this.lblInactivas.TabIndex = 3;
            this.lblInactivas.Text = "Label4";
            // 
            // lblActivas
            // 
            this.lblActivas.AutoSize = true;
            this.lblActivas.Location = new System.Drawing.Point(54, 58);
            this.lblActivas.Name = "lblActivas";
            this.lblActivas.Size = new System.Drawing.Size(39, 13);
            this.lblActivas.TabIndex = 2;
            this.lblActivas.Text = "Label3";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 98);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(53, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Inactivas:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 38);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(45, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Activas:";
            // 
            // tblPnlPrincipal
            // 
            this.tblPnlPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblPnlPrincipal.ColumnCount = 1;
            this.tblPnlPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlPrincipal.Controls.Add(this.tblPnlControles, 0, 0);
            this.tblPnlPrincipal.Controls.Add(this.tblPnlDatos, 0, 1);
            this.tblPnlPrincipal.Location = new System.Drawing.Point(12, 12);
            this.tblPnlPrincipal.Name = "tblPnlPrincipal";
            this.tblPnlPrincipal.RowCount = 2;
            this.tblPnlPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tblPnlPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlPrincipal.Size = new System.Drawing.Size(604, 301);
            this.tblPnlPrincipal.TabIndex = 14;
            // 
            // tblPnlControles
            // 
            this.tblPnlControles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblPnlControles.ColumnCount = 3;
            this.tblPnlControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPnlControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPnlControles.Controls.Add(this.PictureBox1, 0, 0);
            this.tblPnlControles.Controls.Add(this.btnRefrescar, 2, 0);
            this.tblPnlControles.Controls.Add(this.gbUsuario, 1, 0);
            this.tblPnlControles.Location = new System.Drawing.Point(3, 3);
            this.tblPnlControles.Name = "tblPnlControles";
            this.tblPnlControles.RowCount = 1;
            this.tblPnlControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlControles.Size = new System.Drawing.Size(598, 76);
            this.tblPnlControles.TabIndex = 0;
            // 
            // tblPnlDatos
            // 
            this.tblPnlDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblPnlDatos.ColumnCount = 2;
            this.tblPnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.12987F));
            this.tblPnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.87013F));
            this.tblPnlDatos.Controls.Add(this.gbSesiones, 1, 0);
            this.tblPnlDatos.Controls.Add(this.GroupBox3, 0, 0);
            this.tblPnlDatos.Location = new System.Drawing.Point(3, 85);
            this.tblPnlDatos.Name = "tblPnlDatos";
            this.tblPnlDatos.RowCount = 1;
            this.tblPnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlDatos.Size = new System.Drawing.Size(598, 213);
            this.tblPnlDatos.TabIndex = 1;
            // 
            // FrmMonitorSesiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 325);
            this.Controls.Add(this.tblPnlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(648, 368);
            this.MinimumSize = new System.Drawing.Size(648, 368);
            this.Name = "FrmMonitorSesiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitoreo de Sesiones";
            this.Load += new System.EventHandler(this.FrmMonitorSesiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSesiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.gbUsuario.ResumeLayout(false);
            this.gbSesiones.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.tblPnlPrincipal.ResumeLayout(false);
            this.tblPnlControles.ResumeLayout(false);
            this.tblPnlDatos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView DgvSesiones;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Button btnRefrescar;
        internal System.Windows.Forms.GroupBox gbUsuario;
        internal ControlesPersonalizados.AutocompleteComboBox cbUsuario;
        internal System.Windows.Forms.GroupBox gbSesiones;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label lblInactivas;
        internal System.Windows.Forms.Label lblActivas;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TableLayoutPanel tblPnlPrincipal;
        internal System.Windows.Forms.TableLayoutPanel tblPnlControles;
        internal System.Windows.Forms.TableLayoutPanel tblPnlDatos;
    }
}