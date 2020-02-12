using System;
using System.Linq;

namespace _0128_Vibrometer
{

    partial class TrendData
    {
    }

    partial class WaveData
    {
        public float[] Floats;

        //partial void OnCreated()
        //{
        //    Floats = new float[data.Length / sizeof(float)];
        //    //-----

        //    for (int i = 0; i < data.Length; i += 2)
        //    {
        //        Int16 val = BitConverter.ToInt16(data, i);
        //        //Int16 val = short(e.Buffer, i);
        //        //sampleQueue.Enqueue((float) ((double)(val) / Math.Pow(2, 16) * 200.0));
        //        sampleQueue.Enqueue((float)(double)(val));
        //    }

        //    if (sampleQueue.Count >= SAMPLE_RATE)
        //    {
        //        this.wave = new WaveData();
        //        wave.data = new float[SAMPLE_RATE];
        //        for (int i = 0; i < wave.data.Length; i++)
        //        {
        //            wave.data[i] = sampleQueue.Dequeue();
        //        }
        //        sampleQueue.Clear();
        //        OnReceivedWaveData(wave);
        //    }
        //}

        //----

    }

    partial class VibrometerDBClassDataContext
    {
    }

    partial class Channel
    {

    }

    partial class TrendConfig
    {
        public virtual TrendData CalTrend(WaveData wave, Spectrum spectrum)
        {
            return new TrendData();
        }
    }

    partial class RmsConfig : TrendConfig
    {

        public override TrendData CalTrend(WaveData wave, Spectrum spectrum)
        {
            
            RmsCalculator peak = new RmsCalculator(name, start, end);
            //TrendData trendData = new TrendData();
            //trendData.trendConfig_Id = base.Id;
            var trendData = peak.GetTrend(wave, spectrum.fft);
            trendData.trendConfig_Id = base.Id;
            return trendData;
        }

    }
    partial class PeakConfig : TrendConfig
    {
        public override TrendData CalTrend(WaveData wave, Spectrum spectrum)
        {
            PeakCalculator peak = new PeakCalculator(name, option);
            //TrendData trendData = new TrendData();
            //trendData.trendConfig_Id = base.Id;
            var trendData = peak.GetTrend(wave, spectrum.fft);
            return trendData;
        }
    }


}