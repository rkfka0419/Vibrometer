namespace _0128_Vibrometer
{
    enum TrendType
    {
        p2p,
        rms,
        random,
        //peak,
        //upperPeak,
        //lowerPeak
    }

    class TrendGenerator
    {
        //public static LineDraw GetTrendFromConfig(TChart tchart, string configString, )
        //{
        //    LineDraw lineConfig = new LineDraw(tchart, new Steema.TeeChart.Styles.Line());
            
        //    lineConfig.SetTitle(title);

        //    TrendType trendType = (TrendType)Enum.Parse(typeof(TrendType), trendTypeString);
        //    switch (trendType)
        //    {
        //        case TrendType.pear2Peak:
        //            lineConfig.DrawLine(PeakCalculator.GetPeakToPeak(wave));
        //            break;
        //        case TrendType.upperPeak:
        //            lineConfig.DrawLine(PeakCalculator.GetUpperPeak(wave.Data));
        //            break;
        //        case TrendType.lowerPeak:
        //            lineConfig.DrawLine(PeakCalculator.GetLowerPeak(wave.Data));
        //            break;
        //        case TrendType.rms:
        //            lineConfig.DrawLine(RmsCalculator.GetRMS(FFTCalculator.GetFFT(wave)));
        //            break;
        //        case TrendType.random:
        //            lineConfig.DrawLine(RandomTrend.GetRandomValue(wave.Data));
        //            break;
        //        default:
        //            break;
        //    }
        //    return lineConfig;
        //}

        //public static void DrawLineByTrendType(LineDraw drawLineObject, string[] configString, WaveData wave)
        //{
        //    string title = configString[0];
        //    string trendTypeString = configString[1];
        //    int start = 0;
        //    int end = 0;
        //    if (configString.Length == 3)
        //    {
        //        start = Int32.Parse(configString[2].Split('-')[0]);
        //        end = Int32.Parse(configString[2].Split('-')[1]);
        //    }
        //    drawLineObject.SetTitle(title);
            
        //    TrendType trendType = (TrendType)Enum.Parse(typeof(TrendType), trendTypeString);

        //    switch (trendType)
        //    {
        //        case TrendType.p2p:
        //            drawLineObject.SetVerticalAxisToRight();
        //            drawLineObject.DrawLine(PeakCalculator.GetPeakToPeak(wave));
        //            break;
        //        case TrendType.peak:
        //            drawLineObject.SetVerticalAxisToRight();
        //            drawLineObject.DrawLine(PeakCalculator.GetPeak(wave.Data));
        //            break;
        //        case TrendType.upperPeak:
        //            drawLineObject.SetVerticalAxisToRight();
        //            drawLineObject.DrawLine(PeakCalculator.GetUpperPeak(wave.Data));
        //            break;
        //        case TrendType.lowerPeak:
        //            drawLineObject.SetVerticalAxisToRight();
        //            drawLineObject.DrawLine(PeakCalculator.GetLowerPeak(wave.Data));
        //            break;
        //        case TrendType.rms:
        //            if (configString.Length == 3)
        //                drawLineObject.DrawLine(RmsCalculator.GetRMS(FFTCalculator.GetFFT(wave), start, end));
        //            else
        //                drawLineObject.DrawLine(RmsCalculator.GetRMS(FFTCalculator.GetFFT(wave)));
        //            break;
        //        case TrendType.random:
        //            drawLineObject.SetVerticalAxisToRight();
        //            drawLineObject.DrawLine(RandomTrend.GetRandomValue(wave.Data));
        //            break;
        //        default:
        //            break;
        //    }
        //}
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
