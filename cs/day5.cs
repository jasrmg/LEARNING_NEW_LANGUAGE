using System.Globalization;
TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

string str1 = "jeff ALAIN sarmago";

Console.WriteLine(textInfo.ToTitleCase(str1.ToLower()));