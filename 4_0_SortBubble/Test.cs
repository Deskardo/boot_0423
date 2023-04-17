public class Test
{
  public static void Check(int[] data)
  {
    bool flag = true;
    int size = data.Length;
    for (int i = 0; i < size - 1; i++)
    {
      if (!(data[i] <= data[i + 1]))
      {
        flag = false;
        break;
      }
    }
    Console.WriteLine(flag);
  }
}