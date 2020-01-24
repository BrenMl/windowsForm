using ClasesCS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreroCS.SISTEMA
{
    public partial class FrmMonitorSesiones : Form
    {
        private readonly ClsFunciones fn;
        public FrmMonitorSesiones()
        {
            InitializeComponent();
            fn = new ClsFunciones();
        }

        private void FrmMonitorSesiones_Load(System.Object sender, EventArgs e)
        {
            try
            {
                fn.LlenaCombo(ref cbUsuario, "[Sis].[prConsultaUsuarios]", DescPrimerItem: "(TODOS)", ValPrimerItem: "0");
                btnRefrescar.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al llenar los combos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefrescar_Click(System.Object sender, EventArgs e)
        {
            fn.LlenaDataGridView(ref DgvSesiones, "[Sis].[prConsultaSesiones]", (int)cbUsuario.SelectedValue == 0 ? "Null": cbUsuario.SelectedValue.ToString(), null);

            try
            {
                DgvSesiones.ClearSelection();

                DgvSesiones.Columns["IdUsuario"].Visible = false;

                DgvSesiones.AutoResizeColumn(DgvSesiones.Columns["Duracion"].Index, DataGridViewAutoSizeColumnMode.ColumnHeader);
                DgvSesiones.AutoResizeColumn(DgvSesiones.Columns["Activa"].Index, DataGridViewAutoSizeColumnMode.ColumnHeader);

                DgvSesiones.AutoResizeColumn(DgvSesiones.Columns["Inicio de Sesion"].Index);
                DgvSesiones.AutoResizeColumn(DgvSesiones.Columns["Fin de Sesion"].Index);

                DgvSesiones.Columns["Duracion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // DgvSesiones.AlternatingRowsDefaultCellStyle.BackColor = Color.White

                ContarSesiones();
            }
            catch (Exception )
            {
            }
        }

        private void ContarSesiones()
        {
            int Activas = 0;
            int inactivas = 0;

            foreach (DataGridViewRow row in DgvSesiones.Rows)
            {
                if ((bool)row.Cells["Activa"].Value == true)
                {
                    row.Cells["NombreUsuario"].Style.ForeColor = Color.Green;
                    Activas += 1;
                }
                else
                {
                    row.Cells["NombreUsuario"].Style.ForeColor = Color.Red;
                    inactivas += 1;
                }
            }

            lblActivas.Text = Activas.ToString();
            lblInactivas.Text = inactivas.ToString();
        }
    }
}
