using ChallangeApp;

var employee = new Employee("Marek", "Dziurka");
employee.AddGrade(8);
employee.AddGrade(4);
employee.AddGrade(6);

var statistics = employee.GetStatistics(); 

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

