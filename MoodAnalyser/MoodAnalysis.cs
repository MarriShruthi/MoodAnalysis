using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalysis
    {
        string message;
        public MoodAnalysis(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {
            if (this.message.Contains("I am in sad mood"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
