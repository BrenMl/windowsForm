using System;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using enUtilerias;

namespace FerreroCS.CATALOGOS
{
    public partial class GoogleMaps : Form
    {
        private GMapOverlay marcadorMap;
        private GMarkerGoogle marcador;
        private string UbicacionCliente;
        private double Lat;
        private double Lng;

        public Coordenadas Coordenadas { get; set; }

        public GoogleMaps(string Ubicacion)
        {
            InitializeComponent();
            Coordenadas = new Coordenadas();
            this.UbicacionCliente = Ubicacion;
        }

        private void GoogleMaps_Load(object sender, EventArgs e)
        {


            try
            {
               // GeoCoderStatusCode status = gMC_CCDom.SetPositionByKeywords(", Eduardo Ruíz, Morelia, Michoacán");


                GeoCoderStatusCode status = gMC_CCDom.SetPositionByKeywords(UbicacionCliente);
                //if (status != GeoCoderStatusCode.G_GEO_SUCCESS)
                if (status != GeoCoderStatusCode.OK)
                {
                    MessageBox.Show("La ubicación no puede ser encontrada en el mapa", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    gMC_CCDom.DragButton = MouseButtons.Left;
                    gMC_CCDom.CanDragMap = true;
                    gMC_CCDom.ShowCenter = false;
                    gMC_CCDom.MapProvider = BingHybridMapProvider.Instance;
                    GMaps.Instance.Mode = AccessMode.ServerOnly;
                    gMC_CCDom.MapProvider = GMapProviders.GoogleMap;
                    gMC_CCDom.SetPositionByKeywords(UbicacionCliente);
                    gMC_CCDom.MinZoom = 0;
                    gMC_CCDom.MaxZoom = 24;
                    gMC_CCDom.Zoom = 18;
                    gMC_CCDom.AutoScroll = true;
                    GMaps.Instance.Mode = AccessMode.ServerAndCache;

                    Lat = gMC_CCDom.Position.Lat;
                    Lng = gMC_CCDom.Position.Lng;

                    marcadorMap = new GMapOverlay("Marcador");                    
                    marcadorMap.Markers.Add(marcador);

                    marcador = new GMarkerGoogle(new PointLatLng(gMC_CCDom.Position.Lat, gMC_CCDom.Position.Lng), GMarkerGoogleType.red_small);
                    marcador.ToolTipMode = MarkerTooltipMode.Always;
                    marcador.ToolTipText = string.Format("Ubicación: \n Latitud: {0} \n Longitud: {1}", gMC_CCDom.Position.Lat, gMC_CCDom.Position.Lng);

                    gMC_CCDom.Overlays.Add(marcadorMap);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void gMC_CCDom_MouseDoubleClick(object sender, MouseEventArgs e)
        {
             Lat = gMC_CCDom.FromLocalToLatLng(e.X, e.Y).Lat;
             Lng = gMC_CCDom.FromLocalToLatLng(e.X, e.Y).Lng;

            marcador.Position = new PointLatLng(Lat, Lng);

            marcador.ToolTipText = string.Format("Ubicación: \n Latitud: {0} \n Longitud: {1}", Lat, Lng);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Coordenadas.Latitud = Lat;
            Coordenadas.Longitud = Lng;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {


            //////// GeoCoderStatusCode status = gMC_CCDom.SetPositionByKeywords(", Eduardo Ruíz, Morelia, Michoacán");
            //GeoCoderStatusCode status = gMC_CCDom.SetPositionByKeywords(txtUbicacion.Text);

            ////GeoCoderStatusCode status = gMC_CCDom.SetPositionByKeywords(UbicacionCliente);
            //if (status != GeoCoderStatusCode.G_GEO_SUCCESS)
            //{
            //    MessageBox.Show("La ubicación no puede ser encontrada en el mapa", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            //else
            //{
            //    gMC_CCDom.DragButton = MouseButtons.Left;
            //    //gMC_CCDom.CanDragMap = true;
            //    gMC_CCDom.ShowCenter = false;
            //    gMC_CCDom.MapProvider = BingHybridMapProvider.Instance;
            //    GMaps.Instance.Mode = AccessMode.ServerOnly;
            //    gMC_CCDom.MapProvider = GMapProviders.GoogleMap;
            //    gMC_CCDom.SetPositionByKeywords(txtUbicacion.Text);
            //    gMC_CCDom.MinZoom = 0;
            //    gMC_CCDom.MaxZoom = 24;
            //    gMC_CCDom.Zoom = 15;
            //    gMC_CCDom.AutoScroll = true;
            //   // GMaps.Instance.Mode = AccessMode.ServerAndCache;

            //    marcadorMap = new GMapOverlay("Marcador");
            //    marcador = new GMarkerGoogle(new PointLatLng(gMC_CCDom.Position.Lat, gMC_CCDom.Position.Lng), GMarkerGoogleType.red_small);
            //    marcadorMap.Markers.Add(marcador);

            //    marcador.ToolTipMode = MarkerTooltipMode.Always;
            //    marcador.ToolTipText = string.Format("Ubicación: \n Latitud: {0} \n Longitud: {1}", gMC_CCDom.Position.Lat, gMC_CCDom.Position.Lng);

            //    gMC_CCDom.Overlays.Add(marcadorMap);
            //}



        }
    }
}
