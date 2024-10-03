using ChallangeApp;

Console.WriteLine("Witamy w programie do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new Employee("Mirek","Duda");


while (true)
{
    Console.WriteLine("Podaj ocenę pracownika od 0-100 lub od A-E. Aby zakończyć nacisnij 'Q' + 'Enter': ");
    var input = Console.ReadLine();

    if (input == "q" || input == "Q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception Found: {ex.Message}");
    }
}


var statistics = employee.GetStatistics();
Console.WriteLine($"\nStatystyki pracownika: {employee.Name} {employee.Surname}, {employee.Sex}.");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average: {(statistics.AverageLetter)}");
