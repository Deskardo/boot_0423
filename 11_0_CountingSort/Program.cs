void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 101);
}


void CompetetionArray(int[] array, int[] helpArray)
{
  for (int i = 0; i < array.Length; i++)
    helpArray[array[i]] += 1;
}


void SortArray(int[] array, int[] helpArray)
{
  int j = 0;
  for (int i = 1; i <= 100; i++)
    while (helpArray[i] > 0)
    {
      array[j] = i;
      j++;
      helpArray[i]--;
    }
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
int[] helpArray = new int[101];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
CompetetionArray(array, helpArray);
SortArray(array, helpArray);
Console.WriteLine($"Отсортированный массив: [{string.Join(", ", array)}]");