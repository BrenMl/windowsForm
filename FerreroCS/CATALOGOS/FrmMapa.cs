using enUtilerias;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreroCS.CATALOGOS
{
    public partial class FrmMapa : Form
    {
        // Privadas        
        private GeoCoderStatusCode status;
        private PointLatLng? pos;        
        private GMapOverlay MapOverlay;        
        
        // Propiedades        
        public GMarkerGoogle Marker { get; set; }

        public FrmMapa(string direccion)
        {
            InitializeComponent();

            // Inicializar propiedades del mapa
            MainMap.Position = new PointLatLng(19.702831, -101.1944855); // Coordenadas de morelia
            GoogleMapProvider.Instance.ApiKey = "";
            MainMap.MinZoom = 0;
            MainMap.MaxZoom = 24;
            MainMap.Zoom = 9;

            MainMap.ShowCenter = false;
            MainMap.MapProvider = GMapProviders.GoogleMap;            
            MainMap.DragButton = MouseButtons.Left;

            // GMaps.Instance.Mode = AccessMode.ServerOnly;
            // MainMap.AutoScroll = true;
            // GMaps.Instance.Mode = AccessMode.ServerAndCache;
            
            txtBusquedaLibre.Text = direccion;

            try
            {
                ProcesarDatos(txtBusquedaLibre.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBusquedaLibre_Click(object sender, EventArgs e)
        {
            try
            {
                ProcesarDatos(txtBusquedaLibre.Text.Trim());
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProcesarDatos(string BusquedaLibre)
        {
            MainMap.Overlays.Clear();
            status = GeoCoderStatusCode.UNKNOWN_ERROR;
            pos = GMapProviders.GoogleMap.GetPoint(BusquedaLibre, out status);
            if (pos != null && status == GeoCoderStatusCode.OK)
            {
                MainMap.Zoom = 18;
                MainMap.Position = new PointLatLng(pos.Value.Lat, pos.Value.Lng);

                Marker = new GMarkerGoogle(MainMap.Position, GMarkerGoogleType.red_dot)
                {
                    ToolTipText = $"{BusquedaLibre}\nCoordenadas:{pos.Value.Lat}, {pos.Value.Lng}",
                    ToolTipMode = MarkerTooltipMode.Always,                                        
                };

                MapOverlay = new GMapOverlay("Marcador");
                MapOverlay.Markers.Add(Marker);

                MainMap.Overlays.Add(MapOverlay);
            }
            else
                MessageBox.Show("No se pudo localizar la ubicación");          
        }

        private void MainMap_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            Marker.Position = new PointLatLng(MainMap.FromLocalToLatLng(e.X, e.Y).Lat, MainMap.FromLocalToLatLng(e.X, e.Y).Lng);
            Marker.ToolTipText = $"Coordenadas:{Marker.Position.Lat}, {Marker.Position.Lng}";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
