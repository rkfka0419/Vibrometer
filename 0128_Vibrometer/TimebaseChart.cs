using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0128_Vibrometer
{
    public partial class TimebaseChart : UserControl
    {
        public string Aaaa { get { return tChart1.Text; } set { tChart1.Text = value; } }
        public Color AnyColoraaa { get; set; }
        public TimebaseChart()
        {
            InitializeComponent();
        }

        public void Draw(WaveData wave)
        {

        }
    }
}
