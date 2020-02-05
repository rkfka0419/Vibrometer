using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _0128_Vibrometer
{
    public partial class Form1 : Form
    {
        MicControll micControll;
        TrendDrawer lineDrawWave;
        TrendDrawer lineDrawFFT;
        ConfigReader configReader;
        const string CONFIG_FILE_PATH = @"config.txt";

        //파일에서 입력받아 저장할 LineDraw 클래스 리스트
        List<TrendDrawer> lineObjList = new List<TrendDrawer>();
        List<ConfigData> configQueue = new List<ConfigData>();
        TrendCalculatorFactory trendCalculatorFactory = new TrendCalculatorFactory();

        public Form1()
        {
            InitializeComponent();
            //timer1.Interval = 1000;
            //timer1.Tick += timer1_Tick;

            lineDrawWave = new TrendDrawer(lineWave);
            lineDrawFFT = new TrendDrawer(lineFFT);

            configReader = new ConfigReader();
            configQueue = configReader.ReadFile(CONFIG_FILE_PATH);

            //list 객체 하나씩 생성 및 푸쉬
            foreach (var configItem in configQueue)
            { // 파일 라인길이만큼 객체생성
                TrendDrawer lineTempObj = new TrendDrawer(tChart3, new Steema.TeeChart.Styles.Line());
                lineTempObj.SetConfiguration(configItem);
                lineObjList.Add(lineTempObj);
            }

            micControll = new MicControll();
            micControll.StartRecording();
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
            
            foreach (var line_item in lineObjList)
            {
                ITrendCalculator trendCalculator = trendCalculatorFactory.trendCalculator(line_item.GetTrendType());
                TrendData trendData = trendCalculator.GetTrend(wave.Data);
                line_item.DrawLine(trendData.Value);
                Console.WriteLine(trendData.Time);
            }
        }
    }
}

     