namespace FerreroCS.CATALOGOS
{
    partial class FrmConsultaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaClientes));
            this.dxgClientes = new DevExpress.XtraGrid.GridControl();
            this.dxgvCliente = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tsBarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbRefrescar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dxgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxgvCliente)).BeginInit();
            this.tsBarraHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dxgClientes
            // 
            this.dxgClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dxgClientes.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dxgClientes.Location = new System.Drawing.Point(13, 36);
            this.dxgClientes.MainView = this.dxgvCliente;
            this.dxgClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dxgClientes.Name = "dxgClientes";
            this.dxgClientes.Size = new System.Drawing.Size(897, 494);
            this.dxgClientes.TabIndex = 1;
            this.dxgClientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dxgvCliente});
            // 
            // dxgvCliente
            // 
            this.dxgvCliente.GridControl = this.dxgClientes;
            this.dxgvCliente.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.dxgvCliente.Name = "dxgvCliente";
            this.dxgvCliente.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dxgvCliente.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dxgvCliente.OptionsBehavior.AllowIncrementalSearch = true;
            this.dxgvCliente.OptionsBehavior.Editable = false;
            this.dxgvCliente.OptionsBehavior.ReadOnly = true;
            this.dxgvCliente.OptionsCustomization.AllowGroup = false;
            this.dxgvCliente.OptionsCustomization.AllowQuickHideColumns = false;
            this.dxgvCliente.OptionsFind.AlwaysVisible = true;
            this.dxgvCliente.OptionsFind.FindDelay = 500;
            this.dxgvCliente.OptionsFind.FindNullPrompt = "Ingrese el texto a buscar ...";
            this.dxgvCliente.OptionsView.ShowAutoFilterRow = true;
            this.dxgvCliente.OptionsView.ShowGroupPanel = false;
            this.dxgvCliente.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.dxgvCliente_RowClick);
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
            this.tsBarraHerramientas.TabIndex = 23;
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
            // FrmConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 543);
            this.Controls.Add(this.tsBarraHerramientas);
            this.Controls.Add(this.dxgClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(942, 590);
            this.Name = "FrmConsultaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Clientes";
            this.Shown += new System.EventHandler(this.FrmConsultaClientes_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxgvCliente)).EndInit();
            this.tsBarraHerramientas.ResumeLayout(false);
            this.tsBarraHerramientas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevExpress.XtraGrid.GridControl dxgClientes;
        internal DevExpress.XtraGrid.Views.Grid.GridView dxgvCliente;
        internal System.Windows.Forms.ToolStrip tsBarraHerramientas;
        internal System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbRefrescar;
    }
}