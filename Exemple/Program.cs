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


int row = GetNumber("Введите размер массива  ");
string[] array = new string[row];
FillArray(array);
