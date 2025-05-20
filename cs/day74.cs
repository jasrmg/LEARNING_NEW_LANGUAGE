int[] numberArr = { 3, 2, 8, 9, 11 };
Console.WriteLine("Original Array");
foreach (int x in numberArr)
{
  Console.WriteLine(x);
}
Array.Sort(numberArr);
Console.WriteLine("Sorted Array:");
foreach (int x in numberArr)
{
  Console.WriteLine(x);
}