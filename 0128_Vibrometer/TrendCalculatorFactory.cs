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
                    return RmsCalculator.Parse(title, option); //new RmsCalculator(title, option);
                case TrendType.random:
                    return new RandomTrend(title);
                default:
                    return null;
            }
        }
    }
}
