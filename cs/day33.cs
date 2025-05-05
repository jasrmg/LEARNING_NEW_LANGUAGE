Dictionary<string, string> timeZones = new Dictionary<string, string>
{
  {"New York", "Eastern Standard Time"},
  {"London", "GMT Standard Time"},
  {"Tokyo", "Tokyo Standard Time"},
  {"Sydney", "AUS Eastern Standard Time"},
  {"Dubai", "Arabian Standard Time"},
  {"Manila", "Singapore Standard Time"}
};

Console.WriteLine("Current time in different timezones:\n");

foreach (var zone in timeZones) 
{
  try
  {
    TimeZoneInfo tz = TimeZoneInfo.FindSystemTimeZoneById(zone.Value);
    DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, tz);
    Console.WriteLine($"{zone.Key}: {localTime}");
  }
  catch (TimeZoneNotFoundException)
  {
    Console.WriteLine($"{zone.Key}: Time zone not found.");
  }
  catch (InvalidTimeZoneException)
  {
    Console.WriteLine($"{zone.Key}: Invalid time zone.");
  }
}