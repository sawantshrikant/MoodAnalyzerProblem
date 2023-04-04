namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        public string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {
            try
            {
                if (string.IsNullOrEmpty(this.message))
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.EMPTY_MOOD, "message is empty");
                }
                if (message.ToLower().Contains("sad"))
                    return "SAD";
                return "HAPPY";
            }
            catch (Exception)
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NULL_MOOD, "message is null");
            }
        }
    }
}
