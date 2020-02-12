using System;
using System.Numerics;
namespace _0128_Vibrometer
{
    public class Spectrum
    {
        public float[] fft { get; set; }
        
        public void GetFFT(WaveData wave, bool isPositiveFFT = true)
        {
            int arrayLength = wave.data.Length / 2;
            if (isPositiveFFT == false)
                arrayLength *= 2;

            WaveData waveFFT = new WaveData();

            waveFFT.data = new float[arrayLength];
            //float[] fft = new float[data.Length]; // this is where we will store the output (fft)
            Complex[] fftComplex = new Complex[wave.data.Length]; // the FFT function requires complex format
            for (int i = 0; i < arrayLength; i++)
            {
                fftComplex[i] = new Complex(wave.data[i], 0.0); // make it complex format (imaginary = 0)
            }
            Accord.Math.FourierTransform.FFT(fftComplex, Accord.Math.FourierTransform.Direction.Forward);
            for (int i = 0; i < arrayLength; i++)
            {
                waveFFT.data[i] = (float)fftComplex[i].Magnitude; // back to double
                if (isPositiveFFT == true)
                    waveFFT.data[i] *= 2;
            }
            this.fft = waveFFT.data;
        }
        
        public static float[] FFTToDecibel(float[] fft)
        {
            float[] data = new float[fft.Length];
            for (int i = 0; i < fft.Length; i++)
            {
                data[i] = (float)Math.Log10(fft[i]); // convert to dB
            }
            return data;
        }
    }
}
