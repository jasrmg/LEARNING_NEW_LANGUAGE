void printTZ(Dictionary<string, string> dict) {
//print all dict values
int count = 1;
foreach (var zone in dict)
{
  try
  {
    TimeZoneInfo tz = TimeZoneInfo.FindSystemTimeZoneById(zone.Value);
    DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, tz);
    Console.WriteLine($"{count}. {zone.Key}: {localTime}");
    count++;
  }
  catch (TimeZoneNotFoundException)
  {
    Console.WriteLine($"{zone.Key} not found!");
  }
  catch (InvalidTimeZoneException)
  {
    Console.WriteLine($"{zone.Key} invalid!");
  }
}
}

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

Console.WriteLine("DIFFERENT TIMEZONES");

//print all dict values
printTZ(timeZones);
// foreach (zone in timeZones)
// {
//   try
//   {
//     TimeZoneInfo tz = TimeZoneInfo.FindSystemTimeZoneById(zone.Value);
//     DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, tz);
//     Console.WriteLine($"{zone.Key}: {localTime}");
//   }
//   catch (TimeZoneNotFoundException)
//   {
//     Console.WriteLine($"{zone.Key} not found!");
//   }
//   catch (InvalidTimeZoneException)
//   {
//     Console.WriteLine($"{zone.Key} invalid!");
//   }
// }

//get keys as a list
List<string> keys = new List<string>(timeZones.Keys);
Random random = new Random();

//remove 2 random keys
for (int i = 0; i < 2; i++)
{
  int randomIndex = random.Next(keys.Count);
  string keyToRemove = keys[randomIndex];
  timeZones.Remove(keyToRemove);
  keys.RemoveAt(randomIndex);
  Console.WriteLine($"Timezone removed: {keyToRemove}");
}
printTZ(timeZones);
