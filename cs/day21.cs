DateTime today = DateTime.Now;
DateTime end = today.Date.AddDays(1);
TimeSpan ms = end - today;
double micro = ms.TotalMilliseconds * 1000;
Console.WriteLine(micro); 