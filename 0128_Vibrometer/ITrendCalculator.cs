namespace _0128_Vibrometer
{
    interface ITrendCalculator
    {
        string title { get; set; }
        string option { get; set; }

        TrendData GetTrend(WaveData wave, float[] spectrum);
    }
}
