using ClasesCS;
using FerreroCS.VENTAS;
using System;
using System.Data;
using System.Windows.Forms;
using static ClasesCS.ClsEnumeradores;

namespace FerreroCS.CATALOGOS
{
    public partial class FrmConsultaEntradas : Form
    {
        private readonly ClsFunciones _objFunc;
        private DataRow FilaEntrada;
        private bool BestFitColumns;

        public FrmConsultaEntradas(bool BestFitColumns = true)
        {
            InitializeComponent();
            _objFunc = new ClsFunciones();
            this.BestFitColumns = BestFitColumns;
        }

        private void FrmConsultaEntradas_Shown(object sender, EventArgs e)
        {
            LlenaGrid();
        }

        public void LlenaGrid()
        {
            _objFunc.LlenaGridControl(ref dxgEntradas, "[Entr].[ConsultaEntradas]");

            dxgvEntrada.Columns["IdEntrada"].Visible = false;
            dxgvEntrada.Columns["IdEntrada"].OptionsColumn.AllowShowHide = false;
            dxgvEntrada.Columns["IdProveedor"].Visible = false;
            dxgvEntrada.Columns["IdProveedor"].OptionsColumn.AllowShowHide = false;
            dxgvEntrada.Columns["IdEstatusEntrada"].Visible = false;
            dxgvEntrada.Columns["IdEstatusEntrada"].OptionsColumn.AllowShowHide = false;

            // Ajustar ancho de columnas
            if (BestFitColumns)
                dxgvEntrada.BestFitColumns();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            FrmEntradas frmEntradas = new FrmEntradas(ModoOperacion.Alta, ConsultaEntradas:this);
            frmEntradas.MdiParent = this.MdiParent;
            frmEntradas.Show();
        }

        private void dxgvEntrada_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks == 2 && e.RowHandle >= 0)
            {
                FilaEntrada = dxgvEntrada.GetDataRow(e.RowHandle);
                FrmEntradas ModificarCliente = new FrmEntradas(ModoOperacion.Consulta, FilaEntrada,this);

                ModificarCliente.MdiParent = this.MdiParent;

                ModificarCliente.Show();
            }
        }

        private void tsbRefrescar_Click(object sender, EventArgs e)
        {
            _objFunc.LlenaGridControl(ref dxgEntradas, "[Entr].[ConsultaEntradas]");

            dxgvEntrada.Columns["IdEntrada"].Visible = false;
            dxgvEntrada.Columns["IdEntrada"].OptionsColumn.AllowShowHide = false;
            dxgvEntrada.Columns["IdProveedor"].Visible = false;
            dxgvEntrada.Columns["IdProveedor"].OptionsColumn.AllowShowHide = false;
            dxgvEntrada.Columns["IdEstatusEntrada"].Visible = false;
            dxgvEntrada.Columns["IdEstatusEntrada"].OptionsColumn.AllowShowHide = false;
        }
    }
}
