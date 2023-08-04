using System.Linq.Expressions;
using System.Net;

namespace MoodAnaliser
{
    public class MoodAnalyser
    {
        string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {

            if (message.Contains("Sad"))
                return "SAD";
            return "HAPPY";

        }
    }
}