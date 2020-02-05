namespace _0128_Vibrometer
{
    class TrendCalculatorFactory
    {
        public ITrendCalculator trendCalculator(TrendType trendType)
        {
                switch (trendType)
            {
                case TrendType.p2p:
                    return new PeakCalculator();
                case TrendType.random:
                    return new RandomTrend();
                case TrendType.rms:
                    return new RmsCalculator();
                default:
                    return null;
            }
        }
    }
}
