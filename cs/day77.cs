int[] numbers = { 5, 12, 39, 62, 11, 10, 20, 3, 2, 1, 51, 9 };
var filtered = numbers.Where(n => n > 10).ToArray();
Array.Sort(filtered);
Console.WriteLine("Numbers greater than 10:");
foreach (var num in filtered)
{
  Console.WriteLine(num);
};