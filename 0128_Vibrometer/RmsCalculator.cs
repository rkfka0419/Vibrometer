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
        public string title { get; set; }
        public string option { get; set; }
        int start, end;
        //생성자
        private RmsCalculator(string title, string option)
        {
            this.title = title;
            this.option = option;
        }
        
        //파싱한 후 옵션을 제대로 가지게 하고 새로운 인스턴스 리턴
        public static RmsCalculator Parse(string line)
        {
            return new RmsCalculator();
        }

        //Get Rms with Option
        public TrendData GetTrend(WaveData wave, double[] spectrum)
        {
            TrendData trendData;
            var token = this.option.Split('-').Select(int.Parse).ToArray();
            trendData.Value = GetRMS(spectrum, token[0], token[1]);
            trendData.Time = DateTime.Now;

            return trendData;
        }
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
        public float GetRMS(double[] data)
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
        public float GetRMS(double[] data, int start, int end)
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
