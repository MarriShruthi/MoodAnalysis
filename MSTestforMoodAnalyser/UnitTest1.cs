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
        public void GivenAnyMood_ShouldReturnHAPPY()
        {
            //Arrange
            MoodAnalysis moodAnalysis = new MoodAnalysis("I am in any mood");

            //Act
            string mood = moodAnalysis.AnalyzeMood();

            //Assert
            Assert.AreEqual("HAPPY", mood);
        }
    }
}


