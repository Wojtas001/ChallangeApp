namespace ChallangeApp
{
    public class Employee
    {
        private List<int> scores = new List<int>();

        
        public Employee(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }
        public int Age { get; private set; }

        public int Result => scores.Sum();

        public void AddScore(int score)
        {
            scores.Add(score);
            
        }

    }
}


