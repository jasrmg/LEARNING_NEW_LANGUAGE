int num1 = 12;
int num2 = 555;
int num3 = 666;
int num4 = 333;
int num5 = 6969;

int[] arr = new int[5];
arr[0] = num1;
arr[1] = num2;
arr[2] = num3;
arr[3] = num4;
arr[4] = num5;

for (int i = 0; i < arr.Length; i++) {
  char[] arr2 = arr[i].ToString().ToCharArray();
  for (int j = 0; j < arr2.Length; j++) {
    Console.WriteLine(arr2[j]);
  }
}