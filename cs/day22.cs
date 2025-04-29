Console.WriteLine("Enter a year: ");
int year = Int32.Parse(Console.ReadLine());
Console.WriteLine(LeapYr(year));

string LeapYr(int yr) {
  return yr % 4 == 0 ? "Leapyear" : "Not a leapyear";
}