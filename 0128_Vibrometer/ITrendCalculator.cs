namespace _0128_Vibrometer
{
    interface ITrendCalculator
    {
        TrendData GetTrend(float[] data);
        TrendData GetTrend(float[] data, string option);


        // 1.기존 rms타입처럼 인덱스로 제어
        //TrendData GetTrend(float[] data, int start, int end);

        // 2.Peak의 매개변수를 받아서 어떤 함수를 그릴지 제어

        //
    }
}
