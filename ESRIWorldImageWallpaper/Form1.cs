using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace ESRIWorldImageWallpaper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string m_bbox;
        private string m_location;
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            notifyIcon1.ShowBalloonTip(9000);
            RandomSet();
        }

        public void RandomSet()
        {
            StringReader reader;
            if (favoritecbx.Checked)
            {
                reader = new StringReader(ConfigurationManager.AppSettings["Favorite"]);
            }
            else
            {
                reader = new StringReader(GISResource.urban);
            }

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
            SetWallpaper(bbox, location, this.namecbx.Checked);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.Enabled = false;
            string bbox = string.Format("{0},{1},{2},{3}", xmintbx.Text, ymintbx.Text, xmaxtbx.Text, ymaxtbx.Text);
            SetWallpaper(bbox, this.nametbx.Text, this.namecbx.Checked);
            string shared = string.Format("{4}@{0},{1},{2},{3}", xmintbx.Text, ymintbx.Text, xmaxtbx.Text, ymaxtbx.Text, this.nametbx.Text);
            this.button2.Enabled = true;
        }

        private void SetWallpaper(string bbox, string location = "", bool showLocation = false)
        {
            m_bbox = bbox;
            m_location = location;
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            string size = string.Format("{0},{1}", w, h);

            //string bbox = string.Format("{0},{1},{2},{3}",112,22,113,23);
            string url = string.Format("http://server.arcgisonline.com/arcgis/rest/services/World_Imagery/MapServer/export?f=image&bbox={0}&size={1}&bboxSR=4326&format=jpeg", bbox, size);

            Wallpaper.Set(new Uri(url), Wallpaper.Style.Stretched, location, showLocation);
        }


        private void periodiccbx_CheckedChanged(object sender, EventArgs e)
        {
            this.timer1.Enabled = this.periodiccbx.Checked;
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "&Exit")
            {
                Application.Exit();
            }
            else if (e.ClickedItem.Text == "&MarkFavorite")
            {
                if (m_bbox != null)
                {
                    StringWriter writer = new StringWriter();
                    writer.Write(ConfigurationManager.AppSettings["Favorite"]);
                    writer.WriteLine(string.Format("{1}@{0}", m_location, m_bbox));
                    ConfigurationManager.AppSettings["Favorite"] = writer.ToString();
                    writer.Close();
                    MessageBox.Show("Marked as favorites!");
                }
            }
            else if (e.ClickedItem.Text == "&HideSetting")
            {
                this.Visible = false;
            }
            else
            {
                this.Visible = true;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RandomSet();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog(this);
        }

        public void SetExtent(string xmin, string ymin, string xmax, string ymax)
        {
            this.xmintbx.Text = xmin;
            this.ymintbx.Text = ymin;
            this.xmaxtbx.Text = xmax;
            this.ymaxtbx.Text = ymax;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.notifyIcon1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["Favorite"] == null)
            {
                this.favoritecbx.Enabled = false;
            }
        }


    }
}
