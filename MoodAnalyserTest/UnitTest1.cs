using MoodAnalyserAssignment;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //UC1.1
        public void SadMoodShouldReturnSad()
        {
            MoodAnalyser analyser = new MoodAnalyser("Sad");
            string message = analyser.MoodAnalyse();
            Assert.AreEqual(message, "Sad");
        }
        [TestMethod]
        //UC1.2
        public void AnyMoodShouldReturnHappy()
        {
            MoodAnalyser analyser = new MoodAnalyser("I am in Any Mood");
            string message = analyser.MoodAnalyse();
            Assert.AreEqual(message, "Happy");
        }
        [TestMethod]
        //UC2.1
        public void GivenNullMessageShouldReturnHappy()
        {
            MoodAnalyser analyser = new MoodAnalyser(null);
            try
            {
                string message = analyser.MoodAnalyse();
                Assert.AreEqual(message, "Happy");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        [TestMethod]
        //UC3.1
        public void given_Empty_Mood_Should_Throw_MoodAnalyserCustomException_Indocating_NullMood()
        {
            try
            {
                string message = null;
                MoodAnalyser analyser = new MoodAnalyser(message);
                string mood = analyser.MoodAnalyse();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //3.2
        [TestMethod]
        public void given_Empty_Mood_Should_Throw_MoodAnalyserCustomException_Indocating_Empty_Mood()
        {
            try
            {
                string message = "";
                MoodAnalyser analyser = new MoodAnalyser(message);
                string mood = analyser.MoodAnalyse();
            }
            catch (MoodAnalyserException e)
            {
                Console.WriteLine("Mood should not be Empty", e.Message);
            }
        }
        //UC4.1
        //[TestMethod]
        //public void Given_MoodAnalyser_ClassName_Should_Return_MoodAnalyser_Object()
        //{
        //    object expected = new MoodAnalyser();
        //    object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserAssignment.MoodAnalyser", "MoodAnalyser");
        //    expected.Equals(obj);
        //}
        ////UC4.2
        //[TestMethod]
        //public void Given_MoodAnalyser_ClassName_ImproperShould_Throw_MoodAnalyserException()
        //{
        //    try
        //    {
        //        object expected = new MoodAnalyser();
        //        object obj = MoodAnalyserFactory.CreateMoodAnalyse("erMoodAnalyserAssignment.MoodAnalys", "MoodAnalyser");
        //        expected.Equals(obj);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //}
        ////UC4.3
        //[TestMethod]
        //public void Given_MoodAnalyser_Constructor_Name_Improper_Should_Throw_MoodAnalyserException()
        //{
        //    try
        //    {
        //        object expected = new MoodAnalyser();
        //        object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserAssignment.AnalyseMood", "MoodAnaly");
        //        expected.Equals(obj);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //}
        //UC5.1
        [TestMethod]
        public void Given_MoodAnalyser_Class_Name_Should_Return_MoodAnalyser_Object_Using_Parameeterized_ConstrctrutorImproper()
        {
            try
            {
                object expected = new MoodAnalyser("Happy");
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserProblemAssignment.MoodAnalyser", "MoodAnalyser", "Happy");
                expected.Equals(obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //UC5.2
        [TestMethod]
        public void Given_MoodAnalyser_Class_Name_If_Improper_Should_Throw_MoodAnalyserException()
        {
            try
            {
                object expected = new MoodAnalyser("Happy");
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserProblemAssignment.MoodAnalyr", "MoodAnalyser", "Happy");
                expected.Equals(obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //UC5.3
        [TestMethod]
        public void Given_MoodAnalyser_Method_Name_If_Improper_Should_Throw_MoodAnalyserException()
        {
            try
            {
                object expected = new MoodAnalyser("Happy");
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerProblemAssignment.MoodAnalyzer", "MoodAnal", "Happy");
                expected.Equals(obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //UC6.1
        [TestMethod]
        public void GivenHappyShouldReturnHappy()
        {
            string expected = "Happy";
            string mood = MoodAnalyserFactory.InvokedAnalyseMood("Happy", "MoodAnalyse");
            Assert.AreEqual(expected, mood);
        }
        //UC6.2
        [TestMethod]
        public void GivenHappyMessage_WhenImproperMethod_ShouldThrowMoodAnalysisException()
        {
            string expected = "Method is not found";
            string mood = MoodAnalyserFactory.InvokedAnalyseMood("Happy", "Analyse");
            Assert.AreEqual(expected, mood);
        }
    }
}