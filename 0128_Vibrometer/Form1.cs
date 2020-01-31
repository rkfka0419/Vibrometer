﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using NAudio.CoreAudioApi;
using NAudio.Wave; // installed with nuget
using System.Numerics;



namespace _0128_Vibrometer
{
    public partial class Form1 : Form
    {
        private int SAMPLE_RATE = (int)(Math.Pow(2, 13)); // sample rate of the sound card
        WaveIn wi;
        ChartContoll lineDrawer;

        Queue<float> sampleQueue = new Queue<float>();

        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;

            //tChart1.Axes.Left.Automatic = false;
            //tChart1.Axes.Left.Maximum = 45000;
            //tChart1.Axes.Left.Minimum = -45000;

            // see what audio devices are available
            int devcount = WaveIn.DeviceCount;
            Console.Out.WriteLine("Device Count: {0}.", devcount);

            // get the WaveIn class started
            wi = new WaveIn();
            wi.DeviceNumber = 0;
            wi.WaveFormat = new NAudio.Wave.WaveFormat(SAMPLE_RATE, 1);
            //wi.BufferMilliseconds = (int)((double)BUFFERSIZE / (double)SAMPLE_RATE * 1000.0); // 존재 유무의 의미가 있을지

            wi.DataAvailable += new EventHandler<WaveInEventArgs>(wi_DataAvailable);

            
        }
        void wi_DataAvailable(object sender, WaveInEventArgs e)
        {
            try
            {
                for (int i = 0; i < e.BytesRecorded; i += 2)
                {
                    Int16 val = BitConverter.ToInt16(e.Buffer, i);
                    //Int16 val = short(e.Buffer, i);
                    //sampleQueue.Enqueue((float) ((double)(val) / Math.Pow(2, 16) * 200.0));
                    sampleQueue.Enqueue((float)(double)(val));
                }

                if (sampleQueue.Count >= SAMPLE_RATE)
                {
                    var wave = new WaveData();
                    wave.Data = new float[SAMPLE_RATE];
                    for (int i = 0; i < wave.Data.Length; i++)
                    {
                        wave.Data[i] = sampleQueue.Dequeue();
                    }
                    lineDrawer.DrawLine(line_buffer, wave, true);
                    lineDrawer.DrawLine(line_fft, WaveData.FFT(wave), true);
                    lineDrawer.DrawLine(line_p2p, wave.GetPeakToPeak(wave));
                    lineDrawer.DrawLine(line_rms, wave.GetRMS(wave));
                    sampleQueue.Clear();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("녹음 시작");
            wi.StartRecording();
            timer1.Enabled = true;
        }
        private void StopBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("녹음 중지");
            wi.StopRecording();
            timer1.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            tChart1.Invalidate();
            tChart2.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tChart3.ShowEditor();
        }
    }
}
    