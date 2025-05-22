var people = new (string Name, int Age)[]
{
  ("Jeff", 23),
  ("Bob", 69),
  ("Jelly", 22),
};

//print not sorted:
foreach (var person in people)
{
  Console.WriteLine(person);
};

//sort by age:
var sorted = people.OrderBy(p => p.Age).ToArray();

//print sorted:
foreach (var person in sorted)
{
  Console.WriteLine(person);
};

