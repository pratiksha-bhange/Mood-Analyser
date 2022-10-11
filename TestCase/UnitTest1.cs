using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace TestCase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void  GivenMood_WhenSad_ShouldReturn_SAD_MOOD()
        {
            {
                //Arrange
                string moodMessage = "I am in Sad Mood";
                MoodAnalyzerProblems moodAnalyzer = new MoodAnalyzer.MoodAnalyzerProblems();

                string expected = "SAD";

                //Act
                string actual = moodAnalyzer.AnalyseMood(moodMessage);

                //Assert
                Assert.AreEqual(expected, actual);
            }

           
        }
        [TestMethod]

        public void GivenMood_WhenHappy_ShouldReturn_HAPPY_MOOD()
        {
            //Arrange
            string moodMessage = "I am in Any Mood";
            MoodAnalyzerProblems moodAnalyzer = new MoodAnalyzer.MoodAnalyzerProblems();
            string expected = "HAPPY";

            //Act
            string actual = moodAnalyzer.AnalyseMood(moodMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
    

