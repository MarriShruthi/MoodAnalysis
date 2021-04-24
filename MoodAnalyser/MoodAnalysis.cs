﻿using System;
using System.Collections.Generic;
using System.Linq;
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
        public string AnalyzeMood()
        {
                if (this.message.Contains("I am in any mood"))
                {
                    return "HAPPY";
                }
                else
                {
                    return "SAD";
                }
        }
    }
}
