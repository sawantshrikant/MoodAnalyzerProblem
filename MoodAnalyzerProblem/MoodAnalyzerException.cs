using System;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzerException : Exception
    {
        public enum ExceptionType
        {
            NULL_MOOD,
            EMPTY_MOOD
        }

        public ExceptionType exceptionType;

        public MoodAnalyzerException(ExceptionType exceptionType, string message)
            : base(message)
        {
            this.exceptionType = exceptionType;
        }
    }
}
