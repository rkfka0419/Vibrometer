using System;
using System.Linq;

namespace _0128_Vibrometer
{
    //WaveCalculator
    class PeakCalculator : ITrendCalculator
    {
        public TrendData GetTrend(float[] data)
        {
            TrendData trendData;
            trendData.Time = DateTime.Now;
            trendData.Value = GetPeakToPeak(data);
            return trendData;
        }
        public TrendData GetTrend(float[] data, string option)
        {
            TrendData trendData;
            trendData.Time = DateTime.Now;
            switch (option)
            {
                case "p2p":
                    trendData.Value = GetPeakToPeak(data);
                    break;
                case "upper":
                    trendData.Value = GetUpperPeak(data);
                    break;
                case "lower":
                    trendData.Value = GetLowerPeak(data);
                    break;
                case "peak":
                    trendData.Value = GetPeak(data);
                    break;
                default:
                    throw new Exception("Peak option is unavailable");
            }
            return trendData;
        }



        //Get P2P
        public float GetPeakToPeak(float[] data)
        {
            float p2p;
            p2p = data.Max() - data.Min();
            return p2p;
        }
        public float GetPeakToPeak(WaveData wave)
        {
            return GetPeakToPeak(wave.Data);
        }
        //Get Peak
        public float GetUpperPeak(float[] data)
        {
            return data.Max();
        }
        public float GetLowerPeak(float[] data)
        {
            return data.Min();
        }
        public float GetPeak(float[] data)
        {
            float upperPeakScala = data.Max();
            float lowerPeakScala = Math.Abs(data.Min());
            return upperPeakScala > lowerPeakScala == true ? upperPeakScala : lowerPeakScala;
        }



    }
}
