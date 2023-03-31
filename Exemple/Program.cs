int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArray(string[] array)
{
    int row = array.Length;
    for (int i = 0; i < row; i++)
    {
        Console.WriteLine($"Введите {i} значение массива ");
        array[i] = Console.ReadLine();
    }
}
void PrintArray(string[] array)
{
    int row = array.Length;
    for (int i = 0; i < row; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

void NewArray(string[] array, string[] arr)
{
    int row = array.Length;
    for (int i = 0; i < row; i++)
    {
        if (array[i].Length <= 3)
            arr[i] = array[i];
    }
}


int row = GetNumber("Введите размер массива  ");
string[] array = new string[row];
FillArray(array);
PrintArray(array);
string[] arr = new string[row];
NewArray(array, arr);
PrintArray(arr);