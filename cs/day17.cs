// Int32 unixTimestamp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
// DateTimeOffset.UtcNow.ToUnixTimeSeconds();
// DateTime currentTime = DateTime.UtcNow;
// long unixTime = ((DateTimeOffset)currentTime).ToUnixTimeSeconds();

DateTime currentTime = DateTime.UtcNow;
DateTime unixEpoch = new DateTime(1970, 1, 1);
long unixTimestamp = (long)(currentTime - unixEpoch).TotalSeconds;
Console.WriteLine(unixTimestamp);