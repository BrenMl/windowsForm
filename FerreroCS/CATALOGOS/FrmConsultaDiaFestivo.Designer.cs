namespace FerreroCS.CATALOGOS
{
    partial class FrmConsultaDiaFestivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaDiaFestivo));
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslblRegistrosEncontrados = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsslbFilaSeleccionada = new System.Windows.Forms.ToolStripStatusLabel();
            this.dxgDatos = new DevExpress.XtraGrid.GridControl();
            this.dxgvDatos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tsBarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbRefrescar = new System.Windows.Forms.ToolStripButton();
            this.StatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxgDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxgvDatos)).BeginInit();
            this.tsBarraHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblRegistrosEncontrados,
            this.ToolStripSeparator1,
            this.tsslbFilaSeleccionada});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 518);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.StatusStrip1.Size = new System.Drawing.Size(924, 25);
            this.StatusStrip1.TabIndex = 31;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // tsslblRegistrosEncontrados
            // 
            this.tsslblRegistrosEncontrados.Name = "tsslblRegistrosEncontrados";
            this.tsslblRegistrosEncontrados.Size = new System.Drawing.Size(156, 20);
            this.tsslblRegistrosEncontrados.Text = "Registros Encontrados";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsslbFilaSeleccionada
            // 
            this.tsslbFilaSeleccionada.Name = "tsslbFilaSeleccionada";
            this.tsslbFilaSeleccionada.Size = new System.Drawing.Size(169, 20);
            this.tsslbFilaSeleccionada.Text = "Registros Seleccionados";
            // 
            // dxgDatos
            // 
            this.dxgDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dxgDatos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dxgDatos.Location = new System.Drawing.Point(0, 43);
            this.dxgDatos.MainView = this.dxgvDatos;
            this.dxgDatos.Margin = new System.Windows.Forms.Padding(4);
            this.dxgDatos.Name = "dxgDatos";
            this.dxgDatos.Size = new System.Drawing.Size(908, 468);
            this.dxgDatos.TabIndex = 29;
            this.dxgDatos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dxgvDatos});
            // 
            // dxgvDatos
            // 
            this.dxgvDatos.GridControl = this.dxgDatos;
            this.dxgvDatos.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.dxgvDatos.Name = "dxgvDatos";
            this.dxgvDatos.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dxgvDatos.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dxgvDatos.OptionsBehavior.AllowIncrementalSearch = true;
            this.dxgvDatos.OptionsBehavior.Editable = false;
            this.dxgvDatos.OptionsBehavior.ReadOnly = true;
            this.dxgvDatos.OptionsCustomization.AllowGroup = false;
            this.dxgvDatos.OptionsCustomization.AllowQuickHideColumns = false;
            this.dxgvDatos.OptionsFind.AlwaysVisible = true;
            this.dxgvDatos.OptionsFind.FindDelay = 500;
            this.dxgvDatos.OptionsFind.FindNullPrompt = "Ingrese el texto a buscar ...";
            this.dxgvDatos.OptionsView.ShowAutoFilterRow = true;
            this.dxgvDatos.OptionsView.ShowGroupPanel = false;
            this.dxgvDatos.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.dxgvDatos_RowClick);
            this.dxgvDatos.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.dxgvDatos_SelectionChanged);
            this.dxgvDatos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dxgvDatos_KeyDown);
            this.dxgvDatos.RowCountChanged += new System.EventHandler(this.dxgvDatos_RowCountChanged);
            // 
            // tsBarraHerramientas
            // 
            this.tsBarraHerramientas.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tsBarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbRefrescar});
            this.tsBarraHerramientas.Location = new System.Drawing.Point(0, 0);
            this.tsBarraHerramientas.Name = "tsBarraHerramientas";
            this.tsBarraHerramientas.Size = new System.Drawing.Size(924, 32);
            this.tsBarraHerramientas.TabIndex = 30;
            this.tsBarraHerramientas.Text = "Barra de herramientas";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = global::FerreroCS.Properties.Resources.new_file_40454;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(29, 29);
            this.tsbNuevo.Text = "Refrescar datos";
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
            // FrmConsultaDiaFestivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 543);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.dxgDatos);
            this.Controls.Add(this.tsBarraHerramientas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(942, 590);
            this.Name = "FrmConsultaDiaFestivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar dias festivos";
            this.Shown += new System.EventHandler(this.FrmConsultaDiaFestivo_Shown);
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxgDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxgvDatos)).EndInit();
            this.tsBarraHerramientas.ResumeLayout(false);
            this.tsBarraHerramientas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel tsslblRegistrosEncontrados;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripStatusLabel tsslbFilaSeleccionada;
        internal DevExpress.XtraGrid.GridControl dxgDatos;
        internal DevExpress.XtraGrid.Views.Grid.GridView dxgvDatos;
        internal System.Windows.Forms.ToolStrip tsBarraHerramientas;
        internal System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbRefrescar;
    }
}