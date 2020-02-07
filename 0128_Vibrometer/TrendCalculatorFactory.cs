namespace _0128_Vibrometer
{
    class TrendCalculatorFactory
    {
        public ITrendCalculator trendCalculator(string title, string trendType, string option)
        {
                switch (trendType)
            {
                case "peak":
                    return new PeakCalculator(title, option);
                case "rms":
                    return RmsCalculator.Parse(title, option); //new RmsCalculator(title, option);
                case "random":
                    return new RandomTrend(title);
                default:
                    return null;
            }
        }
    }
}
