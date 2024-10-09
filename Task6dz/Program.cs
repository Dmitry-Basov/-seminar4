
;

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]},");
        }
    }
    Console.Write("]");
}

int[] arr = CreateArrayRndInt(8, 1, 10);
PrintArray(arr);

int temp;

for (int i = 0; i < arr.Length / 2; i++)
{
    temp = arr[i];
    arr[i] = arr[arr.Length - 1 - i];
    arr[arr.Length - 1 - i] = temp;
}

Console.WriteLine("\nПеревернутый массив: ");

Console.Write("[");
foreach(int e in arr)
{
    Console.Write(e + ", ");
}
Console.Write("]");