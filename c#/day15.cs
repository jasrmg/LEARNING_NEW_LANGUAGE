public (int num1, int num2) Roll() {
  Random random = new Random();
  return (random.Next(1, 6), random.Next(1, 6));
}

var random = Roll();
Console.WriteLine($"{random.num1}, {random.num2}");
// Console.WriteLine(new Random().Next(1, 6));