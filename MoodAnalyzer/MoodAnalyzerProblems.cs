using System;
using System.Collections.Generic;
using System.Text;
using static MoodAnalyzer.MoodAnalyserCustomException;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        //variable
       public  string moodMessage;
        //parameterized constructor
        public MoodAnalyser(string moodMessage)
        {
            this.moodMessage = moodMessage;
        }
        // default contructor
        public MoodAnalyser()
        {

        }
        //Method to return the type of AnalyseMood
        public string AnalyseMood(string moodMessage)
        {
            try
            {
                if (moodMessage == null)
                {
                    throw new MoodAnalyserCustomException(ExceptionType.NULL_EXCEPTION, "Null message passed.");
                }
                if (moodMessage.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(ExceptionType.EMPTY_EXCEPTION, "Empty message passed.");
                }
                if (moodMessage.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}