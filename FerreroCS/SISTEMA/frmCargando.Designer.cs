namespace FerreroCS.SISTEMA
{
    partial class frmCargando
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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pbGif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGif)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Location = new System.Drawing.Point(13, 13);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(35, 13);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "label1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pbGif
            // 
            this.pbGif.Location = new System.Drawing.Point(47, 29);
            this.pbGif.Name = "pbGif";
            this.pbGif.Size = new System.Drawing.Size(264, 70);
            this.pbGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGif.TabIndex = 3;
            this.pbGif.TabStop = false;
            // 
            // frmCargando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 122);
            this.Controls.Add(this.pbGif);
            this.Controls.Add(this.LblTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCargando";
            this.Text = "frmCargando";
            this.Load += new System.EventHandler(this.frmCargando_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.ImageList imageList1;
        internal System.Windows.Forms.PictureBox pbGif;
    }
}