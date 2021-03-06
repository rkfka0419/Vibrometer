﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace _0128_Vibrometer
{
    public partial class Form1 : Form
    {
        MicControll micControll;
        LineDrawer lineDrawWave;
        LineDrawer lineDrawFFT;
        const string CONFIG_FILE_PATH = @"config.json";

        //파일에서 입력받아 저장할 LineDraw 클래스 리스트
        List<LineDrawer> lineDrawerList = new List<LineDrawer>();
        List<ITrendCalculator> trendCalculatorList = new List<ITrendCalculator>();

        ITrendCalculator[] calc = new ITrendCalculator[] { };

        public Form1()
        {
            InitializeComponent();
            //timer1.Interval = 1000;
            //timer1.Tick += timer1_Tick;

            lineDrawWave = new LineDrawer(lineWave);
            lineDrawFFT = new LineDrawer(lineFFT);

            var setting = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };

            calc = JsonConvert.DeserializeObject<ITrendCalculator[]>(File.ReadAllText(CONFIG_FILE_PATH), setting);

            //var jsonStr = JsonConvert.SerializeObject(calculators, Newtonsoft.Json.Formatting.Indented, setting);
            ////Console.WriteLine(jsonStr);
            //File.WriteAllText("config.json", jsonStr);

            for (int i = 0; i < calc.Length; i++)
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
            //Draw Wave
            lineDrawWave.DrawLine(wave, true);

            //Calculate Spectrum data from wave
            Spectrum spectrum = new Spectrum();
            spectrum.GetFFT(wave);
            //Draw FFT wave
            lineDrawFFT.DrawLine(spectrum.fft, true);
            
            for (int i = 0; i < calc.Length; i++)
            {
                TrendData trendData = calc[i].GetTrend(wave, spectrum.fft);
                lineDrawerList[i].DrawLine(trendData.Value);
            }

        }
    }
}

     