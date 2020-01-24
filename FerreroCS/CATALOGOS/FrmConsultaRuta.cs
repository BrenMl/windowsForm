using ClasesCS;
using System;
using System.Data;
using System.Windows.Forms;
using static ClasesCS.ClsEnumeradores;

namespace FerreroCS.CATALOGOS
{
    public partial class FrmConsultaRuta : Form
    {
        private readonly ClsFunciones _objFunc;
        private DataRow FilaRuta;
        private bool BestFitColumns;

        public FrmConsultaRuta(bool BestFitColumns = true)
        {
            InitializeComponent();
            _objFunc = new ClsFunciones();
            this.BestFitColumns = BestFitColumns;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            FrmRutas frmRutas = new FrmRutas(ModoOperacion.Alta, frmConsultaRuta:this);
            frmRutas.MdiParent = this.MdiParent;
            frmRutas.Show();
        }

        private void FrmConsultaRuta_Shown(object sender, EventArgs e)
        {
            LlenaGrid();  
        }

        public void LlenaGrid()
        {
            _objFunc.LlenaGridControl(ref dxgDatos, "[Rut].[ConsultarRutas]");

            dxgvDatos.Columns["IdRuta"].Visible = false;

            // Ajustar ancho de columnas
            if (BestFitColumns)
                dxgvDatos.BestFitColumns();
        }

        private void dxgvDatos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks == 2 && e.RowHandle >= 0)
            {
                FilaRuta = dxgvDatos.GetDataRow(e.RowHandle);
                FrmRutas ModificarRuta = new FrmRutas(ModoOperacion.Consulta, FilaRuta,this);
                ModificarRuta.MdiParent = this.MdiParent;
                ModificarRuta.Show();
            }
        }

        private void tsbRefrescar_Click(object sender, EventArgs e)
        {
            _objFunc.LlenaGridControl(ref dxgDatos, "[Rut].[ConsultarRutas]");

            dxgvDatos.Columns["IdRuta"].Visible = false;
        }
    }
}
