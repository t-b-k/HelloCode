// Задайте двумерный массив размером m х n, 
// заполненный случайными вещественными числами. 

using static Common.Helper;

uint numberOfRows = 0; 
uint numberOfColumns = 0; 

int lowerBoundOfRange = 0; 
int upperBoundOfRange = 0; 

Console.ForegroundColor = ConsoleColor.Blue;

if (!InputDouble2DRandomArrayParameters (out numberOfRows, out numberOfColumns, 
                                        out lowerBoundOfRange, out upperBoundOfRange))
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("\nОШИБКА ВВОДА: Введено неверное значение. \n"); 
    Console.ResetColor(); 
    return;
}

if (lowerBoundOfRange >= upperBoundOfRange) 
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("\nВерхняя граница диапазона значений должна быть больше нижней. \n" + 
                      "Невозможно заполнить массив значениями. Программа завершает работу. \n"); 
    Console.ResetColor(); 
    return;
}

Console.ForegroundColor = ConsoleColor.Blue;

uint accuracy = 0; 

 if (!InputPositiveInteger("Задайте точность отображения элементов массива\n" + 
                          "(кол-во знаков после запятой, целое положительное) => ", out accuracy))
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nВведенное Вами число не является целым положительным.\n" + 
                          "Программа завершает работу. \n");
        Console.ResetColor();  
        return; 
    }

double[,] array = CreateRandom2DArray (numberOfRows,numberOfColumns,lowerBoundOfRange,upperBoundOfRange);

Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("\nВот какой массив у нас получился: \n"); 

Print2DArray(array, accuracy);  

Console.WriteLine(); 

Console.ResetColor(); 


// bool InputDouble2DRandomArrayParameters (out uint numOfRows, out uint numOfCols, 
//                                         out int lowValue, out int upValue)
// {
//     numOfRows = 0; 
//     numOfCols = 0; 
//     lowValue = 0; 
//     upValue = 0; 

//     Console.WriteLine("\nВведите исходные данные: \n"); 
    
//     return InputPositiveInteger("Число строк в массиве (целое положительное)    => ", out numOfRows)
//     && InputPositiveInteger("Число столбцов в массиве (целое положительное) => ", out numOfCols) 
//     && InputInteger("Нижняя граница диапазона значений элементов (целое)    => ", out lowValue)
//     && InputInteger("Верхняя граница диапазона значений (целое)             => ", out upValue); 

// }


// double[,] CreateRandom2DArray(int qtyOfRows, int qtyOfColumns, int minBound, int upperBound)
//     {
//         Random random = new Random();
//         double[,] array = new double[qtyOfRows, qtyOfColumns];

//         for (int i = 0; i < qtyOfRows; i++)
//         {
//             for (int j = 0; j < qtyOfColumns; j++)
//             {
//                 array[i, j] = random.Next(minBound,upperBound) + random.NextDouble(); 
//             }
//         }
//         return array;
//     }

// void Print2DArray (double[,] array, int accuracy)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(Math.Round(array[i,j], 2) + "  "); 
//         }
//         Console.WriteLine(); 
//     }
// }
