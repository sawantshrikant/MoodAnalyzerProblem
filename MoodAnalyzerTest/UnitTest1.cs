namespace MoodAnalyzerTest
{
    public class Tests
    {
        [Test]
        public void GivenSadMood_WhenAnalyze_ShouldReturnSad()
        {
            string message = "I am in sad mood";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            string res = moodAnalyzer.AnalyzeMood();
            Assert.AreEqual("SAD", res);
        }
        [Test]
        public void GivenAnyMood_WhenAnalyze_ShouldReturnHappy()
        {
            string message = "I am in good mood";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            string res = moodAnalyzer.AnalyzeMood();
            Assert.AreEqual("HAPPY", res);
        }
    }
}