namespace Common;

public static class Helper
{
    // Методы, возвращающие логическое значение, и контролирующие 
    // ввод пользователем правильных исходных данных
    public static bool InputPositiveInteger(string invit, out uint n)
    {
        Console.Write(invit);
        bool res = uint.TryParse(Console.ReadLine(), out n) && n != 0;
        return res;
    }

    public static bool InputInteger(string invit, out int n)
    {
        Console.Write(invit);
        return int.TryParse(Console.ReadLine(), out n);
    }

    public static bool InputDouble(string invit, out double number)
    {
        Console.Write(invit);
        return double.TryParse(Console.ReadLine(), out number);
    }

    // Методы вывода информации на экран
    public static void PrintArray(int[] array)
    {
        for (var i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            Console.Write(" ");
        }
    }

    // Методы создания массивов случайных чисел
    public static int[] CreateRandomArray()
    {
        Random random = new Random();
        int[] array = new int[10];
        for (var i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(int.MinValue, int.MaxValue);
        }
        return array;
    }

    // Метод формирования строки, представляющей собой двоичную 
    // запись заданного целого положительного числа

    public static string GetToBin(int decNumber)
    {
        string binar = string.Empty;

        int number = Math.Abs(decNumber);

        while (number != 0)
        {
            binar = number % 2 + binar;
            number = number / 2;
        }
        return binar;
    }


    // Методы для работы с двумерными массивами

    public static int[,] CreateRandomArray(int countOfRows, int countOfColumns)
    {
        CreateRandomArray random
        int[,] array = new int[countOfRows, countOfColumns];

        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = CreateRandomArray.Next(-10, 11);
            }
        }
    }

    public static void Print2DArray(int[,] array)
for (var i = 0; i<array.GetLength(0); i++) 
{
    for (var j = 0; j<array.GetLength(1); j++)
    {
        Console.Write($"{array[i,j]} "); 
    }
}
}