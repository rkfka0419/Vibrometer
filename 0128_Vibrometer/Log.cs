using System;

namespace _0128_Vibrometer
{
    class Log
    {
        public static void Logging(String summary = "")
        {
            //System.Diagnostics.Trace.WriteLine(System.DateTime.Now.ToString() + "UpdataChart");
            Console.WriteLine(
                summary +
                  System.DateTime.Now.TimeOfDay.Minutes.ToString() + ":"
                + System.DateTime.Now.TimeOfDay.Seconds.ToString() + "."
                + System.DateTime.Now.TimeOfDay.Milliseconds.ToString()
                + "\tUpdataChart");
        }
    }
}
