﻿using System;
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
