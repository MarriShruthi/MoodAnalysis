using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyser;

namespace MSTestforMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {/// <summary>
     /// UC4.1 Expected to return the MoodAnalyser Object by creating object using MoodAnalyserFactory
     /// </summary>
     ///  Given_MoodAnalyser Class Name Should Return MoodAnalyser Object()
       [TestMethod]
        public void Given_MoodAnalyser_ClassName_ShouldReturn_MoodAnalyseObject()
        {
            object expected = new MoodAnalysis();
            object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserProblem.Class", "MoodAnalyser");
            expected.Equals(obj);
       }

        /// <summary>
        ///TC4.2 Class Name When Improper Should Throw MoodAnalysisException
        /// </summary>
        public void GivenInvalidClassName_ShouldThrow_MoodAnalyserException()
        {
            string expected = "Class not Found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserProblem.Class", "MoodAnalyser");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }
        /// <summary>
        /// TC4.3Given Class When Constructor Not Proper Should Throw MoodAnalysisException
        /// </summary>
        public void GivenClass_WhenNotProper_Constructor_ShouldThrow_MoodAnalyserException()
        {
            string expected = "Constructor is not Found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalysisProblem.MoodAnalyser", "sampleClass");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }
    }
}


