using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NAudio.CoreAudioApi;
//using System.Numerics;
using NAudio.Wave; // installed with nuget


namespace _0128_Vibrometer
{
    public partial class Form1 : Form
    {
        public WaveIn wi;
        public BufferedWaveProvider bwp;
        public Int32 envelopeMax;

        private int RATE = 44100; // sample rate of the sound card
        private int BUFFERSIZE = (int)Math.Pow(2, 11); // must be a multiple of 2

        //chart libraries;
        Steema.TeeChart.Styles.Line line1 = new Steema.TeeChart.Styles.Line();

        

        public Form1()
        {
            InitializeComponent();
            //chart libraries;

            //Steema.TeeChart.Styles.Line line1 = new Steema.TeeChart.Styles.Line();
            tChart1.Series.Add(line1);
            tChart1.Legend.Visible = false;

            timer1.Interval = 100;
            timer1.Tick += timer1_Tick;

            tChart1.Axes.Left.Automatic = false;
            tChart1.Axes.Left.Maximum = 45000;
            tChart1.Axes.Left.Minimum = -45000;

            // see what audio devices are available
            int devcount = WaveIn.DeviceCount;
            Console.Out.WriteLine("Device Count: {0}.", devcount);

            // get the WaveIn class started
            WaveIn wi = new WaveIn();
            wi.DeviceNumber = 0;
            wi.WaveFormat = new NAudio.Wave.WaveFormat(RATE, 1);
            wi.BufferMilliseconds = (int)((double)BUFFERSIZE / (double)RATE * 1000.0);
            //wi.BufferMilliseconds = (int)((double)BUFFERSIZE / (double)RATE * 10);

            // create a wave buffer and start the recording
            wi.DataAvailable += new EventHandler<WaveInEventArgs>(wi_DataAvailable);
            bwp = new BufferedWaveProvider(wi.WaveFormat);
            bwp.BufferLength = BUFFERSIZE * 2;

            bwp.DiscardOnBufferOverflow = true;
            wi.StartRecording();

        }

        private void wi_DataAvailable(object sender, WaveInEventArgs e)
        {
            bwp.AddSamples(e.Buffer, 0, e.BytesRecorded);
        }

        public void UpdateAudioGraph()
        {
            // read the bytes from the stream
            int frameSize = BUFFERSIZE;
            var frames = new byte[frameSize];
            bwp.Read(frames, 0, frameSize);
            if (frames.Length == 0) return;
            if (frames[frameSize - 2] == 0) return;

            timer1.Enabled = false;

            // convert it to int32 manually (and a double for scottplot)
            int SAMPLE_RESOLUTION = 16;
            int BYTES_PER_POINT = SAMPLE_RESOLUTION / 8;
            Int32[] vals = new Int32[frames.Length / BYTES_PER_POINT];
            double[] Ys = new double[frames.Length / BYTES_PER_POINT];
            double[] Xs = new double[frames.Length / BYTES_PER_POINT];
            double[] Ys2 = new double[frames.Length / BYTES_PER_POINT];
            double[] Xs2 = new double[frames.Length / BYTES_PER_POINT];
            for (int i = 0; i < vals.Length; i++)
            {
                // bit shift the byte buffer into the right variable format
                byte hByte = frames[i * 2 + 1];
                byte lByte = frames[i * 2 + 0];
                vals[i] = (int)(short)((hByte << 8) | lByte);
                Xs[i] = i;
                Ys[i] = vals[i];
                Xs2[i] = (double)i / Ys.Length * RATE / 1000.0; // units are in kHz
            }

            //line1.Add(Xs);
            line1.Add(Ys);
            tChart1.Refresh();
            //// update scottplot (PCM, time domain)
            //scottPlotUC1.Xs = Xs;
            //scottPlotUC1.Ys = Ys;

            ////update scottplot (FFT, frequency domain)
            //Ys2 = FFT(Ys);
            //scottPlotUC2.Xs = Xs2.Take(Xs2.Length / 2).ToArray();
            //scottPlotUC2.Ys = Ys2.Take(Ys2.Length / 2).ToArray();


            //// update the displays
            //scottPlotUC1.UpdateGraph();
            //scottPlotUC2.UpdateGraph();

            //Application.DoEvents();
            //scottPlotUC1.Update();
            //scottPlotUC2.Update();

            timer1.Enabled = true;

        }
        

        private void StartBtn_Click(object sender, EventArgs e)
        { // read the bytes from the stream
            UpdateAudioGraph();
            timer1.Enabled = true;
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //tChart1.Refresh();
            //tChart1.Clear();
            line1.Clear();
            UpdateAudioGraph();
        }
    }
}
