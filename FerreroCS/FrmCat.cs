using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreroCS
{

    public partial class FrmCat : Form
    {
        
        public string Nombre { get; set; }
        public string Salida { get; set; }
        
        public FrmCat(string strTitulo, string strLabel)
        {

            // Llamada necesaria para el diseñador.
            InitializeComponent();

            // Agregue cualquier inicialización después de la llamada a InitializeComponent().
            this.Text = strTitulo;
            this.Label1.Text = strLabel;
            this.Salida = "1";
        }

        private void BtnOk_Click(System.Object sender, System.EventArgs e)
        {
            ok();
        }

        private void ok()
        {
            if (TxtDescripcion.Text == "")
            {
                MessageBox.Show("Especifique el nombre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.Nombre = TxtDescripcion.Text;
            this.Salida = "0";
            Dispose();
        }

        private void BtnCancel_Click(System.Object sender, System.EventArgs e)
        {
            this.Salida = "1";
            Dispose();
        }


        private void TxtDescripcion_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)

        {
            if (Convert.ToInt32(e.KeyChar) == 13)
                ok();
        }

        private void FrmCat_Shown(System.Object sender, System.EventArgs e)
        {
            TxtDescripcion.Focus();
        }
    }
}
