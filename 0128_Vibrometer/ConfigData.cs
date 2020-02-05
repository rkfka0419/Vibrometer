namespace _0128_Vibrometer
{
    public struct ConfigData
    {
        public string title;
        public TrendType trendType;
        public int[] rangeIndex;
        //public RangeIndex rangeIndex;
        public bool optionFlag;
        public string option;
        
    }
    public struct RangeIndex
    {
        int start;
        int end;
    }
}
