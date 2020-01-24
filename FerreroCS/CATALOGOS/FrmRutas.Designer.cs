namespace FerreroCS.CATALOGOS
{
    partial class FrmRutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRutas));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gcDetalles = new DevExpress.XtraEditors.GroupControl();
            this.chEActivoDetalleRuta = new DevExpress.XtraEditors.CheckEdit();
            this.btnEliminarDetalle = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.btnBuscarDom = new System.Windows.Forms.Button();
            this.meLocalizacion = new DevExpress.XtraEditors.MemoEdit();
            this.cmbDia = new ControlesPersonalizados.AutocompleteComboBox();
            this.gcDetalleRuta = new DevExpress.XtraGrid.GridControl();
            this.gvDetalleRuta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.meNotas = new DevExpress.XtraEditors.MemoEdit();
            this.lblNotas = new DevExpress.XtraEditors.LabelControl();
            this.txtSecuencia = new DevExpress.XtraEditors.TextEdit();
            this.lblDomicilio = new DevExpress.XtraEditors.LabelControl();
            this.lblSecuencia = new DevExpress.XtraEditors.LabelControl();
            this.lblDia = new System.Windows.Forms.Label();
            this.chkActivo = new DevExpress.XtraEditors.CheckEdit();
            this.txtRuta = new DevExpress.XtraEditors.TextEdit();
            this.lblRuta = new System.Windows.Forms.Label();
            this.tsBarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalles)).BeginInit();
            this.gcDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chEActivoDetalleRuta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meLocalizacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalleRuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalleRuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meNotas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecuencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRuta.Properties)).BeginInit();
            this.tsBarraHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // gcDetalles
            // 
            this.gcDetalles.Controls.Add(this.chEActivoDetalleRuta);
            this.gcDetalles.Controls.Add(this.btnEliminarDetalle);
            this.gcDetalles.Controls.Add(this.btnAgregar);
            this.gcDetalles.Controls.Add(this.btnBuscarDom);
            this.gcDetalles.Controls.Add(this.meLocalizacion);
            this.gcDetalles.Controls.Add(this.cmbDia);
            this.gcDetalles.Controls.Add(this.gcDetalleRuta);
            this.gcDetalles.Controls.Add(this.meNotas);
            this.gcDetalles.Controls.Add(this.lblNotas);
            this.gcDetalles.Controls.Add(this.txtSecuencia);
            this.gcDetalles.Controls.Add(this.lblDomicilio);
            this.gcDetalles.Controls.Add(this.lblSecuencia);
            this.gcDetalles.Controls.Add(this.lblDia);
            this.gcDetalles.Enabled = false;
            this.gcDetalles.Location = new System.Drawing.Point(12, 79);
            this.gcDetalles.Name = "gcDetalles";
            this.gcDetalles.Size = new System.Drawing.Size(726, 365);
            this.gcDetalles.TabIndex = 23;
            this.gcDetalles.Text = "Detalle Ruta";
            // 
            // chEActivoDetalleRuta
            // 
            this.chEActivoDetalleRuta.EditValue = true;
            this.chEActivoDetalleRuta.Location = new System.Drawing.Point(515, 28);
            this.chEActivoDetalleRuta.Name = "chEActivoDetalleRuta";
            this.chEActivoDetalleRuta.Properties.Caption = "Activo";
            this.chEActivoDetalleRuta.Size = new System.Drawing.Size(75, 19);
            this.chEActivoDetalleRuta.TabIndex = 30;
            // 
            // btnEliminarDetalle
            // 
            this.btnEliminarDetalle.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarDetalle.Appearance.Options.UseBackColor = true;
            this.btnEliminarDetalle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarDetalle.BackgroundImage")));
            this.btnEliminarDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarDetalle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnEliminarDetalle.Location = new System.Drawing.Point(596, 76);
            this.btnEliminarDetalle.Name = "btnEliminarDetalle";
            this.btnEliminarDetalle.Size = new System.Drawing.Size(26, 27);
            this.btnEliminarDetalle.TabIndex = 29;
            this.btnEliminarDetalle.Click += new System.EventHandler(this.btnEliminarDetalle_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Appearance.Options.UseBackColor = true;
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnAgregar.Location = new System.Drawing.Point(563, 76);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(27, 27);
            this.btnAgregar.TabIndex = 28;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscarDom
            // 
            this.btnBuscarDom.BackgroundImage = global::FerreroCS.Properties.Resources.buscarColonia;
            this.btnBuscarDom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarDom.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscarDom.Location = new System.Drawing.Point(58, 81);
            this.btnBuscarDom.Name = "btnBuscarDom";
            this.btnBuscarDom.Size = new System.Drawing.Size(30, 30);
            this.btnBuscarDom.TabIndex = 27;
            this.btnBuscarDom.UseVisualStyleBackColor = true;
            this.btnBuscarDom.Click += new System.EventHandler(this.btnBuscarDom_Click);
            // 
            // meLocalizacion
            // 
            this.meLocalizacion.Enabled = false;
            this.meLocalizacion.Location = new System.Drawing.Point(93, 65);
            this.meLocalizacion.Margin = new System.Windows.Forms.Padding(2);
            this.meLocalizacion.Name = "meLocalizacion";
            this.meLocalizacion.Size = new System.Drawing.Size(176, 73);
            this.meLocalizacion.TabIndex = 26;
            // 
            // cmbDia
            // 
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Location = new System.Drawing.Point(55, 27);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(176, 21);
            this.cmbDia.TabIndex = 21;
            // 
            // gcDetalleRuta
            // 
            this.gcDetalleRuta.Location = new System.Drawing.Point(20, 161);
            this.gcDetalleRuta.MainView = this.gvDetalleRuta;
            this.gcDetalleRuta.Name = "gcDetalleRuta";
            this.gcDetalleRuta.Size = new System.Drawing.Size(687, 199);
            this.gcDetalleRuta.TabIndex = 24;
            this.gcDetalleRuta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDetalleRuta});
            // 
            // gvDetalleRuta
            // 
            this.gvDetalleRuta.GridControl = this.gcDetalleRuta;
            this.gvDetalleRuta.Name = "gvDetalleRuta";
            this.gvDetalleRuta.OptionsBehavior.Editable = false;
            this.gvDetalleRuta.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvDetalleRuta_RowClick);
            // 
            // meNotas
            // 
            this.meNotas.Location = new System.Drawing.Point(342, 66);
            this.meNotas.Name = "meNotas";
            this.meNotas.Size = new System.Drawing.Size(176, 73);
            this.meNotas.TabIndex = 21;
            // 
            // lblNotas
            // 
            this.lblNotas.Location = new System.Drawing.Point(304, 90);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(32, 13);
            this.lblNotas.TabIndex = 20;
            this.lblNotas.Text = "Notas:";
            // 
            // txtSecuencia
            // 
            this.txtSecuencia.Location = new System.Drawing.Point(304, 28);
            this.txtSecuencia.Name = "txtSecuencia";
            this.txtSecuencia.Size = new System.Drawing.Size(176, 20);
            this.txtSecuencia.TabIndex = 19;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.Location = new System.Drawing.Point(8, 90);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(44, 13);
            this.lblDomicilio.TabIndex = 12;
            this.lblDomicilio.Text = "Domicilio:";
            // 
            // lblSecuencia
            // 
            this.lblSecuencia.Location = new System.Drawing.Point(246, 30);
            this.lblSecuencia.Name = "lblSecuencia";
            this.lblSecuencia.Size = new System.Drawing.Size(52, 13);
            this.lblSecuencia.TabIndex = 18;
            this.lblSecuencia.Text = "Secuencia:";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(17, 30);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(26, 13);
            this.lblDia.TabIndex = 2;
            this.lblDia.Text = "Día:";
            // 
            // chkActivo
            // 
            this.chkActivo.EditValue = true;
            this.chkActivo.Location = new System.Drawing.Point(455, 54);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Properties.Caption = "Activo";
            this.chkActivo.Size = new System.Drawing.Size(75, 19);
            this.chkActivo.TabIndex = 23;
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(294, 53);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(139, 20);
            this.txtRuta.TabIndex = 22;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(214, 56);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(73, 13);
            this.lblRuta.TabIndex = 21;
            this.lblRuta.Text = "Nombre Ruta:";
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
            this.tsBarraHerramientas.Size = new System.Drawing.Size(750, 32);
            this.tsBarraHerramientas.TabIndex = 24;
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
            // FrmRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 452);
            this.Controls.Add(this.tsBarraHerramientas);
            this.Controls.Add(this.gcDetalles);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.lblRuta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(642, 495);
            this.Name = "FrmRutas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rutas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRutas_FormClosed);
            this.Shown += new System.EventHandler(this.FrmRutas_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalles)).EndInit();
            this.gcDetalles.ResumeLayout(false);
            this.gcDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chEActivoDetalleRuta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meLocalizacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalleRuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalleRuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meNotas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecuencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRuta.Properties)).EndInit();
            this.tsBarraHerramientas.ResumeLayout(false);
            this.tsBarraHerramientas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private DevExpress.XtraEditors.GroupControl gcDetalles;
        private ControlesPersonalizados.AutocompleteComboBox cmbDia;
        private DevExpress.XtraGrid.GridControl gcDetalleRuta;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDetalleRuta;
        private DevExpress.XtraEditors.MemoEdit meNotas;
        private DevExpress.XtraEditors.LabelControl lblNotas;
        private DevExpress.XtraEditors.TextEdit txtSecuencia;
        private DevExpress.XtraEditors.LabelControl lblDomicilio;
        private DevExpress.XtraEditors.LabelControl lblSecuencia;
        private System.Windows.Forms.Label lblDia;
        private DevExpress.XtraEditors.MemoEdit meLocalizacion;
        private DevExpress.XtraEditors.CheckEdit chkActivo;
        private DevExpress.XtraEditors.TextEdit txtRuta;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Button btnBuscarDom;
        private DevExpress.XtraEditors.SimpleButton btnEliminarDetalle;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private System.Windows.Forms.ToolStrip tsBarraHerramientas;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private DevExpress.XtraEditors.CheckEdit chEActivoDetalleRuta;
    }
}