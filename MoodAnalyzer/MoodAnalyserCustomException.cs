﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    //Inheriting base Exception Class.
    public class MoodAnalyserCustomException : Exception
    {
        //Enum for Exception Type
        public ExceptionType type;
        //Enumeration
        public enum ExceptionType
        {
            NULL_EXCEPTION,
            EMPTY_EXCEPTION,
            NO_SUCH_CLASS,
            NO_SUCH_CONSTRUCTOR
        }
        //Exception Constructor.
        public MoodAnalyserCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}