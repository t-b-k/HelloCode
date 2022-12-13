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

    public static void PrintArray(double[] array)
    {
        for (var i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            Console.Write(" ");
        }
    }

    public static void PrintArray(double[] array, int accuracy)
    {
        for (var i = 0; i < array.Length; i++)
        {
            Console.Write(Math.Round(array[i], accuracy));
            Console.Write(" ");
        }
        Console.WriteLine();
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
        Random random = new Random();
        int[,] array = new int[countOfRows, countOfColumns];

        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(-10, 11);
            }
        }
        return array;
    }

    public static double[,] CreateRandom2DArray(uint qtyOfRows, uint qtyOfColumns, int minBound, int upperBound)
    {
        Random random = new Random();
        double[,] array = new double[qtyOfRows, qtyOfColumns];

        for (int i = 0; i < qtyOfRows; i++)
        {
            for (int j = 0; j < qtyOfColumns; j++)
            {
                array[i, j] = random.Next(minBound, upperBound) + random.NextDouble();
            }
        }
        return array;
    }

    public static double[,] CreateRandom2DArray(out int qtyOfRows, out int qtyOfColumns,
                                                int minBound, int upperBound)
    {
        Random random = new Random();
        qtyOfRows = random.Next(2, 11);
        qtyOfColumns = random.Next(2, 11);

        double[,] array = new double[qtyOfRows, qtyOfColumns];

        for (int i = 0; i < qtyOfRows; i++)
        {
            for (int j = 0; j < qtyOfColumns; j++)
            {
                array[i, j] = random.Next(minBound, upperBound) + random.NextDouble();
            }
        }
        return array;
    }

    public static int[,] CreateRandom2DArray(out int qtyOfRows, out int qtyOfColumns,
                                            uint maxRows, uint maxColumns,
                                            int minValue, int maxValue)
    {
        Random random = new Random();

        qtyOfRows = random.Next(2, (int)maxRows);
        qtyOfColumns = random.Next(2, (int)maxColumns);

        int[,] array = new int[qtyOfRows, qtyOfColumns];

        for (int i = 0; i < qtyOfRows; i++)
        {
            for (int j = 0; j < qtyOfColumns; j++)
            {
                array[i, j] = random.Next(minValue, maxValue + 1);
            }
        }
        return array;
    }
    public static void Print2DArray(double[,] array, uint accuracy)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(Math.Round(array[i, j], (int)accuracy) + "  ");
            }
            Console.WriteLine();
        }
    }

    public static void Print2DArray(int[,] array)
    {
        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    public static void Print2DArray(double[,] array)
    {
        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    public static double[,] Create2DArray(int m, int n)
    {
        Random random = new Random();
        double[,] array = new double[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = random.Next(-10, 10);
            }
        }
        return array;
    }

    public static bool InputDouble2DRandomArrayParameters(out uint numOfRows, out uint numOfCols,
                                                          out int lowValue, out int upValue)
    {
        numOfRows = 0;
        numOfCols = 0;
        lowValue = 0;
        upValue = 0;

        Console.WriteLine("\nВведите исходные данные: \n");

        return InputPositiveInteger("Число строк в массиве (целое положительное)    => ", out numOfRows)
        && InputPositiveInteger("Число столбцов в массиве (целое положительное) => ", out numOfCols)
        && InputInteger("Нижняя граница диапазона значений элементов (целое)    => ", out lowValue)
        && InputInteger("Верхняя граница диапазона значений (целое)             => ", out upValue);

    }

    public static bool InputInt2DRandomArrayParameters(out uint maxNumOfRows, out uint maxNumOfCols,
                                                        out int lowValue, out int upValue)
    {
        maxNumOfRows = 0;
        maxNumOfCols = 0;
        lowValue = 0;
        upValue = 0;

        Console.WriteLine("Введите исходные параметры для создания двумерного массива \n" +
                            "случайных целых чисел, принадлежащих заданному диапазону: \n");

        return InputPositiveInteger("Макс. число строк в массиве (целое положительное) => ", out maxNumOfRows)
        && InputPositiveInteger("Макс. число столбцов в массиве (целое положительное) => ", out maxNumOfCols)
        && InputInteger("Нижняя граница диапазона значений элементов (целое)    => ", out lowValue)
        && InputInteger("Верхняя граница диапазона значений (целое)             => ", out upValue)
        && maxNumOfRows >= 2
        && maxNumOfCols >= 2
        && lowValue < upValue;
    }

    public static double[] GetArrayOfAveragesByColumns(int[,] arrOfInt)
    {
        int width = arrOfInt.GetLength(1);
        int height = arrOfInt.GetLength(0);

        double[] result = new double[width];

        for (int i = 0; i < width; i++)
        {
            double sum = 0;
            for (int j = 0; j < height; j++)
            {
                sum = sum + arrOfInt[j, i];
            }
            result[i] = sum / height;
        }
        return result;
    }


}