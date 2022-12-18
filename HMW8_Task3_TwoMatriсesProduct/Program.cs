// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц

// Две матрицы можно перемножить, если количество столбцов в первой матрице равно 
// количеству строк во второй. 

// Создадим 1-ю матрицу случайным образом: 

using static Common.Helper; 

uint maxNumberOfRows = 5; 
uint maxNumberOfColumns = 5; 
int minValue = -9; 
int maxValue = 9; 
int quantityOfRows = 0; 
int quantityOfColumns = 0; 

int[,] matrix1 = CreateRandom2DArray (out quantityOfRows, out quantityOfColumns,
                                            maxNumberOfRows, maxNumberOfColumns,
                                            minValue, maxValue); 

Console.WriteLine("1-я матрица получена случайным образом: \n"); 

Print2DArray3Pos(matrix1); 
Console.WriteLine(); 

// Вторую матрицу создадим с конкретным числом строк, равным числу столбцов в 1-й матрице

Console.WriteLine("2-ю матрицу создадим таким образом, чтобы в ней число строк"); 
Console.WriteLine("равнялось числу столбцов в первой матрице: \n"); 

int[,] matrix2 = CreateRandom2DArrayWithDefiniteNumberOfRows(maxNumberOfColumns,
                                         (uint)matrix1.GetLength(1), minValue, maxValue); 

Print2DArray3Pos(matrix2); 
Console.WriteLine(); 

// Найдем произведение двух этих матриц: 

int[,] matricesProduct = TwoMatricesProduct(matrix1, matrix2); 

// и выведем результат в окно консоли: 

Console.ForegroundColor = ConsoleColor.Green; 
Console.WriteLine("Произведение данных двух матриц выглядит следующим образом: \n"); 
Print2DArray5Pos(matricesProduct); 
Console.WriteLine();
Console.ResetColor();  

int[,] TwoMatricesProduct(int[,] matr1, int[,] matr2)
{
    int resMatrixQtyOfRows = matr1.GetLength(0); 
    int resMatrixQtyOfCols = matr2.GetLength(1); 

    int[,] resMatrix = new int[resMatrixQtyOfRows, resMatrixQtyOfCols]; 
    for (int i = 0; i < resMatrixQtyOfRows; i++)
    {
        for (int j = 0; j < resMatrixQtyOfCols; j++)
        {
            resMatrix[i,j] = 0; 
            for (int run = 0; run < matr1.GetLength(1); run++)
            {
                resMatrix[i,j] = resMatrix[i,j] + matr1[i,run] * matr2[run,j]; 
            }
        }
    }

    return resMatrix; 
}

