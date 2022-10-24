using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyserCustomException : Exception
    {
        //Enum for Exception Type
        public enum ExceptionType
        {
            NULL_MESSAGE_EXCEPTION, EMPTY_MESSAGE_EXCEPTION, NO_SUCH_METHODE, NO_SUCH_CLASS
        }

        private readonly ExceptionType exceptionType;

        public MoodAnalyserCustomException(ExceptionType exceptionType, string exceptionMessage) : base(exceptionMessage)
        {
            this.exceptionType = exceptionType;
        }

    }
}
