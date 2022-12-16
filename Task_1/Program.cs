int Number(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] %2==0)
        {
            sum++;
        }
    }
    return sum;
}

int[] CreateMassive(int count, int begin, int end)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(begin, end);
    }
    return array;
}

int[] way = CreateMassive(10, 100, 1000);
Console.WriteLine($"[{String.Join(", ", way)}]");
int even = Number(way);
int odd = Number(way);
Console.WriteLine($"{even}");