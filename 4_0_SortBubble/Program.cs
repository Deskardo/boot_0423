const int n = 100;
int[] array = Enumerable.Range(1, n)
                          .Select(item => Random.Shared.Next(1000))
                         // .Select(item => n - item)
                         .ToArray();
array[n - 1] = 0;

Console.WriteLine(string.Join(' ', array));
int count = 0;
bool needSort = true;
int j = 0;

while(needSort)
{
  needSort = false;
  for (int i = n - 1; i > j; i--)
  {
    if (array[i] < array[i - 1])
    {
      int temp = array[i];
      array[i] = array[i - 1];
      array[i - 1] = temp;
      needSort = true;
    }
    count++;
    // Console.WriteLine($"     i: {i}  [{string.Join(' ', array)}]");
  }
  j++;
  // Console.WriteLine($"  j: {j}  [{string.Join(' ', array)}]");
}
Console.WriteLine($"Array: [{string.Join(' ', array)}]");
Console.WriteLine($"Count: {count}");
Test.Check(array);
