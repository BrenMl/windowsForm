namespace FerreroCS.VENTAS
{
    partial class FrmEntradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntradas));
            this.tsBarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnAfectaInventario = new System.Windows.Forms.ToolStripButton();
            this.btn_BuscarProducto = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Eliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Agregar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCantidad = new DevExpress.XtraEditors.TextEdit();
            this.txtCosto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblProducto = new DevExpress.XtraEditors.LabelControl();
            this.txtFactura = new DevExpress.XtraEditors.TextEdit();
            this.lblFactura = new DevExpress.XtraEditors.LabelControl();
            this.deFechaEntrega = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lblEstatusEntrada = new DevExpress.XtraEditors.LabelControl();
            this.deFechaEntrada = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbProveedor = new ControlesPersonalizados.AutocompleteComboBox();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.grcEntradas = new DevExpress.XtraGrid.GridControl();
            this.dgvEntradas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblSubtotalDesc = new DevExpress.XtraEditors.LabelControl();
            this.lbltotalpesos = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblSubtotal = new DevExpress.XtraEditors.LabelControl();
            this.lblDescuento = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalDesc = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalIEPS = new DevExpress.XtraEditors.LabelControl();
            this.lblIEPS = new DevExpress.XtraEditors.LabelControl();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tnpCompras = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tnpProductos = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.lblNombreProducto = new DevExpress.XtraEditors.LabelControl();
            this.tsBarraHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaEntrega.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaEntrega.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaEntrada.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaEntrada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tnpCompras.SuspendLayout();
            this.tnpProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsBarraHerramientas
            // 
            this.tsBarraHerramientas.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tsBarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar,
            this.tsbModificar,
            this.tsbEliminar,
            this.btnAfectaInventario});
            this.tsBarraHerramientas.Location = new System.Drawing.Point(0, 0);
            this.tsBarraHerramientas.Name = "tsBarraHerramientas";
            this.tsBarraHerramientas.Size = new System.Drawing.Size(593, 32);
            this.tsBarraHerramientas.TabIndex = 1;
            this.tsBarraHerramientas.Text = "toolStrip1";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(29, 29);
            this.tsbGuardar.Text = "toolStripButton1";
            this.tsbGuardar.ToolTipText = "Guardar ";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbModificar
            // 
            this.tsbModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsbModificar.Image")));
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(29, 29);
            this.tsbModificar.Text = "toolStripButton3";
            this.tsbModificar.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tsbModificar.ToolTipText = "Modifcar";
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(29, 29);
            this.tsbEliminar.Text = "toolStripButton2";
            this.tsbEliminar.ToolTipText = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // btnAfectaInventario
            // 
            this.btnAfectaInventario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAfectaInventario.Image = global::FerreroCS.Properties.Resources.carro_de_entregas__1_;
            this.btnAfectaInventario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAfectaInventario.Name = "btnAfectaInventario";
            this.btnAfectaInventario.Size = new System.Drawing.Size(29, 29);
            this.btnAfectaInventario.Text = "Afectar inventario";
            this.btnAfectaInventario.Click += new System.EventHandler(this.btnAfectaInventario_Click);
            // 
            // btn_BuscarProducto
            // 
            this.btn_BuscarProducto.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_BuscarProducto.Appearance.Options.UseBackColor = true;
            this.btn_BuscarProducto.BackgroundImage = global::FerreroCS.Properties.Resources.carro;
            this.btn_BuscarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BuscarProducto.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn_BuscarProducto.Location = new System.Drawing.Point(73, 8);
            this.btn_BuscarProducto.Name = "btn_BuscarProducto";
            this.btn_BuscarProducto.Size = new System.Drawing.Size(27, 27);
            this.btn_BuscarProducto.TabIndex = 26;
            this.btn_BuscarProducto.Click += new System.EventHandler(this.btn_BuscarProducto_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_Eliminar.Appearance.Options.UseBackColor = true;
            this.btn_Eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.BackgroundImage")));
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Eliminar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn_Eliminar.Location = new System.Drawing.Point(522, 41);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(27, 27);
            this.btn_Eliminar.TabIndex = 25;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_Agregar.Appearance.Options.UseBackColor = true;
            this.btn_Agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.BackgroundImage")));
            this.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Agregar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn_Agregar.Location = new System.Drawing.Point(484, 41);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(27, 27);
            this.btn_Agregar.TabIndex = 24;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(20, 50);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 13);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(73, 48);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(57, 20);
            this.txtCantidad.TabIndex = 19;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(175, 48);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(57, 20);
            this.txtCosto.TabIndex = 18;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(137, 50);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Costo:";
            // 
            // lblProducto
            // 
            this.lblProducto.Location = new System.Drawing.Point(20, 13);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(47, 13);
            this.lblProducto.TabIndex = 15;
            this.lblProducto.Text = "Producto:";
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(85, 16);
            this.txtFactura.Margin = new System.Windows.Forms.Padding(2);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(80, 20);
            this.txtFactura.TabIndex = 24;
            // 
            // lblFactura
            // 
            this.lblFactura.Location = new System.Drawing.Point(24, 19);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(56, 13);
            this.lblFactura.TabIndex = 23;
            this.lblFactura.Text = "N° Factura:";
            // 
            // deFechaEntrega
            // 
            this.deFechaEntrega.EditValue = null;
            this.deFechaEntrega.Location = new System.Drawing.Point(383, 121);
            this.deFechaEntrega.Margin = new System.Windows.Forms.Padding(2);
            this.deFechaEntrega.Name = "deFechaEntrega";
            this.deFechaEntrega.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.deFechaEntrega.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaEntrega.Properties.HighlightHolidays = false;
            this.deFechaEntrega.Properties.Mask.BeepOnError = true;
            this.deFechaEntrega.Size = new System.Drawing.Size(126, 20);
            this.deFechaEntrega.TabIndex = 22;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(306, 124);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(74, 13);
            this.labelControl7.TabIndex = 21;
            this.labelControl7.Text = "Fecha Entrega:";
            // 
            // lblEstatusEntrada
            // 
            this.lblEstatusEntrada.Location = new System.Drawing.Point(309, 23);
            this.lblEstatusEntrada.Name = "lblEstatusEntrada";
            this.lblEstatusEntrada.Size = new System.Drawing.Size(0, 13);
            this.lblEstatusEntrada.TabIndex = 20;
            // 
            // deFechaEntrada
            // 
            this.deFechaEntrada.EditValue = null;
            this.deFechaEntrada.Location = new System.Drawing.Point(94, 122);
            this.deFechaEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.deFechaEntrada.Name = "deFechaEntrada";
            this.deFechaEntrada.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.deFechaEntrada.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaEntrada.Properties.HighlightHolidays = false;
            this.deFechaEntrada.Properties.Mask.BeepOnError = true;
            this.deFechaEntrada.Size = new System.Drawing.Size(126, 20);
            this.deFechaEntrada.TabIndex = 19;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 124);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 13);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Fecha Compra:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(233, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Estatus:";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(85, 63);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(135, 21);
            this.cmbProveedor.TabIndex = 15;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(25, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Proveedor:";
            // 
            // grcEntradas
            // 
            this.grcEntradas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcEntradas.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grcEntradas.Location = new System.Drawing.Point(14, 83);
            this.grcEntradas.MainView = this.dgvEntradas;
            this.grcEntradas.Margin = new System.Windows.Forms.Padding(2);
            this.grcEntradas.Name = "grcEntradas";
            this.grcEntradas.Size = new System.Drawing.Size(528, 131);
            this.grcEntradas.TabIndex = 10;
            this.grcEntradas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvEntradas});
            // 
            // dgvEntradas
            // 
            this.dgvEntradas.DetailHeight = 284;
            this.dgvEntradas.GridControl = this.grcEntradas;
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.OptionsBehavior.Editable = false;
            this.dgvEntradas.OptionsView.ShowGroupPanel = false;
            this.dgvEntradas.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.dgvEntradas_RowClick);
            // 
            // lblSubtotalDesc
            // 
            this.lblSubtotalDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotalDesc.Location = new System.Drawing.Point(439, 219);
            this.lblSubtotalDesc.Name = "lblSubtotalDesc";
            this.lblSubtotalDesc.Size = new System.Drawing.Size(47, 13);
            this.lblSubtotalDesc.TabIndex = 20;
            this.lblSubtotalDesc.Text = "Subtotal: ";
            // 
            // lbltotalpesos
            // 
            this.lbltotalpesos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotalpesos.Location = new System.Drawing.Point(501, 276);
            this.lbltotalpesos.Name = "lbltotalpesos";
            this.lbltotalpesos.Size = new System.Drawing.Size(16, 13);
            this.lbltotalpesos.TabIndex = 22;
            this.lbltotalpesos.Text = "0.0";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(455, 276);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 13);
            this.labelControl5.TabIndex = 23;
            this.labelControl5.Text = "Total: ";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotal.Location = new System.Drawing.Point(501, 219);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(16, 13);
            this.lblSubtotal.TabIndex = 24;
            this.lblSubtotal.Text = "0.0";
            // 
            // lblDescuento
            // 
            this.lblDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescuento.Location = new System.Drawing.Point(428, 238);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(58, 13);
            this.lblDescuento.TabIndex = 25;
            this.lblDescuento.Text = "Descuento: ";
            // 
            // lblTotalDesc
            // 
            this.lblTotalDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalDesc.Location = new System.Drawing.Point(501, 238);
            this.lblTotalDesc.Name = "lblTotalDesc";
            this.lblTotalDesc.ShowToolTips = false;
            this.lblTotalDesc.Size = new System.Drawing.Size(16, 13);
            this.lblTotalDesc.TabIndex = 26;
            this.lblTotalDesc.Text = "0.0";
            // 
            // lblTotalIEPS
            // 
            this.lblTotalIEPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalIEPS.Location = new System.Drawing.Point(501, 257);
            this.lblTotalIEPS.Name = "lblTotalIEPS";
            this.lblTotalIEPS.Size = new System.Drawing.Size(16, 13);
            this.lblTotalIEPS.TabIndex = 27;
            this.lblTotalIEPS.Text = "0.0";
            // 
            // lblIEPS
            // 
            this.lblIEPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIEPS.Location = new System.Drawing.Point(457, 257);
            this.lblIEPS.Name = "lblIEPS";
            this.lblIEPS.Size = new System.Drawing.Size(29, 13);
            this.lblIEPS.TabIndex = 28;
            this.lblIEPS.Text = "IEPS: ";
            // 
            // tabPane1
            // 
            this.tabPane1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPane1.Controls.Add(this.tnpCompras);
            this.tabPane1.Controls.Add(this.tnpProductos);
            this.tabPane1.Location = new System.Drawing.Point(12, 35);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tnpCompras,
            this.tnpProductos});
            this.tabPane1.RegularSize = new System.Drawing.Size(566, 324);
            this.tabPane1.SelectedPage = this.tnpCompras;
            this.tabPane1.Size = new System.Drawing.Size(566, 324);
            this.tabPane1.TabIndex = 29;
            this.tabPane1.Text = "tabPane1";
            // 
            // tnpCompras
            // 
            this.tnpCompras.Caption = "General";
            this.tnpCompras.Controls.Add(this.txtFactura);
            this.tnpCompras.Controls.Add(this.lblNombre);
            this.tnpCompras.Controls.Add(this.cmbProveedor);
            this.tnpCompras.Controls.Add(this.lblFactura);
            this.tnpCompras.Controls.Add(this.labelControl1);
            this.tnpCompras.Controls.Add(this.labelControl2);
            this.tnpCompras.Controls.Add(this.deFechaEntrega);
            this.tnpCompras.Controls.Add(this.deFechaEntrada);
            this.tnpCompras.Controls.Add(this.labelControl7);
            this.tnpCompras.Controls.Add(this.lblEstatusEntrada);
            this.tnpCompras.Name = "tnpCompras";
            this.tnpCompras.Size = new System.Drawing.Size(566, 297);
            // 
            // tnpProductos
            // 
            this.tnpProductos.Caption = "Compras";
            this.tnpProductos.Controls.Add(this.lblNombreProducto);
            this.tnpProductos.Controls.Add(this.lblIEPS);
            this.tnpProductos.Controls.Add(this.lblProducto);
            this.tnpProductos.Controls.Add(this.lblTotalIEPS);
            this.tnpProductos.Controls.Add(this.labelControl3);
            this.tnpProductos.Controls.Add(this.lblTotalDesc);
            this.tnpProductos.Controls.Add(this.btn_BuscarProducto);
            this.tnpProductos.Controls.Add(this.lblDescuento);
            this.tnpProductos.Controls.Add(this.txtCosto);
            this.tnpProductos.Controls.Add(this.lblSubtotal);
            this.tnpProductos.Controls.Add(this.txtCantidad);
            this.tnpProductos.Controls.Add(this.labelControl5);
            this.tnpProductos.Controls.Add(this.btn_Eliminar);
            this.tnpProductos.Controls.Add(this.lbltotalpesos);
            this.tnpProductos.Controls.Add(this.labelControl4);
            this.tnpProductos.Controls.Add(this.lblSubtotalDesc);
            this.tnpProductos.Controls.Add(this.btn_Agregar);
            this.tnpProductos.Controls.Add(this.grcEntradas);
            this.tnpProductos.Name = "tnpProductos";
            this.tnpProductos.Size = new System.Drawing.Size(566, 297);
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.Location = new System.Drawing.Point(147, 15);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(0, 13);
            this.lblNombreProducto.TabIndex = 21;
            // 
            // FrmEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 374);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.tsBarraHerramientas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEntradas";
            this.Text = "Compras";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEntradas_FormClosed);
            this.Load += new System.EventHandler(this.FrmEntradas_Load);
            this.Shown += new System.EventHandler(this.FrmEntradas_Shown);
            this.tsBarraHerramientas.ResumeLayout(false);
            this.tsBarraHerramientas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaEntrega.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaEntrega.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaEntrada.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaEntrada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tnpCompras.ResumeLayout(false);
            this.tnpCompras.PerformLayout();
            this.tnpProductos.ResumeLayout(false);
            this.tnpProductos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsBarraHerramientas;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblProducto;
        private DevExpress.XtraEditors.DateEdit deFechaEntrada;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private ControlesPersonalizados.AutocompleteComboBox cmbProveedor;
        private DevExpress.XtraEditors.LabelControl lblNombre;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtCantidad;
        private DevExpress.XtraEditors.TextEdit txtCosto;
        private DevExpress.XtraGrid.GridControl grcEntradas;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvEntradas;
        private DevExpress.XtraEditors.LabelControl lblEstatusEntrada;
        private DevExpress.XtraEditors.SimpleButton btn_Agregar;
        private DevExpress.XtraEditors.SimpleButton btn_Eliminar;
        private System.Windows.Forms.ToolStripButton btnAfectaInventario;
        private DevExpress.XtraEditors.SimpleButton btn_BuscarProducto;
        private DevExpress.XtraEditors.LabelControl lblSubtotalDesc;
        private DevExpress.XtraEditors.LabelControl lbltotalpesos;
        private DevExpress.XtraEditors.DateEdit deFechaEntrega;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtFactura;
        private DevExpress.XtraEditors.LabelControl lblFactura;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblSubtotal;
        private DevExpress.XtraEditors.LabelControl lblDescuento;
        private DevExpress.XtraEditors.LabelControl lblTotalDesc;
        private DevExpress.XtraEditors.LabelControl lblTotalIEPS;
        private DevExpress.XtraEditors.LabelControl lblIEPS;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tnpCompras;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tnpProductos;
        private DevExpress.XtraEditors.LabelControl lblNombreProducto;
    }
}