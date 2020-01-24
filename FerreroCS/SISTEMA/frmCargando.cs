using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClasesCS.ClsEnumeradores;

namespace FerreroCS.SISTEMA
{
    public partial class frmCargando : Form
    {
        private int intGif;
        private bool _enabledCerrar = false;

        public bool EnabledCerrar
        {
            get
            {
                return _enabledCerrar;
            }
            set
            {
                if (_enabledCerrar != value)
                    _enabledCerrar = value;
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                if (_enabledCerrar == false)
                {
                    const int CS_NOCLOSE = 0x200;
                    cp.ClassStyle = cp.ClassStyle | CS_NOCLOSE;
                }
                return cp;
            }
        }

        public frmCargando(string Titulo, string Leyenda, int Gif)
        {
            // Llamada necesaria para el diseñador.
            InitializeComponent();

            // Agregue cualquier inicialización después de la llamada a InitializeComponent().
            intGif = Gif;
            this.Text = Titulo;
            LblTitulo.Text = Leyenda;
        }

        private void frmCargando_Load(System.Object sender, System.EventArgs e)
        {
            
            switch (intGif)
            {
                case (int)Gifs.BarraAzul:
                    {
                       
                        pbGif.Image = Properties.Resources.BarraAzul;
                        break;
                    }

                case (int)Gifs.BarraVerde:
                    {
                        pbGif.Image = Properties.Resources.BarraVerde;
                        break;
                    }

                case (int)Gifs.Buscando:
                    {
                        pbGif.Image = Properties.Resources.Buscando;
                        break;
                    }

                case (int)Gifs.Circular:
                    {
                        pbGif.Image = Properties.Resources.Circular;
                        break;
                    }

                case (int)Gifs.Engrane:
                    {
                        pbGif.Image = Properties.Resources.Engrane;
                        break;
                    }

                case (int)Gifs.Engranes:
                    {
                        pbGif.Image = Properties.Resources.Engranes;
                        break;
                    }
            }

            LblTitulo.SetBounds((this.ClientSize.Width - LblTitulo.Width) / (int)2, LblTitulo.Height, 0, 0, BoundsSpecified.Location);

        }
    }
}
