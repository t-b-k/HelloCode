// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки
// этого двумерного массива. 

// создадим случайный двумерный массив, количество строк и столбцов в котором не будет 
// превышать 10-ти, а диапазон значений будет равен [-99; 100) 
// Количество строк и столбцов в результирующем массиве запишем в переменные 
// quantityOfRow и quantityOfColumns
using static Common.Helper; 

uint maxNumberOfRows = 10; 
uint maxNumberOfColumns = 10; 
int minValue = -99; 
int maxValue = 99; 
int quantityOfRows = 0; 
int quantityOfColumns = 0; 

int[,] sourceArray = CreateRandom2DArray (out quantityOfRows, out quantityOfColumns,
                                            maxNumberOfRows, maxNumberOfColumns,
                                            minValue, maxValue); 

// Выводим созданный массив в окно консоли: 

Console.WriteLine($"\nСоздадим двумерный массив целых чисел размером {quantityOfRows} x {quantityOfColumns} : \n"); 


Print2DArray3Pos(sourceArray); 

Console.WriteLine("\nТеперь упорядочим все его строки по убыванию.  \n"); 
Console.WriteLine("РЕЗУЛЬТАТ: \n"); 

int[,] arrayWithStringsOrderedByDescending = StringsByDescending (sourceArray); 
Print2DArray3Pos(arrayWithStringsOrderedByDescending); 

int[,] StringsByDescending (int[,] arr)
{
    // Создадим массив, в который будет записан результат. 
    int numOfRows = arr.GetLength(0);
    int numOfCols = arr.GetLength(1);

    int[,] arrayWithOrderedStrings = CopyOf2DArray(arr);

    // Проходим по строкам и каждую из них упорядочиваем. 

    for (int i = 0; i < numOfRows; i++)
    {
        for (int j = 0; j < numOfCols - 1; j++)
        {
            int max = arrayWithOrderedStrings[i, j];
            int runOfMax = j;
            for (int run = j + 1; run < numOfCols; run++)
            {
                if (arrayWithOrderedStrings[i,run] > max)
                {
                    max = arrayWithOrderedStrings[i,run];
                    runOfMax = run;
                }
            }

            arrayWithOrderedStrings[i, runOfMax] = arrayWithOrderedStrings[i, j];
            arrayWithOrderedStrings[i, j] = max;

        }
    }
    return arrayWithOrderedStrings; 
}

// int[,] CopyOf2DArray(int[,] arr)
// {
//     int[,] copyOfArr = new int[arr.GetLength(0), arr.GetLength(1)];

//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             copyOfArr[i, j] = arr[i, j];
//         }
//     }

//     return copyOfArr;
// }