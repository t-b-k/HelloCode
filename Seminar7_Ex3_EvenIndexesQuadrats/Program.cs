// Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса нечетные, 
// и замените эти элементы на их квадраты
using static Common.Helper; 

int m = 7; 
int n = 7; 

double[,] ourArray = Create2DArray (m, n); 
Print2DArray (ourArray); 
Console.WriteLine(); 
double[,] modifiedArray = ModifyArray (ourArray); 
Print2DArray (modifiedArray); 


double[,] Create2DArray (int m, int n)
{
    Random random = new Random(); 
    double[,] array = new double[m, n]; 

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = random.Next(-10,10); 
        }
    }
    return array; 
}

double[,] ModifyArray (double[,] arr)
{
    double[,] resultArray = new double[arr.GetLength(0), arr.GetLength(1)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 == 1 && j % 2 == 1)
            {
                resultArray[i,j] = arr[i,j] * arr[i,j]; 
            }
            else
            {
                resultArray[i,j] = arr[i,j]; 
            }
        }
    } 
    return resultArray; 
}
