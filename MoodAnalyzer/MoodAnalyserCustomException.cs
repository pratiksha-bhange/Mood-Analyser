using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    //Inheriting base Exception Class.
    public class MoodAnalyserCustomException : Exception
    {
        //Enum for Exception Type
        public enum ExceptionType
        {
            NULL_EXCEPTION, EMPTY_EXCEPTION,
            NO_SUCH_CONSTRUCTOR, NO_SUCH_CLASS
        }

        private readonly ExceptionType exceptionType;

        public MoodAnalyserCustomException(ExceptionType exceptionType, string exceptionMessage) : base(exceptionMessage)
        {
            this.exceptionType = exceptionType;
        }
    }
}

