using ChallangeApp;


Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("Witamy w programie do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();
Console.ResetColor();

var employee = new EmployeeInFile("Mirek","Duda",'M', 26);
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("Dodano nową ocenę");
    Console.ResetColor();
}

while (true)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Podaj ocenę pracownika od 0-100 lub od A-E. Aby zakończyć nacisnij 'Q' + 'Enter': ");
    var input = Console.ReadLine();
    Console.ResetColor();

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
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Exception Found: {ex.Message}");
        Console.ResetColor();
    }
}

var statistics = employee.GetStatistics();
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"\nStatystyki pracownika: {employee.Name} {employee.Surname} {employee.Sex} {employee.Age}.");
Console.WriteLine($"Average score: {statistics.Average:N2}");
Console.WriteLine($"Min score: {statistics.Min}");
Console.WriteLine($"Max score: {statistics.Max}");
Console.WriteLine($"Average score in letter: {statistics.AverageLetter}");
Console.WriteLine($"Number of ratings: {statistics.NumberOfRatings}");
Console.ResetColor();
