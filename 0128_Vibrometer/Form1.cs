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
        LineDraw lineDrawRMS;
        LineDraw lineDrawP2P;
        List<LineDraw> lineRMSList = new List<LineDraw>();
        static int _rmsCount = 10;

        public Form1()
        {
            InitializeComponent();


            //timer1.Interval = 1000;
            //timer1.Tick += timer1_Tick;
            micControll = new MicControll();
            micControll.StartRecording();

            lineDrawWave = new LineDraw(lineWave);
            lineDrawFFT = new LineDraw(lineFFT);
            lineDrawRMS = new LineDraw(lineRMS);
            lineDrawP2P = new LineDraw(lineP2P);

            Steema.TeeChart.Styles.Line[] lines = new Steema.TeeChart.Styles.Line[_rmsCount];
            LineDraw[] lclc = new LineDraw[_rmsCount];
            for (int i = 0; i < _rmsCount; i++)
            {
                //lines[i] = new Steema.TeeChart.Styles.Line();
                //tChart3.Series.Add(lines[i]);
                //lclc[i] = new LineControll(lines[i]);
                //lineRMSList.Add(lclc[i]);

                //lins
                //Steema.TeeChart.Styles.Line line = new Steema.TeeChart.Styles.Line();
                //tChart3.Series.Add(line);
                //lclc[i] = new LineControll(line);
                //lineRMSList.Add(lclc[i]);

                lineRMSList.Add(new LineDraw(new Steema.TeeChart.Styles.Line()));



            }



            // 방법 2 --- 안됨
            //lineRMSList.Add(new LineControll(new Steema.TeeChart.Styles.Line()));


            //리시버를 보고있음
            micControll.OnReceivedWaveData += micControll_OnReceivedWaveData;
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
            //LineControll.Logging("micControll_OnReceivedWaveData : ");

            lineDrawWave.DrawLine(wave, true);

            FFT fft = new FFT(wave); // 단순 계산 클래스는 static으로 인스턴스화 없이 사용해야 할지?
            lineDrawFFT.DrawLine(fft.GetFFT(), true);

            //Peak peak = new Peak(wave);
            //lineDrawP2P.DrawLine(peak.GetPeakToPeak());

            RMS rms = new RMS(fft.GetFFT());
            lineDrawRMS.DrawLine(rms.GetRMS());

            int waveLength = wave.Data.Length / 2;
            int bandStep = waveLength / _rmsCount;
            int start = 0;
            foreach (var eachRMSLine in lineRMSList)
            {
                float bandedRMS = rms.GetRMS(start, start + bandStep);
                tChart3.Series.Add(eachRMSLine.GetLine());
                eachRMSLine.DrawLine(bandedRMS);
                start += bandStep;
            }
        }
    }
}
    