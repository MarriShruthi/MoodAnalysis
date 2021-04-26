using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyser;

namespace MSTestforMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        //TC 1.1
        /// Test for happy mood
        [TestMethod]
        public void Given_NullMood_Using_CustomException_Return_Null()
        {
            //Arrange
            MoodAnalysis moodAnalysis = new MoodAnalysis(null);
            
            string expected = "Mood should not be null";
            try
            {
                //Act
               string actual = moodAnalysis.AnalyzerMethod();
            }
            catch (MoodAnalyserException exception)
            {
                //Assert
                Assert.AreEqual(expected, exception.Message);
            }
        }
    }
}


