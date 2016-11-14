using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Esri.ArcGISRuntime.Layers;
using Esri.ArcGISRuntime.Geometry;

namespace ESRIWorldImageWallpaper
{
    /// <summary>
    /// Interaction logic for MapControl.xaml
    /// </summary>
    public partial class MapControl : UserControl
    {
        public MapControl()
        {
            InitializeComponent();
            ArcGISTiledMapServiceLayer imgLyr = new ArcGISTiledMapServiceLayer(new Uri("http://server.arcgisonline.com/arcgis/rest/services/World_Imagery/MapServer"));
            Map1.Layers.Add(imgLyr);
            ArcGISTiledMapServiceLayer terrainLyr = new ArcGISTiledMapServiceLayer(new Uri("http://server.arcgisonline.com/arcgis/rest/services/Ocean_Basemap/MapServer"));
            Scene1.Layers.Add(terrainLyr);

        }

        private void Mapview1_ExtentChanged(object sender, EventArgs e)
        {
            Esri.ArcGISRuntime.Geometry.Geometry ext = GeometryEngine.NormalizeCentralMeridian(Mapview1.Extent);
            var vp = new Esri.ArcGISRuntime.Controls.Viewpoint(ext);
            
            SceneView1.SetViewAsync(vp);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Envelope ext = GeometryEngine.NormalizeCentralMeridian(Mapview1.Extent).Extent;
            MapPoint ptnMin = new MapPoint(ext.XMin, ext.YMin,Mapview1.SpatialReference);
            MapPoint nptnMin = GeometryEngine.Project(ptnMin, new SpatialReference(4326)) as MapPoint;
            MapPoint ptnMax = new MapPoint(ext.XMax, ext.YMax, Mapview1.SpatialReference);
            MapPoint nptnMax = GeometryEngine.Project(ptnMax, new SpatialReference(4326)) as MapPoint;
            SetLocation(sender, string.Format("{0},{1},{2},{3}",nptnMin.X,nptnMin.Y,nptnMax.X,nptnMax.Y));
        }

        public EventHandler<String> SetLocation;
    }
}
