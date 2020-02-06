using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _0128_Vibrometer
{
    public partial class Form1 : Form
    {
        MicControll micControll;
        LineDrawer lineDrawWave;
        LineDrawer lineDrawFFT;
        ConfigReader configReader;
        const string CONFIG_FILE_PATH = @"config.txt";

        //파일에서 입력받아 저장할 LineDraw 클래스 리스트
        List<LineDrawer> lineDrawerList = new List<LineDrawer>();
        List<ConfigData> configList = new List<ConfigData>();
        TrendCalculatorFactory trendCalculatorFactory = new TrendCalculatorFactory();

        public Form1()
        {
            InitializeComponent();
            //timer1.Interval = 1000;
            //timer1.Tick += timer1_Tick;

            lineDrawWave = new LineDrawer(lineWave);
            lineDrawFFT = new LineDrawer(lineFFT);

            configReader = new ConfigReader();
            configList = configReader.ReadFile(CONFIG_FILE_PATH);

            //list 객체 하나씩 생성 및 푸쉬
            foreach (var configItem in configList)
            { // 파일 라인길이만큼 객체생성
                LineDrawer lineTempObj = new LineDrawer(tChart3, new Steema.TeeChart.Styles.Line());
                lineTempObj.SetConfiguration(configItem);
                lineDrawerList.Add(lineTempObj);
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
            
            foreach (var lineDrawerItem in lineDrawerList)
            {
                ITrendCalculator trendCalculator = trendCalculatorFactory.trendCalculator(lineDrawerItem.GetTrendType());
                //lineDrawerItem. 트렌드값이 계산되기 전에 옵션 메뉴가 반영되어야 함
                TrendData trendData;
                string option;
                if(lineDrawerItem.isOption())
                {
                    option = lineDrawerItem.GetOption();
                    Console.WriteLine("Trend Option is {0}", option);
                    trendData = trendCalculator.GetTrend(wave.Data, option);
                }
                else
                {
                    Console.WriteLine("Trend Option is null");
                    trendData = trendCalculator.GetTrend(wave.Data);
                }
                //trendData = trendCalculator.GetTrend(wave.Data);

                lineDrawerItem.DrawLine(trendData.Value);
                Console.WriteLine(trendData.Time);
            }

        }
    }
}

     