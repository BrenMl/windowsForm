namespace FerreroCS.VENTAS
{
    partial class FrmSalidas
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
            this.tsBarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tabSalidas = new DevExpress.XtraBars.Navigation.TabPane();
            this.tnpDatosGrales = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gcEmpleado = new DevExpress.XtraEditors.GroupControl();
            this.grcDatosEmpleado = new DevExpress.XtraGrid.GridControl();
            this.dxcvResumen = new DevExpress.XtraGrid.Views.Card.CardView();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnBuscarEmpleado = new DevExpress.XtraEditors.SimpleButton();
            this.gcGenerales = new DevExpress.XtraEditors.GroupControl();
            this.deFechaSalida = new DevExpress.XtraEditors.DateEdit();
            this.lblEstatus = new DevExpress.XtraEditors.LabelControl();
            this.lblFolio = new DevExpress.XtraEditors.LabelControl();
            this.lblEstatus_ = new DevExpress.XtraEditors.LabelControl();
            this.lblFolio_ = new DevExpress.XtraEditors.LabelControl();
            this.lblFecha = new DevExpress.XtraEditors.LabelControl();
            this.tnpProductos = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.grcProductos = new DevExpress.XtraGrid.GridControl();
            this.dgvProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcProductos = new DevExpress.XtraEditors.GroupControl();
            this.lblExistencia = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new DevExpress.XtraEditors.LabelControl();
            this.lblDescripcionProducto = new DevExpress.XtraEditors.LabelControl();
            this.btnBuscarProducto = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuitarProducto = new DevExpress.XtraEditors.SimpleButton();
            this.lblProucto = new DevExpress.XtraEditors.LabelControl();
            this.btnAgregarProducto = new DevExpress.XtraEditors.SimpleButton();
            this.tsBarraHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabSalidas)).BeginInit();
            this.tabSalidas.SuspendLayout();
            this.tnpDatosGrales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpleado)).BeginInit();
            this.gcEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcDatosEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxcvResumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGenerales)).BeginInit();
            this.gcGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaSalida.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaSalida.Properties)).BeginInit();
            this.tnpProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductos)).BeginInit();
            this.gcProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
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
            this.tsBarraHerramientas.Size = new System.Drawing.Size(731, 32);
            this.tsBarraHerramientas.TabIndex = 1;
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
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardarEmpleado_Click);
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
            // tabSalidas
            // 
            this.tabSalidas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSalidas.Controls.Add(this.tnpDatosGrales);
            this.tabSalidas.Controls.Add(this.tnpProductos);
            this.tabSalidas.Location = new System.Drawing.Point(12, 34);
            this.tabSalidas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSalidas.Name = "tabSalidas";
            this.tabSalidas.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tnpDatosGrales,
            this.tnpProductos});
            this.tabSalidas.RegularSize = new System.Drawing.Size(707, 411);
            this.tabSalidas.SelectedPage = this.tnpDatosGrales;
            this.tabSalidas.Size = new System.Drawing.Size(707, 411);
            this.tabSalidas.TabIndex = 2;
            this.tabSalidas.Text = "-";
            // 
            // tnpDatosGrales
            // 
            this.tnpDatosGrales.Caption = "Datos generales";
            this.tnpDatosGrales.Controls.Add(this.gcEmpleado);
            this.tnpDatosGrales.Controls.Add(this.gcGenerales);
            this.tnpDatosGrales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tnpDatosGrales.Name = "tnpDatosGrales";
            this.tnpDatosGrales.Size = new System.Drawing.Size(707, 378);
            // 
            // gcEmpleado
            // 
            this.gcEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcEmpleado.Controls.Add(this.grcDatosEmpleado);
            this.gcEmpleado.Controls.Add(this.pbFoto);
            this.gcEmpleado.Controls.Add(this.btnBuscarEmpleado);
            this.gcEmpleado.Location = new System.Drawing.Point(3, 98);
            this.gcEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcEmpleado.Name = "gcEmpleado";
            this.gcEmpleado.Size = new System.Drawing.Size(701, 261);
            this.gcEmpleado.TabIndex = 1;
            this.gcEmpleado.Text = "Empleado";
            // 
            // grcDatosEmpleado
            // 
            this.grcDatosEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcDatosEmpleado.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.grcDatosEmpleado.Location = new System.Drawing.Point(256, 29);
            this.grcDatosEmpleado.MainView = this.dxcvResumen;
            this.grcDatosEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.grcDatosEmpleado.Name = "grcDatosEmpleado";
            this.grcDatosEmpleado.Size = new System.Drawing.Size(439, 220);
            this.grcDatosEmpleado.TabIndex = 18;
            this.grcDatosEmpleado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dxcvResumen});
            // 
            // dxcvResumen
            // 
            this.dxcvResumen.CardWidth = 267;
            this.dxcvResumen.DetailHeight = 431;
            this.dxcvResumen.GridControl = this.grcDatosEmpleado;
            this.dxcvResumen.Name = "dxcvResumen";
            this.dxcvResumen.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dxcvResumen.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dxcvResumen.OptionsBehavior.AutoHorzWidth = true;
            this.dxcvResumen.OptionsBehavior.Editable = false;
            this.dxcvResumen.OptionsBehavior.FieldAutoHeight = true;
            this.dxcvResumen.OptionsView.ShowCardCaption = false;
            this.dxcvResumen.OptionsView.ShowQuickCustomizeButton = false;
            this.dxcvResumen.OptionsView.ShowViewCaption = true;
            this.dxcvResumen.ViewCaption = "Datos";
            // 
            // pbFoto
            // 
            this.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(72, 29);
            this.pbFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(177, 220);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFoto.TabIndex = 17;
            this.pbFoto.TabStop = false;
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarEmpleado.Appearance.Options.UseBackColor = true;
            this.btnBuscarEmpleado.BackgroundImage = global::FerreroCS.Properties.Resources.Empleado;
            this.btnBuscarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarEmpleado.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(14, 114);
            this.btnBuscarEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(40, 40);
            this.btnBuscarEmpleado.TabIndex = 7;
            this.btnBuscarEmpleado.ToolTip = "Mostrar buscador de colonias";
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // gcGenerales
            // 
            this.gcGenerales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcGenerales.Controls.Add(this.deFechaSalida);
            this.gcGenerales.Controls.Add(this.lblEstatus);
            this.gcGenerales.Controls.Add(this.lblFolio);
            this.gcGenerales.Controls.Add(this.lblEstatus_);
            this.gcGenerales.Controls.Add(this.lblFolio_);
            this.gcGenerales.Controls.Add(this.lblFecha);
            this.gcGenerales.Location = new System.Drawing.Point(3, 2);
            this.gcGenerales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcGenerales.Name = "gcGenerales";
            this.gcGenerales.Size = new System.Drawing.Size(701, 92);
            this.gcGenerales.TabIndex = 0;
            this.gcGenerales.Text = "Generales";
            // 
            // deFechaSalida
            // 
            this.deFechaSalida.EditValue = new System.DateTime(((long)(0)));
            this.deFechaSalida.Location = new System.Drawing.Point(527, 39);
            this.deFechaSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deFechaSalida.Name = "deFechaSalida";
            this.deFechaSalida.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFechaSalida.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaSalida.Properties.HighlightHolidays = false;
            this.deFechaSalida.Properties.Mask.BeepOnError = true;
            this.deFechaSalida.Size = new System.Drawing.Size(168, 22);
            this.deFechaSalida.TabIndex = 12;
            // 
            // lblEstatus
            // 
            this.lblEstatus.Location = new System.Drawing.Point(207, 42);
            this.lblEstatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(41, 16);
            this.lblEstatus.TabIndex = 11;
            this.lblEstatus.Text = "Estatus";
            // 
            // lblFolio
            // 
            this.lblFolio.Location = new System.Drawing.Point(50, 42);
            this.lblFolio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(9, 16);
            this.lblFolio.TabIndex = 10;
            this.lblFolio.Text = "#";
            // 
            // lblEstatus_
            // 
            this.lblEstatus_.Location = new System.Drawing.Point(155, 42);
            this.lblEstatus_.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblEstatus_.Name = "lblEstatus_";
            this.lblEstatus_.Size = new System.Drawing.Size(46, 16);
            this.lblEstatus_.TabIndex = 2;
            this.lblEstatus_.Text = "Estatus:";
            // 
            // lblFolio_
            // 
            this.lblFolio_.Location = new System.Drawing.Point(12, 42);
            this.lblFolio_.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblFolio_.Name = "lblFolio_";
            this.lblFolio_.Size = new System.Drawing.Size(32, 16);
            this.lblFolio_.TabIndex = 0;
            this.lblFolio_.Text = "Folio:";
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(482, 42);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(39, 16);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha:";
            // 
            // tnpProductos
            // 
            this.tnpProductos.Caption = "Productos";
            this.tnpProductos.Controls.Add(this.grcProductos);
            this.tnpProductos.Controls.Add(this.gcProductos);
            this.tnpProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tnpProductos.Name = "tnpProductos";
            this.tnpProductos.Size = new System.Drawing.Size(707, 378);
            // 
            // grcProductos
            // 
            this.grcProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcProductos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grcProductos.Location = new System.Drawing.Point(3, 103);
            this.grcProductos.MainView = this.dgvProductos;
            this.grcProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grcProductos.Name = "grcProductos";
            this.grcProductos.Size = new System.Drawing.Size(696, 271);
            this.grcProductos.TabIndex = 1;
            this.grcProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvProductos});
            // 
            // dgvProductos
            // 
            this.dgvProductos.GridControl = this.grcProductos;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.OptionsBehavior.Editable = false;
            this.dgvProductos.OptionsView.ShowGroupPanel = false;
            this.dgvProductos.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.dgvProductos_RowClick);
            // 
            // gcProductos
            // 
            this.gcProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcProductos.Controls.Add(this.lblExistencia);
            this.gcProductos.Controls.Add(this.labelControl2);
            this.gcProductos.Controls.Add(this.nudCantidad);
            this.gcProductos.Controls.Add(this.lblCantidad);
            this.gcProductos.Controls.Add(this.lblDescripcionProducto);
            this.gcProductos.Controls.Add(this.btnBuscarProducto);
            this.gcProductos.Controls.Add(this.btnQuitarProducto);
            this.gcProductos.Controls.Add(this.lblProucto);
            this.gcProductos.Controls.Add(this.btnAgregarProducto);
            this.gcProductos.Location = new System.Drawing.Point(3, 12);
            this.gcProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcProductos.Name = "gcProductos";
            this.gcProductos.Size = new System.Drawing.Size(701, 87);
            this.gcProductos.TabIndex = 0;
            this.gcProductos.Text = "Productos";
            // 
            // lblExistencia
            // 
            this.lblExistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExistencia.Appearance.Options.UseTextOptions = true;
            this.lblExistencia.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblExistencia.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblExistencia.Location = new System.Drawing.Point(544, 58);
            this.lblExistencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(52, 16);
            this.lblExistencia.TabIndex = 13;
            this.lblExistencia.Text = "0";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(477, 58);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 16);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Existencia:";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCantidad.Enabled = false;
            this.nudCantidad.Location = new System.Drawing.Point(539, 29);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(57, 23);
            this.nudCantidad.TabIndex = 11;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidad.Location = new System.Drawing.Point(477, 32);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 16);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblDescripcionProducto
            // 
            this.lblDescripcionProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcionProducto.Appearance.Options.UseTextOptions = true;
            this.lblDescripcionProducto.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lblDescripcionProducto.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDescripcionProducto.Location = new System.Drawing.Point(126, 32);
            this.lblDescripcionProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDescripcionProducto.Name = "lblDescripcionProducto";
            this.lblDescripcionProducto.Size = new System.Drawing.Size(353, 42);
            this.lblDescripcionProducto.TabIndex = 9;
            this.lblDescripcionProducto.Text = "Elija un producto";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarProducto.Appearance.Options.UseBackColor = true;
            this.btnBuscarProducto.BackgroundImage = global::FerreroCS.Properties.Resources.carro;
            this.btnBuscarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarProducto.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnBuscarProducto.Location = new System.Drawing.Point(14, 32);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(36, 36);
            this.btnBuscarProducto.TabIndex = 8;
            this.btnBuscarProducto.ToolTip = "Mostrar buscador de colonias";
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitarProducto.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitarProducto.Appearance.Options.UseBackColor = true;
            this.btnQuitarProducto.BackgroundImage = global::FerreroCS.Properties.Resources.eliminar;
            this.btnQuitarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitarProducto.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnQuitarProducto.Location = new System.Drawing.Point(663, 36);
            this.btnQuitarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(33, 33);
            this.btnQuitarProducto.TabIndex = 5;
            this.btnQuitarProducto.ToolTip = "Mostrar buscador de colonias";
            this.btnQuitarProducto.Visible = false;
            this.btnQuitarProducto.Click += new System.EventHandler(this.btnQuitarProducto_Click);
            // 
            // lblProucto
            // 
            this.lblProucto.Location = new System.Drawing.Point(65, 32);
            this.lblProucto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblProucto.Name = "lblProucto";
            this.lblProucto.Size = new System.Drawing.Size(55, 16);
            this.lblProucto.TabIndex = 0;
            this.lblProucto.Text = "Producto:";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarProducto.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarProducto.Appearance.Options.UseBackColor = true;
            this.btnAgregarProducto.BackgroundImage = global::FerreroCS.Properties.Resources.anadir;
            this.btnAgregarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarProducto.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnAgregarProducto.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAgregarProducto.Location = new System.Drawing.Point(613, 36);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(33, 33);
            this.btnAgregarProducto.TabIndex = 4;
            this.btnAgregarProducto.ToolTip = "Mostrar buscador de colonias";
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // FrmSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 456);
            this.Controls.Add(this.tabSalidas);
            this.Controls.Add(this.tsBarraHerramientas);
            this.MinimumSize = new System.Drawing.Size(749, 503);
            this.Name = "FrmSalidas";
            this.Text = "Asignar productos a empleados";
            this.Shown += new System.EventHandler(this.FrmSalidas_Shown);
            this.tsBarraHerramientas.ResumeLayout(false);
            this.tsBarraHerramientas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabSalidas)).EndInit();
            this.tabSalidas.ResumeLayout(false);
            this.tnpDatosGrales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpleado)).EndInit();
            this.gcEmpleado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcDatosEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxcvResumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGenerales)).EndInit();
            this.gcGenerales.ResumeLayout(false);
            this.gcGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaSalida.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaSalida.Properties)).EndInit();
            this.tnpProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductos)).EndInit();
            this.gcProductos.ResumeLayout(false);
            this.gcProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsBarraHerramientas;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private DevExpress.XtraBars.Navigation.TabPane tabSalidas;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tnpDatosGrales;
        private DevExpress.XtraEditors.GroupControl gcEmpleado;
        private DevExpress.XtraEditors.SimpleButton btnBuscarEmpleado;
        private DevExpress.XtraEditors.GroupControl gcGenerales;
        private DevExpress.XtraEditors.LabelControl lblEstatus_;
        private DevExpress.XtraEditors.LabelControl lblFolio_;
        private DevExpress.XtraEditors.LabelControl lblFecha;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tnpProductos;
        private DevExpress.XtraGrid.GridControl grcProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvProductos;
        private DevExpress.XtraEditors.GroupControl gcProductos;
        private DevExpress.XtraEditors.SimpleButton btnQuitarProducto;
        private DevExpress.XtraEditors.LabelControl lblProucto;
        private DevExpress.XtraEditors.SimpleButton btnAgregarProducto;
        private DevExpress.XtraEditors.LabelControl lblFolio;
        private DevExpress.XtraEditors.LabelControl lblEstatus;
        private DevExpress.XtraEditors.DateEdit deFechaSalida;
        private DevExpress.XtraEditors.SimpleButton btnBuscarProducto;
        private DevExpress.XtraEditors.LabelControl lblDescripcionProducto;
        private DevExpress.XtraEditors.LabelControl lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.PictureBox pbFoto;
        internal DevExpress.XtraGrid.GridControl grcDatosEmpleado;
        internal DevExpress.XtraGrid.Views.Card.CardView dxcvResumen;
        private DevExpress.XtraEditors.LabelControl lblExistencia;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}