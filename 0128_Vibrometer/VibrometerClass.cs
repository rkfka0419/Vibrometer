namespace _0128_Vibrometer
{
    partial class channel
    {
    }

    partial class trend_data
    {
    }

    partial class TrendConfig
    {
        public virtual TrendData CalTrend(WaveData wave, Spectrum spectrum)
        {
            return new TrendData();
        }
    }

    partial class RmsConfig
    {
        public override TrendData CalTrend(WaveData wave, Spectrum spectrum)
        {
            return new TrendData();
        }

        partial class PeakConfig : TrendConfig
        {
            public override TrendData CalTrend(WaveData wave, Spectrum spectrum)
            {
                return new TrendData();
            }
        }
    }
}