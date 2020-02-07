using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace _0128_Vibrometer
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //var calculators = new ITrendCalculator[]
            //{
            //    new RmsCalculator("RMS1", 10, 500),
            //    new RmsCalculator("RMS2", 500,1000),
            //    new RmsCalculator("RMS3", 1000, 2000),
            //    new RmsCalculator("RMS4", 2000, 4000),
            //    new PeakCalculator("Peak1", "p2p"),
            //    new PeakCalculator("Peak2", "lower"),
            //    new RandomTrend("Random", "random"),
            //};


            //var setting = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };
            //var jsonStr = JsonConvert.SerializeObject(calculators, Newtonsoft.Json.Formatting.Indented, setting);
            ////Console.WriteLine(jsonStr);
            //File.WriteAllText("config.json", jsonStr);

            //var calc = JsonConvert.DeserializeObject<ITrendCalculator[]>(File.ReadAllText("config.json"), setting);



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
