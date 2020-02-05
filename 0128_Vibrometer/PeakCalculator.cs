using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0128_Vibrometer
{
    //WaveCalculator
    class PeakCalculator : Trend
    {

        public PeakCalculator(float[] data)
        {
            this.value = GetPeakToPeak(data);
        }

        //Get P2P
        public float GetPeakToPeak(float[] data)
        {
            float p2p;
            p2p = data.Max() - data.Min();
            return p2p;
        }
        public static float GetPeakToPeak(WaveData wave)
        {
            return GetPeakToPeak(wave.Data);
        }
        //Get Peak
        public static float GetUpperPeak(float[] data)
        {
            return data.Max();
        }
        public static float GetLowerPeak(float[] data)
        {
            return data.Min();
        }
        public static float GetPeak(float[] data)
        {
            float upperPeakScala = data.Max();
            float lowerPeakScala = Math.Abs(data.Min());
            return upperPeakScala > lowerPeakScala == true ? upperPeakScala : lowerPeakScala;
        }

    }
}
