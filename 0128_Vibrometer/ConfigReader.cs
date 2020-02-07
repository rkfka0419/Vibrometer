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
            configData.trendType = tokens[1];

            if (tokens.Length > 2)
            {//if range parameter exist;
                configData.option = tokens[2];
            }
            else
            {
                configData.option = null;
            }
            return configData;
        }
    }
}
