namespace ChallangeApp.Tests
{
    public class Tests
    {
        [Test]
        public void EmployeeCollectionScoreTest()
        {
            var user1 = new Employee("Marek", "Dzień", 25);
            user1.AddScore(4);
            user1.AddScore(6);
            user1.AddScore(8);
            user1.AddScore(6);

            var results = user1.Result;

            Assert.AreEqual(24, results);

        }


        [Test]
        public void EmployeeCollectionMinusScore()
        {
            var user2 = new Employee("Agnieszka", "Strzałka", 30);
            user2.AddScore(-9);
            user2.AddScore(-1);
            user2.AddScore(-5);
            user2.AddScore(-1);

            var results1 = user2.Result;

            Assert.AreEqual(-16, results1);
        }


        [Test]
        public void EmployeeCollectionMixedScores()
        {
            var user3 = new Employee("Kuba", "Gleń", 27);
            user3.AddScore(5);
            user3.AddScore(-4);
            user3.AddScore(9);
            user3.AddScore(-7);


            var results2 = user3.Result;

            Assert.AreEqual(3, results2);
        }


    }   
      
   
}
  