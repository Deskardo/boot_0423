Console.Clear();
Console.Write("Введите число: ");

// int[] size = Console.ReadLine()!.Split().Select(i => int.Parse(i)).ToArray();
// Console.WriteLine(size[0] + size[1]);

string number = Console.ReadLine()!;
int result = 0;
for(int i = 0; i < number.Length; i++)
{
  result += int.Parse(number[i].ToString());
}
Console.WriteLine(result);