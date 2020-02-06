namespace _0128_Vibrometer
{
    class TrendCalculatorFactory
    {
        public ITrendCalculator trendCalculator(string title, TrendType trendType, string option)
        {
                switch (trendType)
            {
                case TrendType.p2p:
                    return new PeakCalculator(title, option);
                case TrendType.rms:
                    내부 파서에서 새로운 인스턴스가 어차피 리턴되기 때문에 스태틱 ㅁ메소드에 옵션만 집어넣으면 됨
                    return RmsCalculator.Parse(); //new RmsCalculator(title, option);
                case TrendType.random:
                    return new RandomTrend(title);
                default:
                    return null;
            }
        }
    }
}
