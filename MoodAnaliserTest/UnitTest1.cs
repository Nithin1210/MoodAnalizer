using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using MoodAnaliser;

namespace MoodAnaliserTest
{
    public class Tests
    {

        [Test]
        public void GivenSadMessage_whenAnalyser_ShouldReturnSad()
        {
            string message = "I am in Sad mood";
            MoodAnalyser analyser = new MoodAnalyser(message);
            string actual = analyser.AnalyseMood();
            Assert.AreEqual(actual,"SAD");
        }

        [Test]
        public void GivenAnyMessage_whenAnalyser_ShouldReturnHappy()
        {
            string message = "I am in normal mood";
            MoodAnalyser analyser = new MoodAnalyser(message);
            string actual = analyser.AnalyseMood();
            Assert.AreEqual(actual, "HAPPY");

        }

    }
}