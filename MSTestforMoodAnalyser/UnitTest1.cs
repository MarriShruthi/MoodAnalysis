using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyser;

namespace MSTestforMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_HappyMood_Expecting_HappyResult()
        {
            //Arrange
            MoodAnalysis moodAnalysis = new MoodAnalysis("I am in happy mood");
            
            string expected = "happy";

            //Act
            string actual = moodAnalysis.AnalyzerMethod();

            //Assert
            Assert.AreEqual(expected, actual);
            
        }
    }
}


