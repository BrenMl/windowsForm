namespace FerreroCS.CATALOGOS
{
    partial class FrmConsultaEntradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaEntradas));
            this.tsBarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbRefrescar = new System.Windows.Forms.ToolStripButton();
            this.dxgEntradas = new DevExpress.XtraGrid.GridControl();
            this.dxgvEntrada = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tsBarraHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxgEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxgvEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // tsBarraHerramientas
            // 
            this.tsBarraHerramientas.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tsBarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbRefrescar});
            this.tsBarraHerramientas.Location = new System.Drawing.Point(0, 0);
            this.tsBarraHerramientas.Name = "tsBarraHerramientas";
            this.tsBarraHerramientas.Size = new System.Drawing.Size(797, 32);
            this.tsBarraHerramientas.TabIndex = 24;
            this.tsBarraHerramientas.Text = "Barra de herramientas";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(29, 29);
            this.tsbNuevo.Text = "Crear nuevo registro";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbRefrescar
            // 
            this.tsbRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefrescar.Image = global::FerreroCS.Properties.Resources.refrescar__3_;
            this.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefrescar.Name = "tsbRefrescar";
            this.tsbRefrescar.Size = new System.Drawing.Size(29, 29);
            this.tsbRefrescar.Text = "toolStripButton1";
            this.tsbRefrescar.Click += new System.EventHandler(this.tsbRefrescar_Click);
            // 
            // dxgEntradas
            // 
            this.dxgEntradas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dxgEntradas.Location = new System.Drawing.Point(0, 35);
            this.dxgEntradas.MainView = this.dxgvEntrada;
            this.dxgEntradas.Name = "dxgEntradas";
            this.dxgEntradas.Size = new System.Drawing.Size(796, 349);
            this.dxgEntradas.TabIndex = 25;
            this.dxgEntradas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dxgvEntrada});
            // 
            // dxgvEntrada
            // 
            this.dxgvEntrada.DetailHeight = 284;
            this.dxgvEntrada.GridControl = this.dxgEntradas;
            this.dxgvEntrada.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.dxgvEntrada.Name = "dxgvEntrada";
            this.dxgvEntrada.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dxgvEntrada.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dxgvEntrada.OptionsBehavior.AllowIncrementalSearch = true;
            this.dxgvEntrada.OptionsBehavior.Editable = false;
            this.dxgvEntrada.OptionsBehavior.ReadOnly = true;
            this.dxgvEntrada.OptionsCustomization.AllowGroup = false;
            this.dxgvEntrada.OptionsCustomization.AllowQuickHideColumns = false;
            this.dxgvEntrada.OptionsFind.AlwaysVisible = true;
            this.dxgvEntrada.OptionsFind.FindDelay = 500;
            this.dxgvEntrada.OptionsFind.FindNullPrompt = "Ingrese el texto a buscar ...";
            this.dxgvEntrada.OptionsView.ShowAutoFilterRow = true;
            this.dxgvEntrada.OptionsView.ShowGroupPanel = false;
            this.dxgvEntrada.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.dxgvEntrada_RowClick);
            // 
            // FrmConsultaEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 403);
            this.Controls.Add(this.dxgEntradas);
            this.Controls.Add(this.tsBarraHerramientas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(813, 442);
            this.Name = "FrmConsultaEntradas";
            this.Text = "Consultar compras";
            this.Shown += new System.EventHandler(this.FrmConsultaEntradas_Shown);
            this.tsBarraHerramientas.ResumeLayout(false);
            this.tsBarraHerramientas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxgEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxgvEntrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip tsBarraHerramientas;
        internal System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbRefrescar;
        internal DevExpress.XtraGrid.GridControl dxgEntradas;
        internal DevExpress.XtraGrid.Views.Grid.GridView dxgvEntrada;
    }
}