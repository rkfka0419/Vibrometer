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

namespace _0128_Vibrometer
{
    public partial class Form1 : Form
    {
        MicControll micControll;
        LineDraw lineDrawWave;
        LineDraw lineDrawFFT;
        string[] configfile =
            {
                "RMS rms",
                "RMS_10~400 rms 10-400",
                "RMS_400~1000 rms 400-1000",
                "RMS_1000~4000 rms 1000-4000",
                "Peak1 peak",
                "UpperPeak upperPeak",
                "LowerPeak lowerPeak",
                "random random"
            };


        //사용자에게 입력 받을 LineDraw 클래스 리스트
        List<LineDraw> lineListFromConf = new List<LineDraw>();

        public Form1()
        {
            InitializeComponent();
            //timer1.Interval = 1000;
            //timer1.Tick += timer1_Tick;

            micControll = new MicControll();
            micControll.StartRecording();

            lineDrawWave = new LineDraw(lineWave);
            lineDrawFFT = new LineDraw(lineFFT);

            for(int i=0; i<configfile.Length; i++)
            {
                lineListFromConf.Add(new LineDraw(tChart3, new Steema.TeeChart.Styles.Line()));
            }

            //리시버를 보고있음
            micControll.OnReceivedWaveData += micControll_OnReceivedWaveData;

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
            //Draw Wave
            lineDrawWave.DrawLine(wave, true);

            //Draw FFT wave
            lineDrawFFT.DrawLine(FFTCalculator.GetFFT(wave), true);

            //미리 준비된 문자열로 선택하기

            int i = 0;
            foreach(var item in lineListFromConf)
            {
                TrendGenerator.DrawLineByTrendType(item, configfile[i], wave);
                i++;
            }

        }
    }
}

     