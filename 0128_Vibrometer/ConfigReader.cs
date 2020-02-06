using System;
using System.Collections.Generic;

namespace _0128_Vibrometer
{
    public enum TrendType
    {
        p2p,
        rms,
        random,
        peak,
        upperPeak,
        lowerPeak
    }
    class ConfigReader
    {

        public ConfigReader()
        {
        }
        public List<ConfigData> ReadFile(string path)
        {
            List<ConfigData> configList = new List<ConfigData>();
            string[] configLines = System.IO.File.ReadAllLines(path);
            foreach(var line in configLines)
            {
                configList.Add(ParseLine(line));
            }
            return configList;
        }


        //get field data from single configfile line
        public ConfigData ParseLine(string configLine)
        {
            return ParseLine(configLine.Split(' '));
        }
        public ConfigData ParseLine(string[] tokens)
        {
            ConfigData configData = new ConfigData(); ;
            configData.title = tokens[0];
            string trendTypeString = tokens[1];
            configData.trendType = (TrendType)Enum.Parse(typeof(TrendType), trendTypeString);

            if (tokens.Length > 2)
            {//if range parameter exist;
                configData.optionFlag = true;
                configData.option = tokens[2];
            }
            else
            {
                configData.optionFlag = false;
                configData.option = null;
            }
            return configData;
        }
        //public ConfigData ParseLine(string[] tokens)
        //{
        //    ConfigData configData = new ConfigData(); ;
        //    configData.title = tokens[0];
        //    string trendTypeString = tokens[1];
        //    configData.trendType = (TrendType)Enum.Parse(typeof(TrendType), trendTypeString);

        //    // peak의 종류를 알아내야하는 문제 있음 -> 지금은 Rms의 인덱스 하드코딩
        //    if (tokens.Length > 2)
        //    {//if range parameter exist;
        //        configData.optionFlag = true;
        //        configData.rangeIndex = new int[2];
        //        configData.rangeIndex[0] = Int32.Parse(tokens[2].Split('-')[0]); //start index
        //        configData.rangeIndex[1] = Int32.Parse(tokens[2].Split('-')[1]); // end index
        //    }
        //    else
        //    {
        //        configData.optionFlag = false;
        //        configData.rangeIndex = null;
        //    }
        //    return configData;
        //}
    }
}
