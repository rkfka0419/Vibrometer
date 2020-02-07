using System;
using System.Linq;

namespace _0128_Vibrometer
{
    //SpectrumCalculator
    class RmsCalculator : ITrendCalculator
    {
        public string title { get; set; }
        public string option { get; set; }
        int start, end;
        //생성자
       public RmsCalculator(string title, int start, int end)
        {
            this.title = title;
            this.start = start;
            this.end = end;
        }
       

        //파싱한 후 옵션을 제대로 가지게 하고 새로운 인스턴스 리턴
        public static RmsCalculator Parse(string title, string line)
        {
            var token = line.Split('-').Select(int.Parse).ToArray();
            return new RmsCalculator(title, token[0], token[1]);
        }

        //Get Rms with Option
        public TrendData GetTrend(WaveData wave, float[] spectrum)
        {
            double square = 0;
            float mean, root = 0;

            for (int i = start; i < end; i++)
            {
                square += (wave.Data[i] * wave.Data[i]);
            }
            mean = (float)square / wave.Data.Length;
            root = (float)Math.Sqrt(mean);

            TrendData trendData;
            trendData.Value = root;
            trendData.Time = DateTime.Now;
            return trendData;
        }

    }
}
