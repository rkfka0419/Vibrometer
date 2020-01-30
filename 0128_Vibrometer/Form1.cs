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
//using System.Numerics;
using NAudio.Wave; // installed with nuget
//using NAudio.Dsp;
using System.Numerics;



namespace _0128_Vibrometer
{
    public partial class Form1 : Form
    {
        public WaveIn wi;
        public BufferedWaveProvider bwp;
        public WaveInProvider wi_provider;
        //public Int32 envelopeMax;

        public BufferedStream bs;

        private int SAMPLE_RATE = 44100; // sample rate of the sound card
        private int BUFFERSIZE = (int)Math.Pow(2, 11); // must be a multiple of 2

        //;
        public WaveData wv_data;
        Queue<float> sampleQueue = new Queue<float>();

        public Form1()
        {
            InitializeComponent();
            
            // Using WaveData class;
            
            wv_data = new WaveData(SAMPLE_RATE);


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
            wi.BufferMilliseconds = (int)((double)BUFFERSIZE / (double)SAMPLE_RATE * 1000.0);


            ////Provider without BufferedWaveProvider
            //bwp = new BufferedWaveProvider(wi.WaveFormat);
            //bwp.BufferLength = BUFFERSIZE * 2;
            //bwp.DiscardOnBufferOverflow = true;




            // create a wave buffer and start the recording
            wi.DataAvailable += new EventHandler<WaveInEventArgs>(wi_DataAvailable);

            wi_provider = new WaveInProvider(wi);
            

            wi.StartRecording();
            Console.WriteLine("녹음 시작");

        }

        //private void wi_DataAvailable(object sender, WaveInEventArgs e)
        //{
        //    bwp.AddSamples(e.Buffer, 0, e.BytesRecorded);
        //}
        private void wi_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (wi == null)
                Console.WriteLine("wi is null");
                //return;
            try
            {
                //short[] audioData = new short[e.Buffer.Length / 2]; //this is your data! by default is in the short format
                //Buffer.BlockCopy(e.Buffer, 0, audioData, 0, e.Buffer.Length);
                //float[] audioFloat = Array.ConvertAll(audioData, x => (float)x); //I typically like to convert it to float for graphical purpose
                //Do something with audioData (short) or audioFloat (float)          
                //byte[] data = new byte[e.Buffer.Length / 2]; ;    
                //wv_data.bata = new byte[e.Buffer.Length] ;
                Console.WriteLine("wi_DataAvailable loop");
                foreach (var sample in e.Buffer)
                    sampleQueue.Enqueue(sample);

                Console.WriteLine("큐 삽입 완료");

                if (sampleQueue.Count > SAMPLE_RATE)
                {
                    Console.WriteLine("큐 가득참!");
                    var wave = new WaveData();
                    wave.Data = new float[SAMPLE_RATE];
                    UpdateAudioGraph(wave);
                    sampleQueue.Clear();
                }
                //Buffer.BlockCopy(e.Buffer, 0, wv_data.bData, 0, e.Buffer.Length);
                //wv_data.Data = Array.ConvertAll(data, x => (float)x);
            }
            catch (Exception error)
            { //if some happens along the way...
                MessageBox.Show(error.ToString());
            }
        }

        public void UpdateAudioGraph(WaveData wv_data)
        {
            
            //wv_data
            // read the bytes from the stream
            int frameSize = BUFFERSIZE;
            var frames = new byte[frameSize];
            Console.WriteLine("frameSize = {0}, frames.Length = {1}", frameSize, frames.Length);

            //bwp.Read(frames, 0, frameSize);
            //wi_provider.Read(wv_data.Data, 0, BUFFERSIZE);


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
            //Int32[] vals = new Int32[wv_data.Data.Length / BYTES_PER_POINT];
            //double[] Ys = new double[wv_data.Data.Length / BYTES_PER_POINT];
            //double[] Xs = new double[wv_data.Data.Length / BYTES_PER_POINT];
            //double[] Ys2 = new double[wv_data.Data.Length / BYTES_PER_POINT];
            //double[] Xs2 = new double[wv_data.Data.Length / BYTES_PER_POINT];
            for (int i = 0; i < vals.Length; i++)
            {
                // bit shift the byte buffer into the right variable format
                byte hByte = frames[i * 2 + 1];
                byte lByte = frames[i * 2 + 0];
                vals[i] = (int)(short)((hByte << 8) | lByte);
                Xs[i] = i;
                Ys[i] = vals[i];
                //Ys[i] = wv_data.Data[i];
                Xs2[i] = (double)i / Ys.Length * SAMPLE_RATE / 1000.0; // units are in kHz
            }

            line_buffer.Add(Ys);
            //line_buffer.Add(wv_data.Data);
            //tChart1.Refresh();
            Ys2 = FFT(Ys);
            line_fft.Add(Ys2.Take(Ys2.Length / 2).ToArray());
            

            timer1.Enabled = true;

        }

        public double[] FFT(double[] data)
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
                //fft[i] = Math.Log10(fft[i]); // convert to dB (데시벨)
            }
            return fft;
            //todo: this could be much faster by reusing variables
        }


        private void StartBtn_Click(object sender, EventArgs e)
        { // read the bytes from the stream
            //UpdateAudioGraph();
            timer1.Enabled = true;
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Timer tick");
            //Console.WriteLine("line_buffer Length = {0}", line_buffer.Count);
            //Console.WriteLine("line_fft Length = {0}", line_fft.Count);
            //line_buffer.Clear();
            //line_fft.Clear();
            //UpdateAudioGraph();
        }
    }


    public class WaveData
    {
        int samplerate = 0;
        //float[] Data;
        public float[] Data { get; set; }
        //public byte[] Data { get; set; }

        public WaveData()
        {
            this.samplerate = 44100;
        }

        public WaveData(int sample_rate)
        {
            this.samplerate = sample_rate;
        }

        public WaveFormat WaveFormat
        {
            get { return WaveFormat; }
        }


    }
}
