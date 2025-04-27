DateTime today = DateTime.Now;
DateTime end = today.Date.AddDays(1);
// TimeSpan remaining = end - today;
// Console.WriteLine(remaining.TotalSeconds);
TimeSpan remaining = today.Date.AddDays(1) - today;
Console.WriteLine(remaining.TotalSeconds);