// Напишите программу, которая принимает на вход индексы элемента
// в двумерном массиве и возвращает значение этого элемента или 
// указание, что такого элемента нет

using static Common.Helper; 

int numberOfRows = 0; 
int numberOfColumns = 0; 

int lowBound = -100; 
int upBound = 99; 

double[,] array = CreateRandom2DArray (out numberOfRows, out numberOfColumns, lowBound, upBound); 

Console.WriteLine("\nСформирован случайный массив вещественных чисел. \n"); 
Console.WriteLine("Значение какого элемента Вас интересует? \n");

int rowIndex = 0; 
int columnIndex = 0; 

Console.ForegroundColor = ConsoleColor.Blue; 

if (!(InputInteger("Введите индекс строки => ", out rowIndex) && rowIndex >= 0) ||
    !(InputInteger("Введите индекс столбца => ", out columnIndex) && columnIndex >= 0))
{
    Console.WriteLine("Вы ввели недопустимое значение. Программа завершает работу. \n"); 
    Console.ResetColor(); 
    return; 
}

double elMeaning = 0; 

if (ElementExist(array, rowIndex, columnIndex, out elMeaning)) 
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"\nЗначение элемента массива на позиции [{rowIndex}, {columnIndex}] равно " + 
                      $"{Math.Round(elMeaning, 2)} (округлено до 2-х знаков после запятой). ");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nВ сгенерированном случайном массиве отсутствут позиция " + 
                      $"[{rowIndex}, {columnIndex}]. \n" + 
                      $"В нем {array.GetLength(0)} строк(и)(a) и {array.GetLength(1)} столбца(цов)(ец).");
}

Console.ForegroundColor = ConsoleColor.Green; 
Console.WriteLine("\nА вот и сам массив: \n"); 

Print2DArray (array, 2); 

Console.ResetColor(); 
Console.WriteLine(); 

bool ElementExist (double[,] arr, int rowInd, int colInd, out double elMean) 
{
    if (rowInd < 0 || colInd < 0 ||
        rowInd >= arr.GetLength(0) || colInd >= arr.GetLength(1))
    {
        elMean = 0; 
        return false; 
    }
    else
    {
        elMean = arr[rowInd,colInd]; 
        return true; 
    }
}

// Текст метода CreateRandom2DArray приведен здесь для удобства проверки (исключительно)

// double[,] CreateRandom2DArray(out int qtyOfRows, out int qtyOfColumns, int minBound, int upperBound)
// {
//     Random random = new Random(); 
//     qtyOfRows = random.Next(2,11); 
//     qtyOfColumns = random.Next(2,11); 

//     double[,] array = new double[qtyOfRows, qtyOfColumns];

//     for (int i = 0; i < qtyOfRows; i++)
//     {
//         for (int j = 0; j < qtyOfColumns; j++)
//         {
//             array[i, j] = random.Next(minBound,upperBound) + random.NextDouble(); 
//         }
//     }
//     return array;
// }