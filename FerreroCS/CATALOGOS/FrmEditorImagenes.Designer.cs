namespace FerreroCS.CATALOGOS
{
    partial class FrmEditorImagenes
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
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbBrillo = new DevExpress.XtraEditors.GroupControl();
            this.TrackBarBrightness = new System.Windows.Forms.TrackBar();
            this.gbRecortar = new DevExpress.XtraEditors.GroupControl();
            this.btnCrop = new System.Windows.Forms.Button();
            this.btnMakeSelection = new System.Windows.Forms.Button();
            this.gbGirar = new DevExpress.XtraEditors.GroupControl();
            this.btnRotatevertical = new System.Windows.Forms.Button();
            this.btnRotateHorizantal = new System.Windows.Forms.Button();
            this.btnRotateRight = new System.Windows.Forms.Button();
            this.btnRotateLeft = new System.Windows.Forms.Button();
            this.gcRedimensionar = new DevExpress.XtraEditors.GroupControl();
            this.tkbRedimensionar = new DevExpress.XtraEditors.TrackBarControl();
            this.btnOk = new System.Windows.Forms.Button();
            this.lbloriginalSize = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblModifiedSize = new System.Windows.Forms.Label();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbBrillo)).BeginInit();
            this.gbBrillo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbRecortar)).BeginInit();
            this.gbRecortar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbGirar)).BeginInit();
            this.gbGirar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRedimensionar)).BeginInit();
            this.gcRedimensionar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbRedimensionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbRedimensionar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbFoto
            // 
            this.pbFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFoto.Location = new System.Drawing.Point(3, 3);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(382, 344);
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            this.pbFoto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pbFoto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.pbFoto.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(710, 24);
            this.MenuStrip1.TabIndex = 5;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.ToolStripSeparator1,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.FileToolStripMenuItem.Tag = "";
            this.FileToolStripMenuItem.Text = "&Archivo";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.OpenToolStripMenuItem.Text = "&Abrir";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Enabled = false;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.SaveToolStripMenuItem.Text = "&Guardar";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.ExitToolStripMenuItem.Text = "&Salir";
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.EditToolStripMenuItem.Text = "&Controles";
            // 
            // UndoToolStripMenuItem
            // 
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.UndoToolStripMenuItem.Text = "&Mostrar/Ocultar";
            this.UndoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // gbBrillo
            // 
            this.gbBrillo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBrillo.Controls.Add(this.TrackBarBrightness);
            this.gbBrillo.Location = new System.Drawing.Point(4, 182);
            this.gbBrillo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbBrillo.Name = "gbBrillo";
            this.gbBrillo.Size = new System.Drawing.Size(282, 70);
            this.gbBrillo.TabIndex = 11;
            this.gbBrillo.Text = "Brillo";
            // 
            // TrackBarBrightness
            // 
            this.TrackBarBrightness.BackColor = System.Drawing.Color.White;
            this.TrackBarBrightness.Location = new System.Drawing.Point(4, 24);
            this.TrackBarBrightness.Maximum = 100;
            this.TrackBarBrightness.Minimum = -100;
            this.TrackBarBrightness.Name = "TrackBarBrightness";
            this.TrackBarBrightness.Size = new System.Drawing.Size(273, 45);
            this.TrackBarBrightness.TabIndex = 0;
            this.TrackBarBrightness.Scroll += new System.EventHandler(this.TrackBarBrightness_Scroll);
            // 
            // gbRecortar
            // 
            this.gbRecortar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRecortar.Controls.Add(this.btnCrop);
            this.gbRecortar.Controls.Add(this.btnMakeSelection);
            this.gbRecortar.Location = new System.Drawing.Point(4, 120);
            this.gbRecortar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbRecortar.Name = "gbRecortar";
            this.gbRecortar.Size = new System.Drawing.Size(282, 56);
            this.gbRecortar.TabIndex = 10;
            this.gbRecortar.Text = "Recortar";
            // 
            // btnCrop
            // 
            this.btnCrop.Location = new System.Drawing.Point(181, 24);
            this.btnCrop.Name = "btnCrop";
            this.btnCrop.Size = new System.Drawing.Size(75, 26);
            this.btnCrop.TabIndex = 1;
            this.btnCrop.Text = "&Recortar";
            this.btnCrop.UseVisualStyleBackColor = true;
            this.btnCrop.Click += new System.EventHandler(this.btnCrop_Click);
            // 
            // btnMakeSelection
            // 
            this.btnMakeSelection.Location = new System.Drawing.Point(14, 24);
            this.btnMakeSelection.Name = "btnMakeSelection";
            this.btnMakeSelection.Size = new System.Drawing.Size(115, 26);
            this.btnMakeSelection.TabIndex = 0;
            this.btnMakeSelection.Text = "&Seleccionar área";
            this.btnMakeSelection.UseVisualStyleBackColor = true;
            this.btnMakeSelection.Click += new System.EventHandler(this.btnMakeSelection_Click);
            // 
            // gbGirar
            // 
            this.gbGirar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGirar.Controls.Add(this.btnRotatevertical);
            this.gbGirar.Controls.Add(this.btnRotateHorizantal);
            this.gbGirar.Controls.Add(this.btnRotateRight);
            this.gbGirar.Controls.Add(this.btnRotateLeft);
            this.gbGirar.Location = new System.Drawing.Point(4, 256);
            this.gbGirar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbGirar.Name = "gbGirar";
            this.gbGirar.Size = new System.Drawing.Size(282, 95);
            this.gbGirar.TabIndex = 12;
            this.gbGirar.Text = "Girar";
            // 
            // btnRotatevertical
            // 
            this.btnRotatevertical.Location = new System.Drawing.Point(155, 66);
            this.btnRotatevertical.Name = "btnRotatevertical";
            this.btnRotatevertical.Size = new System.Drawing.Size(122, 23);
            this.btnRotatevertical.TabIndex = 1;
            this.btnRotatevertical.Text = "Reflejar &vertical";
            this.btnRotatevertical.UseVisualStyleBackColor = true;
            this.btnRotatevertical.Click += new System.EventHandler(this.btnRotatevertical_Click);
            // 
            // btnRotateHorizantal
            // 
            this.btnRotateHorizantal.Location = new System.Drawing.Point(8, 66);
            this.btnRotateHorizantal.Name = "btnRotateHorizantal";
            this.btnRotateHorizantal.Size = new System.Drawing.Size(122, 23);
            this.btnRotateHorizantal.TabIndex = 2;
            this.btnRotateHorizantal.Text = "Reflejar &horizontal";
            this.btnRotateHorizantal.UseVisualStyleBackColor = true;
            this.btnRotateHorizantal.Click += new System.EventHandler(this.btnRotateHorizantal_Click);
            // 
            // btnRotateRight
            // 
            this.btnRotateRight.Location = new System.Drawing.Point(155, 31);
            this.btnRotateRight.Name = "btnRotateRight";
            this.btnRotateRight.Size = new System.Drawing.Size(122, 23);
            this.btnRotateRight.TabIndex = 3;
            this.btnRotateRight.Text = "Girar &derecha";
            this.btnRotateRight.UseVisualStyleBackColor = true;
            this.btnRotateRight.Click += new System.EventHandler(this.btnRotateRight_Click);
            // 
            // btnRotateLeft
            // 
            this.btnRotateLeft.Location = new System.Drawing.Point(8, 31);
            this.btnRotateLeft.Name = "btnRotateLeft";
            this.btnRotateLeft.Size = new System.Drawing.Size(122, 23);
            this.btnRotateLeft.TabIndex = 0;
            this.btnRotateLeft.Text = "Girar &izquierda";
            this.btnRotateLeft.UseVisualStyleBackColor = true;
            this.btnRotateLeft.Click += new System.EventHandler(this.btnRotateLeft_Click);
            // 
            // gcRedimensionar
            // 
            this.gcRedimensionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gcRedimensionar.Controls.Add(this.tkbRedimensionar);
            this.gcRedimensionar.Controls.Add(this.btnOk);
            this.gcRedimensionar.Controls.Add(this.lbloriginalSize);
            this.gcRedimensionar.Controls.Add(this.Label3);
            this.gcRedimensionar.Controls.Add(this.lblModifiedSize);
            this.gcRedimensionar.Location = new System.Drawing.Point(4, 3);
            this.gcRedimensionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gcRedimensionar.Name = "gcRedimensionar";
            this.gcRedimensionar.Size = new System.Drawing.Size(282, 114);
            this.gcRedimensionar.TabIndex = 1;
            this.gcRedimensionar.Text = "Redimensionar";
            // 
            // tkbRedimensionar
            // 
            this.tkbRedimensionar.EditValue = 10;
            this.tkbRedimensionar.Location = new System.Drawing.Point(4, 22);
            this.tkbRedimensionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tkbRedimensionar.Name = "tkbRedimensionar";
            this.tkbRedimensionar.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.tkbRedimensionar.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tkbRedimensionar.Properties.Minimum = 1;
            this.tkbRedimensionar.Size = new System.Drawing.Size(274, 45);
            this.tkbRedimensionar.TabIndex = 9;
            this.tkbRedimensionar.Value = 10;
            this.tkbRedimensionar.EditValueChanged += new System.EventHandler(this.tkbRedimensionar_EditValueChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(220, 83);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(51, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lbloriginalSize
            // 
            this.lbloriginalSize.AutoSize = true;
            this.lbloriginalSize.Location = new System.Drawing.Point(4, 69);
            this.lbloriginalSize.Name = "lbloriginalSize";
            this.lbloriginalSize.Size = new System.Drawing.Size(86, 13);
            this.lbloriginalSize.TabIndex = 8;
            this.lbloriginalSize.Text = "Tamaño original:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(92, 114);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(18, 13);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "%";
            // 
            // lblModifiedSize
            // 
            this.lblModifiedSize.AutoSize = true;
            this.lblModifiedSize.Location = new System.Drawing.Point(4, 92);
            this.lblModifiedSize.Name = "lblModifiedSize";
            this.lblModifiedSize.Size = new System.Drawing.Size(103, 13);
            this.lblModifiedSize.TabIndex = 5;
            this.lblModifiedSize.Text = "Tamaño modificado:";
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.SplitContainer1.Location = new System.Drawing.Point(12, 27);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.AutoScroll = true;
            this.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.SplitContainer1.Panel1.Controls.Add(this.pbFoto);
            this.SplitContainer1.Panel1.Resize += new System.EventHandler(this.SplitContainer1_Panel1_Resize);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.gcRedimensionar);
            this.SplitContainer1.Panel2.Controls.Add(this.gbGirar);
            this.SplitContainer1.Panel2.Controls.Add(this.gbRecortar);
            this.SplitContainer1.Panel2.Controls.Add(this.gbBrillo);
            this.SplitContainer1.Size = new System.Drawing.Size(684, 349);
            this.SplitContainer1.SplitterDistance = 388;
            this.SplitContainer1.TabIndex = 6;
            // 
            // FrmEditorImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 395);
            this.Controls.Add(this.SplitContainer1);
            this.Controls.Add(this.MenuStrip1);
            this.MinimumSize = new System.Drawing.Size(726, 432);
            this.Name = "FrmEditorImagenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de imagenes";
            this.Shown += new System.EventHandler(this.FrmEditorImagenes_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbBrillo)).EndInit();
            this.gbBrillo.ResumeLayout(false);
            this.gbBrillo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbRecortar)).EndInit();
            this.gbRecortar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbGirar)).EndInit();
            this.gbGirar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcRedimensionar)).EndInit();
            this.gcRedimensionar.ResumeLayout(false);
            this.gcRedimensionar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbRedimensionar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbRedimensionar)).EndInit();
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.PictureBox pbFoto;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem UndoToolStripMenuItem;
        private DevExpress.XtraEditors.GroupControl gbBrillo;
        internal System.Windows.Forms.TrackBar TrackBarBrightness;
        private DevExpress.XtraEditors.GroupControl gbRecortar;
        internal System.Windows.Forms.Button btnCrop;
        internal System.Windows.Forms.Button btnMakeSelection;
        private DevExpress.XtraEditors.GroupControl gbGirar;
        internal System.Windows.Forms.Button btnRotatevertical;
        internal System.Windows.Forms.Button btnRotateHorizantal;
        internal System.Windows.Forms.Button btnRotateRight;
        internal System.Windows.Forms.Button btnRotateLeft;
        private DevExpress.XtraEditors.GroupControl gcRedimensionar;
        private DevExpress.XtraEditors.TrackBarControl tkbRedimensionar;
        internal System.Windows.Forms.Button btnOk;
        internal System.Windows.Forms.Label lbloriginalSize;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label lblModifiedSize;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
    }
}

