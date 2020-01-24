namespace FerreroCS
{
    partial class FrmBuscadorGenerico
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
            this.tsBarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.tsbRefrescar = new System.Windows.Forms.ToolStripButton();
            this.tsbExcel = new System.Windows.Forms.ToolStripButton();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cmsMenuGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmActivarInactivar = new System.Windows.Forms.ToolStripMenuItem();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.dxgDatos = new DevExpress.XtraGrid.GridControl();
            this.dxgvDatos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslblRegistrosEncontrados = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsslbFilaSeleccionada = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tsBarraHerramientas.SuspendLayout();
            this.cmsMenuGrid.SuspendLayout();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxgDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxgvDatos)).BeginInit();
            this.StatusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsBarraHerramientas
            // 
            this.tsBarraHerramientas.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tsBarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRefrescar,
            this.tsbExcel});
            this.tsBarraHerramientas.Location = new System.Drawing.Point(0, 0);
            this.tsBarraHerramientas.Name = "tsBarraHerramientas";
            this.tsBarraHerramientas.Size = new System.Drawing.Size(735, 25);
            this.tsBarraHerramientas.TabIndex = 22;
            this.tsBarraHerramientas.Text = "Barra de herramientas";
            // 
            // tsbRefrescar
            // 
            this.tsbRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefrescar.Name = "tsbRefrescar";
            this.tsbRefrescar.Size = new System.Drawing.Size(23, 22);
            this.tsbRefrescar.Text = "Refrescar datos";
            this.tsbRefrescar.Click += new System.EventHandler(this.tsbRefrescar_Click);
            // 
            // tsbExcel
            // 
            this.tsbExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcel.Name = "tsbExcel";
            this.tsbExcel.Size = new System.Drawing.Size(23, 22);
            this.tsbExcel.Text = "Exportar a Excel";
            this.tsbExcel.Click += new System.EventHandler(this.tsbExcel_Click);
            // 
            // ToolTip
            // 
            this.ToolTip.IsBalloon = true;
            // 
            // cmsMenuGrid
            // 
            this.cmsMenuGrid.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMenuGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEditar,
            this.tsmActivarInactivar});
            this.cmsMenuGrid.Name = "cmsMenuGrid";
            this.cmsMenuGrid.Size = new System.Drawing.Size(214, 48);
            // 
            // tsmEditar
            // 
            this.tsmEditar.Name = "tsmEditar";
            this.tsmEditar.Size = new System.Drawing.Size(213, 22);
            this.tsmEditar.Text = "&Editar registro";
            // 
            // tsmActivarInactivar
            // 
            this.tsmActivarInactivar.Name = "tsmActivarInactivar";
            this.tsmActivarInactivar.Size = new System.Drawing.Size(213, 22);
            this.tsmActivarInactivar.Text = "A&ctivar/Desactivar registro";
            // 
            // gbDatos
            // 
            this.gbDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDatos.Controls.Add(this.dxgDatos);
            this.gbDatos.Location = new System.Drawing.Point(2, 24);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(723, 334);
            this.gbDatos.TabIndex = 23;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // dxgDatos
            // 
            this.dxgDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dxgDatos.Location = new System.Drawing.Point(6, 19);
            this.dxgDatos.MainView = this.dxgvDatos;
            this.dxgDatos.Name = "dxgDatos";
            this.dxgDatos.Size = new System.Drawing.Size(711, 308);
            this.dxgDatos.TabIndex = 0;
            this.dxgDatos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dxgvDatos});
            // 
            // dxgvDatos
            // 
            this.dxgvDatos.DetailHeight = 284;
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
            // StatusStrip1
            // 
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblRegistrosEncontrados,
            this.ToolStripSeparator1,
            this.tsslbFilaSeleccionada});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 365);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(735, 23);
            this.StatusStrip1.TabIndex = 24;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // tsslblRegistrosEncontrados
            // 
            this.tsslblRegistrosEncontrados.Name = "tsslblRegistrosEncontrados";
            this.tsslblRegistrosEncontrados.Size = new System.Drawing.Size(124, 18);
            this.tsslblRegistrosEncontrados.Text = "Registros Encontrados";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // tsslbFilaSeleccionada
            // 
            this.tsslbFilaSeleccionada.Name = "tsslbFilaSeleccionada";
            this.tsslbFilaSeleccionada.Size = new System.Drawing.Size(133, 18);
            this.tsslbFilaSeleccionada.Text = "Registros Seleccionados";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(269, 184);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FrmBuscadorGenerico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 388);
            this.Controls.Add(this.tsBarraHerramientas);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.btnBuscar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(620, 414);
            this.Name = "FrmBuscadorGenerico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscador genérico";
            this.Shown += new System.EventHandler(this.FrmBuscadorGenerico_Shown);
            this.tsBarraHerramientas.ResumeLayout(false);
            this.tsBarraHerramientas.PerformLayout();
            this.cmsMenuGrid.ResumeLayout(false);
            this.gbDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxgDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxgvDatos)).EndInit();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip tsBarraHerramientas;
        internal System.Windows.Forms.ToolStripButton tsbRefrescar;
        internal System.Windows.Forms.ToolStripButton tsbExcel;
        internal System.Windows.Forms.ToolTip ToolTip;
        internal System.Windows.Forms.ContextMenuStrip cmsMenuGrid;
        internal System.Windows.Forms.ToolStripMenuItem tsmEditar;
        internal System.Windows.Forms.ToolStripMenuItem tsmActivarInactivar;
        internal System.Windows.Forms.GroupBox gbDatos;
        internal DevExpress.XtraGrid.GridControl dxgDatos;
        internal DevExpress.XtraGrid.Views.Grid.GridView dxgvDatos;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel tsslblRegistrosEncontrados;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripStatusLabel tsslbFilaSeleccionada;
        internal System.Windows.Forms.Button btnBuscar;
    }
}