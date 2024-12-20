﻿using System.Diagnostics;

namespace ChallangeApp
{
    public class EmployeeInFile : EmployeeBase
    {

        public override event GradeAddedDelegate GradeAdded;

        private const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname, char sex, int age)
            : base(name, surname, sex, age)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText($"{fileName}"))

                {
                    writer.WriteLine(grade);
                }

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("invalid float value");
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float resultFloat))
            {
                this.AddGrade(resultFloat);
            }
            else if (char.TryParse(grade, out char resultChar))
            {
                this.AddGrade(resultChar);
            }
            else
            {
                throw new Exception("string is not float");
            }
        }

        public override void AddGrade(int grade)
        {
            this.AddGrade((float)grade);
        }

        public override void AddGrade(char grade)
        {
            switch ((float)grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }

        public override void AddGrade(double grade)
        {
            this.AddGrade((float)grade);
        }

        private List<float> grades = new List<float>();

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var grade = float.Parse(line);
                        grades.Add(grade);
                        line = reader.ReadLine();
                    }
                }
            }
            foreach (var grade in this.grades) 
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }
    }
}
