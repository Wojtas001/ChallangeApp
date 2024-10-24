﻿namespace ChallangeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname, char sex, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
            this.Age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Sex { get; private set; }
        public int Age { get; private set; }


        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("invalid float grade value");
            }
        }

        //public void AddGrade(string grade)
        //{
        //    float extraGrade = 0;
        //    if (grade.Length >= 2)
        //    {
        //        if (grade[grade.Length - 2] == '-' || grade[grade.Length - 1] == '-')
        //        {
        //            extraGrade = -5;
        //            grade = grade.Trim('-');
        //        }
        //        else if (grade[grade.Length - 2] == '+' || grade[grade.Length - 1] == '+')
        //        {
        //            extraGrade = 5;
        //            grade = grade.Trim('+');
        //        }
        //    }
        //    Console.WriteLine(grade);
        //    switch (grade)
        //    {
        //        case "6":
        //            this.AddGrade(100 + extraGrade);
        //            break;
        //        case "5":
        //            this.AddGrade(80 + extraGrade);
        //            break;
        //        case "4":
        //            this.AddGrade(60 + extraGrade);
        //            break;
        //        case "3":
        //            this.AddGrade(40 + extraGrade);
        //            break;
        //        case "2":
        //            this.AddGrade(20 + extraGrade);
        //            break;
        //        case "1":
        //            this.AddGrade(0 + extraGrade);
        //            break;
        //        default:
        //            throw new Exception("invalid grade value");
        //    }


        public void AddGrade(string grade)
        {


            switch (grade)
            {
                case "6": this.AddGrade(100); break;
                case "-6": case "6-": this.AddGrade(95); break;
                case "+5": case "5+": this.AddGrade(85); break;
                case "5": this.AddGrade(80); break;
                case "-5": case "5-": this.AddGrade(75); break;
                case "+4": case "4+": this.AddGrade(65); break;
                case "4": this.AddGrade(60); break;
                case "-4": case "4-": this.AddGrade(55); break;
                case "+3": case "3+": this.AddGrade(45); break;
                case "3": this.AddGrade(40); break;
                case "-3": case "3-": this.AddGrade(35); break;
                case "+2": case "2+": this.AddGrade(25); break;
                case "2": this.AddGrade(20); break;
                case "-2": case "2-": this.AddGrade(15); break;
                case "+1": case "1+": this.AddGrade(5); break;
                case "1": this.AddGrade(0); break;
                default: throw new Exception("Wrong Number (only 1-6)");
            }
        }
        

        public void AddGrade(int grade)
        {
            this.AddGrade((float)grade);
        }

        public void AddGrade(char grade)
        {
            this.AddGrade((float)grade);
        }

        public void AddGrade(double grade)
        {
            this.AddGrade((float)grade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.NumberOfRatings = 0;

            foreach (var grade in this.grades)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                    statistics.NumberOfRatings = this.grades.Count;
                }
            }

            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}
