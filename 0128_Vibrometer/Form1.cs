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

using System.Numerics;



namespace _0128_Vibrometer
{
    public partial class Form1 : Form
    {
        MicControll micControll;
        ChartContoll lineDrawer;


        public Form1()
        {
            InitializeComponent();


            //timer1.Interval = 1000;
            //timer1.Tick += timer1_Tick;
            lineDrawer = new ChartContoll();
            micControll = new MicControll();
            micControll.StartRecording();
            micControll.OnReceivedWaveData += micControll_OnReceivedWaveData;
            //리시버를 보고있음


            //tChart1.Axes.Left.Automatic = false;
            //tChart1.Axes.Left.Maximum = 45000;
            //tChart1.Axes.Left.Minimum = -45000;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("녹음 시작");
            micControll.StartRecording();
            //timer1.Enabled = true;
        }
        private void StopBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("녹음 중지");
            micControll.StopRecording();
            //timer1.Enabled = false;
        }
        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    //tChart1.Invalidate();
        //    //tChart2.Invalidate();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            tChart3.ShowEditor();
        }
        private void micControll_OnReceivedWaveData(WaveData wave)
        {
            ChartContoll.Logging("micControll_OnReceivedWaveData : ");

            //lineDrawer.DrawLine(line_buffer, wave, true);
            //lineDrawer.DrawLine(line_fft, WaveData.FFT(wave), true);
            //lineDrawer.DrawLine(line_p2p, wave.GetPeakToPeak(wave));
            //lineDrawer.DrawLine(line_rms, wave.GetRMS(wave));

            ChartContoll line_buffer_controll = new ChartContoll(line_buffer);
            line_buffer_controll.DrawLine(line_buffer, wave, true);


        }

 
    }
}
    