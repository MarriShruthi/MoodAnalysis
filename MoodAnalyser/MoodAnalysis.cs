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

        public MoodAnalysis()
        {
        }

        //Parameterized constructor for intialising instance members
        public MoodAnalysis(string message)
        {
            this.message = message;
        }

        //Analyser method to find mood
        public string Analyser(string message)
        {
            try
            {
                if(message.Equals(string.Empty))
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_EXCEPTION, "Mood should not be empty");
                }

                if (this.message.Contains("sad"))
                {
                    return "SAD";
                }
                else
                {//
                    return "HAPPY";
                }
            }
            catch(NullReferenceException )
            {
                //return ex.Message;
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_EXCEPTION, "Mood should not be null");
            }
        }
    }
}
