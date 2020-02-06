using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0128_Vibrometer
{
    class RandomTrend : ITrendCalculator
    {

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
        //public float GetRandomValue(float[] data, string option)
        //{
        //    Random rand = new Random();
        //    return rand.Next((int)data.Min(), (int)data.Max());
        //}

    }
}
