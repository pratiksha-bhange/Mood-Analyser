using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
   public class MoodAnalyzerProblems
    {
        public string AnalyseMood(string moodMessage)
        {
            if (moodMessage.ToLower().Contains("sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
    

