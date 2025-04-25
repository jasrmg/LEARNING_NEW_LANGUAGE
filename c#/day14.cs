double Greatest(double x, double y, double z) {
  return x > y && x > z ? x : y > x && y > z ? y : z; 
}

Console.WriteLine(Greatest(12, 210, 10));