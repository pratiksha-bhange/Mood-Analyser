using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace TestCase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMood_WhenSad_ShouldReturn_SAD_MOOD()
        {
            //Arrange
            string moodMessage = "I am in Sad Mood";
            MoodAnalyzerProblems moodAnalyser = new MoodAnalyzerProblems();
            string expected = "SAD";

            //Act
            string actual = moodAnalyser.AnalyseMood(moodMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenMood_WhenHappy_ShouldReturn_HAPPY_MOOD()
        {
            //Arrange
            string moodMessage = "I am in Any Mood";
            MoodAnalyzerProblems moodAnalyser = new MoodAnalyzerProblems();
            string expected = "HAPPY";

            //Act
            string actual = moodAnalyser.AnalyseMood(moodMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenMood_WhenNull_ShouldReturn_Null_MOOD_EXCEPTION_MESSAGE()
        {
            //Arrange
            string moodMessage = null;
            MoodAnalyzerProblems moodAnalyser = new MoodAnalyzerProblems();
            string expected = "Null message passed.";

            //Act
            string actual = moodAnalyser.AnalyseMood(moodMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenMood_WhenEmpty_ShouldReturn_EMPTY_MOOD_EXCEPTION_MESSAGE()
        {
            //Arrange
            string moodMessage = string.Empty;
            MoodAnalyzerProblems moodAnalyser = new MoodAnalyzerProblems();
            string expected = "Empty message passed.";

            //Act
            string actual = moodAnalyser.AnalyseMood(moodMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenMoodAnalyserClassName_ShouldReturns_MoodAnalyserObject()
        {
            object expected = new MoodAnalyzerProblems();
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("Mood_Analyser_Problems.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }
        [TestMethod]
        public void GivenImproperClassName_Shouldthrow_MoodAnalysisException()
        {
            string expected = "Class Not Found";
            try
            {
                MoodAnalyzerProblems moodAnalyser = new MoodAnalyzerProblems();
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("Mood_Analyser.MoodAnalyser", "MoodAnalyser");
            }
            catch (MoodAnalyserCustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        public void GivenImproperConstructor_Shouldthrow_MoodAnalysisException()
        {
            string expected = "Constructor is Not Found";
            try
            {
                MoodAnalyzerProblems moodAnalyser = new MoodAnalyzerProblems();
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("Mood_Analyser_Problems.MoodAnalyser", "MoodAnalysers");
            }
            catch (MoodAnalyserCustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}
    




    