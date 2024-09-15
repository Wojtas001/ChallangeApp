namespace ChallangeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid float grade value");
            }
        }

        public void AddGrade(string grade)
        {

            if (float.TryParse(grade, out float result))
            {
            }
            if (result >= 0 && result <= 100)
            {
                this.grades.Add(result);
            }
            else
            {
                Console.WriteLine("invalid string grade value");
                Console.WriteLine("string is not float");
            }
        }

        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add((float)grade);
            }
            else
            {
                Console.WriteLine("invalid double grade value");
            }
        }

        public void AddGrade(decimal grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add((float)grade);
            }
            else
            {
                Console.WriteLine("invalid decimal grade value");
            }
        }

        public void AddGrade(long grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add((float)grade);
            }
            else
            {
                Console.WriteLine("invalid long grade value");
            }
        }

        public void AddGrade(int grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add((float)grade);
            }
            else
            {
                Console.WriteLine("invalid int grade value");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

            return statistics;
        }
    }
}
