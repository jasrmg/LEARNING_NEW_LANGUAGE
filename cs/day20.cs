DateTime today = DateTime.Now;
DateTime end = today.Date.AddDays(1);
TimeSpan ms = end - today;
Console.WriteLine(ms.TotalMilliseconds);