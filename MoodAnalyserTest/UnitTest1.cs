using MoodAnalyserAssignment;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string message = MoodAnalyser.MoodAnalyse("Sad");
            Assert.AreEqual(message, "Sad");
        }
    }
}