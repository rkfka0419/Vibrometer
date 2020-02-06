namespace _0128_Vibrometer
{
    interface ITrendCalculator
    {
        string title { get; set; }
        string option { get; set; }

        TrendData GetTrend(float[] data);
        TrendData GetTrend(float[] data, string option);

        TrendData GetTrend(WaveData wave, double[] spectrum);
        // 옵션을 없애보자.
        //인터페이스 멤버변수르 title을 받으면됨
        //메인폼에서 인터페이스 배열을 받아서 생성자로 타이틀, rms타입, 옵션 받으면 됨...

        // 1.기존 rms타입처럼 인덱스로 제어
        //TrendData GetTrend(float[] data, int start, int end);

        // 2.Peak의 매개변수를 받아서 어떤 함수를 그릴지 제어

        //
    }
}
