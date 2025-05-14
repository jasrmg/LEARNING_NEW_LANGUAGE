Console.WriteLine("Enter your birth date(YYYY-MM-DD): ");
string input = Console.ReadLine();

if (DateTime.TryParse(input, out DateTime birthDate)) {
  DateTime currentDate = DateTime.Now;
  TimeSpan ageSpan = currentDate - birthDate;
  int ageInDays = (int)Math.Round(ageSpan.TotalDays);
  Console.WriteLine($"You are approximately: {ageInDays} days old.");
} 
else
{
  Console.WriteLine("Invalid date format.");
}