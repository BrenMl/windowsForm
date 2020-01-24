using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;


namespace FerreroCS.CATALOGOS
{
    public partial class FrmEditorImagenes : Form
    {
        // Publicas
        public DashStyle cropDashStyle = DashStyle.DashDot;
        public bool Makeselection = false;
        public bool CreateText = false;

        // Privadas
        private Image Img;
        private Image OriginalImg;
        private Size OriginalImageSize;
        private Size ModifiedImageSize;

        int cropX;
        int cropY;
        int cropWidth;

        int cropHeight;
        public Pen cropPen;
        

        public FrmEditorImagenes()
        {
            InitializeComponent();
        }
        
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dlg = new OpenFileDialog
            {
                //Dlg.Filter = "";
                Filter = "Archivos de imagen (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png",
                Title = "Seleccionar imagen"
            };
            if (Dlg.ShowDialog() == DialogResult.OK)
            {
                Img = Image.FromFile(Dlg.FileName);
                // Realizar una copia de la imagen original (cargada) para que el zoom funcione correctamente
                OriginalImg = Img;

                //Image.FromFile(String) method creates an image from the specifed file, here dlg.
                //Filename contains the name of the file from which to create the image
                LoadImage();

                SplitContainer1.Panel2Collapsed = false;
                SaveToolStripMenuItem.Enabled = true;
            }            
        }

        private void LoadImage()
        {
            //we set the picturebox size according to image, we can get image width and height with the help of Image.
            //Width and Image.height properties.
            //int imgWidth = Img.Width;
            //int imghieght = Img.Height;
            pbFoto.Width = Img.Width;
            pbFoto.Height = Img.Height;
            pbFoto.Image = Img;
            PictureBoxLocation();
            OriginalImageSize = new Size(OriginalImg.Width, OriginalImg.Height);

            SetResizeInfo();
        }
        
        private void PictureBoxLocation()
        {
            int _x = 0;
            int _y = 0;

            if (SplitContainer1.Panel1.Width > pbFoto.Width)
                _x = (SplitContainer1.Panel1.Width - pbFoto.Width) / 2;

            if (SplitContainer1.Panel1.Height > pbFoto.Height)
                _y = (SplitContainer1.Panel1.Height - pbFoto.Height) / 2;

            pbFoto.Location = new Point(_x, _y);
        }

        private void SetResizeInfo()
        {

            lbloriginalSize.Text = $"ORIGINAL. Ancho:{OriginalImageSize.Width} Alto: {OriginalImageSize.Height}";
            lblModifiedSize.Text = $"MODIFICADO. Ancho:{ModifiedImageSize.Width} Alto: {ModifiedImageSize.Height}";

        }

        private void SplitContainer1_Panel1_Resize(object sender, EventArgs e)
        {
            PictureBoxLocation();
        }

