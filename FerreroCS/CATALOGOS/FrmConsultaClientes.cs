using ClasesCS;
using System;
using System.Data;
using System.Windows.Forms;
using static ClasesCS.ClsEnumeradores;

namespace FerreroCS.CATALOGOS
{
    public partial class FrmConsultaClientes : Form
    {
        private readonly ClsFunciones _objFunc;
        private DataRow FilaCliente;
        private bool BestFitColumns;

        public FrmConsultaClientes(bool BestFitColumns = true)
        {
            InitializeComponent();
            _objFunc = new ClsFunciones();
            this.BestFitColumns = BestFitColumns;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes(ModoOperacion.Alta, FrmConsultaClientes: this);
            frmClientes.MdiParent = this.MdiParent;
            frmClientes.Show();
        }

        private void FrmConsultaClientes_Shown(object sender, EventArgs e)
        {
            LlenarGrid();            
        }

        public void LlenarGrid()
        {
            _objFunc.LlenaGridControl(ref dxgClientes, "[Cte].[ConsultarClientes]");

            dxgvCliente.Columns["IdCliente"].Visible = false;
            dxgvCliente.Columns["IdCliente"].OptionsColumn.AllowShowHide = false;
            dxgvCliente.Columns["IdGiro"].Visible = false;
            dxgvCliente.Columns["IdGiro"].OptionsColumn.AllowShowHide = false;

            // Ajustar ancho de columnas
            if (BestFitColumns)
                dxgvCliente.BestFitColumns();
        }

        private void dxgvCliente_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks == 2 && e.RowHandle >= 0)
            {
                FilaCliente = dxgvCliente.GetDataRow(e.RowHandle);
                FrmClientes ModificarCliente = new FrmClientes(ModoOperacion.Consulta, FilaCliente,this);

                ModificarCliente.MdiParent = this.MdiParent;

                ModificarCliente.Show();
            }
        }

        private void tsbRefrescar_Click(object sender, EventArgs e)
        {
            _objFunc.LlenaGridControl(ref dxgClientes, "[Cte].[ConsultarClientes]");

            dxgvCliente.Columns["IdCliente"].Visible = false;
            dxgvCliente.Columns["IdCliente"].OptionsColumn.AllowShowHide = false;
            dxgvCliente.Columns["IdGiro"].Visible = false;
            dxgvCliente.Columns["IdGiro"].OptionsColumn.AllowShowHide = false;
        }
    }
}
