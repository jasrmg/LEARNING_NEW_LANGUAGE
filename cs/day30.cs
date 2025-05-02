Console.WriteLine("STRING CHECKER");
Console.WriteLine("Enter str1: ");
string str1 = Console.ReadLine();
Console.WriteLine("Enter str2: ");
string str2 = Console.ReadLine();

Console.WriteLine("Checking if the first string contains the 2nd string..." );
string contains = str1.Contains(str2) ? "Yes" : "No";
Console.WriteLine(contains);