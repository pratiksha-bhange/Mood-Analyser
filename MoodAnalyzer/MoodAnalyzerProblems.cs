using System;
using System.Collections.Generic;
using System.Text;
using static MoodAnalyzer.MoodAnalyserCustomException;

namespace MoodAnalyzer
{
    public class MoodAnalyserProblems
    {
        //variable
        public string message;

        // default contructor

        public MoodAnalyserProblems()
        {

        }

        public class MoodAnalyzerProblems
        {
            //parameterized constructor
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
}

        
    
