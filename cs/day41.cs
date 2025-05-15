try {
  Console.WriteLine("Enter a future date (YYYY-MM-DD): ");
  string input = Console.ReadLine();
  if (DateTime.TryParse(input, out DateTime futureDate)) {
    DateTime currentDate = DateTime.Now;
    if (futureDate <= currentDate)
      throw new ArgumentException("the date must be in the future");
      
    TimeSpan remainingTime = futureDate - currentDate;
    int daysLeft = (int)Math.Ceiling(remainingTime.TotalDays);

    Console.WriteLine($"{daysLeft} day/s left until {futureDate.ToShortDateString()}");
  }
  else
  {
    throw new FormatException("Invalid date format!");
  }
} catch (Exception e) {
  Console.WriteLine($"Error: {e.Message}");
}