namespace FerreroCS.CATALOGOS
{
    partial class FrmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            this.tsBarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grcAlias = new DevExpress.XtraGrid.GridControl();
            this.dgvAlias = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tnpAlias = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gcTelefonos = new DevExpress.XtraEditors.GroupControl();
            this.btnQuitarAlias = new DevExpress.XtraEditors.SimpleButton();
            this.lblAlias = new DevExpress.XtraEditors.LabelControl();
            this.btnAgregarAlias = new DevExpress.XtraEditors.SimpleButton();
            this.txtAlias = new DevExpress.XtraEditors.TextEdit();
            this.tnpProducto = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gcProducto = new DevExpress.XtraEditors.GroupControl();
            this.cmbConfeccion = new ControlesPersonalizados.AutocompleteComboBox();
            this.cmbFamilia = new ControlesPersonalizados.AutocompleteComboBox();
            this.lblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.chkActivo = new DevExpress.XtraEditors.CheckEdit();
            this.txtProducto = new DevExpress.XtraEditors.TextEdit();
            this.lblConfeccion = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.lblFamilia = new DevExpress.XtraEditors.LabelControl();
            this.lblProducto = new DevExpress.XtraEditors.LabelControl();
            this.tabEmpleados = new DevExpress.XtraBars.Navigation.TabPane();
            this.tsBarraHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcAlias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.tnpAlias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTelefonos)).BeginInit();
            this.gcTelefonos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlias.Properties)).BeginInit();
            this.tnpProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProducto)).BeginInit();
            this.gcProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabEmpleados)).BeginInit();
            this.tabEmpleados.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsBarraHerramientas
            // 
            this.tsBarraHerramientas.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tsBarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar,
            this.tsbModificar,
            this.tsbEliminar});
            this.tsBarraHerramientas.Location = new System.Drawing.Point(0, 0);
            this.tsBarraHerramientas.Name = "tsBarraHerramientas";
            this.tsBarraHerramientas.Size = new System.Drawing.Size(713, 32);
            this.tsBarraHerramientas.TabIndex = 0;
            this.tsBarraHerramientas.Text = "toolStrip1";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGuardar.Image = global::FerreroCS.Properties.Resources.file_complete_40445;
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(29, 29);
            this.tsbGuardar.ToolTipText = "Guardar";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbModificar
            // 
            this.tsbModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModificar.Image = global::FerreroCS.Properties.Resources.edit_validated_40458;
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(29, 29);
            this.tsbModificar.ToolTipText = "Modificar";
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = global::FerreroCS.Properties.Resources.delete_file_40456;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(29, 29);
            this.tsbEliminar.ToolTipText = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grcAlias;
            this.gridView1.Name = "gridView1";
            // 
            // grcAlias
            // 
            this.grcAlias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcAlias.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grcAlias.Location = new System.Drawing.Point(3, 95);
            this.grcAlias.MainView = this.dgvAlias;
            this.grcAlias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grcAlias.Name = "grcAlias";
            this.grcAlias.Size = new System.Drawing.Size(678, 171);
            this.grcAlias.TabIndex = 1;
            this.grcAlias.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvAlias,
            this.gridView2,
            this.gridView1});
            // 
            // dgvAlias
            // 
            this.dgvAlias.GridControl = this.grcAlias;
            this.dgvAlias.Name = "dgvAlias";
            this.dgvAlias.OptionsBehavior.Editable = false;
            this.dgvAlias.OptionsView.ShowGroupPanel = false;
            this.dgvAlias.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.dgvAlias_RowClick);
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grcAlias;
            this.gridView2.Name = "gridView2";
            // 
            // tnpAlias
            // 
            this.tnpAlias.Caption = "Alias";
            this.tnpAlias.Controls.Add(this.grcAlias);
            this.tnpAlias.Controls.Add(this.gcTelefonos);
            this.tnpAlias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tnpAlias.Name = "tnpAlias";
            this.tnpAlias.Size = new System.Drawing.Size(685, 271);
            // 
            // gcTelefonos
            // 
            this.gcTelefonos.Controls.Add(this.btnQuitarAlias);
            this.gcTelefonos.Controls.Add(this.lblAlias);
            this.gcTelefonos.Controls.Add(this.btnAgregarAlias);
            this.gcTelefonos.Controls.Add(this.txtAlias);
            this.gcTelefonos.Location = new System.Drawing.Point(3, 2);
            this.gcTelefonos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcTelefonos.Name = "gcTelefonos";
            this.gcTelefonos.Size = new System.Drawing.Size(684, 86);
            this.gcTelefonos.TabIndex = 0;
            this.gcTelefonos.Text = "Acciones";
            // 
            // btnQuitarAlias
            // 
            this.btnQuitarAlias.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitarAlias.Appearance.Options.UseBackColor = true;
            this.btnQuitarAlias.BackgroundImage = global::FerreroCS.Properties.Resources.eliminar;
            this.btnQuitarAlias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitarAlias.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnQuitarAlias.Location = new System.Drawing.Point(537, 28);
            this.btnQuitarAlias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitarAlias.Name = "btnQuitarAlias";
            this.btnQuitarAlias.Size = new System.Drawing.Size(36, 33);
            this.btnQuitarAlias.TabIndex = 3;
            this.btnQuitarAlias.ToolTip = "Mostrar buscador de colonias";
            this.btnQuitarAlias.Visible = false;
            this.btnQuitarAlias.Click += new System.EventHandler(this.btnQuitarAlias_Click);
            // 
            // lblAlias
            // 
            this.lblAlias.Location = new System.Drawing.Point(127, 42);
            this.lblAlias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(32, 16);
            this.lblAlias.TabIndex = 0;
            this.lblAlias.Text = "Alias:";
            // 
            // btnAgregarAlias
            // 
            this.btnAgregarAlias.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarAlias.Appearance.Options.UseBackColor = true;
            this.btnAgregarAlias.BackgroundImage = global::FerreroCS.Properties.Resources.anadir;
            this.btnAgregarAlias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarAlias.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnAgregarAlias.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAgregarAlias.Location = new System.Drawing.Point(460, 28);
            this.btnAgregarAlias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarAlias.Name = "btnAgregarAlias";
            this.btnAgregarAlias.Size = new System.Drawing.Size(36, 33);
            this.btnAgregarAlias.TabIndex = 2;
            this.btnAgregarAlias.ToolTip = "Mostrar buscador de colonias";
            this.btnAgregarAlias.Click += new System.EventHandler(this.btnAgregarAlias_Click);
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(183, 39);
            this.txtAlias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Properties.Mask.EditMask = "\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d";
            this.txtAlias.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtAlias.Properties.MaxLength = 10;
            this.txtAlias.Size = new System.Drawing.Size(229, 22);
            this.txtAlias.TabIndex = 1;
            // 
            // tnpProducto
            // 
            this.tnpProducto.Caption = "Producto";
            this.tnpProducto.Controls.Add(this.gcProducto);
            this.tnpProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tnpProducto.Name = "tnpProducto";
            this.tnpProducto.Size = new System.Drawing.Size(685, 271);
            // 
            // gcProducto
            // 
            this.gcProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcProducto.Controls.Add(this.cmbConfeccion);
            this.gcProducto.Controls.Add(this.cmbFamilia);
            this.gcProducto.Controls.Add(this.lblCodigo);
            this.gcProducto.Controls.Add(this.chkActivo);
            this.gcProducto.Controls.Add(this.txtProducto);
            this.gcProducto.Controls.Add(this.lblConfeccion);
            this.gcProducto.Controls.Add(this.txtCodigo);
            this.gcProducto.Controls.Add(this.lblFamilia);
            this.gcProducto.Controls.Add(this.lblProducto);
            this.gcProducto.Location = new System.Drawing.Point(3, 2);
            this.gcProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcProducto.Name = "gcProducto";
            this.gcProducto.Size = new System.Drawing.Size(679, 270);
            this.gcProducto.TabIndex = 0;
            this.gcProducto.Text = "Datos del producto";
            // 
            // cmbConfeccion
            // 
            this.cmbConfeccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbConfeccion.FormattingEnabled = true;
            this.cmbConfeccion.Location = new System.Drawing.Point(411, 135);
            this.cmbConfeccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbConfeccion.Name = "cmbConfeccion";
            this.cmbConfeccion.Size = new System.Drawing.Size(253, 24);
            this.cmbConfeccion.TabIndex = 7;
            // 
            // cmbFamilia
            // 
            this.cmbFamilia.FormattingEnabled = true;
            this.cmbFamilia.Location = new System.Drawing.Point(68, 135);
            this.cmbFamilia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFamilia.Name = "cmbFamilia";
            this.cmbFamilia.Size = new System.Drawing.Size(229, 24);
            this.cmbFamilia.TabIndex = 5;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(16, 66);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(44, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // chkActivo
            // 
            this.chkActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkActivo.EditValue = true;
            this.chkActivo.Enabled = false;
            this.chkActivo.Location = new System.Drawing.Point(13, 206);
            this.chkActivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Properties.Caption = "Activo";
            this.chkActivo.Size = new System.Drawing.Size(73, 20);
            this.chkActivo.TabIndex = 8;
            // 
            // txtProducto
            // 
            this.txtProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProducto.Location = new System.Drawing.Point(293, 64);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(371, 22);
            this.txtProducto.TabIndex = 3;
            // 
            // lblConfeccion
            // 
            this.lblConfeccion.Location = new System.Drawing.Point(339, 139);
            this.lblConfeccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblConfeccion.Name = "lblConfeccion";
            this.lblConfeccion.Size = new System.Drawing.Size(67, 16);
            this.lblConfeccion.TabIndex = 6;
            this.lblConfeccion.Text = "Confección:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(68, 63);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(148, 22);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblFamilia
            // 
            this.lblFamilia.Location = new System.Drawing.Point(16, 139);
            this.lblFamilia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(46, 16);
            this.lblFamilia.TabIndex = 4;
            this.lblFamilia.Text = "Familia:";
            // 
            // lblProducto
            // 
            this.lblProducto.Location = new System.Drawing.Point(233, 66);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(55, 16);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Producto:";
            // 
            // tabEmpleados
            // 
            this.tabEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabEmpleados.Controls.Add(this.tnpProducto);
            this.tabEmpleados.Controls.Add(this.tnpAlias);
            this.tabEmpleados.Location = new System.Drawing.Point(12, 44);
            this.tabEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEmpleados.Name = "tabEmpleados";
            this.tabEmpleados.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tnpProducto,
            this.tnpAlias});
            this.tabEmpleados.RegularSize = new System.Drawing.Size(685, 304);
            this.tabEmpleados.SelectedPage = this.tnpProducto;
            this.tabEmpleados.Size = new System.Drawing.Size(685, 304);
            this.tabEmpleados.TabIndex = 1;
            this.tabEmpleados.Text = resources.GetString("tabEmpleados.Text");
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 359);
            this.Controls.Add(this.tabEmpleados);
            this.Controls.Add(this.tsBarraHerramientas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(729, 239);
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmProductos_FormClosed);
            this.Shown += new System.EventHandler(this.FrmProductos_Shown);
            this.tsBarraHerramientas.ResumeLayout(false);
            this.tsBarraHerramientas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcAlias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.tnpAlias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcTelefonos)).EndInit();
            this.gcTelefonos.ResumeLayout(false);
            this.gcTelefonos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlias.Properties)).EndInit();
            this.tnpProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProducto)).EndInit();
            this.gcProducto.ResumeLayout(false);
            this.gcProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabEmpleados)).EndInit();
            this.tabEmpleados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsBarraHerramientas;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl grcAlias;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvAlias;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tnpAlias;
        private DevExpress.XtraEditors.GroupControl gcTelefonos;
        private DevExpress.XtraEditors.SimpleButton btnQuitarAlias;
        private DevExpress.XtraEditors.LabelControl lblAlias;
        private DevExpress.XtraEditors.SimpleButton btnAgregarAlias;
        private DevExpress.XtraEditors.TextEdit txtAlias;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tnpProducto;
        private DevExpress.XtraEditors.GroupControl gcProducto;
        private ControlesPersonalizados.AutocompleteComboBox cmbConfeccion;
        private ControlesPersonalizados.AutocompleteComboBox cmbFamilia;
        private DevExpress.XtraEditors.LabelControl lblCodigo;
        private DevExpress.XtraEditors.CheckEdit chkActivo;
        private DevExpress.XtraEditors.TextEdit txtProducto;
        private DevExpress.XtraEditors.LabelControl lblConfeccion;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.LabelControl lblFamilia;
        private DevExpress.XtraEditors.LabelControl lblProducto;
        private DevExpress.XtraBars.Navigation.TabPane tabEmpleados;
    }
}