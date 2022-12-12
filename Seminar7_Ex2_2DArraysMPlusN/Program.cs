using static Common.Helper; 

// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле A = m+n; 
// Выведите полученный массив на экран

// int[,] array = new int[3,4]; 

int[,] result = Create2DArrayByFormular(3, 4); 
Print2DArray (result); 

int[,] Create2DArrayByFormular (int m, int n)
{
    int[,] array = new int[m, n]; 
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = i + j; 
        }
    }
    return array; 
}


