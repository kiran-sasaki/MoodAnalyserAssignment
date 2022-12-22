using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserAssignment
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string MoodAnalyse()
        {
            if (!string.IsNullOrEmpty(message))
            {
                if (message.Contains("Sad") || message.Contains("sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            else
            {
                throw new MoodAnalyserException("Getting null Value");
            }
        }
    }
}
