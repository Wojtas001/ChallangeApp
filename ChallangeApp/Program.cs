using ChallangeApp;

Console.WriteLine("Witamy w programie do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj ocenę pracownika od 0-100 lub od A-E. Aby zakończyć nacisnij 'Q' + 'Enter': ");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }
    employee.AddGrade(input);
}


var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {Math.Round(statistics.Average)}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

