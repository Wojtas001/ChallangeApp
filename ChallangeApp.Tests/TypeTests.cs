namespace ChallangeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void UsersShoudNotBeEqual()
        {
            var user1 = GetEmployee("Mirek");
            var user2 = GetEmployee("Mirek");


            Assert.AreNotSame(user1, user2);
        }


        [Test]
        public void NumbersAreNotEqual()
        {
            int number1 = 4;
            int number2 = 2;


            Assert.AreNotEqual(number1, number2);
        }


        [Test]
        public void StringAreEqual()
        {
            string a = "34";
            string b = "34";


            Assert.AreEqual(a, b);
        }


        [Test]
        public void DoubleAreNotEqual()
        {
            double a = 4.55543;
            double b = 3.434534;
      

            Assert.AreNotEqual(a, b);
        }


        [Test]
        public void FloatNumbersAreNotEqual()
        {
            float number1 = 342423;
            float number2 = 242342;


            Assert.AreNotEqual(number1, number2);
        }


        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }




    }
}
