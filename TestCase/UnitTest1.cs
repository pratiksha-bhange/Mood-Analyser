using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace TestCase
{

    [TestClass]
    public class UnitTest1
    {
<<<<<<< HEAD
        [TestMethod]
=======
        [TestMethod]  //UC 1.1
>>>>>>> UC3-CustomExceptions
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

<<<<<<< HEAD
        [TestMethod]
=======
        [TestMethod]  //UC 1.2
>>>>>>> UC3-CustomExceptions
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

<<<<<<< HEAD
        [TestMethod]
        public void GivenMood_WhenNull_ShouldReturn_HAPPY_MOOD()
=======
        [TestMethod]   //UC 3.1
        public void GivenMood_WhenNull_ShouldReturn_Null_MOOD_EXCEPTION_MESSAGE()
>>>>>>> UC3-CustomExceptions
        {
            //Arrange
            string moodMessage = null;
            MoodAnalyzerProblems moodAnalyser = new MoodAnalyzerProblems();
<<<<<<< HEAD
            string expected = "HAPPY";
=======
            string expected = "Null message passed.";

            //Act
            string actual = moodAnalyser.AnalyseMood(moodMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]    //UC 3.2
        public void GivenMood_WhenEmpty_ShouldReturn_EMPTY_MOOD_EXCEPTION_MESSAGE()
        {
            //Arrange
            string moodMessage = string.Empty;
            MoodAnalyzerProblems moodAnalyser = new MoodAnalyzerProblems();
            string expected = "Empty message passed.";
>>>>>>> UC3-CustomExceptions

            //Act
            string actual = moodAnalyser.AnalyseMood(moodMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}



