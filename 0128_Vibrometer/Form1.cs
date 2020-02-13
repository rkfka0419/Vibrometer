using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Linq;

namespace _0128_Vibrometer
{
    public partial class Form1 : Form
    {
        MicControll micControll;
        LineDrawer lineDrawWave;
        LineDrawer lineDrawFFT;
        const string CONFIG_FILE_PATH = @"config.json";
        const string connectionString = @"Server=.;database=SimpleCMSDB;uid=sa;password=rootroot;";

        //파일에서 입력받아 저장할 LineDraw 클래스 리스트
        List<LineDrawer> lineDrawerList = new List<LineDrawer>();
        List<ITrendCalculator> trendCalculatorList = new List<ITrendCalculator>();

        ITrendCalculator[] trendCalculator = new ITrendCalculator[] { };

        public Form1()
        {
            InitializeComponent();
            //timer1.Interval = 1000;
            //timer1.Tick += timer1_Tick;
            lineDrawWave = new LineDrawer(lineWave);
            lineDrawFFT = new LineDrawer(lineFFT);

            using (var db = new VibrometerDBClassDataContext(connectionString))
            {
                if (!db.DatabaseExists())
                {
                    db.CreateDatabase();
                    Console.WriteLine("database created.");
                }
                //var setting = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };
                //trendCalculator = JsonConvert.DeserializeObject<ITrendCalculator[]>(File.ReadAllText(CONFIG_FILE_PATH), setting);

                //RmsConfig rmsConfig1 = new RmsConfig();
                //rmsConfig1.name = "RMS1";
                //rmsConfig1.start = 100;
                //rmsConfig1.end = 1000;
                //db.TrendConfig.InsertOnSubmit(rmsConfig1);
                //db.SubmitChanges();

                //RmsConfig rmsConfig2 = new RmsConfig();
                //rmsConfig2.name = "RMS2";
                //rmsConfig2.start = 1000;
                //rmsConfig2.end = 4000;
                //db.TrendConfig.InsertOnSubmit(rmsConfig2);
                //db.SubmitChanges();

                //PeakConfig peakConfig = new PeakConfig();
                //peakConfig.name = "Peak1";
                //peakConfig.option = "upper";
                //db.TrendConfig.InsertOnSubmit(peakConfig);
                //db.SubmitChanges();
            }



            //var jsonStr = JsonConvert.SerializeObject(calculators, Newtonsoft.Json.Formatting.Indented, setting);
            //File.WriteAllText("config.json", jsonStr);

            for (int i = 0; i < trendCalculator.Length; i++)
            {
                LineDrawer lineTempObj = new LineDrawer(tChart3, new Steema.TeeChart.Styles.Line());
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
            //Calculate Spectrum data from wave
            Spectrum spectrum = new Spectrum();
            spectrum.GetFFT(wave);

            //Draw Wave
            lineDrawWave.DrawLine(wave, true);

            //Draw FFT wave
            lineDrawFFT.DrawLine(spectrum.fft, true);

            
            using (var db = new VibrometerDBClassDataContext(connectionString))
            {

                //var rmsConfig = from trendType in db.TrendConfig
                //              where trendType is RmsConfig
                //              select trendType;
                //foreach (var line in rmsConfig)
                //{
                //    TrendData trendData = new TrendData();
                //    trendData = line.CalTrend(wave, spectrum);
                //    db.TrendData.InsertOnSubmit(trendData);
                //    db.SubmitChanges();
                //}
                //var peakConfig = from trendType in db.TrendConfig
                //                 where trendType is PeakConfig
                //                 select trendType;
                //foreach (var line in peakConfig)
                //{
                //    TrendData trendData = new TrendData();
                //    trendData = line.CalTrend(wave, spectrum);
                //    db.TrendData.InsertOnSubmit(trendData);
                //    db.SubmitChanges();
                //}
                //db.WaveData.InsertOnSubmit(wave);
                



                //var rmss = db.TrendConfig.OfType<RmsConfig>().Select(rms => rms.CalTrend(wave, spectrum));
                //db.TrendData.InsertAllOnSubmit(rmss);

                //var peaks = db.TrendData.OfType<PeakConfig>().Select(peak => peak.CalTrend(wave, spectrum));
                //db.TrendData.InsertAllOnSubmit(peaks);

                var trends = db.TrendConfig.Select(trend => trend.CalTrend(wave, spectrum));
                db.TrendData.InsertAllOnSubmit(trends);
                db.SubmitChanges();

            }

            for (int i = 0; i < trendCalculator.Length; i++)
            {
                //TrendData trendData = trendCalculator[i].GetTrend(wave, spectrum.fft);
                //lineDrawerList[i].DrawLine(trendCalculator[i].title, trendData.Value);
                lineDrawerList[i].DrawLine(wave, spectrum, trendCalculator[i]);
            }
        }
    }
}

     