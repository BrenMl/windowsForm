namespace FerreroCS.CATALOGOS
{
    partial class FrmDiasFestivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDiasFestivos));
            this.tsBarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.txtDiaFestivo = new DevExpress.XtraEditors.TextEdit();
            this.lblDiaFestivo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.deFecha = new DevExpress.XtraEditors.DateEdit();
            this.lblNota = new System.Windows.Forms.Label();
            this.meNotas = new DevExpress.XtraEditors.MemoEdit();
            this.tsBarraHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaFestivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meNotas.Properties)).BeginInit();
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
            this.tsBarraHerramientas.Size = new System.Drawing.Size(559, 32);
            this.tsBarraHerramientas.TabIndex = 25;
            this.tsBarraHerramientas.Text = "toolStrip1";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGuardar.Image = global::FerreroCS.Properties.Resources.file_complete_40445;
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
            this.tsbEliminar.Image = global::FerreroCS.Properties.Resources.delete_file_40456;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(29, 29);
            this.tsbEliminar.Text = "toolStripButton2";
            this.tsbEliminar.ToolTipText = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // txtDiaFestivo
            // 
            this.txtDiaFestivo.Location = new System.Drawing.Point(122, 39);
            this.txtDiaFestivo.Name = "txtDiaFestivo";
            this.txtDiaFestivo.Size = new System.Drawing.Size(184, 20);
            this.txtDiaFestivo.TabIndex = 27;
            // 
            // lblDiaFestivo
            // 
            this.lblDiaFestivo.AutoSize = true;
            this.lblDiaFestivo.Location = new System.Drawing.Point(12, 42);
            this.lblDiaFestivo.Name = "lblDiaFestivo";
            this.lblDiaFestivo.Size = new System.Drawing.Size(105, 13);
            this.lblDiaFestivo.TabIndex = 26;
            this.lblDiaFestivo.Text = "Nombre Día Festivo:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(77, 125);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 28;
            this.lblFecha.Text = "Fecha:";
            // 
            // deFecha
            // 
            this.deFecha.EditValue = null;
            this.deFecha.Location = new System.Drawing.Point(122, 122);
            this.deFecha.Margin = new System.Windows.Forms.Padding(2);
            this.deFecha.Name = "deFecha";
            this.deFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.deFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFecha.Properties.HighlightHolidays = false;
            this.deFecha.Properties.Mask.BeepOnError = true;
            this.deFecha.Size = new System.Drawing.Size(184, 20);
            this.deFecha.TabIndex = 29;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(319, 81);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(38, 13);
            this.lblNota.TabIndex = 30;
            this.lblNota.Text = "Notas:";
            // 
            // meNotas
            // 
            this.meNotas.Location = new System.Drawing.Point(363, 36);
            this.meNotas.Name = "meNotas";
            this.meNotas.Size = new System.Drawing.Size(184, 106);
            this.meNotas.TabIndex = 31;
            // 
            // FrmDiasFestivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 158);
            this.Controls.Add(this.meNotas);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.deFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtDiaFestivo);
            this.Controls.Add(this.lblDiaFestivo);
            this.Controls.Add(this.tsBarraHerramientas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDiasFestivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dias Festivos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmDiasFestivos_FormClosed);
            this.Shown += new System.EventHandler(this.FrmDiasFestivos_Shown);
            this.tsBarraHerramientas.ResumeLayout(false);
            this.tsBarraHerramientas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaFestivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meNotas.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsBarraHerramientas;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private DevExpress.XtraEditors.TextEdit txtDiaFestivo;
        private System.Windows.Forms.Label lblDiaFestivo;
        private System.Windows.Forms.Label lblFecha;
        private DevExpress.XtraEditors.DateEdit deFecha;
        private System.Windows.Forms.Label lblNota;
        private DevExpress.XtraEditors.MemoEdit meNotas;
    }
}