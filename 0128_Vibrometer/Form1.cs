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
        string[] configfile;
        const string CONFIG_FILE_PATH = @"config.txt";

        //사용자에게 입력 받을 LineDraw 클래스 리스트
        List<LineDraw> lineObjList = new List<LineDraw>();
        //config파일을 읽어 한줄씩 분리한 후 집어넣을 큐
        Queue<string[]> configLineQueue = new Queue<string[]>();

        public Form1()
        {
            InitializeComponent();
            //timer1.Interval = 1000;
            //timer1.Tick += timer1_Tick;

            lineDrawWave = new LineDraw(lineWave);
            lineDrawFFT = new LineDraw(lineFFT);

            micControll = new MicControll();
            micControll.StartRecording();

            configfile = System.IO.File.ReadAllLines(CONFIG_FILE_PATH);

            for(int i=0; i<configfile.Length; i++)
            { // 파일 라인길이만큼 객체생성
                //configLineQueue.Enqueue(configfile[i].Split(' '));
                LineDraw lineTempObj = new LineDraw(tChart3, new Steema.TeeChart.Styles.Line());
                lineTempObj.SetFieldFromConfigLine(configfile[i].Split(' '));
                lineObjList.Add(lineTempObj);
            }

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
            foreach(var line_item in lineObjList)
            {
                //string[] configLine = configLineQueue[i];
                //string[] configLine = configfile[i++].Split(' ');
                //TrendGenerator.DrawLineByTrendType(line_item, configLine, wave);
                TrendGenerator.DrawLineByTrendType(line_item, wave);
            }

        }
    }
}

     