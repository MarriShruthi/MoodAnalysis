using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyser;

namespace MSTestforMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenHappyMood_ShouldReturnHAPPY()
        {
            //Arrange
            MoodAnalysis moodAnalysis = new MoodAnalysis("I am in happy mood");

            //Act
            string mood = moodAnalysis.AnalyzeMood();

            //Assert
            Assert.AreEqual("HAPPY", mood);
        }

        //UC 2
        /// Test for happy mood
        [TestMethod]
        public void Given_nullMood_Expecting_Exception_Result()
        {
            //Arrange
            MoodAnalysis moodAnalyser = new MoodAnalysis(null);
            string expected = "Object reference not set to an instance of an object.";

            //Act
            string mood = moodAnalyser.AnalyzeMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
    }
}

