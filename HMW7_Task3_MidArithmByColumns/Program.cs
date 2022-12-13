// Задайте двумерный массив целых чисел
// Найдите среднее арифметическое элементов в каждом столбце

using static Common.Helper; 

uint MaximumNumberOfRows = 0; 
uint MaximumNumberOfColumns = 0; 
int lowerValue = 0;
int upperValue = 0; 

int accuracy = 1; // для вывода массива вещественных чисел в консоль

Console.ForegroundColor = ConsoleColor.Blue;  

if (!InputInt2DRandomArrayParameters  (out MaximumNumberOfRows, out MaximumNumberOfColumns, 
                                       out lowerValue, out upperValue))
{
    Console.ForegroundColor = ConsoleColor.Yellow; 
    Console.WriteLine("Вы где-то допустили ошибку. Такой массив не может быть создан. \n"); 
    return; 
}

int numberOfRows = 0; 
int numberOfColumns = 0; 

int[,] arrayOfIntegers = CreateRandom2DArray (out numberOfRows, out numberOfColumns, 
                                            MaximumNumberOfRows, MaximumNumberOfColumns, 
                                            lowerValue, upperValue); 

double[] arrayOfAverageByColumns = GetArrayOfAveragesByColumns (arrayOfIntegers); 

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nВот как выглядит сгенерированный по вашим параметрам случайный массив: \n");
Console.WriteLine($"Количество строк = {numberOfRows}, количество столбцов = {numberOfColumns}\n"); 

Print2DArray(arrayOfIntegers); 

Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine("\nА вот чему равны средние арифметические значения его столбцов \n" + 
                  $"с точностью до {accuracy} десятичных знака(ов): \n");

PrintArray (arrayOfAverageByColumns, accuracy); 

Console.WriteLine (); 
Console.ResetColor(); 

// double[] GetArrayOfAveragesByColumns (int[,] arrOfInt)
// {
//     int width = arrOfInt.GetLength(1); 
//     int height = arrOfInt.GetLength(0); 

//     double[] result = new double[width]; 

//     Console.WriteLine(string.Join(" ", result)); 

//     for (int i = 0; i < width; i++)
//     {
//         double sum = 0; 
//         for (int j = 0; j < height; j++)
//         {
//             sum = sum + arrOfInt[j,i];
//         }
//         result[i] = sum / height; 
//     }
//     return result;
// }

// int[,] CreateRandom2DArray(out int qtyOfRows, out int qtyOfColumns,
//                             uint maxRows, uint maxColumns, 
//                             int minValue, int maxValue)
// {
//     Random random = new Random();

//     qtyOfRows = random.Next(2, (int)maxRows);
//     qtyOfColumns = random.Next(2, (int)maxColumns);

//     int[,] array = new int[qtyOfRows, qtyOfColumns];

//     for (int i = 0; i < qtyOfRows; i++)
//     {
//         for (int j = 0; j < qtyOfColumns; j++)
//         {
//             array[i, j] = random.Next(minValue, maxValue+1);
//         }
//     }
//     return array;
// }