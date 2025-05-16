int a = 1, b = 1, next;

Console.WriteLine("Press any key to see the next fibonacci number. Press 'q' to quit.");
Console.WriteLine(a);
Console.WriteLine(b);

while (true)
{
  var key = Console.ReadKey(true);
  if (key.KeyChar == 'q') break;


  next = a + b;
  Console.WriteLine(next);

  a = b;
  b = next;
}

Console.WriteLine("program terminated.");