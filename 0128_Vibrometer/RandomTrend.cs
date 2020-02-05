using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0128_Vibrometer
{
    class RandomTrend : Trend
    {
        
        public RandomTrend(float[] data)
        {
            this.value = GetRandomValue(data);
        }

        //public override void GetValue(float[] data)
        //{
        //    this.value = GetRandomValue(data);
        //}

        public float GetRandomValue(float[] data)
        {
            Random rand = new Random();
            return rand.Next((int)data.Min(), (int)data.Max());
        }

    }
}
