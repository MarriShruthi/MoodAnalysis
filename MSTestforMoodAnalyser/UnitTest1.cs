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
        public void GivenSadMood_ShouldReturnSAD()
        {
            //Arrange
            MoodAnalysis moodAnalysis = new MoodAnalysis("I am in sad mood");

            //Act
            string mood = moodAnalysis.AnalyzeMood();

            //Assert
            Assert.AreEqual("SAD", mood);
        }
    }
}


