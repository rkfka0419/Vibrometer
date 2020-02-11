using System;

namespace _0128_Vibrometer
{
    public class WaveData
    {
        public int channel { get; set; }
        private int samplerate = 0;
        public float[] Data { get; set; }

        public WaveData()
        {// Accord 라이브러리의 FFT에서 지원하는 최대 2의배수
            this.samplerate = (int)Math.Pow(2, 14);
        }
        public WaveData(int sample_rate)
        {
            this.samplerate = sample_rate;
        }
    }
}
