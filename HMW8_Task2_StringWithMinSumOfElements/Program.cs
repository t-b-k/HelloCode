// Задайте прямоугольный массив. 
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов. 

// I. Создадим случайный прямоугольный массив размером m х n, 
// где m и n не более 10-ти, а значения в диапазоне [-99;100).

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

// II. Выведем созданный массив в окно консоли: 

Console.WriteLine($"\nСоздался двумерный массив целых чисел размером {quantityOfRows} x {quantityOfColumns} : \n"); 

Print2DArray3Pos(sourceArray); 

// III. Определим индекс строки с минимальной суммой элементов и сумму элементов в ней

(int, int) res = StringWithMinSumOfElements(sourceArray); 

Console.WriteLine("\nНайдем в нем строку с наименьшей суммой элементов. \n"); 
Console.WriteLine($"\nРЕЗУЛЬТАТ:   Это {res.Item1+1}-я строка (строка с индексом {res.Item1}),\n");
Console.WriteLine($"              и сумма элементов в ней равна {res.Item2}. \n"); 
Console.WriteLine(); 

Print2DArrayWithOneRedString (sourceArray, res.Item1); 
Console.WriteLine(); 

// Метод находит в заданном массиве строку с наименьшей суммой элементов 
// и возвращает кортеж из индекса этой строки и суммы элементов в ней

(int, int) StringWithMinSumOfElements (int[,] arr)
{
    int indexOfInterest = 0; 
    int minSumOfElements = SumOfElements(arr, 0); 

    for (int i = 1; i < arr.GetLength(0); i++)
    {
        if (SumOfElements(arr,i) < minSumOfElements)        
        {
            minSumOfElements = SumOfElements(arr,i); 
            indexOfInterest = i; 
        }
    }
    return (indexOfInterest, minSumOfElements); 
}

// Метод печатает 2-мерный массив целых чисел, отводя под каждое число 3 позиции. 
// Строку с индексом stringIndex выделяет цветом

void Print2DArrayWithOneRedString (int[,] arr, int stringIndex)
{
    for (int i = 0; i < stringIndex; i++)
    {
        PrintStringOf2DArray(arr, i); 
    }
    Console.ForegroundColor = ConsoleColor.Red;
    PrintStringOf2DArray(arr, stringIndex); 
    Console.ResetColor(); 
    for (int i = stringIndex+1; i < arr.GetLength(0); i++)
    {
        PrintStringOf2DArray(arr, i); 
    }
}

// Метод печатает строку массива с идексом stringInd, 
// отводя под каждый элемент три символа

void PrintStringOf2DArray (int[,] arr, int stringInd)
{
    for (int j = 0; j < arr.GetLength(1); j++) 
        {
            Console.Write(string.Format("{0,3}", arr[stringInd,j])); 
        }
    Console.WriteLine(); 
}
