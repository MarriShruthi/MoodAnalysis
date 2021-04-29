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
        string message;

        /// <summary>
        /// parameterless constructor
        /// </summary>
        public MoodAnalysis()
        {
        }

        /// <summary>
        /// Parameterised constructor for initializing instance member
        /// </summary>
        public MoodAnalysis(string message)
        {
            this.message = message;
        }


        ///Analyser method to find mood        
        public string Analyser(string message)
        {
            try
            {
                if (message.Equals(string.Empty))
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_EXCEPTION, "Mood should not be EMPTY");
                }
                if (this.message.Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_EXCEPTION, "Mood should not be NULL");
            }
        }

    }
}