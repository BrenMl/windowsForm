using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FerreroCS.CATALOGOS
{
    public partial class FrmCapturarFoto : Form
    {
        // Publicas
        public int intIdPersona;
        public int intIdSocio;
        public int intIdTipoPersona;
        public int intIdAval;
        public bool Iniciado;

        // Privadas
        private bool ExistenDispositivos = false;
        private FilterInfoCollection DispositivosDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;
        private int cropX = 0;
        private int cropY = 0;
        private int cropWidth = 0;
        private int cropHeight = 0;

        private Bitmap cropBitmap;
        private Pen cropPen;
        private int cropPenSize = 3;
        private Color cropPenColor = Color.Blue;
        private bool FotoCapturada = false;
        private enum EstatusWebCam
        {
            Iniciado = 1,
            Detenido = 0
        };
        private EstatusWebCam WebCamState = EstatusWebCam.Detenido;

        public FrmCapturarFoto()
        {
            InitializeComponent();
        }

        private void FrmCapturarFoto_Shown(object sender, EventArgs e)
        {
            try
            {
                BuscarDispositivos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
        }

        private void BuscarDispositivos()
        {
            DispositivosDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (DispositivosDeVideo.Count == 0)
                ExistenDispositivos = false;
            else
            {
                ExistenDispositivos = true;
                CargarDispositivos();
                btnIniciaDeten.Enabled = true;
            }
        }

        private void CargarDispositivos()
        {
            for (int i = 0; i < DispositivosDeVideo.Count; i++)
                dispositivos.Items.Add(DispositivosDeVideo[i].Name.ToString());
            dispositivos.Text = dispositivos.Items[0].ToString();
        }

        private void btnIniciaDeten_Click(object sender, EventArgs e)
        {
            if (WebCamState == EstatusWebCam.Detenido)
            {
                if (ExistenDispositivos)
                {
                    FuenteDeVideo = new VideoCaptureDevice(DispositivosDeVideo[dispositivos.SelectedIndex].MonikerString);
                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(video_NuevoFrame);
                    
                    FuenteDeVideo.Start();
                    dispositivos.Enabled = false;
                    btnCapturar.Enabled = true;

                    WebCamState = EstatusWebCam.Iniciado;
                    //btnIniciaDeten.Image = My.Resources.Detener;
                    //Limpiamos la foto en caso de que se haya seleccionado
                    FotoCapturada = false;
                    pbFoto.Image = null;
                }
            }
            else
            {
                if (FuenteDeVideo.IsRunning)
                {
                    TerminarFuenteDeVideo();
                    dispositivos.Enabled = true;
                    btnCapturar.Enabled = false;
                    //btnIniciaDeten.Image = My.Resources.Iniciar;
                    WebCamState = EstatusWebCam.Detenido;
                }
            }
        }

        private void video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            eventArgs.Frame.RotateFlip(RotateFlipType.Rotate180FlipY);
            Bitmap Imagen = ((Bitmap)eventArgs.Frame.Clone());
            pbWebCam.Image = Imagen;
        }

        private void TerminarFuenteDeVideo()
        {
            if (!(FuenteDeVideo == null))
            {
                if (FuenteDeVideo.IsRunning)
                {
                    FuenteDeVideo.SignalToStop();
                    FuenteDeVideo = null;
                }
            }
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            btnIniciaDeten.PerformClick();
            FotoCapturada = true;
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (pbFoto.Image != null)
                this.DialogResult = DialogResult.OK;
        }

        private void FrmCapturarFoto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WebCamState == EstatusWebCam.Iniciado)
                TerminarFuenteDeVideo();
        }

        private void pbWebCam_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (pbWebCam.Image == null | WebCamState == EstatusWebCam.Iniciado) return;

                Cursor = Cursors.NoMove2D;
                //Primero indicamos la cordenada 0 del rectangulo
                cropX = e.X;
                cropY = e.Y;
                cropPen = new Pen(cropPenColor, cropPenSize)
                {
                    DashStyle = DashStyle.DashDotDot
                };
                pbWebCam.Refresh();

                //Calculamos las dimensiones y posicion del rectangulo
                cropWidth = pbFoto.Width; // e.X - cropX
                cropHeight = pbFoto.Height; //e.Y - cropY
                pbWebCam.CreateGraphics().DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight);                

                // Pinta un rectangulo
                pbWebCam.CreateGraphics().FillRectangle(Brushes.Transparent, cropX, cropY, cropWidth, cropHeight);
            }
            catch (Exception )
            {
                //if (Err.Number == 5) return;
            }
        }

        private void pbWebCam_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left & FotoCapturada)
                DibujaMuestra();
        }

        private void DibujaMuestra()
        {
            try
            {
                if (cropWidth < 1) return;

                Rectangle rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);
                Bitmap bit = new Bitmap(pbWebCam.Image, pbWebCam.Width, pbWebCam.Height);
                cropBitmap = new Bitmap(cropWidth, cropHeight);
                Graphics g = Graphics.FromImage(cropBitmap);
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.DrawImage(bit, 0, 0, rect, GraphicsUnit.Pixel);
                pbFoto.Image = cropBitmap;
            }
            catch (Exception )
            {
            }
        }

        private void pbWebCam_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }


    }
}
