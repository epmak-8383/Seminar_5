int Min(int[] arr)
{
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < arr[0])
        {
            min = arr[i];
        }
    }
    return min;
}

int Max(int[] arr)
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > arr[0])
        {
            max = arr[i];
        }
    }
    return max;
}

int[] CreateMassive(int count, int begin, int end)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(begin, end+1);
    }
    return array;
}

int[] way = CreateMassive(6, 0, 10);
Console.WriteLine($"[{String.Join(", ", way)}]");
int min = Min(way);
int max = Max(way);
Console.WriteLine($"{min}, {max}");
int result = max - min;
Console.WriteLine(result);