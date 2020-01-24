namespace FerreroCS.CATALOGOS
{
    partial class FrmMapa
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
            this.MainMap = new GMap.NET.WindowsForms.GMapControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtBusquedaLibre = new DevExpress.XtraEditors.TextEdit();
            this.btnBusquedaLibre = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtBusquedaLibre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMap
            // 
            this.MainMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMap.Bearing = 0F;
            this.MainMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainMap.CanDragMap = true;
            this.MainMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.MainMap.GrayScaleMode = false;
            this.MainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MainMap.LevelsKeepInMemmory = 5;
            this.MainMap.Location = new System.Drawing.Point(11, 82);
            this.MainMap.MarkersEnabled = true;
            this.MainMap.MaxZoom = 2;
            this.MainMap.MinZoom = 2;
            this.MainMap.MouseWheelZoomEnabled = true;
            this.MainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.MainMap.Name = "MainMap";
            this.MainMap.NegativeMode = false;
            this.MainMap.PolygonsEnabled = true;
            this.MainMap.RetryLoadTile = 0;
            this.MainMap.RoutesEnabled = true;
            this.MainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.MainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MainMap.ShowTileGridLines = false;
            this.MainMap.Size = new System.Drawing.Size(1035, 495);
            this.MainMap.TabIndex = 10;
            this.MainMap.Zoom = 0D;
            this.MainMap.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MainMap_MouseDoubleClick);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 25);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(114, 16);
            this.labelControl5.TabIndex = 22;
            this.labelControl5.Text = "Datos de búsqueda:";
            // 
            // txtBusquedaLibre
            // 
            this.txtBusquedaLibre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusquedaLibre.Location = new System.Drawing.Point(131, 22);
            this.txtBusquedaLibre.Name = "txtBusquedaLibre";
            this.txtBusquedaLibre.Size = new System.Drawing.Size(664, 22);
            this.txtBusquedaLibre.TabIndex = 23;
            // 
            // btnBusquedaLibre
            // 
            this.btnBusquedaLibre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBusquedaLibre.Location = new System.Drawing.Point(801, 18);
            this.btnBusquedaLibre.Name = "btnBusquedaLibre";
            this.btnBusquedaLibre.Size = new System.Drawing.Size(80, 30);
            this.btnBusquedaLibre.TabIndex = 24;
            this.btnBusquedaLibre.Text = "&Buscar";
            this.btnBusquedaLibre.Click += new System.EventHandler(this.btnBusquedaLibre_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(966, 18);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 30);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmMapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 589);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBusquedaLibre);
            this.Controls.Add(this.txtBusquedaLibre);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.MainMap);
            this.MinimumSize = new System.Drawing.Size(1076, 636);
            this.Name = "FrmMapa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.txtBusquedaLibre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GMap.NET.WindowsForms.GMapControl MainMap;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtBusquedaLibre;
        private DevExpress.XtraEditors.SimpleButton btnBusquedaLibre;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
    }
}

