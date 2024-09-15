using ChallangeApp;
using static System.Formats.Asn1.AsnWriter;

var employee = new Employee("Marek", "Dziurka");
employee.AddGrade("Marek");
employee.AddGrade("800");
employee.AddGrade("80");
employee.AddGrade(4.4056566);
employee.AddGrade(60);
employee.AddGrade(40.5256);
employee.AddGrade(120);
employee.AddGrade(20m);
employee.AddGrade(240m);
employee.AddGrade(10);
employee.AddGrade(2);
employee.AddGrade(200.0f);
employee.AddGrade(30.0f);
employee.AddGrade("12,34");




var statistics = employee.GetStatistics();

//Console.WriteLine($"Average: {statistics.Average:N2}"); 
Console.WriteLine($"Average: {Math.Round(statistics.Average)}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

