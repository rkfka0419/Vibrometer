namespace _0128_Vibrometer
{
    partial class TrendData
    {
    }

    partial class WaveData_TB : ITrendCalculator
    {
        public float[] Floats;

        partial void OnCreated()
        {
            Floats = new float[data.Length / sizeof(float)];
        }
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
            return new TrendData();
        }

    }
    partial class PeakConfig : TrendConfig
    {
        public override TrendData CalTrend(WaveData wave, Spectrum spectrum)
        {
            return new TrendData();
        }
    }
}