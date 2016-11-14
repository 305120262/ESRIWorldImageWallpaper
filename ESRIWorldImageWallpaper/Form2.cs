using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESRIWorldImageWallpaper
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            MapControl ctrl = new MapControl();
            this.elementHost1.Child =ctrl;
            ctrl.SetLocation = (s, e) => {
                Form1 parent = this.Owner as Form1;
                string[] coords = e.Split(',');
                parent.SetExtent(coords[0],coords[1],coords[2],coords[3]);
                this.Close();
            };
        }

        
    }
}
