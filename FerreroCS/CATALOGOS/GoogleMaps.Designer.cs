namespace FerreroCS.CATALOGOS
{
    partial class GoogleMaps
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
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.gMC_CCDom = new GMap.NET.WindowsForms.GMapControl();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(221, 321);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gMC_CCDom
            // 
            this.gMC_CCDom.Bearing = 0F;
            this.gMC_CCDom.CanDragMap = true;
            this.gMC_CCDom.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMC_CCDom.GrayScaleMode = false;
            this.gMC_CCDom.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMC_CCDom.LevelsKeepInMemmory = 5;
            this.gMC_CCDom.Location = new System.Drawing.Point(12, 12);
            this.gMC_CCDom.MarkersEnabled = true;
            this.gMC_CCDom.MaxZoom = 2;
            this.gMC_CCDom.MinZoom = 2;
            this.gMC_CCDom.MouseWheelZoomEnabled = true;
            this.gMC_CCDom.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMC_CCDom.Name = "gMC_CCDom";
            this.gMC_CCDom.NegativeMode = false;
            this.gMC_CCDom.PolygonsEnabled = true;
            this.gMC_CCDom.RetryLoadTile = 0;
            this.gMC_CCDom.RoutesEnabled = true;
            this.gMC_CCDom.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMC_CCDom.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMC_CCDom.ShowTileGridLines = false;
            this.gMC_CCDom.Size = new System.Drawing.Size(508, 303);
            this.gMC_CCDom.TabIndex = 3;
            this.gMC_CCDom.Zoom = 2D;
            this.gMC_CCDom.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMC_CCDom_MouseDoubleClick);
            // 
            // GoogleMaps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 356);
            this.Controls.Add(this.gMC_CCDom);
            this.Controls.Add(this.btnGuardar);
            this.Name = "GoogleMaps";
            this.Text = "GoogleMaps";
            this.Load += new System.EventHandler(this.GoogleMaps_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private GMap.NET.WindowsForms.GMapControl gMC_CCDom;
    }
}