        #region "**********************  REDIMENSIONAR  **********************"
        private void DomainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            int percentage = 0;
            try
            {
                // percentage = Convert.ToInt32(DomainUpDown1.Text);
                ModifiedImageSize = new Size((OriginalImageSize.Width * percentage) / 100, (OriginalImageSize.Height * percentage) / 100);
                SetResizeInfo();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Percentage");
                return;
            }

        }

        private void tkbRedimensionar_EditValueChanged(object sender, EventArgs e)
        {
            int percentage = 0;
            try
            {
                percentage = tkbRedimensionar.Value * 10;
                ModifiedImageSize = new Size((OriginalImageSize.Width * percentage) / 100, (OriginalImageSize.Height * percentage) / 100);
                SetResizeInfo();
                btnOk.PerformClick();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Percentage");
                return;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //Bitmap bm_source = new Bitmap(pbFoto.Image);
            //// Make a bitmap for the result.
            //Bitmap bm_dest = new Bitmap(Convert.ToInt32(ModifiedImageSize.Width), Convert.ToInt32(ModifiedImageSize.Height));
            //// Make a Graphics object for the result Bitmap.
            //Graphics gr_dest = Graphics.FromImage(bm_dest);
            //// Copy the source image into the destination bitmap.
            //gr_dest.DrawImage(bm_source, 0, 0, bm_dest.Width + 1, bm_dest.Height + 1);
            //// Display the result.
            //pbFoto.Image = bm_dest;
            //pbFoto.Width = bm_dest.Width;
            //pbFoto.Height = bm_dest.Height;      


            Bitmap bm_source = new Bitmap(pbFoto.Image);

            bm_source = new Bitmap(OriginalImg);


            // Make a bitmap for the result.
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(ModifiedImageSize.Width), Convert.ToInt32(ModifiedImageSize.Height));
            // Make a Graphics object for the result Bitmap.
            Graphics gr_dest = Graphics.FromImage(bm_dest);
            // Copy the source image into the destination bitmap.
            gr_dest.DrawImage(bm_source, 0, 0, bm_dest.Width + 1, bm_dest.Height + 1);
            // Display the result.
            pbFoto.Image = bm_dest;
            pbFoto.Width = bm_dest.Width;
            pbFoto.Height = bm_dest.Height;

            PictureBoxLocation();
        }
        #endregion

        #region "**********************  CORTAR IMAGEN  **********************"
        private void btnMakeSelection_Click(object sender, EventArgs e)
        {
            Makeselection = true;
            btnCrop.Enabled = true;

        }

        private void btnCrop_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;

            try
            {
                if (cropWidth < 1)
                {
                    return;
                }

                Rectangle rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);

                //First we define a rectangle with the help of already calculated points
                Bitmap OriginalImage = new Bitmap(pbFoto.Image, pbFoto.Width, pbFoto.Height);

                //Original image
                Bitmap _img = new Bitmap(cropWidth, cropHeight);

                // for cropinf image
                Graphics g = Graphics.FromImage(_img);

                // create graphics
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.CompositingQuality = CompositingQuality.HighQuality;

                //set image attributes
                g.DrawImage(OriginalImage, 0, 0, rect, GraphicsUnit.Pixel);

                pbFoto.Image = _img;
                pbFoto.Width = _img.Width;
                pbFoto.Height = _img.Height;
                PictureBoxLocation();
                btnCrop.Enabled = false;
            }
            catch (Exception )
            {
            }
        }
        
        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //if (TabControl1.SelectedIndex == 4)
            //{
            //    Point TextStartLocation = e.Location;
            //    if (CreateText)
            //    {
            //        Cursor = Cursors.IBeam;
            //    }
            //}
            //else
            //{
                Cursor = Cursors.Default;
                if (Makeselection)
                {

                    try
                    {
                        if (e.Button == MouseButtons.Left)
                        {
                            Cursor = Cursors.Cross;
                            cropX = e.X;
                            cropY = e.Y;

                        cropPen = new Pen(Color.Blue, 2)
                        {
                            DashStyle = DashStyle.DashDot
                        };


                    }
                        pbFoto.Refresh();
                    }
                    catch (Exception )
                    {
                    }
                }
            //}            
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (Makeselection)
            {
                Cursor = Cursors.Default;
            }

        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //if (TabControl1.SelectedIndex == 4)
            //{
            //    Point TextStartLocation = e.Location;
            //    if (CreateText)
            //    {
            //        Cursor = Cursors.IBeam;
            //    }
            //}
            //else
            //{
                Cursor = Cursors.Default;
                if (Makeselection)
                {

                    try
                    {
                        if (pbFoto.Image == null)
                            return;


                        if (e.Button == MouseButtons.Left)
                        {
                            pbFoto.Refresh();
                            cropWidth = e.X - cropX;
                            cropHeight = e.Y - cropY;
                            pbFoto.CreateGraphics().DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight);
                        }
                    }
                    catch (Exception)
                    {
                        //if (ex.Number == 5)
                        //    return;
                    }
                }
            //}

        }
        #endregion

        #region "**********************  BRILLO  **********************"
        // OOOOJOOOOOOOOOOOOOO
        private void TrackBarBrightness_Scroll(object sender, EventArgs e)
        {
            //DomainUpDownBrightness.Text = TrackBarBrightness.Value.ToString();

            float value = TrackBarBrightness.Value * 0.01f;
            float[][] colorMatrixElements = {
    new float[] {
        1,
        0,
        0,
        0,
        0
    },
    new float[] {
        0,
        1,
        0,
        0,
        0
    },
    new float[] {
        0,
        0,
        1,
        0,
        0
    },
    new float[] {
        0,
        0,
        0,
        1,
        0
    },
    new float[] {
        value,
        value,
        value,
        0,
        1
    }
};
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imageAttributes = new ImageAttributes();


            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);



            Image _img = Img;
            //PictureBox1.Image
            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            pbFoto.Image = bm_dest;

        }
        #endregion

        #region "**********************  ROTAR  **********************"
        private void btnRotateLeft_Click(object sender, EventArgs e)
        {
            pbFoto.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pbFoto.Refresh();
        }

        private void btnRotateRight_Click(object sender, EventArgs e)
        {
            pbFoto.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pbFoto.Refresh();
        }

        private void btnRotateHorizantal_Click(object sender, EventArgs e)
        {
            pbFoto.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pbFoto.Refresh();
        }

        private void btnRotatevertical_Click(object sender, EventArgs e)
        {
            pbFoto.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pbFoto.Refresh();
        }
        #endregion

        private void FrmEditorImagenes_Shown(object sender, EventArgs e)
        {
            SplitContainer1.Panel2Collapsed = true;
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplitContainer1.Panel2Collapsed = !SplitContainer1.Panel2Collapsed;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
