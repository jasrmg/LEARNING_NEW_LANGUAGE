DateTime today = DateTime.Now;
DateTime yesterday = today.AddDays(-1).Date;
Console.WriteLine(yesterday);
Console.WriteLine(yesterday.ToString("yyyy-MM-dd"));