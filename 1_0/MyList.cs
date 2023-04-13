class MyList
{
  int[] storage = new int[0];

  public void Create(int item)
  {
    int size = storage.Length;
    int[] temp = new int[size + 1];
    for (int i = 0; i < size; i++) temp[i] = storage[i];
    temp[size] = item;
    storage = temp;
  }

  public int Read(int index)
  {
    return storage[index];
  }

  public void Update(int index, int value)
  {
    storage[index] = value;
  }

  public void DeleteAt(int index)
  {
    int size = storage.Length;
    int[] temp = new int[size - 1];

    for (int i = 0; i < index; i++)
    {
      temp[i] = storage[i];
    }
    for (int i = index + 1; i < size; i++)
    {
      temp[i - 1] = storage[i];
    }
    storage = temp;
  }

  public string Print()
  {
    return $"[{String.Join(' ', storage)}]";
  }
}