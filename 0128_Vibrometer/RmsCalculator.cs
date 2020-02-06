using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0128_Vibrometer
{
    //SpectrumCalculator
    class RmsCalculator : ITrendCalculator
    {
        public TrendData GetTrend(float[] data)
        {
            TrendData trendData;
            trendData.Time = DateTime.Now;
            trendData.Value = GetRMS(data);
            return trendData;
        }
        public TrendData GetTrend(float[] data, string option)
        {
            TrendData trendData;
            trendData.Time = DateTime.Now;

            //int[] token = Array.ConvertAll(option.Split('-'), delegate (string s) { return int.Parse(s); });
            //var token = Array.ConvertAll(option.Split('-'), int.Parse);
            var token = option.Split('-').Select(int.Parse).ToArray();
            trendData.Value = GetRMS(data, token[0], token[1]);

            return trendData;
        }
        

        // Get RMS 
        public float GetRMS(float[] data)
        {
            double square = 0;
            float mean, root = 0;
            //float[] fft

            for (int i = 0; i < data.Length; i++)
            {
                square += (data[i] * data[i]);
            }
            mean = (float)square / data.Length;
            root = (float)Math.Sqrt(mean);
            return root;
        }
        public float GetRMS(WaveData wave)
        {
            return GetRMS(wave.Data);
        }
        // Get RMS with Bandwidth
        public float GetRMS(float[] data, int start, int end)
        {
            double square = 0;
            float mean, root = 0;

            for (int i = start; i < end; i++)
            {
                square += (data[i] * data[i]);
            }
            mean = (float)square / data.Length;
            root = (float)Math.Sqrt(mean);
            return root;

        }
        public float GetRMS(WaveData wave, int start, int end) 
        {
            return GetRMS(wave.Data, start, end);
        }

    }
}
