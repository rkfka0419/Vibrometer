using System;
using System.Linq;

namespace _0128_Vibrometer
{
    class RandomTrend : ITrendCalculator
    {
        public string title { get; set; }
        public string option { get; set; }

        public RandomTrend(string title)
        {
            this.title = title;
        }
        public RandomTrend(string title, string option)
        {
            this.title = title;
            this.option = option;
        }


        public TrendData GetTrend(WaveData wave, double[] spectrum)
        {
            TrendData trendData;
            trendData.Time = DateTime.Now;
            trendData.Value = GetRandomValue(wave.Data);
            return trendData;
        }

        //public float GetRandomValue(float[] data, string option)
        //{
        //    Random rand = new Random();
        //    return rand.Next((int)data.Min(), (int)data.Max());
        //}

        public TrendData GetTrend(float[] data)
        {
            TrendData trendData;
            trendData.Time = DateTime.Now;
            trendData.Value = GetRandomValue(data);
            return trendData;
        }
        public TrendData GetTrend(float[] data, string option)
        {
            TrendData trendData;
            trendData.Time = DateTime.Now;
            //trendData.Value = GetRandomValue(data, option);
            trendData.Value = GetRandomValue(data);
            return trendData;
        }

        public float GetRandomValue(float[] data)
        {
            Random rand = new Random();
            return rand.Next((int)data.Min(), (int)data.Max());
        }


    }
}
