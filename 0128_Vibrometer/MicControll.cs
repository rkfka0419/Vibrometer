using NAudio.Wave; // installed with nuget
using System;
using System.Collections.Generic;

namespace _0128_Vibrometer
{
    class MicControll
    {
        private WaveIn wi;
        private WaveData wave;
        private int SAMPLE_RATE = (int)(Math.Pow(2, 13)); // sample rate of the sound card
        Queue<float> sampleQueue = new Queue<float>();

        public MicControll()
        {
            int devcount = WaveIn.DeviceCount;
            // see what audio devices are available
            Console.Out.WriteLine("Device Count: {0}.", devcount);

            // get the WaveIn class started
            wi = new WaveIn();
            wi.DeviceNumber = 0;
            wi.WaveFormat = new NAudio.Wave.WaveFormat(SAMPLE_RATE, 1);
            //wi.BufferMilliseconds = wi.WaveFormat.AverageBytesPerSecond / 1000;
            //wi.BufferMilliseconds = 20;

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
                    this.wave = new WaveData();
                    wave.Data = new float[SAMPLE_RATE];
                    for (int i = 0; i < wave.Data.Length; i++)
                    {
                        wave.Data[i] = sampleQueue.Dequeue();
                    }

                    //ChartContoll.Logging("wi_DataAvailable : ");
                    sampleQueue.Clear();
                    OnReceivedWaveData(wave);
                }
            }

            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
        }
        public event Action<WaveData> OnReceivedWaveData;
        public void StartRecording()
        {
            wi.StartRecording();
        }
        public void StopRecording()
        {
            wi.StopRecording();
        }
    }
}

