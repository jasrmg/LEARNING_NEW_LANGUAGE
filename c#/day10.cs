
string str1 = "Hello World";
char[] uniqueArr = str1.ToCharArray().Distinct().ToArray()
;
string str2 = string.Join("", uniqueArr);
Console.WriteLine(str2);