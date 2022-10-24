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
            NO_SUCH_METHOD, NO_SUCH_CLASS,
            NO_SUCH_METHOD_ERROR
        }

        private readonly ExceptionType exceptionType;
        //Exception Constructor.
        public MoodAnalyserCustomException(ExceptionType exceptionType, string exceptionMessage) : base(exceptionMessage)
        {
            this.exceptionType = exceptionType;
        }
    }
}

