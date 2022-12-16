// Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна 
// вывести сообщение для пользователя

using static Common.Helper; 

int numberOfRows = 0; 
int numberOfColumns = 0; 
uint maxRows = 10; 
uint maxColumns = 10; 
int minValue = -50; 
int maxValue = 50; 

double[,] array = CreateRandom2DDoubleArray(out numberOfRows, out numberOfColumns,
                                            maxRows, maxColumns,
                                            minValue, maxValue); 

double[,] turnedArray = new double[numberOfColumns, numberOfRows];

for (int i = 0; i < numberOfRows; i++)
{
    for (int j = 0; j < numberOfColumns; j++)
    {
        turnedArray[j,i] = array[i,j]; 
    }
}

Print2DArray(array, 2); 
Console.WriteLine(); 
Print2DArray(turnedArray, 2); 
Console.WriteLine(); 

