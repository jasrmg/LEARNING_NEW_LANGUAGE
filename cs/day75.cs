string[] strArray = { "cat", "art", "big", "duck", "zero", "elder", "xi" };
Console.WriteLine("Original Array");
foreach (string x in strArray)
{
  Console.WriteLine(x);
}
Array.Sort(strArray);
Console.WriteLine("Sorted Array");
foreach (string x in strArray)
{
  Console.WriteLine(x);
}