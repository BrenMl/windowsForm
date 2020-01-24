namespace FerreroCS.CATALOGO
{
    partial class MDICatalogos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDICatalogos));
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsCatalogos = new System.Windows.Forms.ToolStrip();
            this.mnuCatalogos = new System.Windows.Forms.MenuStrip();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.imgListBotones = new System.Windows.Forms.ImageList(this.components);
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 431);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(632, 22);
            this.StatusStrip.TabIndex = 6;
            this.StatusStrip.Text = "StatusStrip";
            this.StatusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.StatusStrip_ItemClicked);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // tsCatalogos
            // 
            this.tsCatalogos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsCatalogos.Location = new System.Drawing.Point(0, 24);
            this.tsCatalogos.Name = "tsCatalogos";
            this.tsCatalogos.Size = new System.Drawing.Size(632, 25);
            this.tsCatalogos.TabIndex = 5;
            this.tsCatalogos.Text = "ToolStrip";
            // 
            // mnuCatalogos
            // 
            this.mnuCatalogos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuCatalogos.Location = new System.Drawing.Point(0, 0);
            this.mnuCatalogos.Name = "mnuCatalogos";
            this.mnuCatalogos.Size = new System.Drawing.Size(632, 24);
            this.mnuCatalogos.TabIndex = 4;
            this.mnuCatalogos.Text = "MenuStrip";
            // 
            // imgListBotones
            // 
            this.imgListBotones.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListBotones.ImageStream")));
            this.imgListBotones.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListBotones.Images.SetKeyName(0, "AddReport.png");
            this.imgListBotones.Images.SetKeyName(1, "DeleteReport.png");
            this.imgListBotones.Images.SetKeyName(2, "EditReport.png");
            this.imgListBotones.Images.SetKeyName(3, "SaveReport.png");
            this.imgListBotones.Images.SetKeyName(4, "CoinsHand.png");
            this.imgListBotones.Images.SetKeyName(5, "DocumentMove.png");
            this.imgListBotones.Images.SetKeyName(6, "Search2.png");
            this.imgListBotones.Images.SetKeyName(7, "DocumenMark.png");
            this.imgListBotones.Images.SetKeyName(8, "CheckList.png");
            this.imgListBotones.Images.SetKeyName(9, "Cancel2.png");
            this.imgListBotones.Images.SetKeyName(10, "VentanasCascada.png");
            this.imgListBotones.Images.SetKeyName(11, "VentanasHorizontal.png");
            this.imgListBotones.Images.SetKeyName(12, "VentanasVertical.png");
            this.imgListBotones.Images.SetKeyName(13, "OpenFolder.png");
            this.imgListBotones.Images.SetKeyName(14, "DocumentInspector.png");
            this.imgListBotones.Images.SetKeyName(15, "TickLightBlue.png");
            this.imgListBotones.Images.SetKeyName(16, "money.png");
            this.imgListBotones.Images.SetKeyName(17, "FontRedDelete.png");
            this.imgListBotones.Images.SetKeyName(18, "ReportStack.png");
            this.imgListBotones.Images.SetKeyName(19, "TableMoney.png");
            this.imgListBotones.Images.SetKeyName(20, "credit.png");
            this.imgListBotones.Images.SetKeyName(21, "CalendarViewMonth.png");
            this.imgListBotones.Images.SetKeyName(22, "CalendarViewWeek.png");
            this.imgListBotones.Images.SetKeyName(23, "Report.png");
            this.imgListBotones.Images.SetKeyName(24, "ReportUser.png");
            this.imgListBotones.Images.SetKeyName(25, "Fingerprint.png");
            this.imgListBotones.Images.SetKeyName(26, "User.png");
            this.imgListBotones.Images.SetKeyName(27, "UserAdd.png");
            this.imgListBotones.Images.SetKeyName(28, "UserSuit.png");
            this.imgListBotones.Images.SetKeyName(29, "UserSuitAdd.png");
            this.imgListBotones.Images.SetKeyName(30, "ReaderWithFinger.png");
            this.imgListBotones.Images.SetKeyName(31, "UserAddFingerprint.png");
            this.imgListBotones.Images.SetKeyName(32, "UserSuitAddFingerprint.png");
            this.imgListBotones.Images.SetKeyName(33, "UserAndUserSuitAddFingerprint.png");
            this.imgListBotones.Images.SetKeyName(34, "UserAndUserSuit.png");
            this.imgListBotones.Images.SetKeyName(35, "ListadoHuellas.png");
            this.imgListBotones.Images.SetKeyName(36, "Date.png");
            this.imgListBotones.Images.SetKeyName(37, "HotJobs.png");
            this.imgListBotones.Images.SetKeyName(38, "Group.png");
            this.imgListBotones.Images.SetKeyName(39, "TagBlueAdd.png");
            this.imgListBotones.Images.SetKeyName(40, "TagblueDelete.png");
            this.imgListBotones.Images.SetKeyName(41, "TagBlue.png");
            this.imgListBotones.Images.SetKeyName(42, "TagBlueEdit.png");
            this.imgListBotones.Images.SetKeyName(43, "ThreeTags.png");
            this.imgListBotones.Images.SetKeyName(44, "Map.png");
            this.imgListBotones.Images.SetKeyName(45, "LayersMap.png");
            this.imgListBotones.Images.SetKeyName(46, "GoogleMap.png");
            this.imgListBotones.Images.SetKeyName(47, "Coins.png");
            this.imgListBotones.Images.SetKeyName(48, "Cinepolis.png");
            this.imgListBotones.Images.SetKeyName(49, "ResellerProgramm.png");
            this.imgListBotones.Images.SetKeyName(50, "ResellerAccount.png");
            this.imgListBotones.Images.SetKeyName(51, "ThreeTags.png");
            this.imgListBotones.Images.SetKeyName(52, "Barcode.png");
            this.imgListBotones.Images.SetKeyName(53, "InstallerBox.png");
            this.imgListBotones.Images.SetKeyName(54, "FileManager.png");
            this.imgListBotones.Images.SetKeyName(55, "BaggageCartBox.png");
            this.imgListBotones.Images.SetKeyName(56, "BoxDown.png");
            this.imgListBotones.Images.SetKeyName(57, "Delete3.png");
            this.imgListBotones.Images.SetKeyName(58, "World.png");
            this.imgListBotones.Images.SetKeyName(59, "Factory.png");
            this.imgListBotones.Images.SetKeyName(60, "UserLevelFiltering.png");
            this.imgListBotones.Images.SetKeyName(61, "UpgradeDowngradeAccount.png");
            this.imgListBotones.Images.SetKeyName(62, "Building.png");
            this.imgListBotones.Images.SetKeyName(63, "lorry.png");
            this.imgListBotones.Images.SetKeyName(64, "ApplicationFromStorage.png");
            this.imgListBotones.Images.SetKeyName(65, "ApplicationHome.png");
            // 
            // MDICatalogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.tsCatalogos);
            this.Controls.Add(this.mnuCatalogos);
            this.IsMdiContainer = true;
            this.Name = "MDICatalogos";
            this.Text = "MDICatalogos";
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStrip tsCatalogos;
        private System.Windows.Forms.MenuStrip mnuCatalogos;
        private System.Windows.Forms.ToolTip toolTip;
        internal System.Windows.Forms.ImageList imgListBotones;
    }
}



