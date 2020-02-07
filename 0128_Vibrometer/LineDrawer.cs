using System;
using Steema.TeeChart;
using Steema.TeeChart.Styles;

namespace _0128_Vibrometer
{
    class LineDrawer
    {
        private Line line;
        private string title;
        private string trendType;
        private string option;

        //이미 디자이너폼에서 만들어진 라인 매개변수 받음
        public LineDrawer()
        {
            this.line = null;
        }
        public LineDrawer(Line line)
        {// 디자이너 폼에서 생성해서 이미 전역변수에 존재함, 붙이기만 함
            this.line = line;
        }

        //코드로 생성한 라인 매개변수 처리. tchart에 붙여야 하기 때문에  해당 변수 필요
        public LineDrawer(TChart tChart, Line line)
        {//새로 생성할때. tchart에 같이 붙여야 함 
            tChart.Series.Add(line);
            this.line = line;
        }
        public LineDrawer(TChart tChart)
        {//새로 생성할때. tchart에 같이 붙여야 함 
            Line line = new Line();
            tChart.Series.Add(line);
            this.line = line;
        }
        

        // getter, setter
        public void SetLine(Line line)
        {
            this.line = line;
        }
        public void SetLine(TChart tChart ,Line line)
        {
            tChart.Series.Add(line);

            this.line = line;
        }
        public Line GetLine()
        {

            return this.line;
        }
        public void SetTitle(String title)
        {
            line.Title = title;
        }
        public string GetTitle()
        {
            return this.title;
        }
        public void SetTrendType(string trendType)
        {
            this.trendType = trendType;
        }
        public string GetTrendType()
        {
            return this.trendType;
        }

        //get field data from single configfile line
        public void SetConfiguration(ConfigData configData)
        {

            this.title = configData.title;
            this.line.Title = this.title;
            this.trendType = configData.trendType;
            this.option = configData.option;
        }
        //public void SetConfiguration(ConfigData configData)
        //{

        //    this.title = configData.title;
        //    this.line.Title = this.title;
        //    this.trendType = configData.trendType;
        //    if (configData.optionFlag == true)
        //        this.rangeIndex = configData.rangeIndex;
        //    else
        //        this.rangeIndex = null;
        //}

        //라인 그리는 메소드

        public void DrawLine(float[] data, bool isClear = false)
        {
            //Draw wave Graph
            if (isClear == true)
            {
                line.Clear();
            }
            line.Add(data);
        }
        public void DrawLine(WaveData wave, bool isClear = false)
        {
            //Draw wave Graph
            DrawLine(wave.Data, isClear);
        }
        public void DrawLine(float point, bool isClear = false)
        {
            if (isClear == true)
            {
                line.Clear();
            }
            line.Add(point);
        }

        //Set Line Vertical Axie. Default is Left(false)
        public void SetVerticalAxisToRight(bool isRight = true)
        {
            line.VertAxis = isRight == true ? VerticalAxis.Right : VerticalAxis.Left;
        }
    }
}
