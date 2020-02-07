using System;
using System.Linq;

namespace _0128_Vibrometer
{
    //WaveCalculator
    class PeakCalculator : ITrendCalculator
    {
        public string title { get ; set; }
        public string option { get; set; }

        //생성자
        public PeakCalculator(string title, string option)
        {
            this.title = title;
            this.option = option;
        }

        public TrendData GetTrend(WaveData wave, float[] spectrum)
        {
            TrendData trendData;
            trendData.Time = DateTime.Now;
            switch (this.option)
            {
                case "p2p":
                    trendData.Value = GetPeakToPeak(wave);
                    break;
                case "upper":
                    trendData.Value = GetUpperPeak(wave);
                    break;
                case "lower":
                    trendData.Value = GetLowerPeak(wave);
                    break;
                case "peak":
                    trendData.Value = GetPeak(wave);
                    break;
                default:
                    throw new Exception("Peak option is unavailable");
            }
            return trendData;
        }

        //public TrendData GetTrend(float[] data)
        //{
        //    TrendData trendData;
        //    trendData.Time = DateTime.Now;
        //    trendData.Value = GetPeakToPeak(data);
        //    return trendData;
        ////}
        //public TrendData GetTrend(float[] data, string option)
        //public TrendData GetTrend(float[] data, string option)
        //{
        //    TrendData trendData;
        //    trendData.Time = DateTime.Now;
        //    Console.WriteLine("Peak option is {0}", this.option);
        //    switch (this.option)
        //    {
        //        case "p2p":
        //            trendData.Value = GetPeakToPeak(data);
        //            break;
        //        case "upper":
        //            trendData.Value = GetUpperPeak(data);
        //            break;
        //        case "lower":
        //            trendData.Value = GetLowerPeak(data);
        //            break;
        //        case "peak":
        //            trendData.Value = GetPeak(data);
        //            break;
        //        default:
        //            throw new Exception("Peak option is unavailable");
        //    }
        //    return trendData;
        //}



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
        public float GetUpperPeak(WaveData wave)
        {
            return GetUpperPeak(wave.Data);
        }
        public float GetLowerPeak(float[] data)
        {
            return data.Min();
        }
        public float GetLowerPeak(WaveData wave)
        {
            return GetLowerPeak(wave.Data);
        }
        public float GetPeak(float[] data)
        {
            float upperPeakScala = data.Max();
            float lowerPeakScala = Math.Abs(data.Min());
            return upperPeakScala > lowerPeakScala == true ? upperPeakScala : lowerPeakScala;
        }
        public float GetPeak(WaveData wave)
        {
            return GetPeak(wave.Data);
        }

    }
}
