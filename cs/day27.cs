Console.WriteLine("Enter a number: ");
string number = Console.ReadLine();
int val = 0;
bool isNumber = int.TryParse(number, out val);
if (!isNumber) {
  Console.Write("Please Enter a number!");
}