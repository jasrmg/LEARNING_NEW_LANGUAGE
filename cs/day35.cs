Dictionary<string, string> timeZones = new Dictionary<string, string>
{
  {"New York", "Eastern Standard Time"},
  {"London", "GMT Standard Time"},
  {"Tokyo", "Tokyo Standard Time"},
  {"Sydney", "AUS Eastern Standard Time"},
  {"Dubai", "Arabian Standard Time"},
  {"Manila", "Singapore Standard Time"},
  {"Paris", "Romance Standard Time"},
  {"Baker Island", "Dateline Standard Time"},
  {"Pago Pago", "Samoa Standard Time"},
  {"Honolulu", "Hawaiian Standard Time"},
  {"Anchorage", "Alaskan Standard Time"},
  {"Los Angeles", "Pacific Standard Time"},
  {"Denver", "Mountain Standard Time"},
  {"Chicago", "Central Standard Time"},
  {"Caracas", "Venezuela Standard Time"},
  {"Buenos Aires", "Argentina Standard Time"},
  {"South Georgia Island", "Mid-Atlantic Standard Time"},
  {"Azores", "Azores Standard Time"},
  {"Athens", "GTB Standard Time"},
  {"Moscow", "Russian Standard Time"},
  {"Tehran", "Iran Standard Time"},
  {"Kabul", "Afghanistan Standard Time"},
  {"Karachi", "Pakistan Standard Time"},
  {"New Delhi", "India Standard Time"},
  {"Dhaka", "Bangladesh Standard Time"},
  {"Bangkok", "SE Asia Standard Time"},
  {"Beijing", "China Standard Time"}
};

Console.WriteLine("TIME IN DIFFERENT TIMEZONES");
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
    Console.WriteLine($"{zone.Key} Not Found!");
  }
  catch (InvalidTimeZoneException)
  {
    Console.WriteLine($"{zone.Key} Invalid!");
  }
}