using System;
using System.Linq;

namespace _0128_Vibrometer
{
    class RandomTrend : ITrendCalculator
    {
        public string title { get; set; }
        public string option { get; set; }

        public RandomTrend() { }
        public RandomTrend(string title)
        {
            this.title = title;
        }
        public RandomTrend(string title, string option)
        {
            this.title = title;
            this.option = option;
        }

        public TrendData GetTrend(WaveData wave, float[] spectrum)
        {
            TrendData trendData;
            trendData.Time = DateTime.Now;
            trendData.Value = new Random().Next((int)wave.Data.Min(), (int)wave.Data.Max());
            return trendData;
        }
        public TrendData GetTrend(float[] data)
        {
            TrendData trendData;
            trendData.Time = DateTime.Now;
            trendData.Value = new Random().Next((int)data.Min(), (int)data.Max());
            return trendData;
        }
    }
}
