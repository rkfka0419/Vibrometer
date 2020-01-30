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

using NAudio.CoreAudioApi;
using NAudio.Wave; // installed with nuget
using System.Numerics;



namespace _0128_Vibrometer
{
    public partial class Form1 : Form
    {
        private int SAMPLE_RATE = (int)(Math.Pow(2, 13)); // sample rate of the sound card

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
            WaveIn wi = new WaveIn();
            wi.DeviceNumber = 0;
            wi.WaveFormat = new NAudio.Wave.WaveFormat(SAMPLE_RATE, 1);
            //wi.BufferMilliseconds = (int)((double)BUFFERSIZE / (double)SAMPLE_RATE * 1000.0);

            wi.DataAvailable += new EventHandler<WaveInEventArgs>(wi_DataAvailable);
            wi.StartRecording();
            timer1.Enabled = true;
        }
        void wi_DataAvailable(object sender, WaveInEventArgs e)
        {
            try
            {
                //foreach (var sample in e.Buffer)
                //    sampleQueue.Enqueue(sample);

                for(int i = 0; i < e.BytesRecorded; i += 2)
                {
                    Int16 val = BitConverter.ToInt16(e.Buffer, i);
                    //sampleQueue.Enqueue((float) ((double)(val) / Math.Pow(2, 16) * 200.0));
                    sampleQueue.Enqueue((float)(double)(val));
                }


                if (sampleQueue.Count > SAMPLE_RATE)
                {
                    var wave = new WaveData();
                    wave.Data = new float[SAMPLE_RATE];
                    for (int i=0; i<wave.Data.Length; i++)
                    {
                        wave.Data[i] = sampleQueue.Dequeue();
                    }
                    UpdataChart(wave);
                    sampleQueue.Clear();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        public void UpdataChart(WaveData wave)
        {
            //System.Diagnostics.Trace.WriteLine(System.DateTime.Now.ToString() + "UpdataChart");
            Console.WriteLine(
                  System.DateTime.Now.TimeOfDay.Minutes.ToString() + ":"
                + System.DateTime.Now.TimeOfDay.Seconds.ToString()
                + "\tUpdataChart");
            //float형 데이타를 받아서 그래프 그리기
            line_buffer.Clear();
            line_fft.Clear();
            line_buffer.Add(wave.Data);
            line_fft.Add(FFT(wave.Data));
        }

        public double[] FFT(float[] data)
        {
            double[] fft = new double[data.Length]; // this is where we will store the output (fft)
            Complex[] fftComplex = new Complex[data.Length]; // the FFT function requires complex format
            for (int i = 0; i < data.Length; i++)
            {
                fftComplex[i] = new Complex(data[i], 0.0); // make it complex format (imaginary = 0)
            }
            Accord.Math.FourierTransform.FFT(fftComplex, Accord.Math.FourierTransform.Direction.Forward);
            for (int i = 0; i < data.Length; i++)
            {
                fft[i] = fftComplex[i].Magnitude; // back to double
                //fft[i] = Math.Log10(fft[i]); // convert to dB
            }
            return fft;
        }


        private void StartBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("녹음 시작");
            timer1.Enabled = true;
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            //wi.StopRecording();
            Console.WriteLine("녹음 중지");
            timer1.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //do tick;
            tChart1.Invalidate();
            tChart2.Invalidate();
        }
    }


    public class WaveData
    {
        int samplerate = 0;
        public float[] Data { get; set; }

        public WaveData()
        {
            this.samplerate = 44100;
        }

        public WaveData(int sample_rate)
        {
            this.samplerate = sample_rate;
        }
        

    }
}