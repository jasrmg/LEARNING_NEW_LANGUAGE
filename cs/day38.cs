Console.WriteLine("Enter the first date(yyyy-MM-dd): ");
DateTime date1 = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Enter the second date(yyyy-MM-dd): ");
DateTime date2 = DateTime.Parse(Console.ReadLine());

string result = date1 > date2 ? "First date is greater" : "Second date is greater";
Console.WriteLine(result);