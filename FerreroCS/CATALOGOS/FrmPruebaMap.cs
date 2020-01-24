using System.Threading.Tasks;
using System.Windows.Forms;
using enUtilerias;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace FerreroCS.CATALOGOS
{
    public partial class FrmPruebaMap : Form
    {
        // Privadas
        private GMapOverlay objects = new GMapOverlay("objects");
        private string fulladress;

        // Propiedades
        public Coordenadas Cords { get; set; }

        public FrmPruebaMap(string direccion)
        {
            InitializeComponent();

            MainMap.Position = new PointLatLng(19.702831, -101.1944855);
            MainMap.MinZoom = 0;
            MainMap.MaxZoom = 24;
            MainMap.Zoom = 9;
            //MainMap.Overlays.Add(objects);
            MainMap.MapProvider = GMapProviders.GoogleMap;
            GoogleMapProvider.Instance.ApiKey = "AIzaSyAmO6pIPTz0Lt8lmYZEIAaixitKjq-4WlB";
            MainMap.DragButton = MouseButtons.Left; //drag
        }

        private async void btnBuscar_Click(object sender, System.EventArgs e)
        {
            try
            {
                await ProcesarDatos(txtPais.Text.Trim(), txtEstado.Text.Trim(), txtCiudad.Text.Trim(), txtDireccion.Text.Trim());
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //
        public Task ProcesarDatos(string Country, string Department, string City, string Address)
        {
            Task task = Task.Run(() =>
            {
                GeoCoderStatusCode status = GeoCoderStatusCode.UNKNOWN_ERROR;

                fulladress = (string.IsNullOrEmpty(Country) ? "" : Country + ", ") + (string.IsNullOrEmpty(Department) ? "" : Department + ", ") + (string.IsNullOrEmpty(City) ? "" : City + ", " + Address);

                PointLatLng? pos = GMapProviders.GoogleMap.GetPoint(fulladress, out status);

                if (pos != null && status == GeoCoderStatusCode.OK)
                {
                    Cords.Latitud = pos.Value.Lat;
                    Cords.Longitud = pos.Value.Lng;

                    GMapMarker myCity = new GMarkerGoogle(pos.Value, GMarkerGoogleType.green_small);
                    myCity.ToolTipText = Address;
                    myCity.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                    objects.Markers.Add(myCity);
                }
                else
                    MessageBox.Show("No se pudo localizar la ubicación");




                //status = MainMap.SetPositionByKeywords(fulladress);
                //if (status != GeoCoderStatusCode.G_GEO_SUCCESS)
                //{
                //    GMapMarker myCity = new GMarkerGoogle(new PointLatLng(MainMap.Position.Lat, MainMap.Position.Lng), GMarkerGoogleType.green_small);
                //    myCity.ToolTipText = Address;
                //    myCity.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                //    objects.Markers.Add(myCity);
                //}
                //else
                //    MessageBox.Show("No se pudo localizar la ubicación");


            });

            return task;
        }
    }
}
