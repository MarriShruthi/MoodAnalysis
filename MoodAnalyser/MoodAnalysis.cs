using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalysis
    {
        //instance variables
        string message;

        //Parameterized constructor for intialising instance members
        public MoodAnalysis(string message)
        {
            this.message = message;
        }

        //Analyser method to find mood
        public string AnalyzerMethod()
        {
           if (this.message.ToLower().Contains("happy"))
           {
               return "happy";
           }
           else
           {
               return "sad";
           }
        }
    }
}
