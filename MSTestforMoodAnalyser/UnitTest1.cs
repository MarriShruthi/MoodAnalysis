using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyser;

namespace MSTestforMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_nullMood_Expecting_Exception_Result()
        {
            //Arrange
            MoodAnalysis moodAnalysis = new MoodAnalysis(null);
            string expected = "Object reference not set to an instance of an object.";

            //Act
            string actual = moodAnalysis.AnalyzerMethod();

            //Assert
            Assert.AreEqual(expected, actual);
            
        }
    }
}


