namespace _0128_Vibrometer
{
    enum TrendType
    {
        p2p,
        rms,
        random,
        peak,
        upperPeak,
        lowerPeak
    }

    class TrendGenerator
    {
        public static void DrawLineByTrendType(TrendDrawer drawLineObject, WaveData wave)
        {
            switch (drawLineObject.GetTrendType())
            {
                case TrendType.p2p:
                    drawLineObject.SetVerticalAxisToRight();
                    drawLineObject.DrawLine(PeakCalculator.GetPeakToPeak(wave));
                    break;
                case TrendType.peak:
                    drawLineObject.SetVerticalAxisToRight();
                    drawLineObject.DrawLine(PeakCalculator.GetPeak(wave.Data));
                    break;
                case TrendType.upperPeak:
                    drawLineObject.SetVerticalAxisToRight();
                    drawLineObject.DrawLine(PeakCalculator.GetUpperPeak(wave.Data));
                    break;
                case TrendType.lowerPeak:
                    drawLineObject.SetVerticalAxisToRight();
                    drawLineObject.DrawLine(PeakCalculator.GetLowerPeak(wave.Data));
                    break;
                case TrendType.rms:
                    if (drawLineObject.GetRangeIndex() != null)
                    {
                        int[] range = drawLineObject.GetRangeIndex();
                        drawLineObject.DrawLine(RmsCalculator.GetRMS(FFTCalculator.GetFFT(wave), range[0], range[1]));
                    }
                    else
                        drawLineObject.DrawLine(RmsCalculator.GetRMS(FFTCalculator.GetFFT(wave)));
                    break;
                case TrendType.random:
                    drawLineObject.SetVerticalAxisToRight();
                    drawLineObject.DrawLine(RandomTrend.GetRandomValue(wave.Data));
                    break;
                default:
                    break;
            }
        }
    }
}
