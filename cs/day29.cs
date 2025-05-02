int GetSum(int a, int b) {
  return a + b;
}

Console.WriteLine("Enter num 1: ");
string input1 = Console.ReadLine();
Console.WriteLine("Enter num 2: ");
string input2 = Console.ReadLine();
int num1, num2;
int.TryParse(input1, out num1);
int.TryParse(input2, out num2);

Console.WriteLine(GetSum(num1, num2));