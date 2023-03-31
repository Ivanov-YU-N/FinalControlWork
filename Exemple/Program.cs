int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int row = GetNumber("Введите размер массива  ");
