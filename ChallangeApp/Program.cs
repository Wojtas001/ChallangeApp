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

var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();





//Console.WriteLine($"Average: {statistics.Average:N2}"); 

Console.WriteLine($"Average: {Math.Round(statistics.Average)}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

Console.WriteLine("         <WithForEach>           ");
Console.WriteLine($"Average: {Math.Round(statistics.Average)}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

Console.WriteLine("         <WithFor>           ");
Console.WriteLine($"Average: {Math.Round(statistics.Average)}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

Console.WriteLine("         <WithDoWhile>           ");
Console.WriteLine($"Average: {Math.Round(statistics.Average)}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

Console.WriteLine("         <WithWhile>           ");
Console.WriteLine($"Average: {Math.Round(statistics.Average)}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
