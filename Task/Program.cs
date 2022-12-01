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

String[] ChangedArray(String[] arr)
{
    List<String> change = new List<String>();
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= 3)
        {
            change.Add(arr[i]); 
        }
    }
    String[] changeArr = change.ToArray();
    return changeArr;
} 

String[] arr =  FillArray(3);
Console.WriteLine(String.Join(", ", arr));
String[] changeArr =  ChangedArray(arr);
Console.WriteLine(String.Join(", ", changeArr));