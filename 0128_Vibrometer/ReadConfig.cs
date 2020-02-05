namespace _0128_Vibrometer
{
    class ConfigReader
    {
        private string[] configfile;

        public ConfigReader()
        {
        }
        public void ReadFile(string path)
        {
            this.configfile = System.IO.File.ReadAllLines(path);
        }
        public string[] GetConfigFileLines()
        {
            return this.configfile;
        }
    }
}
