using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzerException : Exception
    {
        public enum ExceptionType
        {
            NULL_MOOD
        }
        public ExceptionType exceptionType;
        public MoodAnalyzerException(ExceptionType exceptionType, string message) : base(message)
        {
            this.exceptionType = exceptionType;
        }
    }
}
    