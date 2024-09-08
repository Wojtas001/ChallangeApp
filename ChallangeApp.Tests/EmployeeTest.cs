namespace ChallangeApp.Tests
{
    public class EmployeeTest
    {
        [Test]
        public void GetStatistic_CheckingCorrectMax()

        {
            var employee = new Employee("Marek", "Dzień");
            employee.AddGrade(4);
            employee.AddGrade(6);
            employee.AddGrade(8);
            employee.AddGrade(6);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(8, statistics.Max);

        }


        [Test]
        public void GetStatistic_CheckingCorrectMin()
        {
            var employee1 = new Employee("Agnieszka", "Strzałka");
            employee1.AddGrade(6);
            employee1.AddGrade(5);
            employee1.AddGrade(4);


            var statistics = employee1.GetStatistics();

            Assert.AreEqual(4, statistics.Min);
        }


        [Test]
        public void GetStatistic_CheckingCorrectAverage()
        {
            var employee2 = new Employee("Kuba", "Gleń");
            employee2.AddGrade(5);
            employee2.AddGrade(4);
            employee2.AddGrade(9);



            var statistics = employee2.GetStatistics();

            Assert.AreEqual(Math.Round(6.00, 2), Math.Round(statistics.Average, 2));
        }


    }
}