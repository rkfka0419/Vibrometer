using System;
using System.Collections.Generic;
using NAudio.Wave; // installed with nuget
using System.Linq;

namespace _0128_Vibrometer
{
    class MicControll
    {
        private WaveIn wi;
        //private WaveData wave;
        private int SAMPLE_RATE = (int)(Math.Pow(2, 13)); // sample rate of the sound card
        Queue<float> sampleQueue = new Queue<float>();
        Queue<Byte> samplingQueue = new Queue<Byte>();

        public MicControll()
        {
            int devcount = WaveIn.DeviceCount;
            // see what audio devices are available
            Console.Out.WriteLine("Device Count: {0}.", devcount);

            // get the WaveIn class started
            wi = new WaveIn();
            wi.DeviceNumber = 0;
            wi.WaveFormat = new NAudio.Wave.WaveFormat(SAMPLE_RATE, 1);
            //wi.BufferMilliseconds = wi.WaveFormat.AverageBytesPerSecond / 5000;
            //wi.BufferMilliseconds = 100;

            wi.DataAvailable += new EventHandler<WaveInEventArgs>(wi_DataAvailable);
        }

        void wi_DataAvailable(object sender, WaveInEventArgs e)
        {
            try
            {
                byte[] buffer = new byte[SAMPLE_RATE * 2];

                for (int i = 0; i < e.BytesRecorded; i++)
                {
                    samplingQueue.Enqueue(e.Buffer[i]);
                }

                if (samplingQueue.Count >= SAMPLE_RATE * 2)
                {
                    for (int i=0; i<buffer.Length; i++)
                    {
                        buffer[i] = samplingQueue.Dequeue();
                    }

                    WaveData wave = new WaveData();
                    wave.channel_Id = wi.DeviceNumber;
                    //wave.time = DateTime.Now;
                    //Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
                    //Console.WriteLine(wave.time);
                    wave.data = buffer;

                    wave.Floats = new float[SAMPLE_RATE];
                    for (int i = 0; i < buffer.Length; i += 2)
                    {
                        Int16 val = BitConverter.ToInt16(buffer, i);
                        sampleQueue.Enqueue(val);
                    }
                    for (int i = 0; i < wave.Floats.Length; i++)
                    {
                        wave.Floats[i] = sampleQueue.Dequeue();
                    }

                    var connectionString = @"Server=.;database=SimpleCMSDB;uid=sa;password=rootroot;";
                    var db = new VibrometerDBClassDataContext(connectionString);
                    db.WaveData.InsertOnSubmit(wave);
                    db.SubmitChanges();
                    samplingQueue.Clear();
                    OnReceivedWaveData(wave);
                }

                //for (int i = 0; i < e.BytesRecorded; i += 2)
                //{
                //    Int16 val = BitConverter.ToInt16(e.Buffer, i);
                //    //Int16 val = short(e.Buffer, i);
                //    //sampleQueue.Enqueue((float) ((double)(val) / Math.Pow(2, 16) * 200.0));
                //    sampleQueue.Enqueue((float)(double)(val));
                //}

                //if (sampleQueue.Count >= SAMPLE_RATE)
                //{
                //    this.wave = new WaveData();
                //    wave.data = new float[SAMPLE_RATE];
                //    for (int i = 0; i < wave.data.Length; i++)
                //    {
                //        wave.data[i] = sampleQueue.Dequeue();
                //    }
                //    sampleQueue.Clear();
                //    OnReceivedWaveData(wave);
                //}
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

