Console.Clear();
Console.Write("Введите кол-во элементов массива: ");

int[] size = Console.ReadLine()!.Split().Select(i => int.Parse(i)).ToArray();
Console.WriteLine(size[0] + size[1]);