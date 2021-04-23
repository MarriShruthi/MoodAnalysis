using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyser;

namespace MSTestforMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMood_ShouldReturnSAD()
        {
            //Arrange
            MoodAnalysis moodAnalysis = new MoodAnalysis("I am in sad mood");
            //Act
            string mood = moodAnalysis.AnalyzeMood();
            //Assert
            Assert.AreEqual("SAD", mood);
        }

        /// Test for happy mood
        [TestMethod]
        public void GivenHappyMood_ShouldReturnHAPPY()
        {
            //Arrange
            MoodAnalysis moodAnalyser = new MoodAnalysis("I am in any mood");
            //Act
            string mood = moodAnalyser.AnalyzeMood();
            //Assert
            Assert.AreEqual("HAPPY", mood);
        }
    }
}
