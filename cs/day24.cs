DateTime date = DateTime.Now;
TimeZoneInfo east = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
DateTime newyork = TimeZoneInfo.ConvertTime(date, east);
Console.WriteLine(newyork);