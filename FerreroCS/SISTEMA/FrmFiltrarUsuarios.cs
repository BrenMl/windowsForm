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
    public partial class FrmFiltrarUsuarios : Form
    {
        public int IdPerfil { get; set; }
        public string Usuario { get; set; }
        public bool Salida { get; set; }

        private ClsFunciones funciones;

        public FrmFiltrarUsuarios()
        {
            InitializeComponent();

            funciones = new ClsFunciones();
        }

        private void FrmFiltrarUsuarios_Load(System.Object sender, EventArgs e)
        {
            LlenarCombo();
        }

        public void LlenarCombo()
        {
            try
            {
                funciones.LlenaCombo(ref cbBuscar, "[Sis].prConsultaPerfiles", DescPrimerItem:"(TODOS)", ValPrimerItem:"0");
                cbBuscar.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al llenar los combos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ckbBuscarUsuario_CheckedChanged(System.Object sender, EventArgs e)
        {
            txtNombreUsuario.Enabled = ckbBuscarUsuario.Checked;
        }

        private void BtnCancel_Click(System.Object sender, EventArgs e)
        {
            Salida = false;
            Dispose();
        }

        private void BtnOk_Click(System.Object sender, EventArgs e)
        {
            IdPerfil = (int)cbBuscar.SelectedValue;
            Usuario = ckbBuscarUsuario.Checked ? txtNombreUsuario.Text : null;
            Salida = true;
            Dispose();
        }


    }
}
