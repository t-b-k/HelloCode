namespace Common;

public static class Helper
{
    // ***************************************************************************
    // Методы, возвращающие логическое значение, и контролирующие 
    // ввод пользователем правильных исходных данных
    // ***************************************************************************

    // Метод контролирует правильный ввод пользователем целого положительного 
    // числа. В качестве выходного параметра возвращает введенное число. 
    public static bool InputPositiveInteger(string invit, out uint n)
    {
        Console.Write(invit);
        bool res = uint.TryParse(Console.ReadLine(), out n) && n != 0;
        return res;
    }

    // Метод контролирует правильный ввод пользователем целого числа
    //В качестве выходного параметра возвращает введенное число. 
    public static bool InputInteger(string invit, out int n)
    {
        Console.Write(invit);
        return int.TryParse(Console.ReadLine(), out n);
    }

    // Метод контролирует правильный ввод пользователем вещественного числа
    //В качестве выходного параметра возвращает введенное число. 
    public static bool InputDouble(string invit, out double number)
    {
        Console.Write(invit);
        return double.TryParse(Console.ReadLine(), out number);
    }

    // Метод контролирует правильность ввода пользователем входных параметров, 
    // для двумерного массива - 
    // число строк
    // число столбцов
    // нижняя граница диапазона, в котором будут генерироваться числа для его заполнения, 
    // верхняя граница этого диапазона. 

    // Возвращает "ложь", если какое-то из данных введено некорректно. 
    // Все введенные правильно значения возвращает через выходные параметры. 
    // Проверку на  lowValue < upValue и на то, что обе размерности > 1, не выполняет!!! 
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

    // Метод контролирует правильность ввода пользователем входных параметров, 
    // для двумерного массива - 
    // число строк
    // число столбцов
    // нижняя граница диапазона, в котором будут генерироваться числа для его заполнения, 
    // верхняя граница этого диапазона. 

    // Возвращает "ложь", если какое-то из данных введено некорректно, 
    //                или если lowValue >= upValue
    //                или если какая-либо из размерностей меньше 2 (то есть, 
    //                массив превращается в одномерный).

    // Все введенные правильно значения возвращает через выходные параметры. 
    // Проверку на  lowValue < upValue и на то, что обе размерности > 1, не выполняет!!! 
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

    // ***************************************************************************
    // Методы вывода информации на экран
    // ***************************************************************************

    // Печать одномерного массива целых чисел в одну строку через пробел
    public static void PrintArray(int[] array)
    {
        for (var i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            Console.Write(" ");
        }
    }

    // Печать одномерного массива вещественных чисел в одну строку через пробел
    public static void PrintArray(double[] array)
    {
        for (var i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            Console.Write(" ");
        }
    }

    // Печать одномерного массива вещественных чисел в одну строку через 
    // заданный разделитель с заданной точностью
    public static void PrintArray(double[] array, int accuracy, string separator)
    {   
        var i = 0; 
        for (; i < array.Length-1; i++)
        {
            Console.Write(Math.Round(array[i], accuracy) + separator);
        }
        Console.WriteLine(Math.Round(array[i], accuracy) + ".\n"); 
    }

    // Метод выводит в окно консоли двумерный массив вещественных чисел
    // построчно с разделителем "пробел". Числа выводятся с заданной 
    // параметром accuracy точностью. 
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

    // Метод выводит в окно консоли двумерный массив целых чисел
    // построчно с разделителем "пробел"
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

    // Метод выводит в окно консоли двумерный массив вещественных чисел
    // построчно с разделителем "пробел". 
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

    // ***************************************************************************
    // Методы создания массивов случайных чисел
    // ***************************************************************************

    // Создание массива случайных целых чисел длиной 10.  
    // Надо сделать перегрузку, в которой длина будет передаваться в качестве параметра 
    // и еще одну перегрузку, где длина будет генерироваться случайным образом в некотором 
    // диапазоне, чтобы массив был совершенно случайным. 
    public static int[] CreateRandomArray()  // В этом методе длина созданного массива будет 10
    {
        Random random = new Random();
        int[] array = new int[10];
        for (var i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(int.MinValue, int.MaxValue);
        }
        return array;
    }

    // Метод создает и возвращает двумерный массив целых чисел
    // из диапазона [-10;10]
    // с заданными кол-вами строк и столбцов

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

     // Метод создает и возвращает двумерный массив вещественных чисел
    // из диапазона (примерно) [minBound;upperBound]
    // с заданными кол-вами строк (qtyOfRows) и столбцов (qtyOfColumns)
    public static double[,] CreateRandom2DArray(uint qtyOfRows, uint qtyOfColumns, 
                                                int minBound, int upperBound)
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

    // Метод создает и возвращает двумерный массив вещественных чисел
    // из диапазона (примерно) [minBound;upperBound]
    // со случайным кол-вом строк (qtyOfRows) и столбцов (qtyOfColumns) из 
    // диапазона [2; 10]. Количество строк и столбцов в сгенерированном массиве
    // возвращает через выходные параметры. 
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

    // Метод создает и возвращает двумерный массив целых чисел
    // из диапазона [minValue;maxValue] 
    // со случайным кол-вом строк (qtyOfRows) и столбцов (qtyOfColumns) из 
    // диапазона [maxRows; maxColumns]. 
    // Количество строк и столбцов в сгенерированном массиве
    // возвращает через выходные параметры. 
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

    // Метод создает двумерный массив вещественных чисел размера m x n, 
    // заполняя его случайными целыми числами из диапазона [-10, 10]. 
    public static double[,] Create2DArray(int m, int n)
    {
        Random random = new Random();
        double[,] array = new double[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = random.Next(-10, 11);
            }
        }
        return array;
    }

    // **************************************************************************
    //               Прочие методы для работы с массивами
    // **************************************************************************

    // Метод формирует и возвращает строку, представляющую собой двоичную 
    // запись заданного параметром целого положительного числа
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

    // Средние по столбцам. 
    // Метод возвращает одномерный массив вещественных чисел, в котором 
    // на i-й позиции стоит среднее значение по i-му столбцу из 
    // массива arrOfInt, передаваемого в метод в качестве входного параметра
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