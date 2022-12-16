int Number(int[] arr)
{
    int sum = 0;
    for (int i = -1; i < arr.Length; i++)
    {
        if (i %2==1)
        {
            sum = sum + arr[i];
        }
    }
    return sum;
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

int[] way = CreateMassive(6, -10, 10);
Console.WriteLine($"[{String.Join(", ", way)}]");
int oddIndex = Number(way);
Console.WriteLine($"{oddIndex}");