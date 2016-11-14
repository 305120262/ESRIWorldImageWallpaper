using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESRIWallpaperService
{
    public partial class Service1 : ServiceBase
    {
        System.Timers.Timer timer1;  //计时器 
        public Service1()
        {
            InitializeComponent();
            System.Timers.Timer t = new System.Timers.Timer();
            t.Interval = 1000 * 15;
            t.Elapsed += new System.Timers.ElapsedEventHandler(RunWork);
            t.AutoReset = true;//设置是执行一次（false),还是一直执行（true);
            t.Enabled = true;//是否执行
        }

        private void RunWork(object sender, System.Timers.ElapsedEventArgs e)
        {
            RandomSet();
        }

        public void RandomSet()
        {
            StringReader reader = new StringReader(GISResource.urban);
            Random rand = new Random();
            int index = rand.Next(0, 579);
            string bbox = "";
            string location = "";
            for (int i = 0; i <= index; i++)
            {
                string info = reader.ReadLine();
                bbox = info.Split('@')[1];
                location = info.Split('@')[0];
            }
            SetWallpaper(bbox, location, true);
        }

        private void SetWallpaper(string bbox, string location = "", bool showLocation = false)
        {
            
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            string size = string.Format("{0},{1}", w, h);

            //string bbox = string.Format("{0},{1},{2},{3}",112,22,113,23);
            string url = string.Format("http://server.arcgisonline.com/arcgis/rest/services/World_Imagery/MapServer/export?f=image&bbox={0}&size={1}&bboxSR=4326&format=jpeg", bbox, size);

            Wallpaper.Set(new Uri(url), Wallpaper.Style.Stretched, location, showLocation);
        }

        protected override void OnStart(string[] args)
        {
            this.timer1.Start();
        }

        protected override void OnStop()
        {
            this.timer1.Stop();
        }

    }
}
