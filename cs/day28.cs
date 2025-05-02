Console.WriteLine("Enter a float: ");
string fl = Console.ReadLine();
float num;
bool isFloat = float.TryParse(fl, out num);
if (!isFloat) {
  Console.WriteLine("Enter a floating number!");
}
Console.WriteLine(Math.Round(num));