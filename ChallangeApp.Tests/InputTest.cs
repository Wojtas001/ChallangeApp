namespace ChallangeApp.Tests
{
    public class InputTest
    {
        [Test]
        public void WhenLettersInput_ShouldReturnScoreAsLetter()
        {
           Employee employee = new Employee("Mirek");
            employee.AddGrade('A');
            employee.AddGrade('B');
            employee.AddGrade('e');
            employee.AddGrade('c');
            employee.AddGrade('a');
            employee.AddGrade('D');


            var statistics = employee.GetStatistics();

            Assert.AreEqual('B', statistics.AverageLetter);
        }


        [Test]
        public void WhenLettersStringInput_ShouldReturnScoreAsNumbers()
        {
            Employee employee = new Employee("Mirek");
            employee.AddGrade("A");
            employee.AddGrade("c");
            employee.AddGrade("D");
            employee.AddGrade("b");

            var statistics = employee.GetStatistics();

            Assert.AreEqual(70, statistics.Average);    
        }

        [Test]
        public void WhenMixInput_ShouldReturnScoreAsLetter()
        {
            Employee employee = new Employee("Mirek");
            employee.AddGrade("20");
            employee.AddGrade("c");
            employee.AddGrade(40);
            employee.AddGrade('d');

            var statistics = employee.GetStatistics();

            Assert.AreEqual('C', statistics.AverageLetter);
        }

        [Test]
        public void WhenMixStringInput_ShouldReturnScoreAsNumbers()
        {
            Employee employee = new Employee("Mirek");
            employee.AddGrade("A");
            employee.AddGrade("10");
            employee.AddGrade("d");
            employee.AddGrade("20");

            var statistics = employee.GetStatistics();

            Assert.AreEqual(42,5, statistics.Average);
        }
    }
}
