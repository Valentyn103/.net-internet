using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gmap.net
{
    public partial class Form1 : Form
    {
        GMapControl cntrl;
        public Form1()
        {
            InitializeComponent();
            cntrl = new GMapControl();
            cntrl.MapProvider = GMapProviders.OpenStreetMap;
          //  cntrl.Position = new PointLatLng(-25.969562, 32.585789);
            cntrl.Position = new PointLatLng(50.608528, 26.204339);
            cntrl.MinZoom = 1;
            cntrl.MaxZoom = 18;
            cntrl.Zoom = 9;
            cntrl.Dock = DockStyle.Fill;
            cntrl.DoubleClick += new System.EventHandler(this.cntrl_DoubleClick);

            this.Controls.Add(cntrl);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            cntrl.Zoom = trackBar1.Value;
        }

        private void cntrl_DoubleClick(object sender, EventArgs e)
        {
            if (cntrl.Zoom + 2 < 18)
                cntrl.Zoom = cntrl.Zoom + 2;
            else
                cntrl.Zoom = 18;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(cntrl.Position.Lat, cntrl.Position.Lng),
              GMarkerGoogleType.green);
            markersOverlay.Markers.Add(marker);
            cntrl.Overlays.Add(markersOverlay);


            //GMapOverlay polyOverlay = new GMapOverlay("polygons");
            //List<PointLatLng> points = new List<PointLatLng>();
            //points.Add(new PointLatLng(-25.969562, 32.585789));
            //points.Add(new PointLatLng(-25.966205, 32.588171));
            //points.Add(new PointLatLng(-25.968134, 32.591647));
            //points.Add(new PointLatLng(-25.971684, 32.589759));
            //GMapPolygon polygon = new GMapPolygon(points, "mypolygon");
            //polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            //polygon.Stroke = new Pen(Color.Red, 1);
            //polyOverlay.Polygons.Add(polygon);
            //cntrl.Overlays.Add(polyOverlay);
        }
    }
}
