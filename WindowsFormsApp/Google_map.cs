using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GoogleMaps.LocationServices;


namespace WindowsFormsApp
{
    public partial class Google_map : Form
    {
        private GMapControl gmap;
        private GMapMarker currentMarker;

        public Google_map()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            try
            {
                var address = txtlocation.Text.ToString();
                var locationService = new GoogleLocationService("AIzaSyAeOo4nChV9deCrWRXYLclKMxJOTe3zW1M");
                var point = locationService.GetLatLongFromAddress(address);

                if (point != null)
                {
                    txtlatitude.Text = point.Latitude.ToString();
                    txtlongitude.Text = point.Longitude.ToString();

                    // 配置地图
                    map.DragButton = MouseButtons.Left;
                    map.MapProvider = GMapProviders.GoogleMap;
                    double lat = point.Latitude;
                    double longt = point.Longitude;
                    map.Position = new PointLatLng(lat, longt);
                    map.MinZoom = 5;
                    map.MaxZoom = 100;
                    map.Zoom = 10;

                    PointLatLng pointMap = new PointLatLng(lat, longt);
                    GMapMarker marker = new GMarkerGoogle(pointMap, GMarkerGoogleType.red_pushpin);
                    GMapOverlay markers = new GMapOverlay("markers");
                    markers.Markers.Add(marker);
                    map.Overlays.Add(markers);
                }
                else
                {
                    txtlatitude.Text = "Not found";
                    txtlongitude.Text = "Not found";
                }
            }
            catch (WebException webEx)
            {
                MessageBox.Show($"WebException 发生: {webEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"发生错误: {ex.Message}");
            }

        }

        private void Google_map_Load(object sender, EventArgs e)
        {

        }

        private void map_Load(object sender, EventArgs e)
        {

        }

        private void map_Click(object sender, EventArgs e)
        {

        }

        private void map_OnMapClick(PointLatLng pointClick, MouseEventArgs e)
        {
        }
    }
}
