using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserAssignment
{
    public class MoodAnalyserException : Exception
    {
        public MoodAnalyserException(string message) : base(message)
        {

        }
    }
}
