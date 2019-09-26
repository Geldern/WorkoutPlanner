using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerUI
{
    public class FormEditor
    {
        public static string DisplayStopwatchTime(int aStopwatchCounter)
        {
            int stopwatchTime = aStopwatchCounter;
            string output;

            if (stopwatchTime < 10)
            {
                output = $"00:0{stopwatchTime}";
            }
            else if (stopwatchTime < 60)
            {
                output = $"00:{stopwatchTime}";
            }
            else if (stopwatchTime / 60 < 10)
            {
                if (stopwatchTime % 60 < 10)
                {
                    output = $"0{stopwatchTime / 60}:0{stopwatchTime % 60}";
                }
                else
                {
                    output = $"0{stopwatchTime / 60}:{stopwatchTime % 60}";
                }
            }
            else
            {
                if (stopwatchTime % 60 < 10)
                {
                    output = $"{stopwatchTime / 60}:0{stopwatchTime % 60}";
                }
                else
                {
                    output = $"{stopwatchTime / 60}:{stopwatchTime % 60}";
                }
            }

            return output;
        }
    }
}
