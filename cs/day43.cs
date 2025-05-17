Console.WriteLine("Enter a number: ");
string isNum = Console.ReadLine();
if (Int32.TryParse(isNum, out int num))
{
  Console.WriteLine($"{num} is a number!");
}
else
{
  Console.WriteLine("Input is not a number!");
}