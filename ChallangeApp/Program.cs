using ChallangeApp;


Employee user1 = new Employee("Marek", "Dzień", 25);
Employee user2 = new Employee("Agnieszka", "Strzałka", 30);
Employee user3 = new Employee("Kuba", "Gleń", 27);

user1.AddScore(4);
user1.AddScore(6);
user1.AddScore(8);
user1.AddScore(6);
user1.AddScore(1);

user2.AddScore(9);
user2.AddScore(1);
user2.AddScore(5);
user2.AddScore(1);
user2.AddScore(3);

user3.AddScore(5);
user3.AddScore(4);
user3.AddScore(9);
user3.AddScore(7);
user3.AddScore(3);

List<Employee> users = new List<Employee>()
{
     user1,  user2,  user3
};

Employee userWithMaxResult = users.OrderByDescending(u => u.Result).FirstOrDefault();

Console.WriteLine("Największą liczbę punktów zdobył: " + " " + "'" + userWithMaxResult.Name + " " + userWithMaxResult.Surname + " " + "lat" + " " + userWithMaxResult.Age + "'" + " " + "który zdobył" + " " + userWithMaxResult.Result + " " + "punktów");

