Console.WriteLine("Enter a date to be converted to unix timestamp");
string input = Console.ReadLine();

// DateTime dateInput = DateTime.Parse(input);
DateTime unixEpoch = new DateTime(1970, 1, 1);
// long unix = (long)(dateInput - unixEpoch).TotalSeconds;

if (DateTime.TryParse(input, out DateTime date)) {
  long unix = (long)(date - unixEpoch).TotalSeconds;
  Console.WriteLine(unix);
} else {
  Console.WriteLine("Enter a valid date: April 28 2025 OR 2024-04-28");
}