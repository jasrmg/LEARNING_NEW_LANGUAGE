Console.WriteLine("Enter a floating point number: ");
string num = Console.ReadLine();

if (!double.TryParse(num, out double floatingNumber))
{
  Console.WriteLine($"Cannot be parsed!");
  return;
}
Console.WriteLine($"{floatingNumber} is a floating number! rounded {Math.Round(floatingNumber)}");
