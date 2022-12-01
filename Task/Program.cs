String[] FillArray(int size)
{
    String[] arr = new String[size];
    for (int i = 0; i < size; i++)
    {
        String text = Console.ReadLine()!;
        arr[i] = text;
    }
    return arr;
}

String[] arr =  FillArray(3);
Console.WriteLine(String.Join(", ", arr));